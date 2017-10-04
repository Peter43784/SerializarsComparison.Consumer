using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace ConsoleClient.Models
{
    [ProtoContract(ImplicitFields = ImplicitFields.AllFields)]

    public class HmdfEntity
    {
        public int RowId { get; set; }
        public string Action { get; set; }
        public decimal? Age { get; set; }

        public DateTime? ActionDate { get; set; }

        public string Address { get; set; }

        public bool? Age_NA { get; set; }

        public string AgencyCode { get; set; }

        public decimal? APOR { get; set; }

        public DateTime? APOR_Date { get; set; }

        public string Applnumb { get; set; }

        public decimal? Appl_incm_catg { get; set; }

        public decimal? Appl_Incm_perc { get; set; }

        public DateTime? ApplDate { get; set; }

        public bool? ApplDate_NA { get; set; }

        public string APPMethod { get; set; }

        public decimal? APR { get; set; }

        public string Assessment { get; set; }

        public string AUSResult1 { get; set; }

        public string AUSResult2 { get; set; }

        public string AUSResult3 { get; set; }

        public string AUSResult4 { get; set; }

        public string AUSResult5 { get; set; }

        public string AUSResultOther { get; set; }

        public string AUSystem1 { get; set; }

        public string AUSystem2 { get; set; }

        public string AUSystem3 { get; set; }

        public string AUSystem4 { get; set; }

        public string AUSystem5 { get; set; }

        public string AUSystemOther { get; set; }

        public string BalloonPMT { get; set; }

        public string BlockGrp { get; set; }

        public string BUSCML { get; set; }

        public string CensusTrac { get; set; }

        public string City { get; set; }

        public decimal? CLTV { get; set; }

        public bool? CLTV_NA { get; set; }

        public decimal? Coa_Age { get; set; }

        public bool? Coa_Age_NA { get; set; }

        public string Coa_CreditModel { get; set; }

        public string Coa_CreditModelOther { get; set; }

        public decimal? Coa_CreditScore { get; set; }

        public bool? Coa_CreditScore_NA { get; set; }

        public string Ethnicity { get; set; }

        public string Coa_Ethnicity { get; set; }

        public string Coa_Ethnicity_1 { get; set; }

        public string Coa_Ethnicity_2 { get; set; }

        public string Coa_Ethnicity_3 { get; set; }

        public string Coa_Ethnicity_4 { get; set; }

        public string Coa_Ethnicity_5 { get; set; }

        public string Coa_Ethnicity_Determinant { get; set; }

        public string Coa_EthnicityOther { get; set; }

        public string CoaRace { get; set; }

        public string CoaRace_1 { get; set; }

        public string CoaRace_2 { get; set; }

        public string CoaRace_3 { get; set; }

        public string CoaRace_4 { get; set; }

        public string CoaRace_5 { get; set; }

        public string CoaRace_Determinant { get; set; }

        public string CoaRace1_Other { get; set; }

        public string CoaRace27_Other { get; set; }

        public string CoaRace44_Other { get; set; }

        public string CoaSex { get; set; }

        public string CoaSex_Determinant { get; set; }

        public string CongDist { get; set; }

        public string ConstructionMethod { get; set; }

        public string County { get; set; }

        public string County_5 { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public string CreditModel { get; set; }

        public string CreditModelOther { get; set; }

        public decimal? CreditScore { get; set; }

        public bool? CreditScore_NA { get; set; }

        public int? DatasetId { get; set; }

        public string Denial1 { get; set; }

        public string Denial2 { get; set; }

        public string Denial3 { get; set; }

        public string Denial4 { get; set; }

        public string DenialOther { get; set; }

        public decimal? DiscountPts { get; set; }

        public bool? DiscountPts_NA { get; set; }

        public decimal? DTIRatio { get; set; }

        public bool? DTIRatio_NA { get; set; }

        public string EditStatus { get; set; }

        public string Ethnicity_1 { get; set; }

        public string Ethnicity_2 { get; set; }

        public string Ethnicity_3 { get; set; }

        public string Ethnicity_4 { get; set; }

        public string Ethnicity_5 { get; set; }

        public string Ethnicity_Determinant { get; set; }

        public string EthnicityOther { get; set; }

        public string gdtMCD { get; set; }

        public string gdtPlace { get; set; }

        public int? GeocodeEventId { get; set; }

        public string HOEPA_Status { get; set; }

        public decimal? Income { get; set; }

        public string Instit_id { get; set; }

        public string gsLocationCode { get; set; }

        public string gsMatchCode { get; set; }

        public string gsMatchResult { get; set; }

        public bool? Income_NA { get; set; }

        public decimal? InterestRate { get; set; }

        public bool? InterestRate_NA { get; set; }

        public decimal? IntroRatePeriod { get; set; }

        public bool? IntroRatePeriod_NA { get; set; }

        public string IOPMT { get; set; }

        public string Lartype { get; set; }

        public decimal? latitude { get; set; }

        public string LEI { get; set; }

        public decimal? LenderCredts { get; set; }

        public bool? LenderCredts_NA { get; set; }

        public int? Lien_Status { get; set; }

        public decimal? Loan_Term { get; set; }

        public decimal? Loan_Term_Months { get; set; }

        public bool? Loan_Term_Months_NA { get; set; }

        public int? LoanAmount { get; set; }

        public int? LoanAmountInDollars { get; set; }

        public decimal? longitude { get; set; }

        public string LoanType { get; set; }

        public decimal? MFAHU { get; set; }

        public bool? MFAHU_NA { get; set; }

        public string MHLandPropInt { get; set; }

        public string MHSecPropType { get; set; }

        public string Mnrty_trct { get; set; }

        public string MmwAddress { get; set; }

        public string mmwCity { get; set; }

        public string mmwStat { get; set; }

        public string mmwState { get; set; }

        public string mmwZip { get; set; }

        public string mmwZip4 { get; set; }

        public int? ModificationEventId { get; set; }

        public string ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public string MSA { get; set; }

        public string NegAM { get; set; }

        public string NMLSRID { get; set; }

        public bool? NoCoApplicant { get; set; }

        public string NonAmortz { get; set; }

        public string OccupancyType { get; set; }

        public string OpenLOC { get; set; }

        public decimal? OrigFees { get; set; }

        public bool? OrigFees_NA { get; set; }

        public string PayableInst { get; set; }

        public decimal? PercMedian { get; set; }

        public decimal? PercMinor { get; set; }

        public decimal? PPPTerm { get; set; }

        public bool? PPPTerm_NA { get; set; }

        public string Preapproval { get; set; }

        public int? PropertyValue { get; set; }

        public bool? PropertyValue_NA { get; set; }

        public string Purchaser { get; set; }

        public string Purpose { get; set; }

        public string Qualitychk { get; set; }

        public string Race { get; set; }

        public string Race_1 { get; set; }

        public string Race_2 { get; set; }

        public string Race_3 { get; set; }

        public string Race_4 { get; set; }

        public string Race_5 { get; set; }

        public string Race_Determinant { get; set; }

        public string Race1_Other { get; set; }

        public string Race27_Other { get; set; }

        public string Race44_Other { get; set; }

        public DateTime? Rate_lock_date { get; set; }

        public decimal? Rate_Spread { get; set; }

        public bool? Rate_Spread_NANC { get; set; }

        public bool? Rate_spread_input { get; set; }

        public string RateType { get; set; }

        public decimal? Raw_Rate_Spread { get; set; }

        public int? Record_Status { get; set; }

        public string RecordId { get; set; }

        public string Recupd { get; set; }

        public string REVMTG { get; set; }

        public string Sex { get; set; }

        public string Sex_Determinant { get; set; }

        public string State { get; set; }

        public string STATE_ABRV { get; set; }

        public string StndStat { get; set; }

        public int? T_rate_used { get; set; }

        public decimal? TotalLoanCosts { get; set; }

        public bool? TotalLoanCosts_NA { get; set; }

        public decimal? TotalPtsAndFees { get; set; }

        public bool? TotalPtsAndFees_NA { get; set; }

        public decimal? TotalUnits { get; set; }

        public string Tract_11 { get; set; }

        public string Trct_incm_Catg { get; set; }

        public string ULI { get; set; }

        public string ULIStatus { get; set; }

        public decimal? Var_Term { get; set; }

        public string Zip { get; set; }

        public string Zip4 { get; set; }
    }
}
