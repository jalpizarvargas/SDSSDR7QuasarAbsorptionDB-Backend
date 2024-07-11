using Microsoft.AspNetCore.Mvc;
using QuasarWebAppAPI.EFCore;
using QuasarWebAppAPI.Models;
using System.IO;
using System.IO.Compression;

namespace QuasarWebAppAPI.Controllers
{
    [ApiController]
    public class QuasarCatalogDBController : ControllerBase
    {
        //Private instance of DBHelper
        private readonly DBHelper _db;

        //Public instance of the Catalog Controller that takes database context for DBHelper
        public QuasarCatalogDBController(EF_DataContext context)
        {
            _db = new DBHelper(context);
        }

        /**
         * Http request that returns the archive entry with the provided plate and fiber number
         * plateNum, number of the plate used in the archive documents
         * fiberNum, number of the fiber used for the data in the archive documents
        **/
        [HttpGet]
        [Route("api/[controller]/downloadEntryFiles/{plateNum}/{fiberNum}")]
        public IActionResult getArchiveFiles(int plateNum, int fiberNum)
        {
            //Working Directory for the Archive Files
            var dirPath = "/mnt/db/plates";

            //Variable that stores the directory name that matches the requested plate number
            var filePath = "";

            //Stores all the file paths for the plates directories
            string[] plateDirs = Directory.GetDirectories(dirPath);

            //Iterates through the list of available plates and stops once it finds the one that is requested
            foreach (var plateDir in plateDirs)
            {
                if(int.Parse(Path.GetFileNameWithoutExtension(plateDir)) == plateNum)
                {
                    filePath = plateDir;
                    break;
                }
            }
            
            //Stores all the paths for the subdirectories found inside the plate directory 
            string[] subDirs = Directory.GetDirectories(filePath);

            string requestedDir = "";
            string zipFileName = "";

            //Iterates through the archive entries of the requested plate
            foreach (var subDir in subDirs)
            {
                //Disects the name of the subdirectory to compare the fiber number
                string dirName = Path.GetFileName(subDir);
                string[] nameSections = dirName.Split('_');
                string fiberSpace = nameSections[2];
                if (int.Parse(fiberSpace) == fiberNum)
                {
                    //When it finds the entry with the requested fiber number, store both normal path and a path for a zip file on variables
                    requestedDir = subDir;
                    zipFileName = dirName + ".zip";
                    break;
                }
            }

            byte[] result;

            //Generates a zip file of the requested archive
            ZipFile.CreateFromDirectory(requestedDir, requestedDir + ".zip");

            //Stores the data of the zip version of the archive in a variable
            result = System.IO.File.ReadAllBytes(requestedDir + ".zip");

            //Deletes the zip file
            System.IO.File.Delete(requestedDir + ".zip");

            //Ensure archive is formatted as a zip file 
            var archiveEntry = File(result,"application/zip", zipFileName);

            //Return the requested archive entry
            return archiveEntry;
        }

        /**
         * Http request that returns the original quasar catalog
        **/
        [HttpGet]
        [Route("api/[controller]/downloadCatalog")]
        public IActionResult downloadCatalog()
        {
            //Working Directory for the quasar catalog and data model
            var filePath = "/mnt/db/DR7_QSOALS_catalog_091714/DR7_QSOALS_catalog_091714.fits";
            var dirPath = "/mnt/db/DR7_QSOALS_catalog_091714/DR7_QSOALS_catalog";
            var modelDocPath = "/mnt/db/DR7_QSOALS_catalog_091714/data_model_QSOALS_fits.pdf";

            //Generate a folder to store the quasar catlog and data model to store a copies of them if it doesn't exist
            if (!System.IO.Directory.Exists(dirPath))
            {
                System.IO.Directory.CreateDirectory(dirPath);
                
                System.IO.File.Copy(filePath, dirPath + "/DR7_QSOALS_catalog_091714.fits");
                System.IO.File.Copy(modelDocPath, dirPath + "/data_model_QSOALS_fits.pdf");
            }
            
            //Generates a zip file of the directory
            ZipFile.CreateFromDirectory(dirPath, dirPath + ".zip");

            //Stores the data of the zipped catalog in a local variable
            byte[] result = System.IO.File.ReadAllBytes(dirPath + ".zip");

            //Deletes the zip file
            System.IO.File.Delete(dirPath + ".zip");

            //Returns the requested documents in a zip format
            return File(result,"application/zip", "DR7_QSOALS_catalog.zip");

        }

        /**
         * Http request that returns the contents of the lambda_vac table from the database 
        **/
        [HttpGet]
        [Route("api/[controller]/lambda_vac")]
        public IActionResult Get_lambda_vac()
        {
            //Set response type to success
            ResponseType responseType = ResponseType.Success;
            try 
            {
                //Gets the data from the database
                IEnumerable<lambda_vac_Model> data = _db.Get_lambda_vac_Values();

                //If no data is found Change response type
                if (!data.Any())
                {
                    responseType = ResponseType.NotFound;
                }

                //Send an OK response from the API with the requested data
                return Ok(ResponseHandler.GetAppResponse(responseType, data)); 
                
            }
            catch (Exception ex)
            {
                //In case of an exception return a Bad Request response
                responseType = ResponseType.Failed;
                return BadRequest(ResponseHandler.GetExceptionResponse(ex));
            }
        }

