using QuasarWebAppAPI.EFCore;

namespace QuasarWebAppAPI.Models
{
    public class DBHelper
    {

        private EF_DataContext _context;

        public DBHelper(EF_DataContext context)
        {
            _context = context;
        }

        public List<lambda_vac_Model> Get_lambda_vac_Values()
        {
            List<lambda_vac_Model> response = new List<lambda_vac_Model>();
            var dbVals =  _context.lambda_Vacs.ToList();
            dbVals.ForEach(data => response.Add(new lambda_vac_Model()
            {
                lVac_1025 = data.lVac_1025,
                lVac_1215 = data.lVac_1215,
                lVac_1238 = data.lVac_1238,
                lVac_1260 = data.lVac_1260,
                lVac_1302 = data.lVac_1302,
                lVac_1304 = data.lVac_1304,
                lVac_1334 = data.lVac_1334,
                lVac_1393 = data.lVac_1393,
                lVac_1402 = data.lVac_1402,
                lVac_1526 = data.lVac_1526,
                lVac_1548 = data.lVac_1548,
                lVac_1550 = data.lVac_1550,
                lVac_1608 = data.lVac_1608,
                lVac_1656 = data.lVac_1656,
                lVac_1670 = data.lVac_1670,
                lVac_1854 = data.lVac_1854,
                lVac_1862 = data.lVac_1862,
                lVac_2026 = data.lVac_2026,
                lVac_2056 = data.lVac_2056,
                lVac_2260 = data.lVac_2260,
                lVac_2374 = data.lVac_2374,
                lVac_2382 = data.lVac_2382,
                lVac_2586 = data.lVac_2586,
                lVac_2594 = data.lVac_2594,
                lVac_2600 = data.lVac_2600,
                lVac_2796 = data.lVac_2796,
                lVac_2803 = data.lVac_2803,
                lVac_2853 = data.lVac_2853,
                lVac_3242 = data.lVac_3242,
                lVac_3934 = data.lVac_3934,
                lVac_3969 = data.lVac_3969,
                lVac_5891 = data.lVac_5891
            }));

            return response;
        }

        public List<lambda_obs_Model> Get_lambda_obs_Values()
        {
            List<lambda_obs_Model> response = new List<lambda_obs_Model>();

            var dbVals = _context.lambda_Obs.ToList();

            dbVals.ForEach(data => response.Add(new lambda_obs_Model()
            {
                id = data.id,
                lObs_1025 = data.lObs_1025,
                lObs_1215 = data.lObs_1215,
                lObs_1238 = data.lObs_1238,
                lObs_1260 = data.lObs_1260,
                lObs_1302 = data.lObs_1302,
                lObs_1304 = data.lObs_1304,
                lObs_1334 = data.lObs_1334,
                lObs_1393 = data.lObs_1393,
                lObs_1402 = data.lObs_1402,
                lObs_1526 = data.lObs_1526,
                lObs_1548 = data.lObs_1548,
                lObs_1550 = data.lObs_1550,
                lObs_1608 = data.lObs_1608,
                lObs_1656 = data.lObs_1656,
                lObs_1670 = data.lObs_1670,
                lObs_1854 = data.lObs_1854,
                lObs_1862 = data.lObs_1862,
                lObs_2026 = data.lObs_2026,
                lObs_2056 = data.lObs_2056,
                lObs_2260 = data.lObs_2260,
                lObs_2374 = data.lObs_2374,
                lObs_2382 = data.lObs_2382,
                lObs_2586 = data.lObs_2586,
                lObs_2594 = data.lObs_2594,
                lObs_2600 = data.lObs_2600,
                lObs_2796 = data.lObs_2796,
                lObs_2803 = data.lObs_2803,
                lObs_2853 = data.lObs_2853,
                lObs_3242 = data.lObs_3242,
                lObs_3934 = data.lObs_3934,
                lObs_3969 = data.lObs_3969,
                lObs_5891 = data.lObs_5891,
            }));

            return response;
        }

