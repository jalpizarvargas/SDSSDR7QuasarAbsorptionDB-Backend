namespace QuasarWebAppAPI.Models
{
    public class quasar_catalog_Model
    {
        public int id { get; set; }

        public int plate { get; set; }

        public int fiber { get; set; }

        public int mjd { get; set; }

        public float z_qso { get; set; }

        public float imag { get; set; }

        public int bal_flag { get; set; }

        public int bal_flag2 { get; set; }

        public float _20cm_flux { get; set; }

        public float _20cm_snr { get; set; }

        public int target_first { get; set; }

        public float sep_first { get; set; }

        public float iabmag { get; set; }

        public float z_fgal { get; set; }

        public float spec_avesnr { get; set; }

        public float spec_medsnr { get; set; }

        public float spec_avesnr_red { get; set; }

        public float spec_medsnr_red { get; set; }

        public float ra_hex { get; set; }

        public float dec_hex { get; set; }

        public float ra_deg { get; set; }

        public float dec_deg { get; set; }

        public string run_date { get; set; }

        public float avesnr_spec { get; set; }

        public int num_5sigma_unided_inlya { get; set; }

        public int num_5sigma_unided_notinlya { get; set; }

        public float z_abs { get; set; }

        public string grade { get; set; }

        public string type { get; set; }

        public int sys_num { get; set; }

        public float beta { get; set; }

        public float dla_zabs_nd2013 { get; set; }

        public float dla_flag_nd2013 { get; set; }

        public float dla_lognhi_nd2013 { get; set; }

        public float dla_lognhi_err_nd2013 { get; set; }

        public float mgii_class_score { get; set; }

        public float civ_class_score { get; set; }

        public float other_class_score { get; set; }

    }
}