        /**
         * Http request that returns the contents of the lambda_obs table from the database 
        **/
        [HttpGet]
        [Route("api/[controller]/lambda_obs")]
        public IActionResult Get_lambda_obs() 
        {
            //Set response type to success
            ResponseType responseType = ResponseType.Success;
            try
            {
                //Gets the data from the database
                IEnumerable<lambda_obs_Model> data = _db.Get_lambda_obs_Values();

                //If no data is found Change response type
                if (!data.Any())
                {
                    responseType = ResponseType.NotFound;
                }

                //Send an OK response from the API with the requested data
                return Ok(ResponseHandler.GetAppResponse(responseType, data));

            }
            catch (Exception ex)
            {
                //In case of an exception return a Bad Request response
                responseType = ResponseType.Failed;
                return BadRequest(ResponseHandler.GetExceptionResponse(ex));
            }

        }

        /**
         * Http request that returns the contents of the lya_flag table from the database 
        **/
        [HttpGet]
        [Route("api/[controller]/lya_flag")]
        public IActionResult Get_lya_flag()
        {
            //Set response type to success
            ResponseType responseType = ResponseType.Success;
            try
            {
                //Gets the data from the database
                IEnumerable<lya_flag_Model> data = _db.Get_lya_flag_Values();

                //If no data is found Change response type
                if (!data.Any())
                {
                    responseType = ResponseType.NotFound;
                }

                //Send an OK response from the API with the requested data
                return Ok(ResponseHandler.GetAppResponse(responseType, data));

            }
            catch (Exception ex)
            {
                //In case of an exception return a Bad Request response
                responseType = ResponseType.Failed;
                return BadRequest(ResponseHandler.GetExceptionResponse(ex));
            }

        }

        /**
         * Http request that returns the contents of the gradeflag table from the database 
        **/
        [HttpGet]
        [Route("api/[controller]/gradeflag")]
        public IActionResult Get_gradeflag()
        {
            //Set response type to success
            ResponseType responseType = ResponseType.Success;
            try
            {
                //Gets the data from the database
                IEnumerable<gradeflag_Model> data = _db.Get_gradeflag_Values();

                //If no data is found Change response type
                if (!data.Any())
                {
                    responseType = ResponseType.NotFound;
                }

                //Send an OK response from the API with the requested data
                return Ok(ResponseHandler.GetAppResponse(responseType, data));

            }
            catch (Exception ex)
            {
                //In case of an exception return a Bad Request response
                responseType = ResponseType.Failed;
                return BadRequest(ResponseHandler.GetExceptionResponse(ex));
            }

        }

        /**
         * Http request that returns the contents of the fwhm table from the database 
        **/
        [HttpGet]
        [Route("api/[controller]/fwhm")]
        public IActionResult Get_fwhm()
        {
            //Set response type to success
            ResponseType responseType = ResponseType.Success;
            try
            {
                //Gets the data from the database
                IEnumerable<fwhm_Model> data = _db.Get_fwhm_Values();

                //If no data is found Change response type
                if (!data.Any())
                {
                    responseType = ResponseType.NotFound;
                }

                //Send an OK response from the API with the requested data
                return Ok(ResponseHandler.GetAppResponse(responseType, data));

            }
            catch (Exception ex)
            {
                //In case of an exception return a Bad Request response
                responseType = ResponseType.Failed;
                return BadRequest(ResponseHandler.GetExceptionResponse(ex));
            }

        }

        /**
         * Http request that returns the contents of the ew_obs table from the database 
        **/
        [HttpGet]
        [Route("api/[controller]/ew_obs")]
        public IActionResult Get_ew_obs()
        {
            //Set response type to success
            ResponseType responseType = ResponseType.Success;
            try
            {
                //Gets the data from the database
                IEnumerable<ew_obs_Model> data = _db.Get_ew_obs_Values();

                //If no data is found Change response type
                if (!data.Any())
                {
                    responseType = ResponseType.NotFound;
                }

                //Send an OK response from the API with the requested data
                return Ok(ResponseHandler.GetAppResponse(responseType, data));

            }
            catch (Exception ex)
            {
                //In case of an exception return a Bad Request response
                responseType = ResponseType.Failed;
                return BadRequest(ResponseHandler.GetExceptionResponse(ex));
            }

        }