        public List<lya_flag_Model> Get_lya_flag_Values()
        {
            List<lya_flag_Model> response = new List<lya_flag_Model>();

            var dbVals = _context.lya_Flag.ToList();

            dbVals.ForEach(data => response.Add(new lya_flag_Model()
            {
                id = data.id,
                lyFlag_1025 = data.lyFlag_1025,
                lyFlag_1215 = data.lyFlag_1215,
                lyFlag_1238 = data.lyFlag_1238,
                lyFlag_1260 = data.lyFlag_1260,
                lyFlag_1302 = data.lyFlag_1302,
                lyFlag_1304 = data.lyFlag_1304,
                lyFlag_1334 = data.lyFlag_1334,
                lyFlag_1393 = data.lyFlag_1393,
                lyFlag_1402 = data.lyFlag_1402,
                lyFlag_1526 = data.lyFlag_1526,
                lyFlag_1548 = data.lyFlag_1548,
                lyFlag_1550 = data.lyFlag_1550,
                lyFlag_1608 = data.lyFlag_1608,
                lyFlag_1656 = data.lyFlag_1656,
                lyFlag_1670 = data.lyFlag_1670,
                lyFlag_1854 = data.lyFlag_1854,
                lyFlag_1862 = data.lyFlag_1862,
                lyFlag_2026 = data.lyFlag_2026,
                lyFlag_2056 = data.lyFlag_2056,
                lyFlag_2260 = data.lyFlag_2260,
                lyFlag_2374 = data.lyFlag_2374,
                lyFlag_2382 = data.lyFlag_2382,
                lyFlag_2586 = data.lyFlag_2586,
                lyFlag_2594 = data.lyFlag_2594,
                lyFlag_2600 = data.lyFlag_2600,
                lyFlag_2796 = data.lyFlag_2796,
                lyFlag_2803 = data.lyFlag_2803,
                lyFlag_2853 = data.lyFlag_2853,
                lyFlag_3242 = data.lyFlag_3242,
                lyFlag_3934 = data.lyFlag_3934,
                lyFlag_3969 = data.lyFlag_3969,
                lyFlag_5891 = data.lyFlag_5891
            }));

            return response;
        }

        public List<gradeflag_Model> Get_gradeflag_Values()
        {

            List<gradeflag_Model> response = new List<gradeflag_Model>();

            var dbVals = _context.gradeFlag.ToList();

            dbVals.ForEach(data => response.Add(new gradeflag_Model()
            {
                id = data.id,
                gradeFlag_1025 = data.gradeFlag_1025,
                gradeFlag_1215 = data.gradeFlag_1215,
                gradeFlag_1238 = data.gradeFlag_1238,
                gradeFlag_1260 = data.gradeFlag_1260,
                gradeFlag_1302 = data.gradeFlag_1302,
                gradeFlag_1304 = data.gradeFlag_1304,
                gradeFlag_1334 = data.gradeFlag_1334,
                gradeFlag_1393 = data.gradeFlag_1393,
                gradeFlag_1402 = data.gradeFlag_1402,
                gradeFlag_1526 = data.gradeFlag_1526,
                gradeFlag_1548 = data.gradeFlag_1548,
                gradeFlag_1550 = data.gradeFlag_1550,
                gradeFlag_1608 = data.gradeFlag_1608,
                gradeFlag_1656 = data.gradeFlag_1656,
                gradeFlag_1670 = data.gradeFlag_1670,
                gradeFlag_1854 = data.gradeFlag_1854,
                gradeFlag_1862 = data.gradeFlag_1862,
                gradeFlag_2026 = data.gradeFlag_2026,
                gradeFlag_2056 = data.gradeFlag_2056,
                gradeFlag_2260 = data.gradeFlag_2260,
                gradeFlag_2374 = data.gradeFlag_2374,
                gradeFlag_2382 = data.gradeFlag_2382,
                gradeFlag_2586 = data.gradeFlag_2586,
                gradeFlag_2594 = data.gradeFlag_2594,
                gradeFlag_2600 = data.gradeFlag_2600,
                gradeFlag_2796 = data.gradeFlag_2796,
                gradeFlag_2803 = data.gradeFlag_2803,
                gradeFlag_2853 = data.gradeFlag_2853,
                gradeFlag_3242 = data.gradeFlag_3242,
                gradeFlag_3934 = data.gradeFlag_3934,
                gradeFlag_3969 = data.gradeFlag_3969,
                gradeFlag_5891 = data.gradeFlag_5891
            }));

            return response;

        }

        public List<fwhm_Model> Get_fwhm_Values()
        {

            List<fwhm_Model> response = new List<fwhm_Model>();

            var dbVals = _context.fwhm.ToList();


            dbVals.ForEach(data => response.Add(new fwhm_Model()
            {
                id = data.id,
                fwhm_1025 = data.fwhm_1025,
                fwhm_1215 = data.fwhm_1215,
                fwhm_1238 = data.fwhm_1238,
                fwhm_1260 = data.fwhm_1260,
                fwhm_1302 = data.fwhm_1302,
                fwhm_1304 = data.fwhm_1304,
                fwhm_1334 = data.fwhm_1334,
                fwhm_1393 = data.fwhm_1334,
                fwhm_1402 = data.fwhm_1402,
                fwhm_1526 = data.fwhm_1526,
                fwhm_1548 = data.fwhm_1548,
                fwhm_1550 = data.fwhm_1550,
                fwhm_1608 = data.fwhm_1608,
                fwhm_1656 = data.fwhm_1656,
                fwhm_1670 = data.fwhm_1670,
                fwhm_1854 = data.fwhm_1854,
                fwhm_1862 = data.fwhm_1862,
                fwhm_2026 = data.fwhm_2026,
                fwhm_2056 = data.fwhm_2056,
                fwhm_2260 = data.fwhm_2260,
                fwhm_2374 = data.fwhm_2374,
                fwhm_2382 = data.fwhm_2382,
                fwhm_2586 = data.fwhm_2586,
                fwhm_2594 = data.fwhm_2594,
                fwhm_2600 = data.fwhm_2600,
                fwhm_2796 = data.fwhm_2796,
                fwhm_2803 = data.fwhm_2803,
                fwhm_2853 = data.fwhm_2853,
                fwhm_3242 = data.fwhm_3242,
                fwhm_3934 = data.fwhm_3934,
                fwhm_3969 = data.fwhm_3969,
                fwhm_5891 = data.fwhm_5891
            }));

            return response;

        }

        public List<ew_obs_Model> Get_ew_obs_Values()
        {

            List<ew_obs_Model> response = new List<ew_obs_Model>();

            var dbVals = _context.ew_Obs.ToList();

            dbVals.ForEach(data => response.Add(new ew_obs_Model()
            {
                id = data.id,
                eObs_1025 = data.eObs_1025,
                eObs_1215 = data.eObs_1215,
                eObs_1238 = data.eObs_1238,
                eObs_1260 = data.eObs_1260,
                eObs_1302 = data.eObs_1302,
                eObs_1304 = data.eObs_1304,
                eObs_1334 = data.eObs_1334,
                eObs_1393 = data.eObs_1393,
                eObs_1402 = data.eObs_1402,
                eObs_1526 = data.eObs_1526,
                eObs_1548 = data.eObs_1548,
                eObs_1550 = data.eObs_1550,
                eObs_1608 = data.eObs_1608,
                eObs_1656 = data.eObs_1656,
                eObs_1670 = data.eObs_1670,
                eObs_1854 = data.eObs_1854,
                eObs_1862 = data.eObs_1862,
                eObs_2026 = data.eObs_2026,
                eObs_2056 = data.eObs_2056,
                eObs_2260 = data.eObs_2260,
                eObs_2374 = data.eObs_2374,
                eObs_2382 = data.eObs_2382,
                eObs_2586 = data.eObs_2586,
                eObs_2594 = data.eObs_2594,
                eObs_2600 = data.eObs_2600,
                eObs_2796 = data.eObs_2796,
                eObs_2803 = data.eObs_2803,
                eObs_2853 = data.eObs_2853,
                eObs_3242 = data.eObs_3242,
                eObs_3934 = data.eObs_3934,
                eObs_3969 = data.eObs_3969,
                eObs_5891 = data.eObs_5891
            }));

            return response;

        }