        /**
         * Http request that returns the contents of the ew_err_obs table from the database 
        **/
        [HttpGet]
        [Route("api/[controller]/ew_err_obs")]
        public IActionResult Get_ew_err_obs()
        {
            //Set response type to success
            ResponseType responseType = ResponseType.Success;
            try
            {
                //Gets the data from the database
                IEnumerable<ew_err_obs_Model> data = _db.Get_ew_err_obs_Values();

                //If no data is found Change response type
                if (!data.Any())
                {
                    responseType = ResponseType.NotFound;
                }

                //Send an OK response from the API with the requested data
                return Ok(ResponseHandler.GetAppResponse(responseType, data));

            }
            catch (Exception ex)
            {
                //In case of an exception return a Bad Request response
                responseType = ResponseType.Failed;
                return BadRequest(ResponseHandler.GetExceptionResponse(ex));
            }

        }

        /**
         * Http request that returns the contents of the deltaz_sys table from the database 
        **/
        [HttpGet]
        [Route("api/[controller]/deltaz_sys")]
        public IActionResult Get_deltaz_sys()
        {
            //Set response type to success
            ResponseType responseType = ResponseType.Success;
            try
            {
                //Gets the data from the database
                IEnumerable<deltaz_sys_Model> data = _db.Get_deltaz_sys_Values();

                //If no data is found Change response type
                if (!data.Any())
                {
                    responseType = ResponseType.NotFound;
                }

                //Send an OK response from the API with the requested data
                return Ok(ResponseHandler.GetAppResponse(responseType, data));

            }
            catch (Exception ex)
            {
                //In case of an exception return a Bad Request response
                responseType = ResponseType.Failed;
                return BadRequest(ResponseHandler.GetExceptionResponse(ex));
            }

        }

        /**
         * Http request that returns the contents of the deltav_sys table from the database 
        **/
        [HttpGet]
        [Route("api/[controller]/deltav_sys")]
        public IActionResult Get_deltav_sys()
        {
            //Set response type to success
            ResponseType responseType = ResponseType.Success;
            try
            {
                //Gets the data from the database
                IEnumerable<deltav_sys_Model> data = _db.Get_deltav_sys_Values();

                //If no data is found Change response type
                if (!data.Any())
                {
                    responseType = ResponseType.NotFound;
                }

                //Send an OK response from the API with the requested data
                return Ok(ResponseHandler.GetAppResponse(responseType, data));

            }
            catch (Exception ex)
            {
                //In case of an exception return a Bad Request response
                responseType = ResponseType.Failed;
                return BadRequest(ResponseHandler.GetExceptionResponse(ex));
            }

        }

        /**
         * Http request that returns the contents of the blendflag table from the database 
        **/
        [HttpGet]
        [Route("api/[controller]/blendflag")]
        public IActionResult Get_blendflag()
        {
            //Set response type to success
            ResponseType responseType = ResponseType.Success;
            try
            {
                //Gets the data from the database
                IEnumerable<blendflag_Model> data = _db.Get_blendflag_Values();

                //If no data is found Change response type
                if (!data.Any())
                {
                    responseType = ResponseType.NotFound;
                }

                //Send an OK response from the API with the requested data
                return Ok(ResponseHandler.GetAppResponse(responseType, data));

            }
            catch (Exception ex)
            {
                //In case of an exception return a Bad Request response
                responseType = ResponseType.Failed;
                return BadRequest(ResponseHandler.GetExceptionResponse(ex));
            }

        }

        /**
         * Http request that returns the contents of the catalog table from the database 
        **/
        [HttpGet]
        [Route("api/[controller]/catalog")]
        public IActionResult Get_Catalog()
        {
            //Set response type to success
            ResponseType responseType = ResponseType.Success;
            try
            {
                //Gets the data from the database
                IEnumerable<quasar_catalog_Model> data = _db.Get_catalog();

                //If no data is found Change response type
                if (!data.Any())
                {
                    responseType = ResponseType.NotFound;
                }

                //Send an OK response from the API with the requested data
                return Ok(ResponseHandler.GetAppResponse(responseType, data));

            }
            catch (Exception ex)
            {
                //In case of an exception return a Bad Request response
                responseType = ResponseType.Failed;
                return BadRequest(ResponseHandler.GetExceptionResponse(ex));
            }
        }

        /**
         * Http request that returns the contents of the w_limits table from the database 
        **/
        [HttpGet]
        [Route("api/[controller]/w_limits")]
        public IActionResult Get_w_limits()
        {
            //Set response type to success
            ResponseType responseType = ResponseType.Success;
            try
            {
                //Gets the data from the database
                IEnumerable<w_limits_Model> data = _db.Get_W_Limits();

                //If no data is found Change response type
                if (!data.Any())
                {
                    responseType = ResponseType.NotFound;
                }

                //Send an OK response from the API with the requested data
                return Ok(ResponseHandler.GetAppResponse(responseType, data));
                
            }
            catch (Exception ex)
            {
                //In case of an exception return a Bad Request response
                responseType = ResponseType.Failed;
                return BadRequest(ResponseHandler.GetExceptionResponse(ex));
            }
        }

    }
}