        public List<ew_err_obs_Model> Get_ew_err_obs_Values()
        {
            List<ew_err_obs_Model> response = new List<ew_err_obs_Model>();

            var dbVals = _context.ew_Err_Obs.ToList();

            dbVals.ForEach(data => response.Add(new ew_err_obs_Model()
            {
                id = data.id,
                eErrObs_1025 = data.eErrObs_1025,
                eErrObs_1215 = data.eErrObs_1215,
                eErrObs_1238 = data.eErrObs_1238,
                eErrObs_1260 = data.eErrObs_1260,
                eErrObs_1302 = data.eErrObs_1302,
                eErrObs_1304 = data.eErrObs_1304,
                eErrObs_1334 = data.eErrObs_1334,
                eErrObs_1393 = data.eErrObs_1393,
                eErrObs_1402 = data.eErrObs_1402,
                eErrObs_1526 = data.eErrObs_1526,
                eErrObs_1548 = data.eErrObs_1548,
                eErrObs_1550 = data.eErrObs_1550,
                eErrObs_1608 = data.eErrObs_1608,
                eErrObs_1656 = data.eErrObs_1656,
                eErrObs_1670 = data.eErrObs_1670,
                eErrObs_1854 = data.eErrObs_1854,
                eErrObs_1862 = data.eErrObs_1862,
                eErrObs_2026 = data.eErrObs_2026,
                eErrObs_2056 = data.eErrObs_2056,
                eErrObs_2260 = data.eErrObs_2260,
                eErrObs_2374 = data.eErrObs_2374,
                eErrObs_2382 = data.eErrObs_2382,
                eErrObs_2586 = data.eErrObs_2586,
                eErrObs_2594 = data.eErrObs_2594,
                eErrObs_2600 = data.eErrObs_2600,
                eErrObs_2796 = data.eErrObs_2796,
                eErrObs_2803 = data.eErrObs_2803,
                eErrObs_2853 = data.eErrObs_2853,
                eErrObs_3242 = data.eErrObs_3242,
                eErrObs_3934 = data.eErrObs_3934,
                eErrObs_3969 = data.eErrObs_3934,
                eErrObs_5891 = data.eErrObs_5891
            }));

            return response;
        }

        public List<deltaz_sys_Model> Get_deltaz_sys_Values()
        {
            List<deltaz_sys_Model> response = new List<deltaz_sys_Model>();

            var dbVals = _context.deltaz_Sys.ToList();

            dbVals.ForEach(data => response.Add(new deltaz_sys_Model()
            {
                id = data.id,
                deltazSys_1025 = data.deltazSys_1025,
                deltazSys_1215 = data.deltazSys_1215,
                deltazSys_1238 = data.deltazSys_1238,
                deltazSys_1260 = data.deltazSys_1260,
                deltazSys_1302 = data.deltazSys_1302,
                deltazSys_1304 = data.deltazSys_1304,
                deltazSys_1334 = data.deltazSys_1334,
                deltazSys_1393 = data.deltazSys_1334,
                deltazSys_1402 = data.deltazSys_1402,
                deltazSys_1526 = data.deltazSys_1526,
                deltazSys_1548 = data.deltazSys_1548,
                deltazSys_1550 = data.deltazSys_1550,
                deltazSys_1608 = data.deltazSys_1608,
                deltazSys_1656 = data.deltazSys_1656,
                deltazSys_1670 = data.deltazSys_1670,
                deltazSys_1854 = data.deltazSys_1854,
                deltazSys_1862 = data.deltazSys_1862,
                deltazSys_2026 = data.deltazSys_2026,
                deltazSys_2056 = data.deltazSys_2056,
                deltazSys_2260 = data.deltazSys_2260,
                deltazSys_2374 = data.deltazSys_2374,
                deltazSys_2382 = data.deltazSys_2382,
                deltazSys_2586 = data.deltazSys_2586,
                deltazSys_2594 = data.deltazSys_2594,
                deltazSys_2600 = data.deltazSys_2600,
                deltazSys_2796 = data.deltazSys_2796,
                deltazSys_2803 = data.deltazSys_2803,
                deltazSys_2853 = data.deltazSys_2853,
                deltazSys_3242 = data.deltazSys_3242,
                deltazSys_3934 = data.deltazSys_3934,
                deltazSys_3969 = data.deltazSys_3969,
                deltazSys_5891 = data.deltazSys_5891
            }));

            return response;
        }

        public List<deltav_sys_Model> Get_deltav_sys_Values()
        {

            List<deltav_sys_Model> response = new List<deltav_sys_Model>();

            var dbVals = _context.deltav_Sys.ToList();

            dbVals.ForEach(data => response.Add(new deltav_sys_Model()
            {
                id = data.id,
                deltavSys_1025 = data.deltavSys_1025,
                deltavSys_1215 = data.deltavSys_1215,
                deltavSys_1238 = data.deltavSys_1238,
                deltavSys_1260 = data.deltavSys_1260,
                deltavSys_1302 = data.deltavSys_1302,
                deltavSys_1304 = data.deltavSys_1304,
                deltavSys_1334 = data.deltavSys_1334,
                deltavSys_1393 = data.deltavSys_1393,
                deltavSys_1402 = data.deltavSys_1402,
                deltavSys_1526 = data.deltavSys_1526,
                deltavSys_1548 = data.deltavSys_1548,
                deltavSys_1550 = data.deltavSys_1550,
                deltavSys_1608 = data.deltavSys_1608,
                deltavSys_1656 = data.deltavSys_1656,
                deltavSys_1670 = data.deltavSys_1670,
                deltavSys_1854 = data.deltavSys_1854,
                deltavSys_1862 = data.deltavSys_1862,
                deltavSys_2026 = data.deltavSys_2026,
                deltavSys_2056 = data.deltavSys_2056,
                deltavSys_2260 = data.deltavSys_2260,
                deltavSys_2374 = data.deltavSys_2374,
                deltavSys_2382 = data.deltavSys_2382,
                deltavSys_2586 = data.deltavSys_2586,
                deltavSys_2594 = data.deltavSys_2594,
                deltavSys_2600 = data.deltavSys_2600,
                deltavSys_2796 = data.deltavSys_2796,
                deltavSys_2803 = data.deltavSys_2803,
                deltavSys_2853 = data.deltavSys_2853,
                deltavSys_3242 = data.deltavSys_3242,
                deltavSys_3934 = data.deltavSys_3934,
                deltavSys_3969 = data.deltavSys_3969,
                deltavSys_5891 = data.deltavSys_5891
            }));

            return response;
        }

        public List<blendflag_Model> Get_blendflag_Values()
        {
            List<blendflag_Model> response = new List<blendflag_Model>();

            var dbVals = _context.blendflag.ToList();

            dbVals.ForEach(data => response.Add(new blendflag_Model()
            {
                id = data.id,
                blendFlag_1025 = data.blendFlag_1025,
                blendFlag_1215 = data.blendFlag_1215,
                blendFlag_1238 = data.blendFlag_1238,
                blendFlag_1260 = data.blendFlag_1260,
                blendFlag_1302 = data.blendFlag_1302,
                blendFlag_1304 = data.blendFlag_1304,
                blendFlag_1334 = data.blendFlag_1334,
                blendFlag_1393 = data.blendFlag_1393,
                blendFlag_1402 = data.blendFlag_1402,
                blendFlag_1526 = data.blendFlag_1526,
                blendFlag_1548 = data.blendFlag_1548,
                blendFlag_1550 = data.blendFlag_1550,
                blendFlag_1608 = data.blendFlag_1608,
                blendFlag_1656 = data.blendFlag_1656,
                blendFlag_1670 = data.blendFlag_1670,
                blendFlag_1854 = data.blendFlag_1854,
                blendFlag_1862 = data.blendFlag_1862,
                blendFlag_2026 = data.blendFlag_2026,
                blendFlag_2056 = data.blendFlag_2056,
                blendFlag_2260 = data.blendFlag_2260,
                blendFlag_2374 = data.blendFlag_2374,
                blendFlag_2382 = data.blendFlag_2382,
                blendFlag_2586 = data.blendFlag_2586,
                blendFlag_2594 = data.blendFlag_2594,
                blendFlag_2600 = data.blendFlag_2600,
                blendFlag_2796 = data.blendFlag_2796,
                blendFlag_2803 = data.blendFlag_2803,
                blendFlag_2853 = data.blendFlag_2853,
                blendFlag_3242 = data.blendFlag_3242,
                blendFlag_3934 = data.blendFlag_3934,
                blendFlag_3969 = data.blendFlag_3969,
                blendFlag_5891 = data.blendFlag_5891
            }));

            return response;
        }

        public List<quasar_catalog_Model> Get_catalog()
        {
            List<quasar_catalog_Model> response = new List<quasar_catalog_Model>();

            var dbVals = _context.quasar_Catalogs.ToList();

            dbVals.ForEach(data => response.Add(new quasar_catalog_Model()
                {
                id = data.id,
                plate = data.plate,
                fiber = data.fiber,
                mjd = data.mjd,
                z_qso = data.z_qso,
                imag = data.imag,
                bal_flag = data.bal_flag,
                bal_flag2 = data.bal_flag2,
                _20cm_flux = data._20cm_flux,
                _20cm_snr = data._20cm_snr,
                target_first = data.target_first,
                sep_first = data.sep_first,
                iabmag = data.iabmag,
                z_fgal = data.z_fgal,
                spec_avesnr = data.spec_avesnr,
                spec_medsnr = data.spec_medsnr,
                spec_avesnr_red = data.spec_avesnr_red,
                spec_medsnr_red = data.spec_medsnr_red,
                ra_hex = data.ra_hex,
                dec_hex = data.dec_hex,
                ra_deg = data.ra_deg,
                dec_deg = data.dec_deg,
                run_date = data.run_date,
                avesnr_spec = data.avesnr_spec,
                num_5sigma_unided_inlya = data.num_5sigma_unided_inlya,
                num_5sigma_unided_notinlya = data.num_5sigma_unided_notinlya,
                z_abs = data.z_abs,
                grade = data.grade,
                type = data.type,
                sys_num = data.sys_num,
                beta = data.beta,
                dla_zabs_nd2013 = data.dla_zabs_nd2013,
                dla_flag_nd2013 = data.dla_flag_nd2013,
                dla_lognhi_nd2013 = data.dla_lognhi_nd2013,
                dla_lognhi_err_nd2013 = data.dla_lognhi_err_nd2013,
                mgii_class_score = data.mgii_class_score,
                civ_class_score = data.civ_class_score,
                other_class_score = data.other_class_score   
            }));

            return response;
        }

        public List<w_limits_Model> Get_W_Limits()
        {
            List<w_limits_Model> response = new List<w_limits_Model>();

            var dbVals = _context.w_limits.ToList();

            dbVals.ForEach(data => response.Add(new w_limits_Model()
            {
                id = data.id,
                col0 = data.col0,
                col1 = data.col1,
                col2 = data.col2,
                col3 = data.col3,
                col4 = data.col4,
                col5 = data.col5,
                col6 = data.col6,
            }));

            return response;
        }

    }
}
