//************************************************************************
//File Name	     : CreateNewOpportunity.cs 
//Created By     : Gnanasigamani,Vinoth,Anand
//Created Date   : 11-Dec-2017
//************************************************************************
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using RPM_Model.common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using RPM_Model;
using RPM_Model.lib;
using System.ComponentModel;

namespace RPM_Models
{
    public class CreateNewOpportunity
    {

        //DataConstants DataConstants = new DataConstants();
        public int ID { get; set; }
        public int CofID { get; set; }
        public string CofName { get; set; }
        public string PlatForm_NAME { get; set; }
        public string strOpportunityId { get; set; }
        public string on_Result { get; set; }
        public string BPSOfferingName { get; set; }
        public int BPSOfferingId { get; set; }
        public int IESTIMATED_FTE_SIZE { get; set; }
        public string DEAL_REMARKS2 { get; set; }
        public string OFFSHORE_BD_LEAD_NAME { get; set; }
        public int DT_ID { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string OpportunityId { get; set; }
        public string NEXT_STEP_NAME { get; set; }
        public int Id { get; set; }
        public int WIN_LOSS_REASON_ID { get; set; }
        public int CurrentStageID { get; set; }
        public string BusinessName { get; set; }
        public int BusinessId { get; set; }
        public int NextStageID { get; set; }
        public string CompetencyName { get; set; }
        public string InfraHeadEmpId { get; set; }
        public string InfraHeadEmpName { get; set; }
        public string InfraHeadEmpMail { get; set; }
        public string QualityHeadEmpId { get; set; }
        public string QualityHeadEmpName { get; set; }
        public string QualityHeadEmpMail { get; set; }
        public string HCLHeadEmpId { get; set; }
        public string HCLHeadEmpName { get; set; }
        public string HCLHeadEmpMail { get; set; }
        public string StakeHolder { get; set; }
        public int STAKEHOLDERID { get; set; }
        public float FiscRev { get; set; }
        public int RFIProbableSubmissionDate { get; set; }
        public int RFIActualSubmissionDate { get; set; }
        public string RFIApprovedBy { get; set; }
        public int RFISubmissionDate { get; set; }
        public int RFPReceivedDate { get; set; }
        public int RFIReceivedDate { get; set; }
        public int RFPProbableSubmissionDate { get; set; }
        public int RFPActualSubmissionDate { get; set; }
        public string RFPApprovedBy { get; set; }
        public int RFPSubmissionDate { get; set; }
        public string Disqual { get; set; }
        public string AddDeal { get; set; }
        public string DealOwner { get; set; }
        public string DealOwner2 { get; set; }
        public int FTEOn { get; set; }
        public int FTEOff { get; set; }
        public int WIN_STATUS { get; set; }
        public string WIN_LOSS_VERBATUM { get; set; }
        public int DAYS_IN_THIS_STAGE { get; set; }
        public string OPPORTUNITY_DATE { get; set; }
        public string BPS_SALES_FEEDBACK { get; set; }
        public string PROJECT_WON { get; set; }
        public string REVENUE_CFY { get; set; }
        public int REVENUE_MONTHS { get; set; }
        public string ANTICIPATED_ACTUAL_STDT { get; set; }
        public int PROBABILITY_OF_WIN { get; set; }
        public double WON_FINAL_TCV { get; set; }
        public int WON_FTE { get; set; }
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string UserLogin { get; set; }
        public int LEVEL_ID { get; set; }
        public string LEVEL_NAME { get; set; }
        public string BUSINESS_NAME { get; set; }
        public int BUSINESS_ID { get; set; }
        public int LEVEL1_ID { get; set; }
        public int LEVEL2_ID { get; set; }
        public int FTE { get; set; }
        public string SOLUTION_LEAD { get; set; }
        public string TCV { get; set; }
        public int COMPETITOR_ID { get; set; }
        public string COMPETITOR_NAME { get; set; }
        public string TM_PIBS_EMP_NO { get; set; }
        public string TM_PIBS_EMP_NAME { get; set; }
        [ReadOnly(true)]
        public string TM_PIBS_ROLE { get; set; }
        public int VALBPS_CON_ID { get; set; }
        public string VALBPS_CON_NAME { get; set; }
        public string EXECUTIVE_SPONSOR_ID { get; set; }
        public string EXECUTIVE_SPONSOR_NAME { get; set; }
        public string Status { get; set; }
        public string PRESALES_LEAD { get; set; }
        public int LEVELID { get; set; }
        public int SERVICE_ID { get; set; }
        public string DEAL_QUAL_SCORE_WEIGHTAGE { get; set; }
        public string DEAL_QUAL_SCORE_ID { get; set; }
        public string DEAL_QUAL_SCORE_NAME { get; set; }
        public string CRM_TCV { get; set; }
         public int CRM_STAGE { get; set; }
        public int PIBS_STATUS_ID { get; set; }
        public string PIBS_STATUS_NAME { get; set; }
        public string BPO_DOMAIN_ID { get; set; }
        public string PRESALES_DOMAIN_LEAD { get; set; }
        public string COACH_AVAL_ID { get; set; }
        public string COACH_AVAL_NAME { get; set; }
        public string WON_FIRST_BILL_DATE { get; set; }
        public int FnA_FTE { get; set; }
        public int HRO_FTE { get; set; }
        public int SCM_FTE { get; set; }
        public int KPO_FTE { get; set; }
        public int LPO_FTE { get; set; }
        public int BPM_FTE { get; set; }
        public int UnitId { get; set; }
        public string Stage_Name { get; set; }
        public string Advisory_Name { get; set; }
        public int Category_Id { get; set; }
        public string Category_Name { get; set; }
        public string OPPORTUNITY_DESC { get; set; }
        public string OLD_OPPORTUNITY_DESC { get; set; }
        public int GEOGRAPHY_ID { get; set; }
        public string GEOGRAPHY_NAME { get; set; }
        public int CUST_ID { get; set; }
        public string CUST_NAME { get; set; }
        public int CUST_TYPE_ID { get; set; }
        public string CUST_TYPE_NAME { get; set; }
        public int INDUSTRY_PRACTICE_ID { get; set; }
        public string INDUSTRY_PRACTICE_NAME { get; set; }
        public int StageID { get; set; }
        public string STAGE_NAME { get; set; }
        public string ISU_CD { get; set; }
        public string ISU_NAME { get; set; }
        public string GEOGRAPHY_SALES_OWNER { get; set; }
        public string OFFSHORE_PRACTICE_OWNER { get; set; }
        public string RD_CRD { get; set; }
        public string ONSITE_OWNER { get; set; }
        public string OFFSHORE_BD_LEAD { get; set; }
        public string SUB_COMPETENCY_NAME { get; set; }
        public string DEAL_CLOSURE_EXP_DATE { get; set; }
        public int ADVISORY_ID { get; set; }
        public string PLATFORM { get; set; }
        public int PIBS_OUTCOME_ID { get; set; }
        public string PIBS_OUTCOME_NAME { get; set; }
        public int COUNTRY_ID { get; set; }
        public string PIBS { get; set; }
        public string FTE_TYPE { get; set; }
        public int FTE_TYPE_COUNT { get; set; }
        public string CRM_ID { get; set; }
        public string VALUE_BPS { get; set; }
        public int VALUE_BPS_TCV { get; set; }
        public string OPP_TYPE { get; set; }
        public string MULTITOWER_DEAL { get; set; }
        public int OPPSTATUS_FLAG { get; set; }
        public Decimal ESTIMATED_FTE_SIZE { get; set; }
        public int ISU_OWNER_ID { get; set; }
        public int PRODUCT_ID { get; set; }
        public int SUB_COMPETENCY_ID { get; set; }
        public int COMPETENCY_ID { get; set; }
        public string NEXT_STEP_DUE_DT { get; set; }
        public string ACCOUNT_SALES_OWNER_ID { get; set; }
        public int GEOGRAPHY_SALES_OWNER_ID { get; set; }
        public string PRACTICE_SALES_OWNER_ID { get; set; }
        public string ONSITE_OWNER_ID { get; set; }
        public string OFFSHORE_BD_LEAD_ID { get; set; }
        public string DEFAULTERS { get; set; }
        public string LAST_UPDATE { get; set; }
        public string CHANGED_BY { get; set; }
        public DateTime? CHANGED_DT { get; set; }
        public string DEAL_BD_LEAD_ID { get; set; }
        public string DEAL_BD_LEAD_ID2 { get; set; }
        public int RFI_REVIEW_DT { get; set; }
        public int RFP_REVIEW_DT { get; set; }
        public string PIBS_SALE_VALUE { get; set; }
        public string BPO_OFFERING_DESCRIPTION { get; set; }
        public string RFI_REVIEW_BY { get; set; }
        public string RFP_REVIEW_BY { get; set; }
        public string DEAL_QUAL { get; set; }
        public string CRM_REASON { get; set; }
        public string DEAL_DISQUAL { get; set; }
        public string OPP_NGM { get; set; }
        public string BID_EXECUTIVE_EMPID { get; set; }
        public string BID_EXECUTIVE_NAME { get; set; }
        public string KEY_DEAL_CEO { get; set; }
        public string KEY_DEAL_REMARKS { get; set; }
        public int BPS_SUB_SP_ID { get; set; }
        public int BPS_OFFERING_ID { get; set; }
        public int ANNUAL_SALE_VALUE { get; set; }
        public double TOTAL_CONTRACT_VALUE { get; set; }
        public Double DTOTAL_CONTRACT_VALUE { get; set; }

        public string TOTAL_SCORE { get; set; }
        public string SUB_IOU { get; set; }
        public string EXECUTIVE_SPONSOR { get; set; }
        public string VALBPS_CON { get; set; }
        public string PROACTIVE_PROPOSAL { get; set; }
        public string OPP_AGE { get; set; }
        public string ISU_MAIN { get; set; }
        public string PLATFORM_OPTION { get; set; }
        public string WINNING_TEAM { get; set; }
        public string KEY_CUST_EXP { get; set; }
        public string Quarter { get; set; }
        public string FISCAL_YEAR { get; set; }
        public string PROPOSAL_FACTORY { get; set; }
        public string PROPOSAL_FACTORY_OPTIONS { get; set; }
        public string PROPOSAL_FACTORY_COMMENTS { get; set; }
        public string NoOf_TeamMemberPIBS { get; set; }
        public string DT_NAME { get; set; }
        public string Other_DT { get; set; }
        public string STAGESTS { get; set; }
        public string NEXT_STEP { get; set; }
        public string STATUS_UPDATE { get; set; }
        public int PRICING_TYPE_ID { get; set; }
        public int LEVER_ID { get; set; }
        public string LEVER_NAME { get; set; }
        public int VALUE_ID { get; set; }
        public string DOMAIN_PRESALES_LEAD { get; set; }
        public string DEAL_COACH_NAME { get; set; }
        public string DEMAND_TYPE { get; set; }
        public string KEY_DEAL { get; set; }
        public string PROPOSED_SOLUTION { get; set; }
        public string OPERATING_MODEL { get; set; }
        public string PRICING_MODEL { get; set; }
        public string DIFFERENTIATORS { get; set; }
        public string RISKS { get; set; }
        public string KEY_CUSTOMER_CONNECTS { get; set; }
        public string FIRST_TIME_OUTSOURCE { get; set; }
        public string INCUMBENTS { get; set; }
        public string NAME_OF_INCUMBENTS { get; set; }
        public string TCS_OFFERING_CAPABILITY { get; set; }
        public string SPECIFY_OFFERING { get; set; }
        public string COACH_AVAILABLE { get; set; }
        public string FnA { get; set; }
        public string HRO { get; set; }
        public string SCM { get; set; }
        public string KPO { get; set; }
        public string LPO { get; set; }
        public string VERTICAL { get; set; }
        public string BPM { get; set; }
        public int SEAT_REQUIREMENTS { get; set; }
        public string FnA_LEAD { get; set; }
        public string HRO_LEAD { get; set; }
        public string SCM_LEAD { get; set; }
        public string KPO_LEAD { get; set; }
        public string LPO_LEAD { get; set; }
        public string VERTICAL_LEAD { get; set; }
        public string BPM_LEAD { get; set; }
        public string FnATCV { get; set; }
        public string HROTCV { get; set; }
        public string SCMTCV { get; set; }
        public string KPOTCV { get; set; }
        public string LPOTCV { get; set; }
        public string VERTICALTCV { get; set; }
        public string VOICETCV { get; set; }
        public string BPMTCV { get; set; }
        public string VALUE_LEVERS { get; set; }
        public string VALUE_LEVERS_TCV { get; set; }
        public string TCS_INVESTMENT { get; set; }
        public string PIB_START_DT { get; set; }
        public string PIB_END_DT { get; set; }
        public string NO_OF_FTES_ENGAGED { get; set; }
        public string PIB_STATUS { get; set; }
        public string PIB_STATUS_REMARKS { get; set; }
        public string WEEKS { get; set; }
        public string PIBS_QUALIFICATION { get; set; }
        public string PIBS_PROPOSALDECK { get; set; }
        public string PIBS_DATAGATHERING { get; set; }
        public string PIBS_PPTSHARED { get; set; }
        public string PIBS_CUSTFEEDBACK { get; set; }
        public string PIBS_STUDYLOCATION { get; set; }
        public string PIBS_ESTTCV { get; set; }
        public string PIBS_EXEOWNEREMPID { get; set; }
        public string PIBS_EXEOWNEREMPNAME { get; set; }
        public string PIBS_FINALDATE { get; set; }
        public string PIBS_TEAMEMPID { get; set; }
        [ReadOnly(true)]
        public string PIBS_TEAMEMPNAME { get; set; }
        [ReadOnly(true)]
        public string PIBS_ROLEINTEAM { get; set; }
        public string GeosalesOwner { get; set; }
        public string OffPracOwner { get; set; }
        public string RDCrd { get; set; }
        public string OffShoreBDLead { get; set; }
        public string OnsiteOwner { get; set; }
        public int ContractLength { get; set; }
        public string EstFTE { get; set; }
        public int OppDate { get; set; }
        public string EmpNo { get; set; }
        public int ClosureDate { get; set; }
        public string NextStep { get; set; }
        public double AnnualSaleValue { get; set; }
        public string AccountSalesOwner { get; set; }
        public string ExeSponser { get; set; }
        public string ProactiveProposal { get; set; }
        public string ValBPSCon { get; set; }
        public string IsuMain { get; set; }
        public string PlatformNew { get; set; }
        public string StatusUpdate { get; set; }
        public int CountryId { get; set; }
        public int NextStepDueDt { get; set; }
        public string CustFeedback { get; set; }
        public string TCSInvestment { get; set; }
        public int PIBStartDate { get; set; }
        public int PIBSEndDate { get; set; }
        public int FTEsEngaged { get; set; }
        public int PIBStatus { get; set; }
        public string PIBStatusRemarks { get; set; }
        public string chkVariousFTEs { get; set; }
        public int BPODomain { get; set; }
        public string DomainPresalesLeadName { get; set; }
        public int DealCategory { get; set; }
        public int BPSSubSPID { get; set; }
        public int BPSOfferingID { get; set; }
        public string DealCoachName { get; set; }
        public int DemandType { get; set; }
        public string ProposedSolution { get; set; }
        public string KeyRmk { get; set; }
        public string WinningTheme { get; set; }
        public string KeyCustExp { get; set; }
        public string operatingModel { get; set; }
        public string Differentiators { get; set; }
        public string Risks { get; set; }
        public string KeyCustomerConnects { get; set; }
        public string BPOOfferingDescription { get; set; }
        public string chkFirstTimeOutsource { get; set; }
        public string SpecifyOffering { get; set; }
        public string CoachAvailable { get; set; }
        public int VerticalFTE { get; set; }
        public string Voice { get; set; }
        public int VoiceFTE { get; set; }
        public int SeatRequirements { get; set; }
        public int SolTM { get; set; }
        public int DelTM { get; set; }
        public int TransitionTeam { get; set; }
        public int ExpectedDate { get; set; }
        public string TransitionReq { get; set; }
        public string FiscalYear { get; set; }
        public string ImmediateComment { get; set; }
        public string FTEDD { get; set; }
        public string SolutionLeader { get; set; }
        public string RUR { get; set; }
        public string HRTComments { get; set; }
        public string ValueBPS { get; set; }
        public double ValueBPSTCV { get; set; }
        public string MultiTower { get; set; }
        public int StatusFlag { get; set; }
        public string FnA_Lead { get; set; }
        public string HRO_Lead { get; set; }
        public string SCM_Lead { get; set; }
        public string KPO_Lead { get; set; }
        public string LPO_Lead { get; set; }
        public string Voice_Lead { get; set; }
        public string SolutionLeaderId { get; set; }
        public string PibsSaleValue { get; set; }
        public int ClusterId { get; set; }
        public int ServiceId { get; set; }
        public string SUBIOU { get; set; }
        public string TransitionEmpId { get; set; }
        public string TransitionName { get; set; }
        public string TransitionType { get; set; }
        public string TransitionApproach { get; set; }
        public string TransitionModel { get; set; }
        public string Proposalfactory { get; set; }
        public string ProposalfactoryOptions { get; set; }
        public string ProposalComments { get; set; }
        public string DTValue { get; set; }
        public string CRF_ID { get; set; }
        public string T_REF_CODE { get; set; }
        public string GEOGRAPHY_CODE { get; set; }
        public string CUST_TYPE_CODE { get; set; }
        public string INDUSTRY_PRACTICE_CODE { get; set; }
        public string Associate_Details { get; set; }
        public string CREATED_BY { get; set; }
        public string CLOSURE_DATE { get; set; }
        public string DEAL_TERM { get; set; }
        public string CRF_CODE { get; set; }
        public string T_REF_ID { get; set; }
        public string MATC_STATUS { get; set; }
        public string REMARK { get; set; }
        public string FTE_JOIN { get; set; }
        public string READ_STATUS { get; set; }
        public string CRF_CLOSED { get; set; }
        public string REC_FTE { get; set; }
        public string BUFFERFTE { get; set; }
        public string HOLD_DATE { get; set; }
        public string REOPEN_DT { get; set; }
        public string DELIVERY_CENTER_NAME { get; set; }
        public string DL_APPROVED_BY { get; set; }
        public string DL_APPROVED_DT { get; set; }
        public string MATC_APPROVED_BY { get; set; }
        public string MATC_APPROVED_DT { get; set; }
        public string INFRA_HEAD_EMP_ID { get; set; }
        public string INFRA_HEAD_EMP_NAME { get; set; }
        public string INFRA_HEAD_EMP_EMAIL { get; set; }
        public string OSM_STATUS { get; set; }
        public string ESTIMATED_REVENUE { get; set; }
        public int CURRENCY_ID { get; set; }
        public int BUSINESS_TYPE_ID { get; set; }
        public string OPP_OFFERING_ID { get; set; }
        public string TRIGGER_GNDM { get; set; }
        public string STAGE_ENTRY_DT { get; set; }
        public string STAGE_EXIT_DT { get; set; }
        public string CURRENT_FISCAL_REVENUE { get; set; }
        public string WEEKS_REQUIRED_TO_SETUP { get; set; }
        public string SHORTLIST_DT { get; set; }
        public string SELECTION_DT { get; set; }
        public int ONSITE_TRAINING_NOS { get; set; }
        public string VISA_REQUIRED { get; set; }
        public string VISAS_AVAILABLE { get; set; }
        public int VISAS_REQUIRED { get; set; }
        public int TRAINING_DURATION { get; set; }
        public string CONTRACT_NEGOTIATION_DT { get; set; }
        public string WIN_DT { get; set; }
        public string OPPORTUNITY_STATUS { get; set; }
        public string AQP_ASSURANCE_CONTROL_PRESENT { get; set; }
        public string CULTURAL_TRG_INDOCTRINATION_PRESENT { get; set; }
        public string ACTIVE_CAPABILITY_ASSESMENT_PRESENT { get; set; }
        public string EMP_RETENTION_PRG_PRESENT { get; set; }
        public string BCP_DRP_PLAN_PRESENT { get; set; }
        public string RISK_MANAGEMENT_PRESENT { get; set; }
        public string TRIGGER_FOR_REC_SMES { get; set; }
        [ReadOnly(true)]
        public string HIGHLEVEL_COSTS_ESTIMATED { get; set; }
        public string RESOURCING_PLAN_PRESENT { get; set; }
        public int BCP_DRP_LOCATION { get; set; }
        public string NDA_DUE { get; set; }
        public string LINKED_TO_TRON { get; set; }
        public string LINKED_TO_TRON_DT { get; set; }
        public int OPERATION_WINDOW { get; set; }
        public int AREA { get; set; }
        public int TYPES_OF_SEAT { get; set; }
        public int PCS_REQUIRED { get; set; }
        public int DESKS_REQUIRED { get; set; }
        public int PHONES_REQUIRED { get; set; }
        public int CABINS_REQUIRED { get; set; }
        public int LAPTOPS_REQUIRED { get; set; }
        public string IT_REMARK { get; set; }
        public string IT_DOC_STATUS { get; set; }
        public int COMPETITOR_1 { get; set; }
        public int COMPETITOR_2 { get; set; }
        public int COMPETITOR_3 { get; set; }
        public int COMPETITOR_4 { get; set; }
        public int COMPETITOR_5 { get; set; }
        public string TM_SOL_EMP_NO { get; set; }
        public string TM_SOL_EMP_NAME { get; set; }
        public int TM_SOL_ALLOCATION { get; set; }
        [ReadOnly(true)]
        public string BID_MANAGER_EMPID { get; set; }
        public string BID_EXEC_OWNER_EMPID { get; set; }
        [ReadOnly(true)]
        public string BID_MANAGER { get; set; }
        public string BID_EXEC_OWNER { get; set; }
        public string PRICING_OWNER_EMPID { get; set; }
        public string SOLUTION_LEADER_EMPID { get; set; }
        public string NO_SOL_TEAM_MEM { get; set; }
        public string NO_DEL_TEAM_MEM { get; set; }
        public string PRICING_OWNER { get; set; }
        public string TRANSITION_TEAM { get; set; }
        public string TRANSITION_REQUIRED { get; set; }
        public string EXPECTED_START_DATE { get; set; }
        public int FTE_OFFSHORE { get; set; }
        public int FTE_ONSITE { get; set; }
        public string CURRENTLY_ACTIVE { get; set; }
        public string IMMEDIATE_COMMENT { get; set; }
        public string FTE_DD { get; set; }
        public string SOLUTION_LEADER { get; set; }
        public string ENTITY { get; set; }
        public string HRT_COMMENTS { get; set; }
        public string TM_DEL_EMP_NO { get; set; }
        public string TM_DEL_EMP_NAME { get; set; }
        public string TOTAL_TALENT_AVAILABLE { get; set; }
        public string TOTAL_ASSOCIATES_AVAILABLE { get; set; }
        public string TOTAL_TLS_AVAILABLE { get; set; }
        public string TOTAL_LEADERSHIP_AVAILABLE { get; set; }
        public string TOTAL_ASSOCIATES_NEEDED { get; set; }
        public string TOTAL_TLS_NEEDED { get; set; }
        public string TOTAL_LEADERSHIP_NEEDED { get; set; }
        public string AVG_MOVABLE_RATINGS { get; set; }
        public string AVG_TIME_TO_RECRUIT_ASSOCIATES { get; set; }
        public string AVG_TIME_TO_RECRUIT_TLS { get; set; }
        public string AVG_TIME_TO_RECRUIT_LEADERSHIP { get; set; }
        public string MIN_TIME_REQUIRED_TO_MOVE_TALENT { get; set; }
        public string TOTAL_TLS_RECRUITED { get; set; }
        public string VISAS_HELD { get; set; }
        public string TOTAL_ASSOCIATES_RECRUITED { get; set; }
        public string TOTAL_LEADERSHIP_RECRUITED { get; set; }
        public string VISAS_NEEDED { get; set; }
        public string TOTAL_TLS_STAGE { get; set; }
        public string TOTAL_ASSOCIATE_STAGE { get; set; }
        public string TOTAL_LEADERSHIP_STAGE { get; set; }
        public string SUBMITTED_BY { get; set; }
        public string COUNTRY_NAME { get; set; }
        public int DEAL_REASON_ID { get; set; }
        public string DEAL_REASON_NAME { get; set; }
        public string PRODUCT_NAME { get; set; }
        public int LOCATION_ID { get; set; }
        public string LOCATION_NAME { get; set; }
        public string PRICING_TYPE_NAME { get; set; }
        public int WIN_REASON_ID { get; set; }
        public string WIN_REASON_NAME { get; set; }
        public int id { get; set; }
        public string itemName { get; set; }
        public int DEAL_QUAL_ID { get; set; }
        public int DEAL_QUAL_GRP_ID { get; set; }
        public string DEAL_QUAL_GRP_NAME { get; set; }
        public int DEAL_QUAL_FIELD_ID { get; set; }
        public string DEAL_QUAL_FIELD_NAME { get; set; }
        public string DEAL_QUAL_WEIGHTAGE { get; set; }
        public int OPEATION_WINDOW_ID { get; set; }
        public string OPERATION_WINDOW_NAME { get; set; }
        public int TYPES_OF_SEAT_ID { get; set; }
        public string TYPES_OF_SEAT_NAME { get; set; }
        public string TRANSITION_EMPID { get; set; }
        public string TRANSITION_EMPNAME { get; set; }
        public string TRANSITION_TYPE { get; set; }
        public string TRANSITION_APPROACH { get; set; }
        public string TRANSITION_MODEL { get; set; }
        public string opportunity_rec_id { get; set; }
        public int T_REC_ID { get; set; }
        public string DELIVERY_CENTER_ID { get; set; }
        [ReadOnly(true)]
        public string ROLE_CAT_ID { get; set; }
        [ReadOnly(true)]
        public string ROLE_ID { get; set; }
        [ReadOnly(true)]
        public string ROLE_NAME { get; set; }
        public string FTE_REQ_NUMBER { get; set; }
        public string FTE_REQ_DATE { get; set; }
        public string IDENTIFIED_TAGGED { get; set; }
        public string CLOSED_IJP { get; set; }
        public string CRF_RAISED_FOR { get; set; }
        public string CRF_RAISED { get; set; }
        public string Internally_Tagged { get; set; }
        public string Balance1 { get; set; }
        public string IJPCOunt { get; set; }
        public string Balance2 { get; set; }
        public string CLUSTER { get; set; }
        public string SUB_DOMAIN { get; set; }
        public string CRF_TYPE { get; set; }
        public string BUSINESS_TYPE_NAME { get; set; }
        public int IPHCLMAPID { get; set; }
        public string ResponsibleEmployee { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Accountable { get; set; }
        public int offeringType { get; set; }
        public string offeringTypeName { get; set; }
        public string OpportunityDescription { get; set; }
        public string Geography { get; set; }
        public string CustomerName { get; set; }
        public string CustomerTypeID { get; set; }
        public string IndustryPractice { get; set; }
        public string GeographySalesOwner { get; set; }
        public string OffShorePracticeOwner { get; set; }
        public string RdCrd { get; set; }
        public string OffShorePresalesLeadVertical { get; set; }
        public string DealOwner1 { get; set; }
        public string OffshorePresalesLeadHorizontal { get; set; }
        public string PotentialFTE { get; set; }
        public string DaysInStage { get; set; }
        public string Remark { get; set; }
        public string OpportunityReceivedDate { get; set; }
        public string ExpectedDealClosureDate { get; set; }
        public string AdvisoryID { get; set; }
        public string Platform { get; set; }
        public string Vertical { get; set; }
        public string ProductID { get; set; }
        public string CompetencyID { get; set; }
        public string SubCompetencyID { get; set; }
        public string CategoryID { get; set; }
        public string Country { get; set; }
        public string ISU { get; set; }
        public string Service { get; set; }
        public string CRMID { get; set; }
        public string OpportunityTrackedBy { get; set; }
        public string BPSOffering { get; set; }
        public string SubIOU { get; set; }
        public string PlatformOption { get; set; }
        public string Cluster { get; set; }
        public string ExecutiveSponsor { get; set; }
        public string ValueBPSConsultant { get; set; }
        public string IOU { get; set; }
        public string TotalContractValue { get; set; }
        public string ExpectedRevenueQuarter { get; set; }
        public string Fiscalyear { get; set; }
        public string DigitalTransformation { get; set; }
        public string OtherDigitalTransformationValue { get; set; }
        public string StrDealCategory { get; set; }
        public string StrAnnualSaleValue { get; set; }
        public string StrValueBPSTCV { get; set; }
        public string StrBPSSubSPID { get; set; }
        public string StrStatusFlag { get; set; }
        public string StrService { get; set; }
        public string SDealstage { get; set; }
        public string RFI_ReviewDate { get; set; }
        public string RFP_ReviewDate { get; set; }
        public string RFI_ReceivedDate { get; set; }
        public string RFP_ReceivedDate { get; set; }
        public string RFI_ProbableSubmissionDate { get; set; }
        public string RFP_ProbableSubmissionDate { get; set; }
        public string RFI_ActualSubmissionDate { get; set; }
        public string RFP_ActualSubmissionDate { get; set; }
        public string TataGroupAccount { get; set; }
        public string TPA { get; set; }
        public string TPA_Name { get; set; }
        public string ItisScope { get; set; }
        public string IsContractRenewal { get; set; }
        public string ContractRenewalValue { get; set; }
        public int DealStatus { get; set; }
        public int ServicePractice { get; set; }
        public int CoreOffering { get; set; }
        public int subSPId { get; set; }
        public string subSPName { get; set; }
        public string CRM_Beacon { get; set; }
        public string strDigitalTcv { get; set; }

        public int HorizontalId { get; set; }

        //changess
        public int RESOURCING_ID { get; set; }
        public string RESOURCING_NAME { get; set; }
        public string RESOURCING_COLOR { get; set; }
        public int SEAT_IDENTIFICATION_ID { get; set; }
        public string SEAT_IDENTIFICATION_NAME { get; set; }
        public string SEAT_IDENTIFICATION_COLOR { get; set; }
        public string CRM_BEACON { get; set; }
        public int ShortListDate { get; set; }
        public int SelectionDate { get; set; }
        public int ContractCloserDate { get; set; }
        public string strReason1 { get; set; }
        public string strReason2 { get; set; }
        public string strReason3 { get; set; }
        public int intWonFTE { get; set; }
        public string strWINTCV { get; set; }
        public string strWinReason { get; set; }
        public string strWinDate { get; set; }
        public int Deal_statusID { get; set; }
        public string Deal_statusName { get; set; }
        public string Deal_statusColor { get; set; }
        public int Core_OfferingID { get; set; }
        public string Core_OfferingName { get; set; }
        public int Service_PracticesID { get; set; }
        public string Service_PracticesName { get; set; }
        public int ModernisedOffering { get; set; }
        public int CognitiveSolutions { get; set; }
        public string Offerings { get; set; }
        public string WIN_VERBATIM { get; set; }
        public int DEAL_AGING { get; set; }
        public string Next_Step_Notes { get; set; }
        public string Contract_Closure_Date { get; set; }
        public string Category_RAG { get; set; }
        public int DEAL_REASON1 { get; set; }
        public int DEAL_REASON2 { get; set; }
        public int DEAL_REASON3 { get; set; }
        public string Submitted_DT { get; set; }
        public string ActualCloseDate { get; set; }
        public string DealClosureReason { get; set; }
        public string IgnioTMScope { get; set; }
        public string IgnioTMScopeDetails { get; set; }
        public string DigitalFlagging { get; set; }        
        public string OpportunityDescDetails { get; set; }
//End



        public string PROPOSAL_SUBMISSION_DATE { get; set; }
        public string SALES_STAGE_MOVED_ONDATE { get; set; }
        public int Previous_Deal_Stage { get; set; }
        public string DELIVERY_LOCATION_PROPOSED { get; set; }
        public int Delivery_Owner_ID { get; set; }
        public string Delivery_Owner_Name { get; set; }

        public string Category_Code { get; set; }
        public int Platform_id { get; set; }
        public string Platform_name { get; set; }
        public string Cboi_Offering_Name { get; set; }
        public int Cboi_Offering_id { get; set; }
        public int Deal_Flag_id { get; set; }
        public string Deal_Flag_Name { get; set; }



        /// <summary>
        /// Get UnitID based on the OpportunityID
        /// </summary>






        public List<OpportunityUnitID> GetOpportunityUnitID(string opportunityUnitID)
        {
            DataSet ds = null;
            List<OpportunityUnitID> modelList = new List<OpportunityUnitID>();
            try
            {
                string opportunityID = "";

                if (!String.IsNullOrEmpty(opportunityUnitID))
                {
                    opportunityID = StringFunctions.Base64Decode(opportunityUnitID);
                }

                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();

                DbCommand cd = db.GetStoredProcCommand(DataConstants.Get_OpportunityUnitID);

                db.AddInParameter(cd, "@iv_OpportunityID", SqlDbType.VarChar, opportunityID);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;
                        for (int i = 0; i < rowCount; i++)
                        {
                            modelList.Add(MapOpportunity_Get_OpportunityUnitID(ds.Tables[0].Rows[i]));
                        }
                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }
            return modelList;
        }
        private static OpportunityUnitID MapOpportunity_Get_OpportunityUnitID(DataRow dr)
        {
            try
            {
                return new OpportunityUnitID()
                {
                    OpportunityId = (dr.Table.Columns.Contains("OPPORTUNITY_ID")) ? (dr["OPPORTUNITY_ID"] == DBNull.Value) ? "" : Convert.ToString(dr["OPPORTUNITY_ID"]) : "",
                    Id = (dr.Table.Columns.Contains("id")) ? (dr["id"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["id"]) : 0,
                    UnitId = (dr.Table.Columns.Contains("UNIT_ID")) ? (dr["UNIT_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["UNIT_ID"]) : 0,
                };
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }

        }
        /// <summary>
        /// Get OpportunityID based on the Date
        /// </summary>
        public List<OpportunityUnitID> GetOPPID(int unitID)
        {
            DataSet ds = null;
            List<OpportunityUnitID> modelList = new List<OpportunityUnitID>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Get_OPP_Id_by_Date);
                db.AddInParameter(cd, "@iv_UnitId", SqlDbType.Int, unitID);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;
                        for (int i = 0; i < rowCount; i++)
                        {
                            modelList.Add(MapPopulate_OPP_Id(ds.Tables[0].Rows[i]));
                        }
                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }
            return modelList;
        }
        private static OpportunityUnitID MapPopulate_OPP_Id(DataRow dr)
        {
            try
            {
                return new OpportunityUnitID()
                {
                    OpportunityId = (dr.Table.Columns.Contains("OPPORTUNITY_ID")) ? (dr["OPPORTUNITY_ID"] == DBNull.Value) ? "" : Convert.ToString(dr["OPPORTUNITY_ID"]) : "",
                };
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
        }
        /// <summary>
        /// Get FTE_TCV Data
        /// </summary>
        public List<FTETCVData> GetFteTcvData(string unitId, string opportunityId)
        {
            DataSet ds = null;
            List<FTETCVData> modelList = new List<FTETCVData>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Get_FTE_TCV_Data);
                db.AddInParameter(cd, "@iv_UnitId", SqlDbType.VarChar, unitId);
                db.AddInParameter(cd, "@in_OpportunityId", SqlDbType.VarChar, opportunityId);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;
                        for (int i = 0; i < rowCount; i++)
                        {
                            modelList.Add(MapPopulate_fte_tcv_DATA(ds.Tables[0].Rows[i]));
                        }
                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }
            return modelList;
        }
        private static FTETCVData MapPopulate_fte_tcv_DATA(DataRow dr)
        {
            try
            {
                return new FTETCVData()
                {
                    FnA_FTE = (dr.Table.Columns.Contains("FnA_FTE")) ? (dr["FnA_FTE"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["FnA_FTE"]) : 0,
                    HRO_FTE = (dr.Table.Columns.Contains("HRO_FTE")) ? (dr["HRO_FTE"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["HRO_FTE"]) : 0,
                    SCM_FTE = (dr.Table.Columns.Contains("SCM_FTE")) ? (dr["SCM_FTE"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["SCM_FTE"]) : 0,
                    KPO_FTE = (dr.Table.Columns.Contains("KPO_FTE")) ? (dr["KPO_FTE"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["KPO_FTE"]) : 0,
                    LPO_FTE = (dr.Table.Columns.Contains("LPO_FTE")) ? (dr["LPO_FTE"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["LPO_FTE"]) : 0,
                    VerticalFTE = (dr.Table.Columns.Contains("VERTICAL_FTE")) ? (dr["VERTICAL_FTE"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["VERTICAL_FTE"]) : 0,
                    VoiceFTE = (dr.Table.Columns.Contains("VOICE_FTE")) ? (dr["VOICE_FTE"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["VOICE_FTE"]) : 0,
                    BPM_FTE = (dr.Table.Columns.Contains("BPM_FTE")) ? (dr["BPM_FTE"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["BPM_FTE"]) : 0,
                    OpportunityId = (dr.Table.Columns.Contains("OPPORTUNITY_ID")) ? (dr["OPPORTUNITY_ID"] == DBNull.Value) ? "" : Convert.ToString(dr["OPPORTUNITY_ID"]) : "",
                };
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
        }
        /// <summary>
        /// Get ProceedStage Details
        /// </summary>
        public List<OppStage> GetProceedStage(int stageID)
        {
            DataSet ds = null;
            List<OppStage> modelList = new List<OppStage>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Get_ProceedStage);
                db.AddInParameter(cd, "@in_StageID", SqlDbType.Int, stageID);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;
                        for (int i = 0; i < rowCount; i++)
                        {
                            modelList.Add(MapPopulate_Proceed_Stage(ds.Tables[0].Rows[i]));
                        }
                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }
            return modelList;
        }
        private static OppStage MapPopulate_Proceed_Stage(DataRow dr)
        {
            try
            {
                return new OppStage()
                {
                    StageID = (dr.Table.Columns.Contains("STAGE_ID")) ? (dr["STAGE_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["STAGE_ID"]) : 0,
                    Stage_Name = (dr.Table.Columns.Contains("STAGE_NAME")) ? (dr["STAGE_NAME"] == DBNull.Value) ? "" : dr.Field<string>("STAGE_NAME") : "",
                };
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
        }
        /// <summary>
        /// Get Advisory Details
        /// </summary>
        public List<CreateNewOpportunity> GetAdvisory()
        {
            DataSet ds = null;
            List<CreateNewOpportunity> modelList = new List<CreateNewOpportunity>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Get_Advisory);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;
                        for (int i = 0; i < rowCount; i++)
                        {
                            modelList.Add(MapPopulate_cmb_Advisory(ds.Tables[0].Rows[i]));
                        }
                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }
            return modelList;
        }
        private static CreateNewOpportunity MapPopulate_cmb_Advisory(DataRow dr)
        {
            try
            {
                return new CreateNewOpportunity()
                {
                    ADVISORY_ID = (dr.Table.Columns.Contains("ADVISORY_ID")) ? (dr["ADVISORY_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["ADVISORY_ID"]) : 0,
                    Advisory_Name = (dr.Table.Columns.Contains("ADVISORY_NAME")) ? (dr["ADVISORY_NAME"] == DBNull.Value) ? "" : dr.Field<string>("ADVISORY_NAME") : "",
                };
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
        }
        /// <summary>
        /// Get Category Details
        /// </summary>
        public List<CreateNewOpportunity> GetCategory(int unitID)
        {
            DataSet ds = null;
            List<CreateNewOpportunity> modelList = new List<CreateNewOpportunity>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Get_Category);
                db.AddInParameter(cd, "@iv_UnitId", SqlDbType.Int, unitID);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;
                        for (int i = 0; i < rowCount; i++)
                        {
                            modelList.Add(MapPopulate_cmb_Category(ds.Tables[0].Rows[i]));
                        }
                    }
                }
            }

            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }

            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }
            return modelList;
        }
        private static CreateNewOpportunity MapPopulate_cmb_Category(DataRow dr)
        {
            try
            {
                return new CreateNewOpportunity()
                {
                    Category_Id = (dr.Table.Columns.Contains("CATEGORY_ID")) ? (dr["CATEGORY_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CATEGORY_ID"]) : 0,
                    Category_Name = (dr.Table.Columns.Contains("CATEGORY_NAME")) ? (dr["CATEGORY_NAME"] == DBNull.Value) ? "" : dr.Field<string>("CATEGORY_NAME") : "",
                    Category_Code = (dr.Table.Columns.Contains("CATEGORY_CODE")) ? (dr["CATEGORY_CODE"] == DBNull.Value) ? "" : dr.Field<string>("CATEGORY_CODE") : "",
                };

            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
        }
        /// <summary>
        /// Get OffshoreBDLeadAdmin Details
        /// </summary>
        public List<CreateNewOpportunity> GetOffshoreBDLeadAdmin()
        {
            DataSet ds = null;
            List<CreateNewOpportunity> modelList = new List<CreateNewOpportunity>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Get_OffshoreBDLead_Admin);

                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;

                        for (int i = 0; i < rowCount; i++)
                        {
                            modelList.Add(MapPopulate_cmb_OffshoreBDLead_Admin(ds.Tables[0].Rows[i]));
                        }

                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }

            return modelList;
        }
        private static CreateNewOpportunity MapPopulate_cmb_OffshoreBDLead_Admin(DataRow dr)
        {
            try
            {
                return new CreateNewOpportunity()
                {

                    OFFSHORE_BD_LEAD_ID = (dr.Table.Columns.Contains("OFFSHORE_BD_LEAD_ID")) ? (dr["OFFSHORE_BD_LEAD_ID"] == DBNull.Value) ? "" : Convert.ToString(dr["OFFSHORE_BD_LEAD_ID"]) : "",
                    OFFSHORE_BD_LEAD_NAME = (dr.Table.Columns.Contains("OFFSHORE_BD_LEAD_NAME")) ? (dr["OFFSHORE_BD_LEAD_NAME"] == DBNull.Value) ? "" : dr.Field<string>("OFFSHORE_BD_LEAD_NAME") : "",

                };
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
        }
        /// <summary>
        /// Get OffshoreBDLead Details
        /// </summary>
        public List<CreateNewOpportunity> GetOffshoreBDLead(int unitID)
        {
            DataSet ds = null;
            List<CreateNewOpportunity> modelList = new List<CreateNewOpportunity>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Get_OffshoreBDLead);
                db.AddInParameter(cd, "@in_UnitId", SqlDbType.Int, unitID);

                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;

                        for (int i = 0; i < rowCount; i++)
                        {
                            modelList.Add(MapPopulate_cmb_OffshoreBDLead(ds.Tables[0].Rows[i]));
                        }

                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }

            return modelList;
        }
        private static CreateNewOpportunity MapPopulate_cmb_OffshoreBDLead(DataRow dr)
        {
            try
            {
                return new CreateNewOpportunity()
                {

                    OFFSHORE_BD_LEAD_ID = (dr.Table.Columns.Contains("OFFSHORE_BD_LEAD_ID")) ? (dr["OFFSHORE_BD_LEAD_ID"] == DBNull.Value) ? "" : Convert.ToString(dr["OFFSHORE_BD_LEAD_ID"]) : "",
                    OFFSHORE_BD_LEAD_NAME = (dr.Table.Columns.Contains("OFFSHORE_BD_LEAD_NAME")) ? (dr["OFFSHORE_BD_LEAD_NAME"] == DBNull.Value) ? "" : dr.Field<string>("OFFSHORE_BD_LEAD_NAME") : "",

                };
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
        }
        /// <summary>
        /// Get Max Stage 
        /// </summary>
        public int Get_MaxStage(int OpportunityId)
        {
            int Result = 0;
            try
            {

                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Get_MaxStage);
                db.AddInParameter(cd, "@in_OpportunityId", SqlDbType.VarChar, OpportunityId);
                db.AddOutParameter(cd, "@on_StageId", SqlDbType.Int, Int16.MaxValue);
                db.ExecuteNonQuery(cd);
                Result = Convert.ToInt16(db.GetParameterValue(cd, "@on_StageId"));
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {

            }
            return Result;


        }
        /// <summary>
        /// Delete Vertical Data Details
        /// </summary>
        public int DeleteVerticalOppdate(int id, int userId, string oppId, int multiTower)
        {
            try
            {
                int intResult;
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.DELETE_Vertical_Data);
                db.AddInParameter(cd, "@in_Id", SqlDbType.Int, id);
                db.AddInParameter(cd, "@in_EmpNo", SqlDbType.Int, userId);
                db.AddInParameter(cd, "@in_OppId", SqlDbType.VarChar, oppId);
                db.AddInParameter(cd, "@in_MultiTower", SqlDbType.Int, multiTower);
                db.AddOutParameter(cd, "@on_Result", SqlDbType.Int, Int16.MaxValue);
                db.ExecuteNonQuery(cd);
                intResult = Convert.ToInt16(db.GetParameterValue(cd, "@on_Result"));
                return intResult;
            }

            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }


        }
        /// <summary>
        /// Get BPSOffering Details
        /// </summary>
        public List<MultiSelectList> GetBPSOffering(string unitId)
        {
            DataSet ds = null;
            List<MultiSelectList> modelList = new List<MultiSelectList>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Get_BPS_OFFERINGSWTID);

                db.AddInParameter(cd, "@unit_id", SqlDbType.VarChar, unitId);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;

                        for (int i = 0; i < rowCount; i++)
                        {

                            modelList.Add(MapGetBPSOffering(ds.Tables[0].Rows[i]));
                        }

                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }

            return modelList;
        }
        private static MultiSelectList MapGetBPSOffering(DataRow dr)
        {
            try
            {
                return new MultiSelectList()
                {
                    id = (dr.Table.Columns.Contains("BPS_OFFERING_ID")) ? (dr["BPS_OFFERING_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["BPS_OFFERING_ID"]) : 0,
                    itemName = (dr.Table.Columns.Contains("BPS_OFFERING_NAME")) ? (dr["BPS_OFFERING_NAME"] == DBNull.Value) ? "" : dr.Field<string>("BPS_OFFERING_NAME") : "",
                };
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
        }
        /// <summary>
        /// Get Vertical Details
        /// </summary>
        public List<OppVertical> GetVertical(string unitId)
        {
            DataSet ds = null;
            List<OppVertical> modelList = new List<OppVertical>();
            try
            {
                int unit = 0;
                if (!String.IsNullOrEmpty(unitId))
                {
                    unit = Convert.ToInt32(StringFunctions.Base64Decode(unitId));
                }
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Get_ClusterBased_VerticalWTID);
                db.AddInParameter(cd, "@in_UnitId", SqlDbType.Int, unit);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;

                        for (int i = 0; i < rowCount; i++)
                        {

                            modelList.Add(MapGetVerticalName(ds.Tables[0].Rows[i]));
                        }

                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }

            return modelList;
        }
        private static OppVertical MapGetVerticalName(DataRow dr)
        {
            try
            {
                return new OppVertical()
                {
                    BusinessId = (dr.Table.Columns.Contains("BUSINESS_ID")) ? (dr["BUSINESS_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["BUSINESS_ID"]) : 0,
                    BusinessName = (dr.Table.Columns.Contains("BUSINESS_NAME")) ? (dr["BUSINESS_NAME"] == DBNull.Value) ? "" : dr.Field<string>("BUSINESS_NAME") : "",
                };
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
        }
        /// <summary>
        /// Get Platform Details
        /// </summary>
        public List<MultiSelectList> GetPlatform(int unitID)
        {
            DataSet ds = null;
            List<MultiSelectList> modelList = new List<MultiSelectList>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Get_Platform);
                db.AddInParameter(cd, "@iv_UnitId", SqlDbType.VarChar, unitID);

                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;

                        for (int i = 0; i < rowCount; i++)
                        {

                            modelList.Add(MapGetPlatform(ds.Tables[0].Rows[i]));
                        }

                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }

            return modelList;
        }
        private static MultiSelectList MapGetPlatform(DataRow dr)
        {
            try
            {
                return new MultiSelectList()
                {
                    id = (dr.Table.Columns.Contains("ID")) ? (dr["ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["ID"]) : 0,
                    itemName = (dr.Table.Columns.Contains("PLATFORM_NAME")) ? (dr["PLATFORM_NAME"] == DBNull.Value) ? "" : dr.Field<string>("PLATFORM_NAME") : "",

                };
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
        }
        /// <summary>
        /// Get Opportunity Details based on the Stage
        /// </summary>
        public List<CreateNewOpportunity> Getstage1(string strOpportunityId, string strStageId)
        {
            DataSet ds = null;
            List<CreateNewOpportunity> modelList = new List<CreateNewOpportunity>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.GetOpportunity_Stage1_sp);
                db.AddInParameter(cd, "@in_OpportunityId", SqlDbType.VarChar, strOpportunityId);
                db.AddInParameter(cd, "@in_StageId", SqlDbType.Int, strStageId);

                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;

                        for (int i = 0; i < rowCount; i++)
                        {
                            modelList.Add(MapPopulate_Get_stage1(ds.Tables[0].Rows[i]));
                        }

                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }
            return modelList;
        }
        private static CreateNewOpportunity MapPopulate_Get_stage1(DataRow dr)
        {
            try
            {
                return new CreateNewOpportunity()
                {

                    OpportunityId = (dr.Table.Columns.Contains("OPPORTUNITY_ID")) ? (dr["OPPORTUNITY_ID"] == DBNull.Value) ? "" : Convert.ToString(dr["OPPORTUNITY_ID"]) : "",
                    OPPORTUNITY_DESC = (dr.Table.Columns.Contains("OPPORTUNITY_DESC")) ? (dr["OPPORTUNITY_DESC"] == DBNull.Value) ? "" : dr.Field<string>("OPPORTUNITY_DESC") : "",
                    OLD_OPPORTUNITY_DESC = (dr.Table.Columns.Contains("OLD_OPPORTUNITY_DESC")) ? (dr["OLD_OPPORTUNITY_DESC"] == DBNull.Value) ? "" : dr.Field<string>("OLD_OPPORTUNITY_DESC") : "",
                    GEOGRAPHY_ID = (dr.Table.Columns.Contains("GEOGRAPHY_ID")) ? (dr["GEOGRAPHY_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["GEOGRAPHY_ID"]) : 0,
                    GEOGRAPHY_NAME = (dr.Table.Columns.Contains("GEOGRAPHY_NAME")) ? (dr["GEOGRAPHY_NAME"] == DBNull.Value) ? "" : dr.Field<string>("GEOGRAPHY_NAME") : "",
                    CUST_ID = (dr.Table.Columns.Contains("CUST_ID")) ? (dr["CUST_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CUST_ID"]) : 0,
                    CUST_NAME = (dr.Table.Columns.Contains("CUST_NAME")) ? (dr["CUST_NAME"] == DBNull.Value) ? "" : dr.Field<string>("CUST_NAME") : "",
                    CUST_TYPE_ID = (dr.Table.Columns.Contains("CUST_TYPE_ID")) ? (dr["CUST_TYPE_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CUST_TYPE_ID"]) : 0,
                    CUST_TYPE_NAME = (dr.Table.Columns.Contains("CUST_TYPE_NAME")) ? (dr["CUST_TYPE_NAME"] == DBNull.Value) ? "" : dr.Field<string>("CUST_TYPE_NAME") : "",
                    INDUSTRY_PRACTICE_ID = (dr.Table.Columns.Contains("INDUSTRY_PRACTICE_ID")) ? (dr["INDUSTRY_PRACTICE_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["INDUSTRY_PRACTICE_ID"]) : 0,
                    StageID = (dr.Table.Columns.Contains("STAGE_ID")) ? (dr["STAGE_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["STAGE_ID"]) : 0,
                    INDUSTRY_PRACTICE_NAME = (dr.Table.Columns.Contains("INDUSTRY_PRACTICE_NAME")) ? (dr["INDUSTRY_PRACTICE_NAME"] == DBNull.Value) ? "" : dr.Field<string>("INDUSTRY_PRACTICE_NAME") : "",
                    STAGE_NAME = (dr.Table.Columns.Contains("STAGE_NAME")) ? (dr["STAGE_NAME"] == DBNull.Value) ? "" : dr.Field<string>("STAGE_NAME") : "",
                    ISU_CD = (dr.Table.Columns.Contains("ISU_CD")) ? (dr["ISU_CD"] == DBNull.Value) ? "" : dr.Field<string>("ISU_CD") : "",
                    ISU_NAME = (dr.Table.Columns.Contains("ISU_NAME")) ? (dr["ISU_NAME"] == DBNull.Value) ? "" : dr.Field<string>("ISU_NAME") : "",
                    GEOGRAPHY_SALES_OWNER = (dr.Table.Columns.Contains("GEOGRAPHY_SALES_OWNER_ID")) ? (dr["GEOGRAPHY_SALES_OWNER_ID"] == DBNull.Value) ? "" : dr.Field<string>("GEOGRAPHY_SALES_OWNER_ID") : "",
                    ONSITE_OWNER = (dr.Table.Columns.Contains("ONSITE_OWNER_ID")) ? (dr["ONSITE_OWNER_ID"] == DBNull.Value) ? "" : dr.Field<string>("ONSITE_OWNER_ID") : "",
                    OFFSHORE_BD_LEAD = (dr.Table.Columns.Contains("OFFSHORE_BD_LEAD_ID")) ? (dr["OFFSHORE_BD_LEAD_ID"] == DBNull.Value) ? "" : dr.Field<string>("OFFSHORE_BD_LEAD_ID") : "",
                    OPPORTUNITY_DATE = (dr.Table.Columns.Contains("OPPORTUNITY_DATE")) ? (dr["OPPORTUNITY_DATE"] == DBNull.Value) ? "" : dr.Field<string>("OPPORTUNITY_DATE") : "",
                    DEAL_CLOSURE_EXP_DATE = (dr.Table.Columns.Contains("DEAL_CLOSURE_EXP_DATE")) ? (dr["DEAL_CLOSURE_EXP_DATE"] == DBNull.Value) ? "" : dr.Field<string>("DEAL_CLOSURE_EXP_DATE") : "",
                    DTOTAL_CONTRACT_VALUE = (dr.Table.Columns.Contains("TOTAL_CONTRACT_VALUE")) ? (dr["TOTAL_CONTRACT_VALUE"] == DBNull.Value) ? 0 : Convert.ToDouble(dr["TOTAL_CONTRACT_VALUE"]) : 0,
                    BUSINESS_ID = (dr.Table.Columns.Contains("BUSINESS_ID")) ? (dr["BUSINESS_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["BUSINESS_ID"]) : 0,
                    COUNTRY_ID = (dr.Table.Columns.Contains("COUNTRY_ID")) ? (dr["COUNTRY_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["COUNTRY_ID"]) : 0,
                    PIBS = (dr.Table.Columns.Contains("PIBS")) ? (dr["PIBS"] == DBNull.Value) ? "" : dr.Field<string>("PIBS") : "",
                    CRM_ID = (dr.Table.Columns.Contains("CRM_ID")) ? (dr["CRM_ID"] == DBNull.Value) ? "" : dr.Field<string>("CRM_ID") : "",
                    VALUE_BPS = (dr.Table.Columns.Contains("VALUE_BPS")) ? (dr["VALUE_BPS"] == DBNull.Value) ? "" : dr.Field<string>("VALUE_BPS") : "",
                    VALUE_BPS_TCV = (dr.Table.Columns.Contains("VALUE_BPS_TCV")) ? (dr["VALUE_BPS_TCV"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["VALUE_BPS_TCV"]) : 0,
                    OPP_TYPE = (dr.Table.Columns.Contains("OPP_TYPE")) ? (dr["OPP_TYPE"] == DBNull.Value) ? "" : dr.Field<string>("OPP_TYPE") : "",
                    IESTIMATED_FTE_SIZE = (dr.Table.Columns.Contains("ESTIMATED_FTE_SIZE")) ? (dr["ESTIMATED_FTE_SIZE"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["ESTIMATED_FTE_SIZE"]) : 0,
                    ContractLength = (dr.Table.Columns.Contains("CONTRACT_LENGTH")) ? (dr["CONTRACT_LENGTH"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CONTRACT_LENGTH"]) : 0,
                    ISU_OWNER_ID = (dr.Table.Columns.Contains("ISU_OWNER_ID")) ? (dr["ISU_OWNER_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["ISU_OWNER_ID"]) : 0,
                    ACCOUNT_SALES_OWNER_ID = (dr.Table.Columns.Contains("ACCOUNT_SALES_OWNER_ID")) ? (dr["ACCOUNT_SALES_OWNER_ID"] == DBNull.Value) ? "" : dr.Field<string>("ACCOUNT_SALES_OWNER_ID") : "",
                    GEOGRAPHY_SALES_OWNER_ID = (dr.Table.Columns.Contains("GEOGRAPHY_SALES_OWNER_ID")) ? (dr["GEOGRAPHY_SALES_OWNER_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["GEOGRAPHY_SALES_OWNER_ID"]) : 0,
                    OFFSHORE_BD_LEAD_ID = (dr.Table.Columns.Contains("OFFSHORE_BD_LEAD_ID")) ? (dr["OFFSHORE_BD_LEAD_ID"] == DBNull.Value) ? "" : dr.Field<string>("OFFSHORE_BD_LEAD_ID") : "",
                    LAST_UPDATE = (dr.Table.Columns.Contains("LAST_UPDATE")) ? (dr["LAST_UPDATE"] == DBNull.Value) ? "" : dr.Field<string>("LAST_UPDATE") : "",
                    DEAL_BD_LEAD_ID = (dr.Table.Columns.Contains("DEAL_BD_LEAD_ID")) ? (dr["DEAL_BD_LEAD_ID"] == DBNull.Value) ? "" : dr.Field<string>("DEAL_BD_LEAD_ID") : "",
                    DEAL_BD_LEAD_ID2 = (dr.Table.Columns.Contains("DEAL_BD_LEAD_ID2")) ? (dr["DEAL_BD_LEAD_ID2"] == DBNull.Value) ? "" : dr.Field<string>("DEAL_BD_LEAD_ID2") : "",
                    ClusterId = (dr.Table.Columns.Contains("CLUSTER_ID")) ? (dr["CLUSTER_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CLUSTER_ID"]) : 0,
                    DealCategory = (dr.Table.Columns.Contains("DEAL_CATEGORY")) ? (dr["DEAL_CATEGORY"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["DEAL_CATEGORY"]) : 0,
                    BPS_OFFERING_ID = (dr.Table.Columns.Contains("BPS_OFFERING_ID")) ? (dr["BPS_OFFERING_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["BPS_OFFERING_ID"]) : 0,
                    SERVICE_ID = (dr.Table.Columns.Contains("SERVICE_ID")) ? (dr["SERVICE_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["SERVICE_ID"]) : 0,
                    SUB_IOU = (dr.Table.Columns.Contains("SUB_IOU")) ? (dr["SUB_IOU"] == DBNull.Value) ? "" : dr.Field<string>("SUB_IOU") : "",
                    EXECUTIVE_SPONSOR = (dr.Table.Columns.Contains("EXECUTIVE_SPONSOR")) ? (dr["EXECUTIVE_SPONSOR"] == DBNull.Value) ? "" : dr.Field<string>("EXECUTIVE_SPONSOR") : "",
                    VALBPS_CON = (dr.Table.Columns.Contains("VALBPS_CON")) ? (dr["VALBPS_CON"] == DBNull.Value) ? "" : dr.Field<string>("VALBPS_CON") : "",
                    PROACTIVE_PROPOSAL = (dr.Table.Columns.Contains("PROACTIVE_PROPOSAL")) ? (dr["PROACTIVE_PROPOSAL"] == DBNull.Value) ? "" : dr.Field<string>("PROACTIVE_PROPOSAL") : "",
                    ISU_MAIN = (dr.Table.Columns.Contains("ISU_MAIN")) ? (dr["ISU_MAIN"] == DBNull.Value) ? "" : dr.Field<string>("ISU_MAIN") : "",
                    Quarter = (dr.Table.Columns.Contains("quarter")) ? (dr["quarter"] == DBNull.Value) ? "" : dr.Field<string>("quarter") : "",
                    FISCAL_YEAR = (dr.Table.Columns.Contains("FISCAL_YEAR")) ? (dr["FISCAL_YEAR"] == DBNull.Value) ? "" : dr.Field<string>("FISCAL_YEAR") : "",
                    PROPOSAL_FACTORY = (dr.Table.Columns.Contains("PROPOSAL_FACTORY")) ? (dr["PROPOSAL_FACTORY"] == DBNull.Value) ? "" : dr.Field<string>("PROPOSAL_FACTORY") : "",
                    PROPOSAL_FACTORY_OPTIONS = (dr.Table.Columns.Contains("PROPOSAL_FACTORY_OPTIONS")) ? (dr["PROPOSAL_FACTORY_OPTIONS"] == DBNull.Value) ? "" : dr.Field<string>("PROPOSAL_FACTORY_OPTIONS") : "",
                    PROPOSAL_FACTORY_COMMENTS = (dr.Table.Columns.Contains("PROPOSAL_FACTORY_COMMENTS")) ? (dr["PROPOSAL_FACTORY_COMMENTS"] == DBNull.Value) ? "" : dr.Field<string>("PROPOSAL_FACTORY_COMMENTS") : "",
                    DT_ID = (dr.Table.Columns.Contains("DT_ID")) ? (dr["DT_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["DT_ID"]) : 0,
                    Other_DT = (dr.Table.Columns.Contains("Other_DT")) ? (dr["Other_DT"] == DBNull.Value) ? "" : dr.Field<string>("Other_DT") : "",
                    CRM_TCV = (dr.Table.Columns.Contains("CRM_TCV")) ? (dr["CRM_TCV"] == DBNull.Value) ? "" : Convert.ToString(dr["CRM_TCV"]) : "",
                    CRM_STAGE = (dr.Table.Columns.Contains("CRM_STAGE")) ? (dr["CRM_STAGE"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CRM_STAGE"]) : 0,
                    TataGroupAccount = (dr.Table.Columns.Contains("TATA_GROUP_ACCOUNT")) ? (dr["TATA_GROUP_ACCOUNT"] == DBNull.Value) ? "" : Convert.ToString(dr["TATA_GROUP_ACCOUNT"]) : "",
                    ItisScope = (dr.Table.Columns.Contains("ItisScope")) ? (dr["ItisScope"] == DBNull.Value) ? "" : Convert.ToString(dr["ItisScope"]) : "",
                    IsContractRenewal = (dr.Table.Columns.Contains("IsContractRenewal")) ? (dr["IsContractRenewal"] == DBNull.Value) ? "" : Convert.ToString(dr["IsContractRenewal"]) : "",
                    ContractRenewalValue = (dr.Table.Columns.Contains("ContractRenewalValue")) ? (dr["ContractRenewalValue"] == DBNull.Value) ? "" : Convert.ToString(dr["ContractRenewalValue"]) : "",
                    subSPId = (dr.Table.Columns.Contains("SubSPID")) ? (dr["SubSPID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["SubSPID"]) : 0,
                    CRM_Beacon = (dr.Table.Columns.Contains("CRM_Beacon")) ? (dr["CRM_Beacon"] == DBNull.Value) ? "" : Convert.ToString(dr["CRM_Beacon"]) : "",
                    RFI_REVIEW_BY = (dr.Table.Columns.Contains("RFI_REVIEW_BY")) ? (dr["RFI_REVIEW_BY"] == DBNull.Value) ? "" : Convert.ToString(dr["RFI_REVIEW_BY"]) : "",
                    RFI_ReviewDate = (dr.Table.Columns.Contains("RFI_REVIEW_DT")) ? (dr["RFI_REVIEW_DT"] == DBNull.Value) ? "" : dr.Field<string>("RFI_REVIEW_DT") : "",
                    //changess
                    RESOURCING_ID = (dr.Table.Columns.Contains("ResourcingId")) ? (dr["ResourcingId"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["ResourcingId"]) : 0,
                    SEAT_IDENTIFICATION_ID = (dr.Table.Columns.Contains("Seat_IdentificationId")) ? (dr["Seat_IdentificationId"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["Seat_IdentificationId"]) : 0,
                    //End
                    strDigitalTcv = (dr.Table.Columns.Contains("Digital_TCV")) ? (dr["Digital_TCV"] == DBNull.Value) ? "" : dr.Field<string>("Digital_TCV") : "",
                    MULTITOWER_DEAL = (dr.Table.Columns.Contains("MULTITOWER_DEAL")) ? (dr["MULTITOWER_DEAL"] == DBNull.Value) ? "" : dr.Field<string>("MULTITOWER_DEAL") : "",
                    DealStatus = (dr.Table.Columns.Contains("DealStatus_Id")) ? (dr["DealStatus_Id"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["DealStatus_Id"]) : 0,
                    ServicePractice = (dr.Table.Columns.Contains("ServicePractice_Id")) ? (dr["ServicePractice_Id"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["ServicePractice_Id"]) : 0,
                    CoreOffering = (dr.Table.Columns.Contains("CoreOffering_Id")) ? (dr["CoreOffering_Id"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CoreOffering_Id"]) : 0,
                    OpportunityDescDetails = (dr.Table.Columns.Contains("Opportunity_Desc_Details")) ? (dr["Opportunity_Desc_Details"] == DBNull.Value) ? "" : dr.Field<string>("Opportunity_Desc_Details") : "",
                    Previous_Deal_Stage = (dr.Table.Columns.Contains("Previous_Deal_Stage")) ? (dr["Previous_Deal_Stage"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["Previous_Deal_Stage"]) : 0,
                    PLATFORM = (dr.Table.Columns.Contains("PLATFORM")) ? (dr["PLATFORM"] == DBNull.Value) ? "" : dr.Field<string>("PLATFORM") : "",
                    PLATFORM_OPTION = (dr.Table.Columns.Contains("PLATFORM_OPTION")) ? (dr["PLATFORM_OPTION"] == DBNull.Value) ? "" : dr.Field<string>("PLATFORM_OPTION") : "",

                };
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
        }
        /// <summary>
        /// Get General Information for Stage1 
        /// </summary>
        public List<CreateNewOpportunity> GetgenInfoStage1(string opportunityId, string stageId)
        {
            DataSet ds = null;
            List<CreateNewOpportunity> modelList = new List<CreateNewOpportunity>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.GetOpportunity_Stage1_GenInfo_sp);
                db.AddInParameter(cd, "@in_OpportunityId", SqlDbType.VarChar, opportunityId);
                db.AddInParameter(cd, "@in_StageId", SqlDbType.Int, Convert.ToInt32(stageId));

                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;

                        for (int i = 0; i < rowCount; i++)
                        {
                            modelList.Add(MapPopulate_GenInfo_stage1(ds.Tables[0].Rows[i]));
                        }

                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }
            return modelList;
        }
        private static CreateNewOpportunity MapPopulate_GenInfo_stage1(DataRow dr)
        {
            try
            {
                return new CreateNewOpportunity()
                {
                    STAGESTS = (dr.Table.Columns.Contains("STAGESTS")) ? (dr["STAGESTS"] == DBNull.Value) ? "" : dr.Field<string>("STAGESTS") : "",
                    PROBABILITY_OF_WIN = (dr.Table.Columns.Contains("PROBABILITY_OF_WIN")) ? (dr["PROBABILITY_OF_WIN"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["PROBABILITY_OF_WIN"]) : 0,
                    NEXT_STEP = (dr.Table.Columns.Contains("NEXT_STEP")) ? (dr["NEXT_STEP"] == DBNull.Value) ? "" : dr.Field<string>("NEXT_STEP") : "",
                    NEXT_STEP_DUE_DT = (dr.Table.Columns.Contains("NEXT_STEP_DUE_DT")) ? (dr["NEXT_STEP_DUE_DT"] == DBNull.Value) ? "" : dr.Field<string>("NEXT_STEP_DUE_DT") : "",
                    SUB_COMPETENCY_ID = (dr.Table.Columns.Contains("SUB_COMPETENCY_ID")) ? (dr["SUB_COMPETENCY_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["SUB_COMPETENCY_ID"]) : 0,
                    STATUS_UPDATE = (dr.Table.Columns.Contains("STATUS_UPDATE")) ? (dr["STATUS_UPDATE"] == DBNull.Value) ? "" : dr.Field<string>("STATUS_UPDATE") : "",
                    Category_Id = (dr.Table.Columns.Contains("CATEGORY_ID")) ? (dr["CATEGORY_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CATEGORY_ID"]) : 0,
                    OPPSTATUS_FLAG = (dr.Table.Columns.Contains("OPPSTATUS_FLAG")) ? (dr["OPPSTATUS_FLAG"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["OPPSTATUS_FLAG"]) : 0,
                    COMPETENCY_ID = (dr.Table.Columns.Contains("COMPETENCY_ID")) ? (dr["COMPETENCY_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["COMPETENCY_ID"]) : 0,
                    PRICING_TYPE_ID = (dr.Table.Columns.Contains("PRICING_TYPE_ID")) ? (dr["PRICING_TYPE_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["PRICING_TYPE_ID"]) : 0,
                    KEY_CUST_EXP = (dr.Table.Columns.Contains("KEY_CUST_EXP")) ? (dr["KEY_CUST_EXP"] == DBNull.Value) ? "" : dr.Field<string>("KEY_CUST_EXP") : "",
                    WINNING_TEAM = (dr.Table.Columns.Contains("WINNING_TEAM")) ? (dr["WINNING_TEAM"] == DBNull.Value) ? "" : dr.Field<string>("WINNING_TEAM") : "",
                    DAYS_IN_THIS_STAGE = (dr.Table.Columns.Contains("DAYS_IN_THIS_STAGE")) ? (dr["DAYS_IN_THIS_STAGE"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["DAYS_IN_THIS_STAGE"]) : 0,
                    OPPORTUNITY_DATE = (dr.Table.Columns.Contains("OPPORTUNITY_DATE")) ? (dr["OPPORTUNITY_DATE"] == DBNull.Value) ? "" : dr.Field<string>("OPPORTUNITY_DATE") : "",
                    FTE_OFFSHORE = (dr.Table.Columns.Contains("FTE_OFFSHORE")) ? (dr["FTE_OFFSHORE"] == DBNull.Value) ? 0 : dr.Field<Int32>("FTE_OFFSHORE") : 0,
                    FTE_ONSITE = (dr.Table.Columns.Contains("FTE_ONSITE")) ? (dr["FTE_ONSITE"] == DBNull.Value) ? 0 : dr.Field<Int32>("FTE_ONSITE") : 0,
                    RFI_ReceivedDate = (dr.Table.Columns.Contains("RFI_RECEIVED_DT")) ? (dr["RFI_RECEIVED_DT"] == DBNull.Value) ? "" : dr.Field<string>("RFI_RECEIVED_DT") : "",
                    RFP_ReceivedDate = (dr.Table.Columns.Contains("RFP_RECEIVED_DT")) ? (dr["RFP_RECEIVED_DT"] == DBNull.Value) ? "" : dr.Field<string>("RFP_RECEIVED_DT") : "",
                    RFI_ProbableSubmissionDate = (dr.Table.Columns.Contains("RFI_PROBABLE_SUBMISSION_DT")) ? (dr["RFI_PROBABLE_SUBMISSION_DT"] == DBNull.Value) ? "" : dr.Field<string>("RFI_PROBABLE_SUBMISSION_DT") : "",
                    RFP_ProbableSubmissionDate = (dr.Table.Columns.Contains("RFP_PROBABLE_SUBMISSION_DT")) ? (dr["RFI_PROBABLE_SUBMISSION_DT"] == DBNull.Value) ? "" : dr.Field<string>("RFI_PROBABLE_SUBMISSION_DT") : "",
                    RFI_ActualSubmissionDate = (dr.Table.Columns.Contains("RFI_ACTUAL_SUBMISSION_DT")) ? (dr["RFI_ACTUAL_SUBMISSION_DT"] == DBNull.Value) ? "" : dr.Field<string>("RFI_ACTUAL_SUBMISSION_DT") : "",
                    RFP_ActualSubmissionDate = (dr.Table.Columns.Contains("RFP_ACTUAL_SUBMISSION_DT")) ? (dr["RFP_ACTUAL_SUBMISSION_DT"] == DBNull.Value) ? "" : dr.Field<string>("RFP_ACTUAL_SUBMISSION_DT") : "",
                    CURRENCY_ID = (dr.Table.Columns.Contains("CURRENCY_ID")) ? (dr["CURRENCY_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CURRENCY_ID"]) : 0,
                    TPA = (dr.Table.Columns.Contains("TPA")) ? (dr["TPA"] == DBNull.Value) ? "" : Convert.ToString(dr["TPA"]) : "",
                    TPA_Name = (dr.Table.Columns.Contains("TPA_NAME")) ? (dr["TPA_NAME"] == DBNull.Value) ? "" : Convert.ToString(dr["TPA_NAME"]) : "",
                    RFI_REVIEW_BY = (dr.Table.Columns.Contains("RFI_REVIEW_BY")) ? (dr["RFI_REVIEW_BY"] == DBNull.Value) ? "" : Convert.ToString(dr["RFI_REVIEW_BY"]) : "",
                    RFP_REVIEW_BY = (dr.Table.Columns.Contains("RFP_REVIEW_BY")) ? (dr["RFP_REVIEW_BY"] == DBNull.Value) ? "" : Convert.ToString(dr["RFP_REVIEW_BY"]) : "",                                     
                    SHORTLIST_DT = (dr.Table.Columns.Contains("SHORTLIST_DT")) ? (dr["SHORTLIST_DT"] == DBNull.Value) ? "" : Convert.ToString(dr["SHORTLIST_DT"]) : "",
                    SELECTION_DT = (dr.Table.Columns.Contains("SELECTION_DT")) ? (dr["SELECTION_DT"] == DBNull.Value) ? "" : Convert.ToString(dr["SELECTION_DT"]) : "",
                    ModernisedOffering = (dr.Table.Columns.Contains("ModernisedOffering_Id")) ? (dr["ModernisedOffering_Id"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["ModernisedOffering_Id"]) : 0,
                    CognitiveSolutions = (dr.Table.Columns.Contains("CognitiveSolutions_Id")) ? (dr["CognitiveSolutions_Id"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CognitiveSolutions_Id"]) : 0,
                    Offerings = (dr.Table.Columns.Contains("IsNewOfferings")) ? (dr["IsNewOfferings"] == DBNull.Value) ? "" : dr.Field<string>("IsNewOfferings") : "",
                    IgnioTMScope = (dr.Table.Columns.Contains("IgnioTM_Scope")) ? (dr["IgnioTM_Scope"] == DBNull.Value) ? "" : Convert.ToString(dr["IgnioTM_Scope"]) : "",
                    IgnioTMScopeDetails = (dr.Table.Columns.Contains("IgnioTM_ScopeDetail")) ? (dr["IgnioTM_ScopeDetail"] == DBNull.Value) ? "" : dr.Field<string>("IgnioTM_ScopeDetail") : "",

                };
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
        }
        /// <summary>
        /// Get Value Levers Details
        /// </summary>
        public List<CreateNewOpportunity> GetValueLevers()
        {
            DataSet ds = null;
            List<CreateNewOpportunity> modelList = new List<CreateNewOpportunity>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.POPULATE_VALUE_LEVERS);

                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;

                        for (int i = 0; i < rowCount; i++)
                        {
                            modelList.Add(MapGet_ValueLevers(ds.Tables[0].Rows[i]));
                        }

                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }
            return modelList;
        }
        private static CreateNewOpportunity MapGet_ValueLevers(DataRow dr)
        {
            try
            {
                return new CreateNewOpportunity()
                {

                    LEVER_ID = (dr.Table.Columns.Contains("LEVER_ID")) ? (dr["LEVER_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["LEVER_ID"]) : 0,
                    LEVER_NAME = (dr.Table.Columns.Contains("LEVER_NAME")) ? (dr["LEVER_NAME"] == DBNull.Value) ? "" : dr.Field<string>("LEVER_NAME") : "",

                };
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
        }
        /// <summary>
        /// Get Opportunity Value Levers Details 
        /// </summary>
        public List<CreateNewOpportunity> GetValueLevers(string oppID)
        {
            DataSet ds = null;
            List<CreateNewOpportunity> modelList = new List<CreateNewOpportunity>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Get_Opp_ValueLevers);
                db.AddInParameter(cd, "@iv_OppID", SqlDbType.VarChar, oppID);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;

                        for (int i = 0; i < rowCount; i++)
                        {
                            modelList.Add(MapGet_Opp_ValueLevers(ds.Tables[0].Rows[i]));
                        }

                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }
            return modelList;
        }
        private static CreateNewOpportunity MapGet_Opp_ValueLevers(DataRow dr)
        {
            try
            {
                return new CreateNewOpportunity()
                {

                    VALUE_ID = (dr.Table.Columns.Contains("VALUE_ID")) ? (dr["VALUE_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["VALUE_ID"]) : 0,
                    LEVER_NAME = (dr.Table.Columns.Contains("LEVER_NAME")) ? (dr["LEVER_NAME"] == DBNull.Value) ? "" : dr.Field<string>("LEVER_NAME") : "",

                };
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
        }
        /// <summary>
        /// Update Opportunity Value Levers Details
        /// </summary>
        public int UpdOppValueLevers(string oppId, int valueID, string userLogin)
        {
            try
            {
                int intResult;
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Upd_OppValueLevers);
                db.AddInParameter(cd, "@iv_OppID", SqlDbType.VarChar, oppId);
                db.AddInParameter(cd, "@in_ValueID", SqlDbType.VarChar, valueID);
                db.AddInParameter(cd, "@iv_UserLogin", SqlDbType.VarChar, userLogin);
                db.AddOutParameter(cd, "@on_Result", SqlDbType.Int, Int16.MaxValue);
                db.ExecuteNonQuery(cd);
                intResult = Convert.ToInt16(db.GetParameterValue(cd, "@on_Result"));
                return intResult;
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
        }
        /// <summary>
        /// Save Opportunity Value Levers Details
        /// </summary>
        public int SaveOppValueLevers(string oppId, int valueID, string userLogin, string proactiveProposal)
        {
            try
            {
                int intResult;
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Ins_ValueLevers);
                db.AddInParameter(cd, "@iv_OppID", SqlDbType.VarChar, oppId);
                db.AddInParameter(cd, "@in_ValueID", SqlDbType.Int, valueID);
                db.AddInParameter(cd, "@iv_UserLogin", SqlDbType.VarChar, userLogin);
                db.AddInParameter(cd, "@iv_ProactiveProposal", SqlDbType.VarChar, proactiveProposal);
                db.AddOutParameter(cd, "@on_Result", SqlDbType.Int, Int16.MaxValue);
                db.ExecuteNonQuery(cd);
                intResult = Convert.ToInt16(db.GetParameterValue(cd, "@on_Result"));
                return intResult;
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
        }
        /// <summary>
        /// Update ValueLevers TCV 
        /// </summary>
        public int Stage1Save_ValueLeversTCV(string oppId, string valueID, string userLogin)
        {
            try
            {
                int intResult;
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Update_ValueLevers_TCV);
                db.AddInParameter(cd, "@iv_OppID", SqlDbType.VarChar, oppId);
                db.AddInParameter(cd, "@in_ValueTCV", SqlDbType.VarChar, valueID);
                db.AddInParameter(cd, "@iv_UserLogin", SqlDbType.VarChar, userLogin);
                db.ExecuteNonQuery(cd);
                intResult = Convert.ToInt16(db.GetParameterValue(cd, "@on_Result"));
                return intResult;
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
        }
        /// <summary>
        /// Insert DelTeamMember Details
        /// </summary>
        public int Ins_DelTeamMember(CreateNewOpportunity ObjCreateNewOpportunity)
        {
            try
            {
                int intResult;
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Ins_DelTeamMmber);
                db.AddInParameter(cd, "@iv_OppID", SqlDbType.VarChar, ObjCreateNewOpportunity.OpportunityId);
                db.AddInParameter(cd, "@iv_EmpID", SqlDbType.Int, ObjCreateNewOpportunity.EmpId);
                db.AddInParameter(cd, "@iv_EmpName", SqlDbType.VarChar, ObjCreateNewOpportunity.EmpName);
                db.AddInParameter(cd, "@iv_UserLogin", SqlDbType.VarChar, ObjCreateNewOpportunity.UserLogin);
                db.AddOutParameter(cd, "@on_Result", SqlDbType.Int, Int16.MaxValue);
                db.ExecuteNonQuery(cd);
                intResult = Convert.ToInt16(db.GetParameterValue(cd, "@on_Result"));
                return intResult;
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
        }
        /// <summary>
        /// Get Opportunity Stage1 FnA Details
        /// </summary>
        public List<CreateNewOpportunity> Get_FnA_stage1(string opportunityId, string stageId)
        {
            DataSet ds = null;
            List<CreateNewOpportunity> modelList = new List<CreateNewOpportunity>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.GetOpportunity_Stage1_FnA_sp);
                db.AddInParameter(cd, "in_OpportunityId", SqlDbType.VarChar, opportunityId);
                db.AddInParameter(cd, "in_StageId", SqlDbType.VarChar, stageId);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;

                        for (int i = 0; i < rowCount; i++)
                        {
                            modelList.Add(MapPopulate_Get_FnA_stage1(ds.Tables[0].Rows[i]));
                        }

                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }
            return modelList;
        }
        private static CreateNewOpportunity MapPopulate_Get_FnA_stage1(DataRow dr)
        {
            try
            {
                return new CreateNewOpportunity()
                {

                    STAGESTS = (dr.Table.Columns.Contains("STAGESTS")) ? (dr["STAGESTS"] == DBNull.Value) ? "" : dr.Field<string>("STAGESTS") : "",
                    BPODomain = (dr.Table.Columns.Contains("BPO_DOMAIN")) ? (dr["BPO_DOMAIN"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["BPO_DOMAIN"]) : 0,
                    DOMAIN_PRESALES_LEAD = (dr.Table.Columns.Contains("DOMAIN_PRESALES_LEAD")) ? (dr["DOMAIN_PRESALES_LEAD"] == DBNull.Value) ? "" : dr.Field<string>("DOMAIN_PRESALES_LEAD") : "",
                    DomainPresalesLeadName = (dr.Table.Columns.Contains("DOMAIN_PRESALES_LEAD_NAME")) ? (dr["DOMAIN_PRESALES_LEAD_NAME"] == DBNull.Value) ? "" : dr.Field<string>("DOMAIN_PRESALES_LEAD_NAME") : "",
                    DealCategory = (dr.Table.Columns.Contains("DEAL_CATEGORY")) ? (dr["DEAL_CATEGORY"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["DEAL_CATEGORY"]) : 0,
                    DEAL_COACH_NAME = (dr.Table.Columns.Contains("DEAL_COACH_NAME")) ? (dr["DEAL_COACH_NAME"] == DBNull.Value) ? "" : dr.Field<string>("DEAL_COACH_NAME") : "",
                    DEMAND_TYPE = (dr.Table.Columns.Contains("DEMAND_TYPE")) ? (dr["DEMAND_TYPE"] == DBNull.Value) ? "" : dr.Field<string>("DEMAND_TYPE") : "",
                    KEY_DEAL = (dr.Table.Columns.Contains("KEY_DEAL")) ? (dr["KEY_DEAL"] == DBNull.Value) ? "" : dr.Field<string>("KEY_DEAL") : "",
                    PROPOSED_SOLUTION = (dr.Table.Columns.Contains("PROPOSED_SOLUTION")) ? (dr["PROPOSED_SOLUTION"] == DBNull.Value) ? "" : dr.Field<string>("PROPOSED_SOLUTION") : "",
                    WINNING_TEAM = (dr.Table.Columns.Contains("WINNING_TEAM")) ? (dr["WINNING_TEAM"] == DBNull.Value) ? "" : dr.Field<string>("WINNING_TEAM") : "",
                    KEY_CUST_EXP = (dr.Table.Columns.Contains("KEY_CUST_EXP")) ? (dr["KEY_CUST_EXP"] == DBNull.Value) ? "" : dr.Field<string>("KEY_CUST_EXP") : "",
                    OPERATING_MODEL = (dr.Table.Columns.Contains("OPERATING_MODEL")) ? (dr["OPERATING_MODEL"] == DBNull.Value) ? "" : dr.Field<string>("OPERATING_MODEL") : "",
                    PRICING_MODEL = (dr.Table.Columns.Contains("PRICING_MODEL")) ? (dr["PRICING_MODEL"] == DBNull.Value) ? "" : dr.Field<string>("PRICING_MODEL") : "",
                    DIFFERENTIATORS = (dr.Table.Columns.Contains("DIFFERENTIATORS")) ? (dr["DIFFERENTIATORS"] == DBNull.Value) ? "" : dr.Field<string>("DIFFERENTIATORS") : "",
                    RISKS = (dr.Table.Columns.Contains("RISKS")) ? (dr["RISKS"] == DBNull.Value) ? "" : dr.Field<string>("RISKS") : "",
                    KEY_CUSTOMER_CONNECTS = (dr.Table.Columns.Contains("KEY_CUSTOMER_CONNECTS")) ? (dr["KEY_CUSTOMER_CONNECTS"] == DBNull.Value) ? "" : dr.Field<string>("KEY_CUSTOMER_CONNECTS") : "",
                    BPO_OFFERING_DESCRIPTION = (dr.Table.Columns.Contains("BPO_OFFERING_DESCRIPTION")) ? (dr["BPO_OFFERING_DESCRIPTION"] == DBNull.Value) ? "" : dr.Field<string>("BPO_OFFERING_DESCRIPTION") : "",
                    FIRST_TIME_OUTSOURCE = (dr.Table.Columns.Contains("FIRST_TIME_OUTSOURCE")) ? (dr["FIRST_TIME_OUTSOURCE"] == DBNull.Value) ? "" : dr.Field<string>("FIRST_TIME_OUTSOURCE") : "",
                    INCUMBENTS = (dr.Table.Columns.Contains("INCUMBENTS")) ? (dr["INCUMBENTS"] == DBNull.Value) ? "" : dr.Field<string>("INCUMBENTS") : "",
                    NAME_OF_INCUMBENTS = (dr.Table.Columns.Contains("NAME_OF_INCUMBENTS")) ? (dr["NAME_OF_INCUMBENTS"] == DBNull.Value) ? "" : dr.Field<string>("NAME_OF_INCUMBENTS") : "",
                    TCS_OFFERING_CAPABILITY = (dr.Table.Columns.Contains("TCS_OFFERING_CAPABILITY")) ? (dr["TCS_OFFERING_CAPABILITY"] == DBNull.Value) ? "" : dr.Field<string>("TCS_OFFERING_CAPABILITY") : "",
                    SPECIFY_OFFERING = (dr.Table.Columns.Contains("SPECIFY_OFFERING")) ? (dr["SPECIFY_OFFERING"] == DBNull.Value) ? "" : dr.Field<string>("SPECIFY_OFFERING") : "",
                    COACH_AVAILABLE = (dr.Table.Columns.Contains("COACH_AVAILABLE")) ? (dr["COACH_AVAILABLE"] == DBNull.Value) ? "" : dr.Field<string>("COACH_AVAILABLE") : "",
                    FnA = (dr.Table.Columns.Contains("FnA")) ? (dr["FnA"] == DBNull.Value) ? "" : dr.Field<string>("FnA") : "",
                    FnA_FTE = (dr.Table.Columns.Contains("FnA_FTE")) ? (dr["FnA_FTE"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["FnA_FTE"]) : 0,
                    HRO = (dr.Table.Columns.Contains("HRO")) ? (dr["HRO"] == DBNull.Value) ? "" : dr.Field<string>("HRO") : "",
                    HRO_FTE = (dr.Table.Columns.Contains("HRO_FTE")) ? (dr["HRO_FTE"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["HRO_FTE"]) : 0,
                    SCM = (dr.Table.Columns.Contains("SCM")) ? (dr["SCM"] == DBNull.Value) ? "" : dr.Field<string>("SCM") : "",
                    SCM_FTE = (dr.Table.Columns.Contains("SCM_FTE")) ? (dr["SCM_FTE"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["SCM_FTE"]) : 0,
                    KPO = (dr.Table.Columns.Contains("KPO")) ? (dr["KPO"] == DBNull.Value) ? "" : dr.Field<string>("KPO") : "",
                    KPO_FTE = (dr.Table.Columns.Contains("KPO_FTE")) ? (dr["KPO_FTE"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["KPO_FTE"]) : 0,
                    LPO = (dr.Table.Columns.Contains("LPO")) ? (dr["LPO"] == DBNull.Value) ? "" : dr.Field<string>("LPO") : "",
                    LPO_FTE = (dr.Table.Columns.Contains("LPO_FTE")) ? (dr["LPO_FTE"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["LPO_FTE"]) : 0,
                    VERTICAL = (dr.Table.Columns.Contains("VERTICAL")) ? (dr["VERTICAL"] == DBNull.Value) ? "" : dr.Field<string>("VERTICAL") : "",
                    VerticalFTE = (dr.Table.Columns.Contains("VERTICAL_FTE")) ? (dr["VERTICAL_FTE"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["VERTICAL_FTE"]) : 0,
                    Voice = (dr.Table.Columns.Contains("VOICE")) ? (dr["VOICE"] == DBNull.Value) ? "" : dr.Field<string>("VOICE") : "",
                    VoiceFTE = (dr.Table.Columns.Contains("VOICE_FTE")) ? (dr["VOICE_FTE"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["VOICE_FTE"]) : 0,
                    BPM = (dr.Table.Columns.Contains("BPM")) ? (dr["BPM"] == DBNull.Value) ? "" : dr.Field<string>("BPM") : "",
                    BPM_FTE = (dr.Table.Columns.Contains("BPM_FTE")) ? (dr["BPM_FTE"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["BPM_FTE"]) : 0,
                    SEAT_REQUIREMENTS = (dr.Table.Columns.Contains("SEAT_REQUIREMENTS")) ? (dr["SEAT_REQUIREMENTS"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["SEAT_REQUIREMENTS"]) : 0,
                    FnA_LEAD = (dr.Table.Columns.Contains("FnA_LEAD")) ? (dr["FnA_LEAD"] == DBNull.Value) ? "" : dr.Field<string>("FnA_LEAD") : "",
                    HRO_LEAD = (dr.Table.Columns.Contains("HRO_LEAD")) ? (dr["HRO_LEAD"] == DBNull.Value) ? "" : dr.Field<string>("HRO_LEAD") : "",
                    SCM_LEAD = (dr.Table.Columns.Contains("SCM_LEAD")) ? (dr["SCM_LEAD"] == DBNull.Value) ? "" : dr.Field<string>("SCM_LEAD") : "",
                    KPO_LEAD = (dr.Table.Columns.Contains("KPO_LEAD")) ? (dr["KPO_LEAD"] == DBNull.Value) ? "" : dr.Field<string>("KPO_LEAD") : "",
                    LPO_LEAD = (dr.Table.Columns.Contains("LPO_LEAD")) ? (dr["LPO_LEAD"] == DBNull.Value) ? "" : dr.Field<string>("LPO_LEAD") : "",
                    VERTICAL_LEAD = (dr.Table.Columns.Contains("VERTICAL_LEAD")) ? (dr["VERTICAL_LEAD"] == DBNull.Value) ? "" : dr.Field<string>("VERTICAL_LEAD") : "",
                    Voice_Lead = (dr.Table.Columns.Contains("VOICE_LEAD")) ? (dr["VOICE_LEAD"] == DBNull.Value) ? "" : dr.Field<string>("VOICE_LEAD") : "",
                    BPM_LEAD = (dr.Table.Columns.Contains("BPM_LEAD")) ? (dr["BPM_LEAD"] == DBNull.Value) ? "" : dr.Field<string>("BPM_LEAD") : "",
                    FnATCV = (dr.Table.Columns.Contains("FnATCV")) ? (dr["FnATCV"] == DBNull.Value) ? "" : dr.Field<string>("FnATCV") : "",
                    HROTCV = (dr.Table.Columns.Contains("HROTCV")) ? (dr["HROTCV"] == DBNull.Value) ? "" : dr.Field<string>("HROTCV") : "",
                    SCMTCV = (dr.Table.Columns.Contains("SCMTCV")) ? (dr["SCMTCV"] == DBNull.Value) ? "" : dr.Field<string>("SCMTCV") : "",
                    KPOTCV = (dr.Table.Columns.Contains("KPOTCV")) ? (dr["KPOTCV"] == DBNull.Value) ? "" : dr.Field<string>("KPOTCV") : "",
                    LPOTCV = (dr.Table.Columns.Contains("LPOTCV")) ? (dr["LPOTCV"] == DBNull.Value) ? "" : dr.Field<string>("LPOTCV") : "",
                    VERTICALTCV = (dr.Table.Columns.Contains("VERTICALTCV")) ? (dr["VERTICALTCV"] == DBNull.Value) ? "" : dr.Field<string>("VERTICALTCV") : "",
                    VOICETCV = (dr.Table.Columns.Contains("VOICETCV")) ? (dr["VOICETCV"] == DBNull.Value) ? "" : dr.Field<string>("VOICETCV") : "",
                    BPMTCV = (dr.Table.Columns.Contains("BPMTCV")) ? (dr["BPMTCV"] == DBNull.Value) ? "" : dr.Field<string>("BPMTCV") : "",
                    KEY_DEAL_CEO = (dr.Table.Columns.Contains("KEY_DEAL_CEO")) ? (dr["KEY_DEAL_CEO"] == DBNull.Value) ? "" : dr.Field<string>("KEY_DEAL_CEO") : "",
                    KEY_DEAL_REMARKS = (dr.Table.Columns.Contains("KEY_DEAL_REMARKS")) ? (dr["KEY_DEAL_REMARKS"] == DBNull.Value) ? "" : dr.Field<string>("KEY_DEAL_REMARKS") : "",
                    GEOGRAPHY_SALES_OWNER_ID = (dr.Table.Columns.Contains("GEOGRAPHY_SALES_OWNER_ID")) ? (dr["GEOGRAPHY_SALES_OWNER_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["GEOGRAPHY_SALES_OWNER_ID"]) : 0,
                    VALUE_LEVERS = (dr.Table.Columns.Contains("VALUE_LEVERS")) ? (dr["VALUE_LEVERS"] == DBNull.Value) ? "" : dr.Field<string>("VALUE_LEVERS") : "",
                    VALUE_LEVERS_TCV = (dr.Table.Columns.Contains("VALUE_LEVERS_TCV")) ? (dr["VALUE_LEVERS_TCV"] == DBNull.Value) ? "" : dr.Field<string>("VALUE_LEVERS_TCV") : "",
                    PROACTIVE_PROPOSAL = (dr.Table.Columns.Contains("PROACTIVE_PROPOSAL")) ? (dr["PROACTIVE_PROPOSAL"] == DBNull.Value) ? "" : dr.Field<string>("PROACTIVE_PROPOSAL") : "",
                    DEAL_QUAL = (dr.Table.Columns.Contains("DEAL_QUAL")) ? (dr["DEAL_QUAL"] == DBNull.Value) ? "" : dr.Field<string>("DEAL_QUAL") : "",
                    DEAL_DISQUAL = (dr.Table.Columns.Contains("DEAL_DISQUAL")) ? (dr["DEAL_DISQUAL"] == DBNull.Value) ? "" : dr.Field<string>("DEAL_DISQUAL") : "",
                    PLATFORM = (dr.Table.Columns.Contains("PLATFORM")) ? (dr["PLATFORM"] == DBNull.Value) ? "" : dr.Field<string>("PLATFORM") : "",
                    PLATFORM_OPTION = (dr.Table.Columns.Contains("PLATFORM_OPTION")) ? (dr["PLATFORM_OPTION"] == DBNull.Value) ? "" : dr.Field<string>("PLATFORM_OPTION") : "",
                   

                };
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
        }
        /// <summary>
        /// Get Opportunity Stage1 PIBS Details
        /// </summary>
        public List<CreateNewOpportunity> GetPIBS_stage1(string opportunityId, string stageId)
        {
            DataSet ds = null;
            List<CreateNewOpportunity> modelList = new List<CreateNewOpportunity>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.GetOpportunity_Stage1_PIBS_sp);
                db.AddInParameter(cd, "@in_OpportunityId", SqlDbType.VarChar, opportunityId);
                db.AddInParameter(cd, "@in_StageId", SqlDbType.Int, stageId);

                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;

                        for (int i = 0; i < rowCount; i++)
                        {
                            modelList.Add(MapGetPopulate_Get_PIBS_stage1(ds.Tables[0].Rows[i]));
                        }

                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }
            return modelList;
        }
        private static CreateNewOpportunity MapGetPopulate_Get_PIBS_stage1(DataRow dr)
        {
            try
            {
                return new CreateNewOpportunity()
                {

                    STAGESTS = (dr.Table.Columns.Contains("STAGESTS")) ? (dr["STAGESTS"] == DBNull.Value) ? "" : dr.Field<string>("STAGESTS") : "",
                    PIBS = (dr.Table.Columns.Contains("PIBS")) ? (dr["PIBS"] == DBNull.Value) ? "" : dr.Field<string>("PIBS") : "",
                    TCS_INVESTMENT = (dr.Table.Columns.Contains("TCS_INVESTMENT")) ? (dr["TCS_INVESTMENT"] == DBNull.Value) ? "" : dr.Field<string>("TCS_INVESTMENT") : "",
                    PIB_START_DT = (dr.Table.Columns.Contains("PIB_START_DT")) ? (dr["PIB_START_DT"] == DBNull.Value) ? "" : dr.Field<string>("PIB_START_DT") : "",
                    PIB_END_DT = (dr.Table.Columns.Contains("PIB_END_DT")) ? (dr["PIB_END_DT"] == DBNull.Value) ? "" : dr.Field<string>("PIB_END_DT") : "",
                    NO_OF_FTES_ENGAGED = (dr.Table.Columns.Contains("NO_OF_FTES_ENGAGED")) ? (dr["NO_OF_FTES_ENGAGED"] == DBNull.Value) ? "" : dr.Field<string>("NO_OF_FTES_ENGAGED") : "",
                    PIB_STATUS = (dr.Table.Columns.Contains("PIB_STATUS")) ? (dr["PIB_STATUS"] == DBNull.Value) ? "" : dr.Field<string>("PIB_STATUS") : "",
                    PIBS_OUTCOME_NAME = (dr.Table.Columns.Contains("PIBS_OUTCOME")) ? (dr["PIBS_OUTCOME"] == DBNull.Value) ? "" : dr.Field<string>("PIBS_OUTCOME") : "",
                    PIB_STATUS_REMARKS = (dr.Table.Columns.Contains("PIB_STATUS_REMARKS")) ? (dr["PIB_STATUS_REMARKS"] == DBNull.Value) ? "" : dr.Field<string>("PIB_STATUS_REMARKS") : "",
                    WEEKS = (dr.Table.Columns.Contains("WEEKS")) ? (dr["WEEKS"] == DBNull.Value) ? "" : dr.Field<string>("WEEKS") : "",
                    PIBS_QUALIFICATION = (dr.Table.Columns.Contains("PIBS_QUALIFICATION")) ? (dr["PIBS_QUALIFICATION"] == DBNull.Value) ? "" : dr.Field<string>("PIBS_QUALIFICATION") : "",
                    PIBS_PROPOSALDECK = (dr.Table.Columns.Contains("PIBS_PROPOSALDECK")) ? (dr["PIBS_PROPOSALDECK"] == DBNull.Value) ? "" : dr.Field<string>("PIBS_PROPOSALDECK") : "",
                    PIBS_DATAGATHERING = (dr.Table.Columns.Contains("PIBS_DATAGATHERING")) ? (dr["PIBS_DATAGATHERING"] == DBNull.Value) ? "" : dr.Field<string>("PIBS_DATAGATHERING") : "",
                    PIBS_PPTSHARED = (dr.Table.Columns.Contains("PIBS_PPTSHARED")) ? (dr["PIBS_PPTSHARED"] == DBNull.Value) ? "" : dr.Field<string>("PIBS_PPTSHARED") : "",
                    PIBS_CUSTFEEDBACK = (dr.Table.Columns.Contains("PIBS_CUSTFEEDBACK")) ? (dr["PIBS_CUSTFEEDBACK"] == DBNull.Value) ? "" : dr.Field<string>("PIBS_CUSTFEEDBACK") : "",
                    PIBS_STUDYLOCATION = (dr.Table.Columns.Contains("PIBS_STUDYLOCATION")) ? (dr["PIBS_STUDYLOCATION"] == DBNull.Value) ? "" : dr.Field<string>("PIBS_STUDYLOCATION") : "",
                    PIBS_ESTTCV = (dr.Table.Columns.Contains("PIBS_ESTTCV")) ? (dr["PIBS_ESTTCV"] == DBNull.Value) ? "" : dr.Field<string>("PIBS_ESTTCV") : "",
                    PIBS_EXEOWNEREMPID = (dr.Table.Columns.Contains("PIBS_EXEOWNEREMPID")) ? (dr["PIBS_EXEOWNEREMPID"] == DBNull.Value) ? "" : dr.Field<string>("PIBS_EXEOWNEREMPID") : "",
                    PIBS_EXEOWNEREMPNAME = (dr.Table.Columns.Contains("PIBS_EXEOWNEREMPNAME")) ? (dr["PIBS_EXEOWNEREMPNAME"] == DBNull.Value) ? "" : dr.Field<string>("PIBS_EXEOWNEREMPNAME") : "",
                    PIBS_FINALDATE = (dr.Table.Columns.Contains("PIBS_FINALDATE")) ? (dr["PIBS_FINALDATE"] == DBNull.Value) ? "" : dr.Field<string>("PIBS_FINALDATE") : "",
                    PIBS_TEAMEMPID = (dr.Table.Columns.Contains("PIBS_TEAMEMPID")) ? (dr["PIBS_TEAMEMPID"] == DBNull.Value) ? "" : dr.Field<string>("PIBS_TEAMEMPID") : "",
                    PIBS_TEAMEMPNAME = (dr.Table.Columns.Contains("PIBS_TEAMEMPNAME")) ? (dr["PIBS_TEAMEMPNAME"] == DBNull.Value) ? "" : dr.Field<string>("PIBS_TEAMEMPNAME") : "",
                    PIBS_ROLEINTEAM = (dr.Table.Columns.Contains("PIBS_ROLEINTEAM")) ? (dr["PIBS_ROLEINTEAM"] == DBNull.Value) ? "" : dr.Field<string>("PIBS_ROLEINTEAM") : "",
                    NoOf_TeamMemberPIBS = (dr.Table.Columns.Contains("PIBS_ROLEINTEAM")) ? (dr["NoOf_TeamMemberPIBS"] == DBNull.Value) ? "" : dr.Field<string>("NoOf_TeamMemberPIBS") : "",

                };
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
        }
        /// <summary>
        /// Save Stage1 Opportunity Details
        /// </summary>
        public List<CreateNewOpportunity> Save_Stage1Opportunity(CreateNewOpportunity ObjCreateNewOpportunity)
        {
            List<CreateNewOpportunity> strResult = new List<CreateNewOpportunity>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Ins_Opportunity_stage1_sp);
                db.AddInParameter(cd, "@in_OpportunityId", SqlDbType.VarChar, ObjCreateNewOpportunity.OpportunityId);
                db.AddInParameter(cd, "@iv_OpportunityDesc", SqlDbType.VarChar, ObjCreateNewOpportunity.OPPORTUNITY_DESC);
                db.AddInParameter(cd, "@iv_OldOpportunityDesc", SqlDbType.VarChar, ObjCreateNewOpportunity.OLD_OPPORTUNITY_DESC);
                db.AddInParameter(cd, "@in_GeographyId", SqlDbType.Int, ObjCreateNewOpportunity.GEOGRAPHY_ID);
                db.AddInParameter(cd, "@in_CustId", SqlDbType.Int, ObjCreateNewOpportunity.CUST_ID);
                db.AddInParameter(cd, "@in_CustTypeId", SqlDbType.Int, ObjCreateNewOpportunity.CUST_TYPE_ID);
                db.AddInParameter(cd, "@in_IndustryPracticeId", SqlDbType.Int, ObjCreateNewOpportunity.INDUSTRY_PRACTICE_ID);
                db.AddInParameter(cd, "@in_StageId", SqlDbType.Int, ObjCreateNewOpportunity.StageID);
                db.AddInParameter(cd, "@iv_GeographySalesOwner", SqlDbType.VarChar, ObjCreateNewOpportunity.GeosalesOwner);
                db.AddInParameter(cd, "@iv_OffshorePracticeOwner", SqlDbType.VarChar, ObjCreateNewOpportunity.OffPracOwner);
                db.AddInParameter(cd, "@iv_RdCrd", SqlDbType.VarChar, ObjCreateNewOpportunity.RDCrd);
                db.AddInParameter(cd, "@iv_OffshoreBDLead", SqlDbType.VarChar, ObjCreateNewOpportunity.OffShoreBDLead);
                db.AddInParameter(cd, "@iv_OnsiteOwner", SqlDbType.VarChar, ObjCreateNewOpportunity.OnsiteOwner);
                db.AddInParameter(cd, "@in_ProbabilityOfwin", SqlDbType.Int, ObjCreateNewOpportunity.PROBABILITY_OF_WIN);
                db.AddInParameter(cd, "@in_ContractLength", SqlDbType.Int, ObjCreateNewOpportunity.ContractLength);
                db.AddInParameter(cd, "@in_FTE", SqlDbType.Int, ObjCreateNewOpportunity.FTE);
                db.AddInParameter(cd, "@iv_Remark", SqlDbType.VarChar, ObjCreateNewOpportunity.REMARK);
                db.AddInParameter(cd, "@in_OppDate", SqlDbType.Int, ObjCreateNewOpportunity.OppDate);
                db.AddInParameter(cd, "@iv_EmpNo", SqlDbType.VarChar, ObjCreateNewOpportunity.EmpNo);
                db.AddInParameter(cd, "@in_ClosureDate", SqlDbType.Int, ObjCreateNewOpportunity.ClosureDate);
                db.AddInParameter(cd, "@in_AdvisoryId", SqlDbType.Int, ObjCreateNewOpportunity.ADVISORY_ID);
                db.AddInParameter(cd, "@iv_Platform", SqlDbType.VarChar, ObjCreateNewOpportunity.PLATFORM);
                db.AddInParameter(cd, "@in_PricingTypeId", SqlDbType.Int, ObjCreateNewOpportunity.PRICING_TYPE_ID);
                db.AddInParameter(cd, "@iv_NextStep", SqlDbType.VarChar, ObjCreateNewOpportunity.NextStep);
                db.AddInParameter(cd, "@in_BusinessId", SqlDbType.Int, ObjCreateNewOpportunity.BUSINESS_ID);
                db.AddInParameter(cd, "@in_ProductId", SqlDbType.Int, ObjCreateNewOpportunity.PRODUCT_ID);
                db.AddInParameter(cd, "@in_CompetencyId", SqlDbType.Int, ObjCreateNewOpportunity.COMPETENCY_ID);
                db.AddInParameter(cd, "@in_SubCompetencyId", SqlDbType.Int, ObjCreateNewOpportunity.SUB_COMPETENCY_ID);
                db.AddInParameter(cd, "@in_AnnualSaleValue", SqlDbType.Decimal, ObjCreateNewOpportunity.AnnualSaleValue);
                db.AddInParameter(cd, "@iv_AccountSalesOwner", SqlDbType.VarChar, ObjCreateNewOpportunity.AccountSalesOwner);
                db.AddInParameter(cd, "@iv_ExeSponser", SqlDbType.VarChar, ObjCreateNewOpportunity.ExeSponser);
                db.AddInParameter(cd, "@iv_ProactiveProposal", SqlDbType.VarChar, ObjCreateNewOpportunity.ProactiveProposal);
                db.AddInParameter(cd, "@iv_ValBPSCon", SqlDbType.VarChar, ObjCreateNewOpportunity.ValBPSCon);
                db.AddInParameter(cd, "@iv_IsuMain", SqlDbType.VarChar, ObjCreateNewOpportunity.IsuMain);
                db.AddInParameter(cd, "@iv_PlatformNew", SqlDbType.VarChar, ObjCreateNewOpportunity.PlatformNew);
                db.AddInParameter(cd, "@iv_StatusUpdate", SqlDbType.VarChar, ObjCreateNewOpportunity.StatusUpdate);
                db.AddInParameter(cd, "@in_CategoryId", SqlDbType.Int, ObjCreateNewOpportunity.Category_Id);
                db.AddInParameter(cd, "@in_CountryId", SqlDbType.Int, ObjCreateNewOpportunity.CountryId);
                db.AddInParameter(cd, "@in_NextStepDueDt", SqlDbType.Int, ObjCreateNewOpportunity.NextStepDueDt);
                db.AddInParameter(cd, "@in_UnitID", SqlDbType.Int, ObjCreateNewOpportunity.UnitId);
                db.AddInParameter(cd, "@iv_ISUOwner", SqlDbType.VarChar, ObjCreateNewOpportunity.ISU_OWNER_ID);
                db.AddInParameter(cd, "@iv_ISU", SqlDbType.VarChar, ObjCreateNewOpportunity.ISU_CD);
                db.AddInParameter(cd, "@iv_PIBS", SqlDbType.VarChar, ObjCreateNewOpportunity.PIBS);
                db.AddInParameter(cd, "@iv_TCS_INVESTMENT", SqlDbType.VarChar, ObjCreateNewOpportunity.TCSInvestment);
                db.AddInParameter(cd, "@in_PIBStartDate", SqlDbType.Int, ObjCreateNewOpportunity.PIBStartDate);
                db.AddInParameter(cd, "@in_PIBEndDate", SqlDbType.Int, ObjCreateNewOpportunity.PIBSEndDate);
                db.AddInParameter(cd, "@in_NoOfFTEsEngaged", SqlDbType.Int, ObjCreateNewOpportunity.FTEsEngaged);
                db.AddInParameter(cd, "@in_PIBStatus", SqlDbType.Int, ObjCreateNewOpportunity.PIBStatus);
                db.AddInParameter(cd, "@in_PIBSOutcome", SqlDbType.Int, ObjCreateNewOpportunity.PIBS_OUTCOME_ID);
                db.AddInParameter(cd, "@iv_PIBStatusRemarks", SqlDbType.VarChar, ObjCreateNewOpportunity.PIBStatusRemarks);
                db.AddInParameter(cd, "@iv_FTEType", SqlDbType.VarChar, ObjCreateNewOpportunity.FTE_TYPE);
                db.AddInParameter(cd, "@in_FTETypeCount", SqlDbType.Int, ObjCreateNewOpportunity.FTE_TYPE_COUNT);
                db.AddInParameter(cd, "@in_BPODomain", SqlDbType.Int, ObjCreateNewOpportunity.BPODomain);
                db.AddInParameter(cd, "@iv_DomainPresalesLead", SqlDbType.VarChar, ObjCreateNewOpportunity.DOMAIN_PRESALES_LEAD);
                db.AddInParameter(cd, "@in_DealCategory", SqlDbType.Int, ObjCreateNewOpportunity.DealCategory);
                db.AddInParameter(cd, "@in_BPSSubSPID", SqlDbType.Int, ObjCreateNewOpportunity.BPSSubSPID);
                db.AddInParameter(cd, "@in_BPSOfferingID", SqlDbType.Int, ObjCreateNewOpportunity.BPSOfferingID);
                db.AddInParameter(cd, "@iv_DealCoachName", SqlDbType.VarChar, ObjCreateNewOpportunity.DealCoachName);
                db.AddInParameter(cd, "@in_DemandType", SqlDbType.Int, ObjCreateNewOpportunity.DemandType);
                db.AddInParameter(cd, "@iv_KeyDeal", SqlDbType.VarChar, ObjCreateNewOpportunity.KEY_DEAL);
                db.AddInParameter(cd, "@iv_ProposedSolution", SqlDbType.VarChar, ObjCreateNewOpportunity.ProposedSolution);
                db.AddInParameter(cd, "@iv_KeyRmk", SqlDbType.VarChar, ObjCreateNewOpportunity.KeyRmk);
                db.AddInParameter(cd, "@iv_WinningTeam", SqlDbType.VarChar, ObjCreateNewOpportunity.WinningTheme);
                db.AddInParameter(cd, "@iv_KeyCustExp", SqlDbType.VarChar, ObjCreateNewOpportunity.KeyCustExp);
                db.AddInParameter(cd, "@iv_OperatingModel", SqlDbType.VarChar, ObjCreateNewOpportunity.operatingModel);
                db.AddInParameter(cd, "@iv_PricingModel", SqlDbType.VarChar, ObjCreateNewOpportunity.PRICING_MODEL);
                db.AddInParameter(cd, "@iv_Differentiators", SqlDbType.VarChar, ObjCreateNewOpportunity.Differentiators);
                db.AddInParameter(cd, "@iv_Risks", SqlDbType.VarChar, ObjCreateNewOpportunity.Risks);
                db.AddInParameter(cd, "@iv_KeyCustomerConnects", SqlDbType.VarChar, ObjCreateNewOpportunity.KeyCustomerConnects);
                db.AddInParameter(cd, "@iv_BPOOfferingDescription", SqlDbType.VarChar, ObjCreateNewOpportunity.BPOOfferingDescription);
                db.AddInParameter(cd, "@iv_FirstTimeOutsource", SqlDbType.VarChar, ObjCreateNewOpportunity.FIRST_TIME_OUTSOURCE);
                db.AddInParameter(cd, "@iv_Incumbents", SqlDbType.VarChar, ObjCreateNewOpportunity.INCUMBENTS);
                db.AddInParameter(cd, "@iv_NameOfIncumbents", SqlDbType.VarChar, ObjCreateNewOpportunity.NAME_OF_INCUMBENTS);
                db.AddInParameter(cd, "@iv_TCSOfferingCapability", SqlDbType.VarChar, ObjCreateNewOpportunity.TCS_OFFERING_CAPABILITY);
                db.AddInParameter(cd, "@iv_SpecifyOffering", SqlDbType.VarChar, ObjCreateNewOpportunity.SpecifyOffering);
                db.AddInParameter(cd, "@iv_CoachAvailable", SqlDbType.VarChar, ObjCreateNewOpportunity.CoachAvailable);
                db.AddInParameter(cd, "@iv_FnA", SqlDbType.VarChar, ObjCreateNewOpportunity.FnA);
                db.AddInParameter(cd, "@in_Fna_FTE", SqlDbType.Int, ObjCreateNewOpportunity.FnA_FTE);
                db.AddInParameter(cd, "@iv_HRO", SqlDbType.VarChar, ObjCreateNewOpportunity.HRO);
                db.AddInParameter(cd, "@in_HRO_FTE", SqlDbType.Int, ObjCreateNewOpportunity.HRO_FTE);
                db.AddInParameter(cd, "@iv_SCM", SqlDbType.VarChar, ObjCreateNewOpportunity.SCM);
                db.AddInParameter(cd, "@in_SCM_FTE", SqlDbType.Int, ObjCreateNewOpportunity.SCM_FTE);
                db.AddInParameter(cd, "@iv_KPO", SqlDbType.VarChar, ObjCreateNewOpportunity.KPO);
                db.AddInParameter(cd, "@in_KPO_FTE", SqlDbType.Int, ObjCreateNewOpportunity.KPO_FTE);
                db.AddInParameter(cd, "@iv_LPO", SqlDbType.VarChar, ObjCreateNewOpportunity.LPO);
                db.AddInParameter(cd, "@in_LPO_FTE", SqlDbType.Int, ObjCreateNewOpportunity.LPO_FTE);
                db.AddInParameter(cd, "@iv_Vertical", SqlDbType.VarChar, ObjCreateNewOpportunity.VERTICAL);
                db.AddInParameter(cd, "@in_Vertical_FTE", SqlDbType.Int, ObjCreateNewOpportunity.VerticalFTE);
                db.AddInParameter(cd, "@iv_Voice", SqlDbType.VarChar, ObjCreateNewOpportunity.Voice);
                db.AddInParameter(cd, "@in_Voice_FTE", SqlDbType.Int, ObjCreateNewOpportunity.VoiceFTE);
                db.AddInParameter(cd, "@iv_Bpm", SqlDbType.VarChar, ObjCreateNewOpportunity.BPM);
                db.AddInParameter(cd, "@in_Bpm_FTE", SqlDbType.Int, ObjCreateNewOpportunity.BPM_FTE);
                db.AddInParameter(cd, "@in_SolTM", SqlDbType.Int, ObjCreateNewOpportunity.SolTM);
                db.AddInParameter(cd, "@in_DelTM", SqlDbType.Int, ObjCreateNewOpportunity.DelTM);
                db.AddInParameter(cd, "@iv_BidManager", SqlDbType.VarChar, ObjCreateNewOpportunity.BID_MANAGER);
                db.AddInParameter(cd, "@iv_BidExec", SqlDbType.VarChar, ObjCreateNewOpportunity.BID_EXEC_OWNER);
                db.AddInParameter(cd, "@iv_PricingOwner", SqlDbType.VarChar, ObjCreateNewOpportunity.PRICING_OWNER);
                db.AddInParameter(cd, "@in_TransitionTeam", SqlDbType.Int, ObjCreateNewOpportunity.TransitionTeam);
                db.AddInParameter(cd, "@iv_ExpectedDate", SqlDbType.Int, ObjCreateNewOpportunity.ExpectedDate);
                db.AddInParameter(cd, "@iv_TransitionReq", SqlDbType.VarChar, ObjCreateNewOpportunity.TransitionReq);
                db.AddInParameter(cd, "@iv_Quarter", SqlDbType.VarChar, ObjCreateNewOpportunity.Quarter);
                db.AddInParameter(cd, "@iv_FiscalYear", SqlDbType.VarChar, ObjCreateNewOpportunity.FiscalYear);
                db.AddInParameter(cd, "@in_RFIRwDt", SqlDbType.Int, ObjCreateNewOpportunity.RFI_REVIEW_DT);
                db.AddInParameter(cd, "@in_RFPRwDt", SqlDbType.Int, ObjCreateNewOpportunity.RFP_REVIEW_DT);
                db.AddInParameter(cd, "@iv_RFIBy", SqlDbType.VarChar, ObjCreateNewOpportunity.RFI_REVIEW_BY);
                db.AddInParameter(cd, "@iv_RFPBy", SqlDbType.VarChar, ObjCreateNewOpportunity.RFP_REVIEW_BY);
                db.AddInParameter(cd, "@iv_NGM", SqlDbType.VarChar, ObjCreateNewOpportunity.OPP_NGM);
                db.AddInParameter(cd, "@iv_CRMReason", SqlDbType.VarChar, ObjCreateNewOpportunity.CRM_REASON);
                db.AddInParameter(cd, "@iv_BidExeEmpId", SqlDbType.VarChar, ObjCreateNewOpportunity.BID_EXECUTIVE_EMPID);
                db.AddInParameter(cd, "@iv_Disqual", SqlDbType.VarChar, ObjCreateNewOpportunity.Disqual);
                db.AddInParameter(cd, "@iv_AddDeal", SqlDbType.VarChar, ObjCreateNewOpportunity.AddDeal);
                db.AddInParameter(cd, "@iv_BidExeName", SqlDbType.VarChar, ObjCreateNewOpportunity.BID_EXECUTIVE_NAME);
                db.AddInParameter(cd, "@iv_DealOwner", SqlDbType.VarChar, ObjCreateNewOpportunity.DealOwner);
                db.AddInParameter(cd, "@iv_DealOwner2", SqlDbType.VarChar, ObjCreateNewOpportunity.DealOwner2);
                db.AddInParameter(cd, "@iv_ImmediateComment", SqlDbType.VarChar, ObjCreateNewOpportunity.ImmediateComment);
                db.AddInParameter(cd, "@iv_FTEDD", SqlDbType.VarChar, ObjCreateNewOpportunity.FTEDD);
                db.AddInParameter(cd, "@iv_SolutionLeader", SqlDbType.VarChar, ObjCreateNewOpportunity.SolutionLeader);
                db.AddInParameter(cd, "@iv_RUR", SqlDbType.VarChar, ObjCreateNewOpportunity.RUR);
                db.AddInParameter(cd, "@iv_HRT_Comments", SqlDbType.VarChar, ObjCreateNewOpportunity.HRTComments);
                db.AddInParameter(cd, "@in_Seat_Requirements", SqlDbType.Int, ObjCreateNewOpportunity.SeatRequirements);
                db.AddInParameter(cd, "@iv_CRMId", SqlDbType.VarChar, ObjCreateNewOpportunity.CRM_ID);
                db.AddInParameter(cd, "@in_TCV", SqlDbType.VarChar, ObjCreateNewOpportunity.TCV);
                db.AddInParameter(cd, "@iv_ValueBPS", SqlDbType.VarChar, ObjCreateNewOpportunity.ValueBPS);
                db.AddInParameter(cd, "@in_ValueBPSTCV", SqlDbType.Decimal, ObjCreateNewOpportunity.ValueBPSTCV);
                db.AddInParameter(cd, "@iv_OppType", SqlDbType.VarChar, ObjCreateNewOpportunity.OPP_TYPE);
                db.AddInParameter(cd, "@iv_MultiTower", SqlDbType.VarChar, ObjCreateNewOpportunity.MultiTower);
                db.AddInParameter(cd, "@in_StatusFlag", SqlDbType.Int, ObjCreateNewOpportunity.StatusFlag);
                db.AddInParameter(cd, "@iv_Fna_Lead", SqlDbType.VarChar, ObjCreateNewOpportunity.FnA_Lead);
                db.AddInParameter(cd, "@iv_HRO_Lead", SqlDbType.VarChar, ObjCreateNewOpportunity.HRO_Lead);
                db.AddInParameter(cd, "@iv_SCM_Lead", SqlDbType.VarChar, ObjCreateNewOpportunity.SCM_Lead);
                db.AddInParameter(cd, "@iv_KPO_Lead", SqlDbType.VarChar, ObjCreateNewOpportunity.KPO_Lead);
                db.AddInParameter(cd, "@iv_LPO_Lead", SqlDbType.VarChar, ObjCreateNewOpportunity.LPO_Lead);
                db.AddInParameter(cd, "@iv_Vertical_Lead", SqlDbType.VarChar, ObjCreateNewOpportunity.VERTICAL_LEAD);
                db.AddInParameter(cd, "@iv_Voice_Lead", SqlDbType.VarChar, ObjCreateNewOpportunity.Voice_Lead);
                db.AddInParameter(cd, "@iv_Bpm_Lead", SqlDbType.VarChar, ObjCreateNewOpportunity.BPM_LEAD);
                db.AddInParameter(cd, "@iv_BidManagerId", SqlDbType.VarChar, ObjCreateNewOpportunity.BID_MANAGER_EMPID);
                db.AddInParameter(cd, "@iv_BidExecId", SqlDbType.VarChar, ObjCreateNewOpportunity.BID_EXEC_OWNER_EMPID);
                db.AddInParameter(cd, "@iv_PricingOwnerId", SqlDbType.VarChar, ObjCreateNewOpportunity.PRICING_OWNER_EMPID);
                db.AddInParameter(cd, "@iv_SolutionLeaderId", SqlDbType.VarChar, ObjCreateNewOpportunity.SolutionLeaderId);
                db.AddInParameter(cd, "@iv_FnaTCV", SqlDbType.VarChar, ObjCreateNewOpportunity.FnATCV);
                db.AddInParameter(cd, "@iv_HROTCV", SqlDbType.VarChar, ObjCreateNewOpportunity.HROTCV);
                db.AddInParameter(cd, "@iv_SCMTCV", SqlDbType.VarChar, ObjCreateNewOpportunity.SCMTCV);
                db.AddInParameter(cd, "@iv_KPOTCV", SqlDbType.VarChar, ObjCreateNewOpportunity.KPOTCV);
                db.AddInParameter(cd, "@iv_LPOTCV", SqlDbType.VarChar, ObjCreateNewOpportunity.LPOTCV);
                db.AddInParameter(cd, "@iv_VerticalTCV", SqlDbType.VarChar, ObjCreateNewOpportunity.VERTICALTCV);
                db.AddInParameter(cd, "@iv_VoiceTCV", SqlDbType.VarChar, ObjCreateNewOpportunity.VOICETCV);
                db.AddInParameter(cd, "@iv_BpmTCV", SqlDbType.VarChar, ObjCreateNewOpportunity.BPMTCV);
                db.AddInParameter(cd, "@in_PIBSTCV", SqlDbType.VarChar, ObjCreateNewOpportunity.PibsSaleValue);
                db.AddInParameter(cd, "@in_ClusterId", SqlDbType.Int, ObjCreateNewOpportunity.ClusterId);
                db.AddInParameter(cd, "@in_ServiceId", SqlDbType.Int, ObjCreateNewOpportunity.ServiceId);
                db.AddInParameter(cd, "@in_SUBIOU", SqlDbType.VarChar, ObjCreateNewOpportunity.SUBIOU);
                db.AddInParameter(cd, "@in_strTransitionEmpId", SqlDbType.VarChar, ObjCreateNewOpportunity.TransitionEmpId);
                db.AddInParameter(cd, "@in_strTransitionName", SqlDbType.VarChar, ObjCreateNewOpportunity.TransitionName);
                db.AddInParameter(cd, "@in_strTransitionType", SqlDbType.VarChar, ObjCreateNewOpportunity.TransitionType);
                db.AddInParameter(cd, "@in_strTransitionApproach", SqlDbType.VarChar, ObjCreateNewOpportunity.TransitionApproach);
                db.AddInParameter(cd, "@in_strTransitionModel", SqlDbType.VarChar, ObjCreateNewOpportunity.TransitionModel);
                db.AddInParameter(cd, "@in_strProposalfactory", SqlDbType.VarChar, ObjCreateNewOpportunity.Proposalfactory);
                db.AddInParameter(cd, "@in_strProposalfactoryOptions", SqlDbType.VarChar, ObjCreateNewOpportunity.ProposalfactoryOptions);
                db.AddInParameter(cd, "@in_strProposalComments", SqlDbType.VarChar, ObjCreateNewOpportunity.ProposalComments);
                db.AddInParameter(cd, "@iv_DTValue", SqlDbType.VarChar, ObjCreateNewOpportunity.DTValue);
                db.AddInParameter(cd, "@iv_OtherDT", SqlDbType.VarChar, ObjCreateNewOpportunity.Other_DT);
                db.AddInParameter(cd, "@in_CRMStage", SqlDbType.Int, ObjCreateNewOpportunity.CRM_STAGE);
                db.AddInParameter(cd, "@in_CRMTCV", SqlDbType.VarChar, ObjCreateNewOpportunity.CRM_TCV);
                db.AddInParameter(cd, "@in_TGA", SqlDbType.VarChar, ObjCreateNewOpportunity.TataGroupAccount);
                db.AddInParameter(cd, "@in_TPA", SqlDbType.VarChar, ObjCreateNewOpportunity.TPA);
                db.AddInParameter(cd, "@in_TPA_Name", SqlDbType.VarChar, ObjCreateNewOpportunity.TPA_Name);
                db.AddInParameter(cd, "@in_ItisScope", SqlDbType.VarChar, ObjCreateNewOpportunity.ItisScope);
                db.AddInParameter(cd, "@in_IsContractRenewal", SqlDbType.VarChar, ObjCreateNewOpportunity.IsContractRenewal);
                db.AddInParameter(cd, "@in_ContractRenewalValue", SqlDbType.VarChar, ObjCreateNewOpportunity.ContractRenewalValue);
                db.AddInParameter(cd, "@in_SubSP", SqlDbType.Int, ObjCreateNewOpportunity.subSPId);
                db.AddInParameter(cd, "@in_CRMBeacon", SqlDbType.VarChar, ObjCreateNewOpportunity.CRM_Beacon);
                db.AddOutParameter(cd, "@on_Result", SqlDbType.Int, Int16.MaxValue);
                db.AddInParameter(cd, "@iv_DigitalTCV", SqlDbType.VarChar, ObjCreateNewOpportunity.strDigitalTcv);
                //changess
                db.AddInParameter(cd, "@in_ResourcingId", SqlDbType.Int, ObjCreateNewOpportunity.RESOURCING_ID);
                db.AddInParameter(cd, "@in_Seat_IdentificationId", SqlDbType.Int, ObjCreateNewOpportunity.SEAT_IDENTIFICATION_ID);
                db.AddInParameter(cd, "@DealStatus_Id", SqlDbType.Int, ObjCreateNewOpportunity.DealStatus);
                db.AddInParameter(cd, "@in_Opportunity_Desc_Details", SqlDbType.VarChar, ObjCreateNewOpportunity.OpportunityDescDetails);
                //End

                db.ExecuteNonQuery(cd);
                on_Result = db.GetParameterValue(cd, "@on_Result").ToString();
                strResult.Add(new CreateNewOpportunity()
                {
                    on_Result = db.GetParameterValue(cd, "@on_Result").ToString()
                });
            }



            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
            return strResult;

        }








        public void Save_ExpClsDt(string opportunityId)
        {
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Upd_ExpClsDt_sp);
                db.AddInParameter(cd, "@in_OpportunityId", SqlDbType.VarChar, opportunityId);
                db.ExecuteNonQuery(cd);
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
        }
        public int CompareDates(string fromDt, string toDt)
        {
            try
            {
                DateTime dtFromDt = Convert.ToDateTime(fromDt);
                DateTime dtToDt = Convert.ToDateTime(toDt);
                int intCompare = dtToDt.CompareTo(dtFromDt);
                return intCompare;
            }

            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
        }
        /// <summary>
        /// Get OpportunityChkCRM Details
        /// </summary>
        public List<OppStage> GetOpportunityChkCRM(string opportunityID)
        {
            DataSet ds = null;
            List<OppStage> modelList = new List<OppStage>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Get_OpportunityChkCRM);
                db.AddInParameter(cd, "@iv_OpportunityID", SqlDbType.VarChar, opportunityID);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;

                        for (int i = 0; i < rowCount; i++)
                        {
                            if (Convert.ToString(ds.Tables[0].Rows[i][0]) != "NULL" && Convert.ToString(ds.Tables[0].Rows[i][1]) != "NULL")
                            {
                            modelList.Add(MapGet_OpportunityChkCRM(ds.Tables[0].Rows[i]));
                        }

                    }

                }
            }
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }
            return modelList;
        }
        private static OppStage MapGet_OpportunityChkCRM(DataRow dr)
        {
            try
            {
                    return new OppStage()
                    {

                        OpportunityId = (dr.Table.Columns.Contains("OPPORTUNITY_ID")) ? (dr["OPPORTUNITY_ID"] == DBNull.Value) ? "" : Convert.ToString(dr["OPPORTUNITY_ID"]) : "",
                        StageID = (dr.Table.Columns.Contains("STAGE_ID")) ? (dr["STAGE_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["STAGE_ID"]) : 0,

                    };
                }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
        }
        /// <summary>
        /// Save Opportunity Stage Change count Details
        /// </summary>
        public void Opportunity_StageChangeCount_sp(CreateNewOpportunity obj)
        {
            try
            {

                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Opportunity_StageChangeCount_sp);
                db.AddInParameter(cd, "@in_CurrentStageId", SqlDbType.Int, obj.CurrentStageID);
                db.AddInParameter(cd, "@in_NextStageId", SqlDbType.Int, obj.NextStageID);
                db.AddInParameter(cd, "@in_IndustryPracticeId", SqlDbType.Int, obj.INDUSTRY_PRACTICE_ID);
                db.ExecuteNonQuery(cd);


            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
        }
        /// <summary>
        /// Get Opportunity Details
        /// </summary>
        public List<CreateNewOpportunity> GetOpportunityDetails_Tref(string stageId, string stake, string custType,
            string oppId, string tRefId, int unitID, string empID, int fromDt, int toDt, string opSuppCRF)
        {
            DataSet ds = null;
            List<CreateNewOpportunity> modelList = new List<CreateNewOpportunity>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.GetOpportunityDetails_Tref_sp);
                db.AddInParameter(cd, "@in_StageId", SqlDbType.VarChar, stageId);
                db.AddInParameter(cd, "@iv_Stake", SqlDbType.VarChar, stake);
                db.AddInParameter(cd, "@iv_CustTypeId", SqlDbType.VarChar, CUST_TYPE_ID);
                db.AddInParameter(cd, "@iv_OppId", SqlDbType.VarChar, oppId);
                db.AddInParameter(cd, "@iv_TRefCode", SqlDbType.VarChar, tRefId);
                db.AddInParameter(cd, "@in_UnitId", SqlDbType.Int, unitID);
                db.AddInParameter(cd, "@iv_EmpID", SqlDbType.VarChar, empID);
                db.AddInParameter(cd, "@in_FromDt", SqlDbType.Int, fromDt);
                db.AddInParameter(cd, "@in_ToDt", SqlDbType.Int, toDt);
                db.AddInParameter(cd, "@iv_CRFType", SqlDbType.VarChar, opSuppCRF);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;

                        for (int i = 0; i < rowCount; i++)
                        {
                            modelList.Add(MapPopulate_Get_OpportunityDetails_Tref(ds.Tables[0].Rows[i]));
                        }
                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }
            return modelList;
        }
        private static CreateNewOpportunity MapPopulate_Get_OpportunityDetails_Tref(DataRow dr)
        {
            try
            {
                return new CreateNewOpportunity()
                {

                    CRF_ID = (dr.Table.Columns.Contains("CRF_ID")) ? (dr["CRF_ID"] == DBNull.Value) ? "" : dr.Field<string>("CRF_ID") : "",
                    T_REF_CODE = (dr.Table.Columns.Contains("T_REF_CODE")) ? (dr["T_REF_CODE"] == DBNull.Value) ? "" : dr.Field<string>("T_REF_CODE") : "",
                    OpportunityId = (dr.Table.Columns.Contains("OPPORTUNITY_ID")) ? (dr["OPPORTUNITY_ID"] == DBNull.Value) ? "" : Convert.ToString(dr["OPPORTUNITY_ID"]) : "",
                    StageID = (dr.Table.Columns.Contains("STAGE_ID")) ? (dr["STAGE_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["STAGE_ID"]) : 0,
                    STAGE_NAME = (dr.Table.Columns.Contains("STAGE_NAME")) ? (dr["STAGE_NAME"] == DBNull.Value) ? "" : dr.Field<string>("STAGE_NAME") : "",
                    OPPORTUNITY_DESC = (dr.Table.Columns.Contains("OPPORTUNITY_DESC")) ? (dr["OPPORTUNITY_DESC"] == DBNull.Value) ? "" : dr.Field<string>("OPPORTUNITY_DESC") : "",
                    GEOGRAPHY_CODE = (dr.Table.Columns.Contains("GEOGRAPHY_CODE")) ? (dr["GEOGRAPHY_CODE"] == DBNull.Value) ? "" : dr.Field<string>("GEOGRAPHY_CODE") : "",
                    GEOGRAPHY_NAME = (dr.Table.Columns.Contains("GEOGRAPHY_NAME")) ? (dr["GEOGRAPHY_NAME"] == DBNull.Value) ? "" : dr.Field<string>("GEOGRAPHY_NAME") : "",
                    CUST_NAME = (dr.Table.Columns.Contains("CUST_NAME")) ? (dr["CUST_NAME"] == DBNull.Value) ? "" : dr.Field<string>("CUST_NAME") : "",
                    CUST_TYPE_NAME = (dr.Table.Columns.Contains("CUST_TYPE_NAME")) ? (dr["CUST_TYPE_NAME"] == DBNull.Value) ? "" : dr.Field<string>("CUST_TYPE_NAME") : "",
                    CUST_ID = (dr.Table.Columns.Contains("CUST_ID")) ? (dr["CUST_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CUST_ID"]) : 0,
                    ESTIMATED_FTE_SIZE = (dr.Table.Columns.Contains("ESTIMATED_FTE_SIZE")) ? (dr["ESTIMATED_FTE_SIZE"] == DBNull.Value) ? 0 : dr.Field<Decimal>("ESTIMATED_FTE_SIZE") : 0,
                    CUST_TYPE_CODE = (dr.Table.Columns.Contains("CUST_TYPE_CODE")) ? (dr["CUST_TYPE_CODE"] == DBNull.Value) ? "" : dr.Field<string>("CUST_TYPE_CODE") : "",
                    INDUSTRY_PRACTICE_NAME = (dr.Table.Columns.Contains("INDUSTRY_PRACTICE_NAME")) ? (dr["INDUSTRY_PRACTICE_NAME"] == DBNull.Value) ? "" : dr.Field<string>("INDUSTRY_PRACTICE_NAME") : "",
                    INDUSTRY_PRACTICE_CODE = (dr.Table.Columns.Contains("INDUSTRY_PRACTICE_CODE")) ? (dr["INDUSTRY_PRACTICE_CODE"] == DBNull.Value) ? "" : dr.Field<string>("INDUSTRY_PRACTICE_CODE") : "",
                    Associate_Details = (dr.Table.Columns.Contains("Associate_Details")) ? (dr["Associate_Details"] == DBNull.Value) ? "" : dr.Field<string>("Associate_Details") : "",
                    OPPORTUNITY_DATE = (dr.Table.Columns.Contains("OPPORTUNITY_DATE")) ? (dr["OPPORTUNITY_DATE"] == DBNull.Value) ? "" : dr.Field<string>("OPPORTUNITY_DATE") : "",
                    DEFAULTERS = (dr.Table.Columns.Contains("DEFAULTERS")) ? (dr["DEFAULTERS"] == DBNull.Value) ? "" : dr.Field<string>("DEFAULTERS") : "",
                    CREATED_BY = (dr.Table.Columns.Contains("CREATED_BY")) ? (dr["CREATED_BY"] == DBNull.Value) ? "" : dr.Field<string>("CREATED_BY") : "",
                    TOTAL_CONTRACT_VALUE = (dr.Table.Columns.Contains("TOTAL_CONTRACT_VALUE")) ? (dr["TOTAL_CONTRACT_VALUE"] == DBNull.Value) ? 0 : Convert.ToDouble(dr["TOTAL_CONTRACT_VALUE"]) : 0,
                    CLOSURE_DATE = (dr.Table.Columns.Contains("CLOSURE_DATE")) ? (dr["CLOSURE_DATE"] == DBNull.Value) ? "" : dr.Field<string>("CLOSURE_DATE") : "",
                    DEAL_TERM = (dr.Table.Columns.Contains("DEAL_TERM")) ? (dr["DEAL_TERM"] == DBNull.Value) ? "" : dr.Field<string>("DEAL_TERM") : "",
                    CRF_CODE = (dr.Table.Columns.Contains("CRF_CODE")) ? (dr["CRF_CODE"] == DBNull.Value) ? "" : dr.Field<string>("CRF_CODE") : "",
                    T_REF_ID = (dr.Table.Columns.Contains("T_REF_ID")) ? (dr["T_REF_ID"] == DBNull.Value) ? "" : dr.Field<string>("T_REF_ID") : "",
                    MATC_STATUS = (dr.Table.Columns.Contains("MATC_STATUS")) ? (dr["MATC_STATUS"] == DBNull.Value) ? "" : dr.Field<string>("MATC_STATUS") : "",
                    REMARK = (dr.Table.Columns.Contains("REMARK")) ? (dr["REMARK"] == DBNull.Value) ? "" : dr.Field<string>("REMARK") : "",
                    FTE_JOIN = (dr.Table.Columns.Contains("FTE_JOIN")) ? (dr["FTE_JOIN"] == DBNull.Value) ? "" : dr.Field<string>("FTE_JOIN") : "",
                    READ_STATUS = (dr.Table.Columns.Contains("READ_STATUS")) ? (dr["READ_STATUS"] == DBNull.Value) ? "" : dr.Field<string>("READ_STATUS") : "",
                    CRF_CLOSED = (dr.Table.Columns.Contains("CRF_CLOSED")) ? (dr["CRF_CLOSED"] == DBNull.Value) ? "" : dr.Field<string>("CRF_CLOSED") : "",
                    REC_FTE = (dr.Table.Columns.Contains("REC_FTE")) ? (dr["REC_FTE"] == DBNull.Value) ? "" : dr.Field<string>("REC_FTE") : "",
                    BUFFERFTE = (dr.Table.Columns.Contains("BUFFERFTE")) ? (dr["BUFFERFTE"] == DBNull.Value) ? "" : dr.Field<string>("BUFFERFTE") : "",
                    HOLD_DATE = (dr.Table.Columns.Contains("HOLD_DATE")) ? (dr["HOLD_DATE"] == DBNull.Value) ? "" : dr.Field<string>("HOLD_DATE") : "",
                    REOPEN_DT = (dr.Table.Columns.Contains("REOPEN_DT")) ? (dr["REOPEN_DT"] == DBNull.Value) ? "" : dr.Field<string>("REOPEN_DT") : "",
                    DELIVERY_CENTER_NAME = (dr.Table.Columns.Contains("DELIVERY_CENTER_NAME")) ? (dr["DELIVERY_CENTER_NAME"] == DBNull.Value) ? "" : dr.Field<string>("DELIVERY_CENTER_NAME") : "",
                    DL_APPROVED_BY = (dr.Table.Columns.Contains("DL_APPROVED_BY")) ? (dr["DL_APPROVED_BY"] == DBNull.Value) ? "" : dr.Field<string>("DL_APPROVED_BY") : "",
                    DL_APPROVED_DT = (dr.Table.Columns.Contains("DL_APPROVED_DT")) ? (dr["DL_APPROVED_DT"] == DBNull.Value) ? "" : dr.Field<string>("DL_APPROVED_DT") : "",
                    MATC_APPROVED_BY = (dr.Table.Columns.Contains("MATC_APPROVED_BY")) ? (dr["MATC_APPROVED_BY"] == DBNull.Value) ? "" : dr.Field<string>("MATC_APPROVED_BY") : "",
                    MATC_APPROVED_DT = (dr.Table.Columns.Contains("MATC_APPROVED_DT")) ? (dr["MATC_APPROVED_DT"] == DBNull.Value) ? "" : dr.Field<string>("MATC_APPROVED_DT") : "",
                    CRF_TYPE = (dr.Table.Columns.Contains("CRF_TYPE")) ? (dr["CRF_TYPE"] == DBNull.Value) ? "" : dr.Field<string>("CRF_TYPE") : "",
                    OSM_STATUS = (dr.Table.Columns.Contains("OSM_STATUS")) ? (dr["OSM_STATUS"] == DBNull.Value) ? "" : dr.Field<string>("OSM_STATUS") : "",

                };
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
        }
        /// <summary>
        /// Get Opportunity Details
        /// </summary>
        public List<OppDetails> Get_OpportunityDetails(string opportunityID)
        {
            DataSet ds = null;
            List<OppDetails> modelList = new List<OppDetails>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Get_Opportunity_sp);
                db.AddInParameter(cd, "@iv_OpportunityID", SqlDbType.VarChar, opportunityID);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;

                        for (int i = 0; i < rowCount; i++)
                        {
                            modelList.Add(MapGet_OpportunityDetails(ds.Tables[0].Rows[i]));
                        }

                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }
            return modelList;
        }
        private static OppDetails MapGet_OpportunityDetails(DataRow dr)
        {
            try
            {
                return new OppDetails()
                {


                    GEOGRAPHY_ID = (dr.Table.Columns.Contains("GEOGRAPHY_ID")) ? (dr["GEOGRAPHY_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["GEOGRAPHY_ID"]) : 0,
                    CUST_ID = (dr.Table.Columns.Contains("CUST_ID")) ? (dr["CUST_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CUST_ID"]) : 0,
                    INDUSTRY_PRACTICE_ID = (dr.Table.Columns.Contains("INDUSTRY_PRACTICE_ID")) ? (dr["INDUSTRY_PRACTICE_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["INDUSTRY_PRACTICE_ID"]) : 0,
                    StageID = (dr.Table.Columns.Contains("STAGE_ID")) ? (dr["STAGE_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["STAGE_ID"]) : 0,
                    ISU_CD = (dr.Table.Columns.Contains("ISU_CD")) ? (dr["ISU_CD"] == DBNull.Value) ? "" : dr.Field<string>("ISU_CD") : "",
                };
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
        }
        /// <summary>
        /// Get Opportunity Details 
        /// </summary>
        public List<CreateNewOpportunity> GetOpportunityDetails_Tref_BFS(string stageId, string stake, string custType, string oppId,
            string tRefId, int unitID, string empID, int fromDt, int toDt, string opSuppCRF)
        {
            DataSet ds = null;
            List<CreateNewOpportunity> modelList = new List<CreateNewOpportunity>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.GetOpportunityDetails_Tref_sp_BFS);
                db.AddInParameter(cd, "@in_StageId", SqlDbType.VarChar, stageId);
                db.AddInParameter(cd, "@iv_Stake", SqlDbType.VarChar, stake);
                db.AddInParameter(cd, "@iv_CustTypeId", SqlDbType.VarChar, custType);
                db.AddInParameter(cd, "@iv_OppId", SqlDbType.VarChar, oppId);
                db.AddInParameter(cd, "@iv_TRefCode", SqlDbType.VarChar, tRefId);
                db.AddInParameter(cd, "@in_UnitId", SqlDbType.Int, unitID);
                db.AddInParameter(cd, "@iv_EmpID", SqlDbType.VarChar, empID);
                db.AddInParameter(cd, "@in_FromDt", SqlDbType.Int, fromDt);
                db.AddInParameter(cd, "@in_ToDt", SqlDbType.Int, toDt);
                db.AddInParameter(cd, "@iv_CRFType", SqlDbType.VarChar, opSuppCRF);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;

                        for (int i = 0; i < rowCount; i++)
                        {
                            modelList.Add(MapPopulate_Get_OpportunityDetails_Tref_BFS(ds.Tables[0].Rows[i]));
                        }

                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }
            return modelList;
        }
        private static CreateNewOpportunity MapPopulate_Get_OpportunityDetails_Tref_BFS(DataRow dr)
        {
            try
            {
                return new CreateNewOpportunity()
                {
                    CRF_ID = (dr.Table.Columns.Contains("CRF_ID")) ? (dr["CRF_ID"] == DBNull.Value) ? "" : dr.Field<string>("CRF_ID") : "",
                    T_REF_CODE = (dr.Table.Columns.Contains("T_REF_CODE")) ? (dr["T_REF_CODE"] == DBNull.Value) ? "" : dr.Field<string>("T_REF_CODE") : "",
                    OpportunityId = (dr.Table.Columns.Contains("OPPORTUNITY_ID")) ? (dr["OPPORTUNITY_ID"] == DBNull.Value) ? "" : Convert.ToString(dr["OPPORTUNITY_ID"]) : "",
                    StageID = (dr.Table.Columns.Contains("STAGE_ID")) ? (dr["STAGE_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["STAGE_ID"]) : 0,
                    CUST_ID = (dr.Table.Columns.Contains("CUST_ID")) ? (dr["CUST_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CUST_ID"]) : 0,
                    STAGE_NAME = (dr.Table.Columns.Contains("STAGE_NAME")) ? (dr["STAGE_NAME"] == DBNull.Value) ? "" : dr.Field<string>("STAGE_NAME") : "",
                    OPPORTUNITY_DESC = (dr.Table.Columns.Contains("OPPORTUNITY_DESC")) ? (dr["OPPORTUNITY_DESC"] == DBNull.Value) ? "" : dr.Field<string>("OPPORTUNITY_DESC") : "",
                    GEOGRAPHY_CODE = (dr.Table.Columns.Contains("GEOGRAPHY_CODE")) ? (dr["GEOGRAPHY_CODE"] == DBNull.Value) ? "" : dr.Field<string>("GEOGRAPHY_CODE") : "",
                    GEOGRAPHY_NAME = (dr.Table.Columns.Contains("GEOGRAPHY_NAME")) ? (dr["GEOGRAPHY_NAME"] == DBNull.Value) ? "" : dr.Field<string>("GEOGRAPHY_NAME") : "",
                    CUST_NAME = (dr.Table.Columns.Contains("CUST_NAME")) ? (dr["CUST_NAME"] == DBNull.Value) ? "" : dr.Field<string>("CUST_NAME") : "",
                    CUST_TYPE_NAME = (dr.Table.Columns.Contains("CUST_TYPE_NAME")) ? (dr["CUST_TYPE_NAME"] == DBNull.Value) ? "" : dr.Field<string>("CUST_TYPE_NAME") : "",
                    ESTIMATED_FTE_SIZE = (dr.Table.Columns.Contains("ESTIMATED_FTE_SIZE")) ? (dr["ESTIMATED_FTE_SIZE"] == DBNull.Value) ? 0 : dr.Field<Decimal>("ESTIMATED_FTE_SIZE") : 0,
                    CUST_TYPE_CODE = (dr.Table.Columns.Contains("CUST_TYPE_CODE")) ? (dr["CUST_TYPE_CODE"] == DBNull.Value) ? "" : dr.Field<string>("CUST_TYPE_CODE") : "",
                    INDUSTRY_PRACTICE_NAME = (dr.Table.Columns.Contains("INDUSTRY_PRACTICE_NAME")) ? (dr["INDUSTRY_PRACTICE_NAME"] == DBNull.Value) ? "" : dr.Field<string>("INDUSTRY_PRACTICE_NAME") : "",
                    INDUSTRY_PRACTICE_CODE = (dr.Table.Columns.Contains("INDUSTRY_PRACTICE_CODE")) ? (dr["INDUSTRY_PRACTICE_CODE"] == DBNull.Value) ? "" : dr.Field<string>("INDUSTRY_PRACTICE_CODE") : "",
                    Associate_Details = (dr.Table.Columns.Contains("Associate_Details")) ? (dr["Associate_Details"] == DBNull.Value) ? "" : dr.Field<string>("Associate_Details") : "",
                    OPPORTUNITY_DATE = (dr.Table.Columns.Contains("OPPORTUNITY_DATE")) ? (dr["OPPORTUNITY_DATE"] == DBNull.Value) ? "" : dr.Field<string>("OPPORTUNITY_DATE") : "",
                    DEFAULTERS = (dr.Table.Columns.Contains("DEFAULTERS")) ? (dr["DEFAULTERS"] == DBNull.Value) ? "" : dr.Field<string>("DEFAULTERS") : "",
                    CREATED_BY = (dr.Table.Columns.Contains("CREATED_BY")) ? (dr["CREATED_BY"] == DBNull.Value) ? "" : dr.Field<string>("CREATED_BY") : "",
                    TOTAL_CONTRACT_VALUE = (dr.Table.Columns.Contains("TOTAL_CONTRACT_VALUE")) ? (dr["TOTAL_CONTRACT_VALUE"] == DBNull.Value) ? 0 : Convert.ToDouble(dr["TOTAL_CONTRACT_VALUE"]) : 0,
                    CLOSURE_DATE = (dr.Table.Columns.Contains("CLOSURE_DATE")) ? (dr["CLOSURE_DATE"] == DBNull.Value) ? "" : dr.Field<string>("CLOSURE_DATE") : "",
                    DEAL_TERM = (dr.Table.Columns.Contains("DEAL_TERM")) ? (dr["DEAL_TERM"] == DBNull.Value) ? "" : dr.Field<string>("DEAL_TERM") : "",
                    CRF_CODE = (dr.Table.Columns.Contains("CRF_CODE")) ? (dr["CRF_CODE"] == DBNull.Value) ? "" : dr.Field<string>("CRF_CODE") : "",
                    T_REF_ID = (dr.Table.Columns.Contains("T_REF_ID")) ? (dr["T_REF_ID"] == DBNull.Value) ? "" : dr.Field<string>("T_REF_ID") : "",
                    MATC_STATUS = (dr.Table.Columns.Contains("MATC_STATUS")) ? (dr["MATC_STATUS"] == DBNull.Value) ? "" : dr.Field<string>("MATC_STATUS") : "",
                    REMARK = (dr.Table.Columns.Contains("REMARK")) ? (dr["REMARK"] == DBNull.Value) ? "" : dr.Field<string>("REMARK") : "",
                    FTE_JOIN = (dr.Table.Columns.Contains("FTE_JOIN")) ? (dr["FTE_JOIN"] == DBNull.Value) ? "" : dr.Field<string>("FTE_JOIN") : "",
                    READ_STATUS = (dr.Table.Columns.Contains("READ_STATUS")) ? (dr["READ_STATUS"] == DBNull.Value) ? "" : dr.Field<string>("READ_STATUS") : "",
                    CRF_CLOSED = (dr.Table.Columns.Contains("CRF_CLOSED")) ? (dr["CRF_CLOSED"] == DBNull.Value) ? "" : dr.Field<string>("CRF_CLOSED") : "",
                    REC_FTE = (dr.Table.Columns.Contains("REC_FTE")) ? (dr["REC_FTE"] == DBNull.Value) ? "" : dr.Field<string>("REC_FTE") : "",
                    BUFFERFTE = (dr.Table.Columns.Contains("BUFFERFTE")) ? (dr["BUFFERFTE"] == DBNull.Value) ? "" : dr.Field<string>("BUFFERFTE") : "",
                    HOLD_DATE = (dr.Table.Columns.Contains("HOLD_DATE")) ? (dr["HOLD_DATE"] == DBNull.Value) ? "" : dr.Field<string>("HOLD_DATE") : "",
                    REOPEN_DT = (dr.Table.Columns.Contains("REOPEN_DT")) ? (dr["REOPEN_DT"] == DBNull.Value) ? "" : dr.Field<string>("REOPEN_DT") : "",
                    DELIVERY_CENTER_NAME = (dr.Table.Columns.Contains("DELIVERY_CENTER_NAME")) ? (dr["DELIVERY_CENTER_NAME"] == DBNull.Value) ? "" : dr.Field<string>("DELIVERY_CENTER_NAME") : "",
                    DL_APPROVED_BY = (dr.Table.Columns.Contains("DL_APPROVED_BY")) ? (dr["DL_APPROVED_BY"] == DBNull.Value) ? "" : dr.Field<string>("DL_APPROVED_BY") : "",
                    DL_APPROVED_DT = (dr.Table.Columns.Contains("DL_APPROVED_DT")) ? (dr["DL_APPROVED_DT"] == DBNull.Value) ? "" : dr.Field<string>("DL_APPROVED_DT") : "",
                    MATC_APPROVED_BY = (dr.Table.Columns.Contains("MATC_APPROVED_BY")) ? (dr["MATC_APPROVED_BY"] == DBNull.Value) ? "" : dr.Field<string>("MATC_APPROVED_BY") : "",
                    MATC_APPROVED_DT = (dr.Table.Columns.Contains("MATC_APPROVED_DT")) ? (dr["MATC_APPROVED_DT"] == DBNull.Value) ? "" : dr.Field<string>("MATC_APPROVED_DT") : "",
                    CRF_TYPE = (dr.Table.Columns.Contains("CRF_TYPE")) ? (dr["CRF_TYPE"] == DBNull.Value) ? "" : dr.Field<string>("CRF_TYPE") : "",
                    OSM_STATUS = (dr.Table.Columns.Contains("OSM_STATUS")) ? (dr["OSM_STATUS"] == DBNull.Value) ? "" : dr.Field<string>("OSM_STATUS") : "",

                };
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
        }
        /// <summary>
        /// Pipeline Update
        /// </summary>
        public int Check_weeklyStatusUpdate(string opportunityId)
        {
            try
            {
                int intResult;
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Check_Pipleine_Update);
                db.AddInParameter(cd, "@in_OpportunityId", SqlDbType.VarChar, opportunityId);
                db.ExecuteNonQuery(cd);
                intResult = Convert.ToInt16(db.GetParameterValue(cd, "@on_Result"));
                return intResult;
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
        }
        /// <summary>
        /// Get Get_Sol_TM Details
        /// </summary>
        public List<CreateNewOpportunity> GetSol_TM_Dtls(string oppID)
        {
            DataSet ds = null;
            List<CreateNewOpportunity> modelList = new List<CreateNewOpportunity>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Get_Sol_TM_Dtls);
                db.AddInParameter(cd, "@iv_OppID", SqlDbType.VarChar, oppID);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;

                        for (int i = 0; i < rowCount; i++)
                        {
                            modelList.Add(MapGet_Sol_TM_Dtls(ds.Tables[0].Rows[i]));
                        }

                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }
            return modelList;
        }
        private static CreateNewOpportunity MapGet_Sol_TM_Dtls(DataRow dr)
        {
            try
            {
                return new CreateNewOpportunity()
                {
                    OpportunityId = (dr.Table.Columns.Contains("OPPORTUNITY_ID")) ? (dr["OPPORTUNITY_ID"] == DBNull.Value) ? "" : Convert.ToString(dr["OPPORTUNITY_ID"]) : "",
                    TM_SOL_EMP_NO = (dr.Table.Columns.Contains("TM_SOL_EMP_NO")) ? (dr["TM_SOL_EMP_NO"] == DBNull.Value) ? "" : dr.Field<string>("TM_SOL_EMP_NO") : "",
                    TM_SOL_EMP_NAME = (dr.Table.Columns.Contains("TM_SOL_EMP_NAME")) ? (dr["TM_SOL_EMP_NAME"] == DBNull.Value) ? "" : dr.Field<string>("TM_SOL_EMP_NAME") : "",
                    TM_SOL_ALLOCATION = (dr.Table.Columns.Contains("TM_SOL_ALLOCATION")) ? (dr["TM_SOL_ALLOCATION"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["TM_SOL_ALLOCATION"]) : 0,

                };
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
        }
        /// <summary>

        /// Get Stage8 Details

        /// </summary>

        public List<CreateNewOpportunity> Get_stage8(string opportunityId, string stageId)
        {

            DataSet ds = null;

            List<CreateNewOpportunity> modelList = new List<CreateNewOpportunity>();

            try
            {

                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();

                DbCommand cd = db.GetStoredProcCommand(DataConstants.GetOpportunity_Stage8_sp);

                db.AddInParameter(cd, "@in_OpportunityId", SqlDbType.VarChar, opportunityId);

                db.AddInParameter(cd, "@in_StageId", SqlDbType.Int, stageId);

                ds = db.ExecuteDataSet(cd);

                if (ds != null)
                {

                    if (ds.Tables.Count > 0)
                    {

                        int rowCount = ds.Tables[0].Rows.Count;



                        for (int i = 0; i < rowCount; i++)
                        {

                            modelList.Add(MapPopulate_Get_stage8(ds.Tables[0].Rows[i]));

                        }



                    }

                }

            }

            catch (InvalidOperationException ex)
            {

                throw new DatabaseException(ex);

            }

            catch (ArgumentException ex)
            {

                throw new DatabaseException(ex);

            }

            finally
            {

                if (ds != null)
                {

                    ds.Dispose();

                }

            }

            return modelList;

        }

        private static CreateNewOpportunity MapPopulate_Get_stage8(DataRow dr)
        {

            try
            {

                return new CreateNewOpportunity()

                {

                    OpportunityId = (dr.Table.Columns.Contains("OPPORTUNITY_ID")) ? (dr["OPPORTUNITY_ID"] == DBNull.Value) ? "" : Convert.ToString(dr["OPPORTUNITY_ID"]) : "",

                    OPPORTUNITY_DESC = (dr.Table.Columns.Contains("OPPORTUNITY_DESC")) ? (dr["OPPORTUNITY_DESC"] == DBNull.Value) ? "" : dr.Field<string>("OPPORTUNITY_DESC") : "",

                    OLD_OPPORTUNITY_DESC = (dr.Table.Columns.Contains("OLD_OPPORTUNITY_DESC")) ? (dr["OLD_OPPORTUNITY_DESC"] == DBNull.Value) ? "" : dr.Field<string>("OLD_OPPORTUNITY_DESC") : "",

                    GEOGRAPHY_ID = (dr.Table.Columns.Contains("GEOGRAPHY_ID")) ? (dr["GEOGRAPHY_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["GEOGRAPHY_ID"]) : 0,

                    GEOGRAPHY_NAME = (dr.Table.Columns.Contains("GEOGRAPHY_NAME")) ? (dr["GEOGRAPHY_NAME"] == DBNull.Value) ? "" : dr.Field<string>("GEOGRAPHY_NAME") : "",

                    CUST_ID = (dr.Table.Columns.Contains("CUST_ID")) ? (dr["CUST_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CUST_ID"]) : 0,

                    CUST_NAME = (dr.Table.Columns.Contains("CUST_NAME")) ? (dr["CUST_NAME"] == DBNull.Value) ? "" : dr.Field<string>("CUST_NAME") : "",

                    CUST_TYPE_ID = (dr.Table.Columns.Contains("CUST_TYPE_ID")) ? (dr["CUST_TYPE_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CUST_TYPE_ID"]) : 0,

                    CUST_TYPE_NAME = (dr.Table.Columns.Contains("CUST_TYPE_NAME")) ? (dr["CUST_TYPE_NAME"] == DBNull.Value) ? "" : dr.Field<string>("CUST_TYPE_NAME") : "",

                    INDUSTRY_PRACTICE_ID = (dr.Table.Columns.Contains("INDUSTRY_PRACTICE_ID")) ? (dr["INDUSTRY_PRACTICE_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["INDUSTRY_PRACTICE_ID"]) : 0,

                    StageID = (dr.Table.Columns.Contains("STAGE_ID")) ? (dr["STAGE_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["STAGE_ID"]) : 0,

                    INDUSTRY_PRACTICE_NAME = (dr.Table.Columns.Contains("INDUSTRY_PRACTICE_NAME")) ? (dr["INDUSTRY_PRACTICE_NAME"] == DBNull.Value) ? "" : dr.Field<string>("INDUSTRY_PRACTICE_NAME") : "",

                    STAGE_NAME = (dr.Table.Columns.Contains("STAGE_NAME")) ? (dr["STAGE_NAME"] == DBNull.Value) ? "" : dr.Field<string>("STAGE_NAME") : "",

                    ISU_CD = (dr.Table.Columns.Contains("ISU_CD")) ? (dr["ISU_CD"] == DBNull.Value) ? "" : dr.Field<string>("ISU_CD") : "",

                    ISU_NAME = (dr.Table.Columns.Contains("ISU_NAME")) ? (dr["ISU_NAME"] == DBNull.Value) ? "" : dr.Field<string>("ISU_NAME") : "",

                    GEOGRAPHY_SALES_OWNER = (dr.Table.Columns.Contains("GEOGRAPHY_SALES_OWNER_ID")) ? (dr["GEOGRAPHY_SALES_OWNER_ID"] == DBNull.Value) ? "" : dr.Field<string>("GEOGRAPHY_SALES_OWNER_ID") : "",

                    ONSITE_OWNER = (dr.Table.Columns.Contains("ONSITE_OWNER_ID")) ? (dr["ONSITE_OWNER_ID"] == DBNull.Value) ? "" : dr.Field<string>("ONSITE_OWNER_ID") : "",

                    OFFSHORE_BD_LEAD = (dr.Table.Columns.Contains("OFFSHORE_BD_LEAD_ID")) ? (dr["OFFSHORE_BD_LEAD_ID"] == DBNull.Value) ? "" : dr.Field<string>("OFFSHORE_BD_LEAD_ID") : "",

                    OPPORTUNITY_DATE = (dr.Table.Columns.Contains("OPPORTUNITY_DATE")) ? (dr["OPPORTUNITY_DATE"] == DBNull.Value) ? "" : dr.Field<string>("OPPORTUNITY_DATE") : "",
                    DEAL_CLOSURE_EXP_DATE = (dr.Table.Columns.Contains("DEAL_CLOSURE_EXP_DATE")) ? (dr["DEAL_CLOSURE_EXP_DATE"] == DBNull.Value) ? "" : dr.Field<string>("DEAL_CLOSURE_EXP_DATE") : "",

                    DTOTAL_CONTRACT_VALUE = (dr.Table.Columns.Contains("TOTAL_CONTRACT_VALUE")) ? (dr["TOTAL_CONTRACT_VALUE"] == DBNull.Value) ? 0 : Convert.ToDouble(dr["TOTAL_CONTRACT_VALUE"]) : 0,

                    BUSINESS_ID = (dr.Table.Columns.Contains("BUSINESS_ID")) ? (dr["BUSINESS_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["BUSINESS_ID"]) : 0,

                    COUNTRY_ID = (dr.Table.Columns.Contains("COUNTRY_ID")) ? (dr["COUNTRY_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["COUNTRY_ID"]) : 0,

                    PIBS = (dr.Table.Columns.Contains("PIBS")) ? (dr["PIBS"] == DBNull.Value) ? "" : dr.Field<string>("PIBS") : "",

                    CRM_ID = (dr.Table.Columns.Contains("CRM_ID")) ? (dr["CRM_ID"] == DBNull.Value) ? "" : dr.Field<string>("CRM_ID") : "",

                    VALUE_BPS = (dr.Table.Columns.Contains("VALUE_BPS")) ? (dr["VALUE_BPS"] == DBNull.Value) ? "" : dr.Field<string>("VALUE_BPS") : "",

                    VALUE_BPS_TCV = (dr.Table.Columns.Contains("VALUE_BPS_TCV")) ? (dr["VALUE_BPS_TCV"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["VALUE_BPS_TCV"]) : 0,

                    OPP_TYPE = (dr.Table.Columns.Contains("OPP_TYPE")) ? (dr["OPP_TYPE"] == DBNull.Value) ? "" : dr.Field<string>("OPP_TYPE") : "",

                    IESTIMATED_FTE_SIZE = (dr.Table.Columns.Contains("ESTIMATED_FTE_SIZE")) ? (dr["ESTIMATED_FTE_SIZE"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["ESTIMATED_FTE_SIZE"]) : 0,

                    ContractLength = (dr.Table.Columns.Contains("CONTRACT_LENGTH")) ? (dr["CONTRACT_LENGTH"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CONTRACT_LENGTH"]) : 0,

                    ISU_OWNER_ID = (dr.Table.Columns.Contains("ISU_OWNER_ID")) ? (dr["ISU_OWNER_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["ISU_OWNER_ID"]) : 0,

                    ACCOUNT_SALES_OWNER_ID = (dr.Table.Columns.Contains("ACCOUNT_SALES_OWNER_ID")) ? (dr["ACCOUNT_SALES_OWNER_ID"] == DBNull.Value) ? "" : dr.Field<string>("ACCOUNT_SALES_OWNER_ID") : "",

                    GEOGRAPHY_SALES_OWNER_ID = (dr.Table.Columns.Contains("GEOGRAPHY_SALES_OWNER_ID")) ? (dr["GEOGRAPHY_SALES_OWNER_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["GEOGRAPHY_SALES_OWNER_ID"]) : 0,

                    OFFSHORE_BD_LEAD_ID = (dr.Table.Columns.Contains("OFFSHORE_BD_LEAD_ID")) ? (dr["OFFSHORE_BD_LEAD_ID"] == DBNull.Value) ? "" : dr.Field<string>("OFFSHORE_BD_LEAD_ID") : "",

                    LAST_UPDATE = (dr.Table.Columns.Contains("LAST_UPDATE")) ? (dr["LAST_UPDATE"] == DBNull.Value) ? "" : dr.Field<string>("LAST_UPDATE") : "",

                    DEAL_BD_LEAD_ID = (dr.Table.Columns.Contains("DEAL_BD_LEAD_ID")) ? (dr["DEAL_BD_LEAD_ID"] == DBNull.Value) ? "" : dr.Field<string>("DEAL_BD_LEAD_ID") : "",

                    DEAL_BD_LEAD_ID2 = (dr.Table.Columns.Contains("DEAL_BD_LEAD_ID2")) ? (dr["DEAL_BD_LEAD_ID2"] == DBNull.Value) ? "" : dr.Field<string>("DEAL_BD_LEAD_ID2") : "",

                    RFI_ReviewDate = (dr.Table.Columns.Contains("RFI_REVIEW_DT")) ? (dr["RFI_REVIEW_DT"] == DBNull.Value) ? "" : dr.Field<string>("RFI_REVIEW_DT") : "",

                    RFP_ReviewDate = (dr.Table.Columns.Contains("RFP_REVIEW_DT")) ? (dr["RFP_REVIEW_DT"] == DBNull.Value) ? "" : dr.Field<string>("RFP_REVIEW_DT") : "",

                    RFI_ReceivedDate = (dr.Table.Columns.Contains("RFI_RECEIVED_DT")) ? (dr["RFI_RECEIVED_DT"] == DBNull.Value) ? "" : dr.Field<string>("RFI_RECEIVED_DT") : "",

                    RFP_ReceivedDate = (dr.Table.Columns.Contains("RFP_RECEIVED_DT")) ? (dr["RFP_RECEIVED_DT"] == DBNull.Value) ? "" : dr.Field<string>("RFP_RECEIVED_DT") : "",

                    RFI_ProbableSubmissionDate = (dr.Table.Columns.Contains("RFI_PROBABLE_SUBMISSION_DT")) ? (dr["RFI_PROBABLE_SUBMISSION_DT"] == DBNull.Value) ? "" : dr.Field<string>("RFI_PROBABLE_SUBMISSION_DT") : "",

                    RFP_ProbableSubmissionDate = (dr.Table.Columns.Contains("RFP_PROBABLE_SUBMISSION_DT")) ? (dr["RFP_PROBABLE_SUBMISSION_DT"] == DBNull.Value) ? "" : dr.Field<string>("RFP_PROBABLE_SUBMISSION_DT") : "",

                    RFI_ActualSubmissionDate = (dr.Table.Columns.Contains("RFI_ACTUAL_SUBMISSION_DT")) ? (dr["RFI_ACTUAL_SUBMISSION_DT"] == DBNull.Value) ? "" : dr.Field<string>("RFI_ACTUAL_SUBMISSION_DT") : "",

                    RFP_ActualSubmissionDate = (dr.Table.Columns.Contains("RFP_ACTUAL_SUBMISSION_DT")) ? (dr["RFP_ACTUAL_SUBMISSION_DT"] == DBNull.Value) ? "" : dr.Field<string>("RFP_ACTUAL_SUBMISSION_DT") : "",

                    BCP_DRP_LOCATION = (dr.Table.Columns.Contains("BCP_DRP_LOCATION")) ? (dr["BCP_DRP_LOCATION"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["BCP_DRP_LOCATION"]) : 0,

                    RFI_REVIEW_BY = (dr.Table.Columns.Contains("RFI_REVIEW_BY")) ? (dr["RFI_REVIEW_BY"] == DBNull.Value) ? "" : dr.Field<string>("RFI_REVIEW_BY") : "",

                    RFP_REVIEW_BY = (dr.Table.Columns.Contains("RFP_REVIEW_BY")) ? (dr["RFP_REVIEW_BY"] == DBNull.Value) ? "" : dr.Field<string>("RFP_REVIEW_BY") : "",

                    CURRENCY_ID = (dr.Table.Columns.Contains("CURRENCY_ID")) ? (dr["CURRENCY_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CURRENCY_ID"]) : 0,

                    FTEOff = (dr.Table.Columns.Contains("FTE_OFFSHORE")) ? (dr["FTE_OFFSHORE"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["FTE_OFFSHORE"]) : 0,

                    FTEOn = (dr.Table.Columns.Contains("FTE_ONSITE")) ? (dr["FTE_ONSITE"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["FTE_ONSITE"]) : 0,

                    ClusterId = (dr.Table.Columns.Contains("CLUSTER_ID")) ? (dr["CLUSTER_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CLUSTER_ID"]) : 0,

                    DealCategory = (dr.Table.Columns.Contains("DEAL_CATEGORY")) ? (dr["DEAL_CATEGORY"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["DEAL_CATEGORY"]) : 0,

                    BPS_OFFERING_ID = (dr.Table.Columns.Contains("BPS_OFFERING_ID")) ? (dr["BPS_OFFERING_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["BPS_OFFERING_ID"]) : 0,

                    SERVICE_ID = (dr.Table.Columns.Contains("SERVICE_ID")) ? (dr["SERVICE_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["SERVICE_ID"]) : 0,

                    SUB_IOU = (dr.Table.Columns.Contains("SUB_IOU")) ? (dr["SUB_IOU"] == DBNull.Value) ? "" : dr.Field<string>("SUB_IOU") : "",

                    EXECUTIVE_SPONSOR = (dr.Table.Columns.Contains("EXECUTIVE_SPONSOR")) ? (dr["EXECUTIVE_SPONSOR"] == DBNull.Value) ? "" : dr.Field<string>("EXECUTIVE_SPONSOR") : "",

                    VALBPS_CON = (dr.Table.Columns.Contains("VALBPS_CON")) ? (dr["VALBPS_CON"] == DBNull.Value) ? "" : dr.Field<string>("VALBPS_CON") : "",

                    PROACTIVE_PROPOSAL = (dr.Table.Columns.Contains("PROACTIVE_PROPOSAL")) ? (dr["PROACTIVE_PROPOSAL"] == DBNull.Value) ? "" : dr.Field<string>("PROACTIVE_PROPOSAL") : "",

                    ISU_MAIN = (dr.Table.Columns.Contains("ISU_MAIN")) ? (dr["ISU_MAIN"] == DBNull.Value) ? "" : dr.Field<string>("ISU_MAIN") : "",

                    Quarter = (dr.Table.Columns.Contains("quarter")) ? (dr["quarter"] == DBNull.Value) ? "" : dr.Field<string>("quarter") : "",

                    FISCAL_YEAR = (dr.Table.Columns.Contains("FISCAL_YEAR")) ? (dr["FISCAL_YEAR"] == DBNull.Value) ? "" : dr.Field<string>("FISCAL_YEAR") : "",

                    PROPOSAL_FACTORY = (dr.Table.Columns.Contains("PROPOSAL_FACTORY")) ? (dr["PROPOSAL_FACTORY"] == DBNull.Value) ? "" : dr.Field<string>("PROPOSAL_FACTORY") : "",

                    PROPOSAL_FACTORY_OPTIONS = (dr.Table.Columns.Contains("PROPOSAL_FACTORY_OPTIONS")) ? (dr["PROPOSAL_FACTORY_OPTIONS"] == DBNull.Value) ? "" : dr.Field<string>("PROPOSAL_FACTORY_OPTIONS") : "",

                    PROPOSAL_FACTORY_COMMENTS = (dr.Table.Columns.Contains("PROPOSAL_FACTORY_COMMENTS")) ? (dr["PROPOSAL_FACTORY_COMMENTS"] == DBNull.Value) ? "" : dr.Field<string>("PROPOSAL_FACTORY_COMMENTS") : "",

                    DT_ID = (dr.Table.Columns.Contains("DT_ID")) ? (dr["DT_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["DT_ID"]) : 0,

                    Other_DT = (dr.Table.Columns.Contains("Other_DT")) ? (dr["Other_DT"] == DBNull.Value) ? "" : dr.Field<string>("Other_DT") : "",

                    CRM_TCV = (dr.Table.Columns.Contains("CRM_TCV")) ? (dr["CRM_TCV"] == DBNull.Value) ? "" : Convert.ToString(dr["CRM_TCV"]) : "",

                    CRM_STAGE = (dr.Table.Columns.Contains("CRM_STAGE")) ? (dr["CRM_STAGE"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CRM_STAGE"]) : 0,

                    strDigitalTcv = (dr.Table.Columns.Contains("Digital_TCV")) ? (dr["Digital_TCV"] == DBNull.Value) ? "" : dr.Field<string>("Digital_TCV") : "",

                    subSPId = (dr.Table.Columns.Contains("SubSPID")) ? (dr["SubSPID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["SubSPID"]) : 0,

                    CRM_Beacon = (dr.Table.Columns.Contains("CRM_Beacon")) ? (dr["CRM_Beacon"] == DBNull.Value) ? "" : Convert.ToString(dr["CRM_Beacon"]) : "",

                    MULTITOWER_DEAL = (dr.Table.Columns.Contains("MULTITOWER_DEAL")) ? (dr["MULTITOWER_DEAL"] == DBNull.Value) ? "" : dr.Field<string>("MULTITOWER_DEAL") : "",

                    TataGroupAccount = (dr.Table.Columns.Contains("TATA_GROUP_ACCOUNT")) ? (dr["TATA_GROUP_ACCOUNT"] == DBNull.Value) ? "" : Convert.ToString(dr["TATA_GROUP_ACCOUNT"]) : "",

                    ItisScope = (dr.Table.Columns.Contains("ItisScope")) ? (dr["ItisScope"] == DBNull.Value) ? "" : Convert.ToString(dr["ItisScope"]) : "",

                    IsContractRenewal = (dr.Table.Columns.Contains("IsContractRenewal")) ? (dr["IsContractRenewal"] == DBNull.Value) ? "" : Convert.ToString(dr["IsContractRenewal"]) : "",

                    ContractRenewalValue = (dr.Table.Columns.Contains("ContractRenewalValue")) ? (dr["ContractRenewalValue"] == DBNull.Value) ? "" : Convert.ToString(dr["ContractRenewalValue"]) : "",

                    RESOURCING_ID = (dr.Table.Columns.Contains("ResourcingId")) ? (dr["ResourcingId"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["ResourcingId"]) : 0,

                    SEAT_IDENTIFICATION_ID = (dr.Table.Columns.Contains("Seat_IdentificationId")) ? (dr["Seat_IdentificationId"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["Seat_IdentificationId"]) : 0,

                    SHORTLIST_DT = (dr.Table.Columns.Contains("SHORTLIST_DT")) ? (dr["SHORTLIST_DT"] == DBNull.Value) ? "" : Convert.ToString(dr["SHORTLIST_DT"]) : "",

                    SELECTION_DT = (dr.Table.Columns.Contains("SELECTION_DT")) ? (dr["SELECTION_DT"] == DBNull.Value) ? "" : Convert.ToString(dr["SELECTION_DT"]) : "",

                    ONSITE_TRAINING_NOS = (dr.Table.Columns.Contains("ONSITE_TRAINING_NOS")) ? (dr["ONSITE_TRAINING_NOS"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["ONSITE_TRAINING_NOS"]) : 0,

                    VISA_REQUIRED = (dr.Table.Columns.Contains("VISA_REQUIRED")) ? (dr["VISA_REQUIRED"] == DBNull.Value) ? "" : dr.Field<string>("VISA_REQUIRED") : "",

                    VISAS_REQUIRED = (dr.Table.Columns.Contains("VISAS_REQUIRED")) ? (dr["VISAS_REQUIRED"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["VISAS_REQUIRED"]) : 0,

                    TRAINING_DURATION = (dr.Table.Columns.Contains("TRAINING_DURATION")) ? (dr["TRAINING_DURATION"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["TRAINING_DURATION"]) : 0,

                    CONTRACT_NEGOTIATION_DT = (dr.Table.Columns.Contains("CONTRACT_NEGOTIATION_DT")) ? (dr["CONTRACT_NEGOTIATION_DT"] == DBNull.Value) ? "" : dr.Field<string>("CONTRACT_NEGOTIATION_DT") : "",
                    DealStatus = (dr.Table.Columns.Contains("DealStatus_Id")) ? (dr["DealStatus_Id"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["DealStatus_Id"]) : 0,
                    ServicePractice = (dr.Table.Columns.Contains("ServicePractice_Id")) ? (dr["ServicePractice_Id"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["ServicePractice_Id"]) : 0,
                    CoreOffering = (dr.Table.Columns.Contains("CoreOffering_Id")) ? (dr["CoreOffering_Id"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CoreOffering_Id"]) : 0,
                    OpportunityDescDetails = (dr.Table.Columns.Contains("Opportunity_Desc_Details")) ? (dr["Opportunity_Desc_Details"] == DBNull.Value) ? "" : dr.Field<string>("Opportunity_Desc_Details") : "",
                    offeringType = (dr.Table.Columns.Contains("OfferingType_Id")) ? (dr["OfferingType_Id"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["OfferingType_Id"]) : 0,
                    CofID = (dr.Table.Columns.Contains("CoreOfferingName_Id")) ? (dr["CoreOfferingName_Id"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CoreOfferingName_Id"]) : 0,

                    DigitalFlagging = (dr.Table.Columns.Contains("Digital_Flagging")) ? (dr["Digital_Flagging"] == DBNull.Value) ? "" : Convert.ToString(dr["Digital_Flagging"]) : "",
                    PROPOSAL_SUBMISSION_DATE = (dr.Table.Columns.Contains("PROPOSAL_SUBMISSION_DATE")) ? (dr["PROPOSAL_SUBMISSION_DATE"] == DBNull.Value) ? "" : dr.Field<string>("PROPOSAL_SUBMISSION_DATE") : "",
                    SALES_STAGE_MOVED_ONDATE = (dr.Table.Columns.Contains("SALES_STAGE_MOVED_ON_DATE")) ? (dr["SALES_STAGE_MOVED_ON_DATE"] == DBNull.Value) ? "" : dr.Field<string>("SALES_STAGE_MOVED_ON_DATE") : "",

                    Previous_Deal_Stage = (dr.Table.Columns.Contains("Previous_Deal_Stage")) ? (dr["Previous_Deal_Stage"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["Previous_Deal_Stage"]) : 0,

                    DELIVERY_LOCATION_PROPOSED = (dr.Table.Columns.Contains("DELIVERY_LOCATION_PROPOSED")) ? (dr["DELIVERY_LOCATION_PROPOSED"] == DBNull.Value) ? "" : dr.Field<string>("DELIVERY_LOCATION_PROPOSED") : "",
                    Cboi_Offering_id = (dr.Table.Columns.Contains("cboi_offering_id")) ? (dr["cboi_offering_id"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["cboi_offering_id"]) : 0,
                    Deal_Flag_id = (dr.Table.Columns.Contains("deal_flag")) ? (dr["deal_flag"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["deal_flag"]) : 0,
                    PLATFORM = (dr.Table.Columns.Contains("PLATFORM")) ? (dr["PLATFORM"] == DBNull.Value) ? "" : dr.Field<string>("PLATFORM") : "",
                    PLATFORM_OPTION = (dr.Table.Columns.Contains("PLATFORM_OPTION")) ? (dr["PLATFORM_OPTION"] == DBNull.Value) ? "" : dr.Field<string>("PLATFORM_OPTION") : "",




                };

            }

            catch (Exception ex)
            {

                throw new DatabaseException(ex);

            }

        }
        /// <summary>

        /// Save Stage8 Details

        /// </summary>

        ///

        public List<CreateNewOpportunity> Save_Stage8Opportunity(CreateNewOpportunity ObjCreateNewOpportunity)
        {

            List<CreateNewOpportunity> strResult = new List<CreateNewOpportunity>();

            try
            {

                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();

                DbCommand cd = db.GetStoredProcCommand(DataConstants.Ins_Opportunity_stage8_sp);

                db.AddInParameter(cd, "@in_OpportunityId", SqlDbType.VarChar, ObjCreateNewOpportunity.OpportunityId);

                db.AddInParameter(cd, "@iv_OpportunityDesc", SqlDbType.VarChar, ObjCreateNewOpportunity.OPPORTUNITY_DESC);

                db.AddInParameter(cd, "@iv_OldOpportunityDesc", SqlDbType.VarChar, ObjCreateNewOpportunity.OLD_OPPORTUNITY_DESC);

                db.AddInParameter(cd, "@in_GeographyId", SqlDbType.Int, ObjCreateNewOpportunity.GEOGRAPHY_ID);

                db.AddInParameter(cd, "@in_CustId", SqlDbType.Int, ObjCreateNewOpportunity.CUST_ID);

                db.AddInParameter(cd, "@in_CustTypeId", SqlDbType.Int, ObjCreateNewOpportunity.CUST_TYPE_ID);

                db.AddInParameter(cd, "@in_IndustryPracticeId", SqlDbType.Int, ObjCreateNewOpportunity.INDUSTRY_PRACTICE_ID);

                db.AddInParameter(cd, "@in_StageId", SqlDbType.Int, ObjCreateNewOpportunity.StageID);

                db.AddInParameter(cd, "@iv_GeographySalesOwner", SqlDbType.VarChar, ObjCreateNewOpportunity.GeosalesOwner);

                db.AddInParameter(cd, "@iv_OffshorePracticeOwner", SqlDbType.VarChar, ObjCreateNewOpportunity.OFFSHORE_PRACTICE_OWNER);

                db.AddInParameter(cd, "@iv_RdCrd", SqlDbType.VarChar, ObjCreateNewOpportunity.RDCrd);

                db.AddInParameter(cd, "@iv_OffshoreBDLead", SqlDbType.VarChar, ObjCreateNewOpportunity.OffShoreBDLead);

                db.AddInParameter(cd, "@iv_OnsiteOwner", SqlDbType.VarChar, ObjCreateNewOpportunity.OnsiteOwner);

                db.AddInParameter(cd, "@in_ProbabilityOfwin", SqlDbType.Int, ObjCreateNewOpportunity.PROBABILITY_OF_WIN);

                db.AddInParameter(cd, "@in_CurencyId", SqlDbType.Int, ObjCreateNewOpportunity.CURRENCY_ID);

                db.AddInParameter(cd, "@in_TCV", SqlDbType.VarChar, ObjCreateNewOpportunity.TCV);

                db.AddInParameter(cd, "@in_ContractLength", SqlDbType.Int, ObjCreateNewOpportunity.ContractLength);

                db.AddInParameter(cd, "@in_FiscalRev", SqlDbType.Float, ObjCreateNewOpportunity.FiscRev);

                db.AddInParameter(cd, "@in_FTE", SqlDbType.Int, ObjCreateNewOpportunity.FTE);

                db.AddInParameter(cd, "@iv_PricingOwnerId", SqlDbType.VarChar, ObjCreateNewOpportunity.PRICING_OWNER_EMPID);

                db.AddInParameter(cd, "@iv_SolutionLeaderId", SqlDbType.VarChar, ObjCreateNewOpportunity.SolutionLeaderId);



                db.AddInParameter(cd, "@in_PricingTypeId", SqlDbType.Int, ObjCreateNewOpportunity.PRICING_TYPE_ID);

                db.AddInParameter(cd, "@in_OnsiteTrainingNos", SqlDbType.VarChar, ObjCreateNewOpportunity.ONSITE_TRAINING_NOS);

                db.AddInParameter(cd, "@iv_VisaRequired", SqlDbType.VarChar, ObjCreateNewOpportunity.VISAS_REQUIRED);

                db.AddInParameter(cd, "@in_TrainingDuration", SqlDbType.Int, ObjCreateNewOpportunity.TRAINING_DURATION);

                db.AddInParameter(cd, "@in_VisasRequired", SqlDbType.Int, ObjCreateNewOpportunity.VISAS_REQUIRED);

                db.AddInParameter(cd, "@iv_Remark", SqlDbType.VarChar, ObjCreateNewOpportunity.REMARK);

                db.AddInParameter(cd, "@in_OppDate", SqlDbType.Int, ObjCreateNewOpportunity.OppDate);

                db.AddInParameter(cd, "@in_RFIReceivedDt", SqlDbType.Int, ObjCreateNewOpportunity.RFIReceivedDate);



                db.AddInParameter(cd, "@in_RFIActSubmissiondDt", SqlDbType.Int, ObjCreateNewOpportunity.RFIActualSubmissionDate);

                db.AddInParameter(cd, "@in_RFPReceivedDt", SqlDbType.Int, ObjCreateNewOpportunity.RFPReceivedDate);

                db.AddInParameter(cd, "@in_RFIProbSubmissiondDt", SqlDbType.Int, ObjCreateNewOpportunity.RFIProbableSubmissionDate);

                db.AddInParameter(cd, "@in_RFPProbSubmissiondDt", SqlDbType.Int, ObjCreateNewOpportunity.RFPProbableSubmissionDate);

                db.AddInParameter(cd, "@in_RFPActSubmissiondDt", SqlDbType.Int, ObjCreateNewOpportunity.RFPActualSubmissionDate);

                db.AddInParameter(cd, "@in_ShortListDt", SqlDbType.Int, ObjCreateNewOpportunity.ShortListDate);

                db.AddInParameter(cd, "@in_SelectionDt", SqlDbType.Int, ObjCreateNewOpportunity.SelectionDate);

                db.AddInParameter(cd, "@in_ContractNegoDt", SqlDbType.Int, ObjCreateNewOpportunity.ContractCloserDate);

                db.AddInParameter(cd, "@in_BCPDRPLoc", SqlDbType.Int, ObjCreateNewOpportunity.BCP_DRP_LOCATION);

                db.AddInParameter(cd, "@iv_EmpNo", SqlDbType.VarChar, ObjCreateNewOpportunity.EmpNo);

                db.AddInParameter(cd, "@in_ClosureDate", SqlDbType.Int, ObjCreateNewOpportunity.ClosureDate);

                db.AddInParameter(cd, "@in_RFIRwDt", SqlDbType.Int, ObjCreateNewOpportunity.RFI_REVIEW_DT);

                db.AddInParameter(cd, "@in_RFPRwDt", SqlDbType.Int, ObjCreateNewOpportunity.RFP_REVIEW_DT);

                db.AddInParameter(cd, "@iv_RFIBy", SqlDbType.VarChar, ObjCreateNewOpportunity.RFI_REVIEW_BY);

                db.AddInParameter(cd, "@iv_RFPBy", SqlDbType.VarChar, ObjCreateNewOpportunity.RFP_REVIEW_BY);

                db.AddInParameter(cd, "@iv_NGM", SqlDbType.VarChar, ObjCreateNewOpportunity.OPP_NGM);

                db.AddInParameter(cd, "@iv_CRMReason", SqlDbType.VarChar, ObjCreateNewOpportunity.CRM_REASON);

                db.AddInParameter(cd, "@iv_BidExeEmpId", SqlDbType.VarChar, ObjCreateNewOpportunity.BID_EXECUTIVE_EMPID);

                db.AddInParameter(cd, "@iv_Disqual", SqlDbType.VarChar, ObjCreateNewOpportunity.Disqual);

                db.AddInParameter(cd, "@iv_AddDeal", SqlDbType.VarChar, ObjCreateNewOpportunity.AddDeal);

                db.AddInParameter(cd, "@iv_BidExeName", SqlDbType.VarChar, ObjCreateNewOpportunity.BID_EXECUTIVE_NAME);

                db.AddInParameter(cd, "@iv_DealOwner", SqlDbType.VarChar, ObjCreateNewOpportunity.DealOwner);

                db.AddInParameter(cd, "@iv_DealOwner2", SqlDbType.VarChar, ObjCreateNewOpportunity.DealOwner2);

                db.AddInParameter(cd, "@in_OperationWindow", SqlDbType.Int, ObjCreateNewOpportunity.OPERATION_WINDOW);

                db.AddInParameter(cd, "@in_Area", SqlDbType.Int, ObjCreateNewOpportunity.AREA);

                db.AddInParameter(cd, "@in_TypesOfSeat", SqlDbType.Int, ObjCreateNewOpportunity.TYPES_OF_SEAT);

                db.AddInParameter(cd, "@in_PCsRequired", SqlDbType.Int, ObjCreateNewOpportunity.PCS_REQUIRED);

                db.AddInParameter(cd, "@in_DesksRequired", SqlDbType.Int, ObjCreateNewOpportunity.DESKS_REQUIRED);

                db.AddInParameter(cd, "@in_PhonesRequired", SqlDbType.Int, ObjCreateNewOpportunity.PHONES_REQUIRED);

                db.AddInParameter(cd, "@in_CabinsRequired", SqlDbType.Int, ObjCreateNewOpportunity.CABINS_REQUIRED);

                db.AddInParameter(cd, "@in_LaptopsRequired", SqlDbType.Int, ObjCreateNewOpportunity.LAPTOPS_REQUIRED);

                db.AddInParameter(cd, "@in_Comp1", SqlDbType.VarChar, ObjCreateNewOpportunity.COMPETITOR_1);

                db.AddInParameter(cd, "@in_Comp2", SqlDbType.VarChar, ObjCreateNewOpportunity.COMPETITOR_2);

                db.AddInParameter(cd, "@in_Comp3", SqlDbType.VarChar, ObjCreateNewOpportunity.COMPETITOR_3);

                db.AddInParameter(cd, "@in_Comp4", SqlDbType.VarChar, ObjCreateNewOpportunity.COMPETITOR_4);

                db.AddInParameter(cd, "@in_Comp5", SqlDbType.VarChar, ObjCreateNewOpportunity.COMPETITOR_5);

                db.AddInParameter(cd, "@in_AdvisoryId", SqlDbType.Int, ObjCreateNewOpportunity.ADVISORY_ID);

                db.AddInParameter(cd, "@iv_Platform", SqlDbType.VarChar, ObjCreateNewOpportunity.PLATFORM);

                db.AddInParameter(cd, "@in_PIBSTCV", SqlDbType.VarChar, ObjCreateNewOpportunity.PibsSaleValue);

                db.AddInParameter(cd, "@iv_NextStep", SqlDbType.VarChar, ObjCreateNewOpportunity.NextStep);

                db.AddInParameter(cd, "@in_BusinessId", SqlDbType.Int, ObjCreateNewOpportunity.BUSINESS_ID);

                db.AddInParameter(cd, "@in_ProductId", SqlDbType.Int, ObjCreateNewOpportunity.PRODUCT_ID);

                db.AddInParameter(cd, "@in_CompetencyId", SqlDbType.Int, ObjCreateNewOpportunity.COMPETENCY_ID);

                db.AddInParameter(cd, "@in_SubCompetencyId", SqlDbType.Int, ObjCreateNewOpportunity.SUB_COMPETENCY_ID);

                db.AddInParameter(cd, "@in_AnnualSaleValue", SqlDbType.Decimal, ObjCreateNewOpportunity.AnnualSaleValue);

                db.AddInParameter(cd, "@iv_AccountSalesOwner", SqlDbType.VarChar, ObjCreateNewOpportunity.AccountSalesOwner);

                db.AddInParameter(cd, "@iv_ExeSponser", SqlDbType.VarChar, ObjCreateNewOpportunity.ExeSponser);

                db.AddInParameter(cd, "@iv_ValBPSCon", SqlDbType.VarChar, ObjCreateNewOpportunity.ValBPSCon);

                db.AddInParameter(cd, "@iv_ProactiveProposal", SqlDbType.VarChar, ObjCreateNewOpportunity.ProactiveProposal);

                db.AddInParameter(cd, "@iv_IsuMain", SqlDbType.VarChar, ObjCreateNewOpportunity.IsuMain);

                db.AddInParameter(cd, "@iv_PlatformNew", SqlDbType.VarChar, ObjCreateNewOpportunity.PlatformNew);

                db.AddInParameter(cd, "@iv_StatusUpdate", SqlDbType.VarChar, ObjCreateNewOpportunity.StatusUpdate);

                db.AddInParameter(cd, "@in_CategoryId", SqlDbType.Int, ObjCreateNewOpportunity.Category_Id);

                db.AddInParameter(cd, "@in_CountryId", SqlDbType.Int, ObjCreateNewOpportunity.CountryId);

                db.AddInParameter(cd, "@in_NextStepDueDt", SqlDbType.Int, ObjCreateNewOpportunity.NextStepDueDt);

                db.AddInParameter(cd, "@in_OffFTE  ", SqlDbType.Int, ObjCreateNewOpportunity.FTEOff);

                db.AddInParameter(cd, "@in_OnFTE  ", SqlDbType.Int, ObjCreateNewOpportunity.FTEOn);

                db.AddInParameter(cd, "@iv_ISUOwner", SqlDbType.VarChar, ObjCreateNewOpportunity.ISU_OWNER_ID);

                db.AddInParameter(cd, "@in_UnitID", SqlDbType.Int, ObjCreateNewOpportunity.UnitId);

                db.AddInParameter(cd, "@iv_ISU", SqlDbType.VarChar, ObjCreateNewOpportunity.ISU_CD);

                db.AddInParameter(cd, "@iv_KeyRmk", SqlDbType.VarChar, ObjCreateNewOpportunity.KeyRmk);

                db.AddInParameter(cd, "@iv_PIBS", SqlDbType.VarChar, ObjCreateNewOpportunity.PIBS);

                db.AddInParameter(cd, "@iv_TCS_INVESTMENT", SqlDbType.VarChar, ObjCreateNewOpportunity.TCSInvestment);

                db.AddInParameter(cd, "@in_PIBStartDate", SqlDbType.Int, ObjCreateNewOpportunity.PIBStartDate);

                db.AddInParameter(cd, "@in_PIBEndDate", SqlDbType.Int, ObjCreateNewOpportunity.PIBSEndDate);

                db.AddInParameter(cd, "@in_NoOfFTEsEngaged", SqlDbType.Int, ObjCreateNewOpportunity.FTEsEngaged);

                db.AddInParameter(cd, "@in_PIBStatus", SqlDbType.Int, ObjCreateNewOpportunity.PIBStatus);

                db.AddInParameter(cd, "@in_PIBSOutcome", SqlDbType.Int, ObjCreateNewOpportunity.PIBS_OUTCOME_ID);

                db.AddInParameter(cd, "@iv_PIBStatusRemarks", SqlDbType.VarChar, ObjCreateNewOpportunity.PIBStatusRemarks);

                db.AddInParameter(cd, "@iv_FTEType", SqlDbType.VarChar, ObjCreateNewOpportunity.FTE_TYPE);

                db.AddInParameter(cd, "@in_FTETypeCount", SqlDbType.Int, ObjCreateNewOpportunity.FTE_TYPE_COUNT);

                db.AddInParameter(cd, "@in_BPODomain", SqlDbType.Int, ObjCreateNewOpportunity.BPODomain);

                db.AddInParameter(cd, "@iv_DomainPresalesLead", SqlDbType.VarChar, ObjCreateNewOpportunity.DOMAIN_PRESALES_LEAD);

                db.AddInParameter(cd, "@in_DealCategory", SqlDbType.Int, ObjCreateNewOpportunity.DealCategory);

                db.AddInParameter(cd, "@in_BPSSubSPID", SqlDbType.Int, ObjCreateNewOpportunity.BPSSubSPID);

                db.AddInParameter(cd, "@in_BPSOfferingID", SqlDbType.Int, ObjCreateNewOpportunity.BPSOfferingID);

                db.AddInParameter(cd, "@iv_DealCoachName", SqlDbType.VarChar, ObjCreateNewOpportunity.DealCoachName);

                db.AddInParameter(cd, "@in_DemandType", SqlDbType.Int, ObjCreateNewOpportunity.DemandType);

                db.AddInParameter(cd, "@iv_KeyDeal", SqlDbType.VarChar, ObjCreateNewOpportunity.KEY_DEAL);

                db.AddInParameter(cd, "@iv_ProposedSolution", SqlDbType.VarChar, ObjCreateNewOpportunity.ProposedSolution);

                db.AddInParameter(cd, "@iv_WinningTeam", SqlDbType.VarChar, ObjCreateNewOpportunity.WinningTheme);

                db.AddInParameter(cd, "@iv_KeyCustExp", SqlDbType.VarChar, ObjCreateNewOpportunity.KeyCustExp);

                db.AddInParameter(cd, "@iv_OperatingModel", SqlDbType.VarChar, ObjCreateNewOpportunity.OPERATING_MODEL);

                db.AddInParameter(cd, "@iv_PricingModel", SqlDbType.VarChar, ObjCreateNewOpportunity.PRICING_MODEL);

                db.AddInParameter(cd, "@iv_Differentiators", SqlDbType.VarChar, ObjCreateNewOpportunity.Differentiators);

                db.AddInParameter(cd, "@iv_Risks", SqlDbType.VarChar, ObjCreateNewOpportunity.Risks);

                db.AddInParameter(cd, "@iv_KeyCustomerConnects", SqlDbType.VarChar, ObjCreateNewOpportunity.KeyCustomerConnects);

                db.AddInParameter(cd, "@iv_BPOOfferingDescription", SqlDbType.VarChar, ObjCreateNewOpportunity.BPOOfferingDescription);

                db.AddInParameter(cd, "@iv_FirstTimeOutsource", SqlDbType.VarChar, ObjCreateNewOpportunity.FIRST_TIME_OUTSOURCE);

                db.AddInParameter(cd, "@iv_Incumbents", SqlDbType.VarChar, ObjCreateNewOpportunity.INCUMBENTS);

                db.AddInParameter(cd, "@iv_NameOfIncumbents", SqlDbType.VarChar, ObjCreateNewOpportunity.NAME_OF_INCUMBENTS);

                db.AddInParameter(cd, "@iv_TCSOfferingCapability", SqlDbType.VarChar, ObjCreateNewOpportunity.TCS_OFFERING_CAPABILITY);

                db.AddInParameter(cd, "@iv_SpecifyOffering", SqlDbType.VarChar, ObjCreateNewOpportunity.SpecifyOffering);

                db.AddInParameter(cd, "@iv_CoachAvailable", SqlDbType.VarChar, ObjCreateNewOpportunity.CoachAvailable);

                db.AddInParameter(cd, "@iv_FnA", SqlDbType.VarChar, ObjCreateNewOpportunity.FnA);

                db.AddInParameter(cd, "@in_Fna_FTE", SqlDbType.Int, ObjCreateNewOpportunity.FnA_FTE);

                db.AddInParameter(cd, "@iv_HRO", SqlDbType.VarChar, ObjCreateNewOpportunity.HRO);

                db.AddInParameter(cd, "@in_HRO_FTE", SqlDbType.Int, ObjCreateNewOpportunity.HRO_FTE);

                db.AddInParameter(cd, "@iv_SCM", SqlDbType.VarChar, ObjCreateNewOpportunity.SCM);

                db.AddInParameter(cd, "@in_SCM_FTE", SqlDbType.Int, ObjCreateNewOpportunity.SCM_FTE);

                db.AddInParameter(cd, "@iv_KPO", SqlDbType.VarChar, ObjCreateNewOpportunity.KPO);

                db.AddInParameter(cd, "@in_KPO_FTE", SqlDbType.Int, ObjCreateNewOpportunity.KPO_FTE);

                db.AddInParameter(cd, "@iv_LPO", SqlDbType.VarChar, ObjCreateNewOpportunity.LPO);

                db.AddInParameter(cd, "@in_LPO_FTE", SqlDbType.Int, ObjCreateNewOpportunity.LPO_FTE);

                db.AddInParameter(cd, "@iv_Vertical", SqlDbType.VarChar, ObjCreateNewOpportunity.VERTICAL);

                db.AddInParameter(cd, "@in_Vertical_FTE", SqlDbType.Int, ObjCreateNewOpportunity.VerticalFTE);

                db.AddInParameter(cd, "@iv_Voice", SqlDbType.VarChar, ObjCreateNewOpportunity.Voice);

                db.AddInParameter(cd, "@in_Voice_FTE", SqlDbType.Int, ObjCreateNewOpportunity.VoiceFTE);

                db.AddInParameter(cd, "@iv_Bpm", SqlDbType.VarChar, ObjCreateNewOpportunity.BPM);

                db.AddInParameter(cd, "@in_Bpm_FTE", SqlDbType.Int, ObjCreateNewOpportunity.BPM_FTE);

                db.AddInParameter(cd, "@in_SolTM", SqlDbType.Int, ObjCreateNewOpportunity.SolTM);

                db.AddInParameter(cd, "@in_DelTM", SqlDbType.Int, ObjCreateNewOpportunity.DelTM);

                db.AddInParameter(cd, "@iv_BidManager", SqlDbType.VarChar, ObjCreateNewOpportunity.BID_MANAGER);

                db.AddInParameter(cd, "@iv_BidExec", SqlDbType.VarChar, ObjCreateNewOpportunity.BID_EXEC_OWNER);

                db.AddInParameter(cd, "@iv_PricingOwner", SqlDbType.VarChar, ObjCreateNewOpportunity.PRICING_OWNER);

                db.AddInParameter(cd, "@in_TransitionTeam", SqlDbType.Int, ObjCreateNewOpportunity.TransitionTeam);

                db.AddInParameter(cd, "@iv_ExpectedDate", SqlDbType.Int, ObjCreateNewOpportunity.ExpectedDate);

                db.AddInParameter(cd, "@iv_TransitionReq", SqlDbType.VarChar, ObjCreateNewOpportunity.TransitionReq);

                db.AddInParameter(cd, "@iv_Entity", SqlDbType.VarChar, ObjCreateNewOpportunity.ENTITY);

                db.AddInParameter(cd, "@iv_Quarter", SqlDbType.VarChar, ObjCreateNewOpportunity.Quarter);

                db.AddInParameter(cd, "@iv_FiscalYear", SqlDbType.VarChar, ObjCreateNewOpportunity.FiscalYear);

                db.AddInParameter(cd, "@iv_CurrentlyActive", SqlDbType.VarChar, ObjCreateNewOpportunity.CURRENTLY_ACTIVE);

                db.AddInParameter(cd, "@in_Seat_Requirements", SqlDbType.Int, ObjCreateNewOpportunity.SeatRequirements);

                db.AddInParameter(cd, "@iv_ImmediateComment", SqlDbType.VarChar, ObjCreateNewOpportunity.ImmediateComment);

                db.AddInParameter(cd, "@iv_FTEDD", SqlDbType.VarChar, ObjCreateNewOpportunity.FTEDD);

                db.AddInParameter(cd, "@iv_SolutionLeader", SqlDbType.VarChar, ObjCreateNewOpportunity.SolutionLeader);

                db.AddInParameter(cd, "@iv_RUR", SqlDbType.VarChar, ObjCreateNewOpportunity.RUR);

                db.AddInParameter(cd, "@iv_HRT_Comments", SqlDbType.VarChar, ObjCreateNewOpportunity.HRTComments);

                db.AddInParameter(cd, "@iv_CRMId", SqlDbType.VarChar, ObjCreateNewOpportunity.CRM_ID);

                db.AddInParameter(cd, "@iv_ValueBPS", SqlDbType.VarChar, ObjCreateNewOpportunity.ValueBPS);

                db.AddInParameter(cd, "@in_ValueBPSTCV", SqlDbType.Decimal, ObjCreateNewOpportunity.ValueBPSTCV);

                db.AddInParameter(cd, "@iv_OppType", SqlDbType.VarChar, ObjCreateNewOpportunity.OPP_TYPE);

                db.AddInParameter(cd, "@iv_MultiTower", SqlDbType.VarChar, ObjCreateNewOpportunity.MultiTower);

                db.AddInParameter(cd, "@in_StatusFlag", SqlDbType.Int, ObjCreateNewOpportunity.StatusFlag);

                db.AddInParameter(cd, "@iv_Fna_Lead", SqlDbType.VarChar, ObjCreateNewOpportunity.FnA_Lead);

                db.AddInParameter(cd, "@iv_HRO_Lead", SqlDbType.VarChar, ObjCreateNewOpportunity.HRO_Lead);

                db.AddInParameter(cd, "@iv_SCM_Lead", SqlDbType.VarChar, ObjCreateNewOpportunity.SCM_Lead);

                db.AddInParameter(cd, "@iv_KPO_Lead", SqlDbType.VarChar, ObjCreateNewOpportunity.KPO_Lead);

                db.AddInParameter(cd, "@iv_LPO_Lead", SqlDbType.VarChar, ObjCreateNewOpportunity.LPO_Lead);

                db.AddInParameter(cd, "@iv_Vertical_Lead", SqlDbType.VarChar, ObjCreateNewOpportunity.VERTICAL_LEAD);

                db.AddInParameter(cd, "@iv_Voice_Lead", SqlDbType.VarChar, ObjCreateNewOpportunity.Voice_Lead);

                db.AddInParameter(cd, "@iv_Bpm_Lead", SqlDbType.VarChar, ObjCreateNewOpportunity.BPM_LEAD);

                db.AddInParameter(cd, "@iv_BidManagerId", SqlDbType.VarChar, ObjCreateNewOpportunity.BID_MANAGER_EMPID);

                db.AddInParameter(cd, "@iv_BidExecId", SqlDbType.VarChar, ObjCreateNewOpportunity.BID_EXEC_OWNER_EMPID);

                db.AddInParameter(cd, "@iv_FnaTCV", SqlDbType.VarChar, ObjCreateNewOpportunity.FnATCV);

                db.AddInParameter(cd, "@iv_HROTCV", SqlDbType.VarChar, ObjCreateNewOpportunity.HROTCV);

                db.AddInParameter(cd, "@iv_SCMTCV", SqlDbType.VarChar, ObjCreateNewOpportunity.SCMTCV);

                db.AddInParameter(cd, "@iv_KPOTCV", SqlDbType.VarChar, ObjCreateNewOpportunity.KPOTCV);

                db.AddInParameter(cd, "@iv_LPOTCV", SqlDbType.VarChar, ObjCreateNewOpportunity.LPOTCV);

                db.AddInParameter(cd, "@iv_VerticalTCV", SqlDbType.VarChar, ObjCreateNewOpportunity.VERTICALTCV);

                db.AddInParameter(cd, "@iv_VoiceTCV", SqlDbType.VarChar, ObjCreateNewOpportunity.VOICETCV);

                db.AddInParameter(cd, "@iv_BpmTCV", SqlDbType.VarChar, ObjCreateNewOpportunity.BPMTCV);

                db.AddInParameter(cd, "@in_ClusterId", SqlDbType.Int, ObjCreateNewOpportunity.ClusterId);

                db.AddInParameter(cd, "@in_ServiceId", SqlDbType.Int, ObjCreateNewOpportunity.ServiceId);

                db.AddInParameter(cd, "@in_SUBIOU", SqlDbType.VarChar, ObjCreateNewOpportunity.SUBIOU);

                db.AddInParameter(cd, "@in_strTransitionEmpId", SqlDbType.VarChar, ObjCreateNewOpportunity.TransitionEmpId);

                db.AddInParameter(cd, "@in_strTransitionName", SqlDbType.VarChar, ObjCreateNewOpportunity.TransitionName);

                db.AddInParameter(cd, "@in_strTransitionType", SqlDbType.VarChar, ObjCreateNewOpportunity.TransitionType);

                db.AddInParameter(cd, "@in_strTransitionApproach", SqlDbType.VarChar, ObjCreateNewOpportunity.TransitionApproach);

                db.AddInParameter(cd, "@in_strTransitionModel", SqlDbType.VarChar, ObjCreateNewOpportunity.TransitionModel);

                db.AddInParameter(cd, "@in_strProposalfactory", SqlDbType.VarChar, ObjCreateNewOpportunity.Proposalfactory);

                db.AddInParameter(cd, "@in_strProposalfactoryOptions", SqlDbType.VarChar, ObjCreateNewOpportunity.ProposalfactoryOptions);

                db.AddInParameter(cd, "@in_strProposalComments", SqlDbType.VarChar, ObjCreateNewOpportunity.ProposalComments);

                db.AddInParameter(cd, "@iv_DTValue", SqlDbType.VarChar, ObjCreateNewOpportunity.DTValue);

                db.AddInParameter(cd, "@iv_OtherDT", SqlDbType.VarChar, ObjCreateNewOpportunity.Other_DT);

                db.AddInParameter(cd, "@in_CRMTCV", SqlDbType.VarChar, ObjCreateNewOpportunity.CRM_TCV);

                db.AddInParameter(cd, "@in_CRMStage", SqlDbType.Int, ObjCreateNewOpportunity.CRM_STAGE);

                db.AddInParameter(cd, "@in_TGA", SqlDbType.VarChar, ObjCreateNewOpportunity.TataGroupAccount);

                db.AddInParameter(cd, "@in_TPA", SqlDbType.VarChar, ObjCreateNewOpportunity.TPA);

                db.AddInParameter(cd, "@in_TPA_Name", SqlDbType.VarChar, ObjCreateNewOpportunity.TPA_Name);

                db.AddInParameter(cd, "@in_ItisScope", SqlDbType.VarChar, ObjCreateNewOpportunity.ItisScope);

                db.AddInParameter(cd, "@in_IsContractRenewal", SqlDbType.VarChar, ObjCreateNewOpportunity.IsContractRenewal);

                db.AddInParameter(cd, "@in_ContractRenewalValue", SqlDbType.VarChar, ObjCreateNewOpportunity.ContractRenewalValue);

                db.AddInParameter(cd, "@iv_DigitalTCV", SqlDbType.VarChar, ObjCreateNewOpportunity.strDigitalTcv);

                db.AddInParameter(cd, "@in_SubSP", SqlDbType.Int, ObjCreateNewOpportunity.subSPId);

                db.AddInParameter(cd, "@in_CRMBeacon", SqlDbType.VarChar, ObjCreateNewOpportunity.CRM_Beacon);

                //changess

                db.AddInParameter(cd, "@in_ResourcingId", SqlDbType.Int, ObjCreateNewOpportunity.RESOURCING_ID);

                db.AddInParameter(cd, "@in_Seat_IdentificationId", SqlDbType.Int, ObjCreateNewOpportunity.SEAT_IDENTIFICATION_ID);
                db.AddInParameter(cd, "@DealStatus_Id", SqlDbType.Int, ObjCreateNewOpportunity.DealStatus);
                db.AddInParameter(cd, "@ServicePractice_Id", SqlDbType.Int, ObjCreateNewOpportunity.ServicePractice);
                db.AddInParameter(cd, "@CoreOffering_Id", SqlDbType.Int, ObjCreateNewOpportunity.CoreOffering);
                db.AddInParameter(cd, "@in_modernisedOfferingId", SqlDbType.Int, ObjCreateNewOpportunity.ModernisedOffering);
                db.AddInParameter(cd, "@in_cognitiveSolutionId", SqlDbType.Int, ObjCreateNewOpportunity.CognitiveSolutions);
                db.AddInParameter(cd, "@in_offerings", SqlDbType.VarChar, ObjCreateNewOpportunity.Offerings);
                db.AddInParameter(cd, "@in_Opportunity_Desc_Details", SqlDbType.VarChar, ObjCreateNewOpportunity.OpportunityDescDetails);

                db.AddInParameter(cd, "@in_proposalSubmissionDate", SqlDbType.VarChar, ObjCreateNewOpportunity.PROPOSAL_SUBMISSION_DATE);

                db.AddInParameter(cd, "@in_salesStageMovedOnDate", SqlDbType.VarChar, ObjCreateNewOpportunity.SALES_STAGE_MOVED_ONDATE);

                db.AddInParameter(cd, "@iv_deliveryLocationProposed", SqlDbType.VarChar, ObjCreateNewOpportunity.DELIVERY_LOCATION_PROPOSED);

                db.AddInParameter(cd, "@OfferingType_Id", SqlDbType.Int, ObjCreateNewOpportunity.offeringType);
                db.AddInParameter(cd, "@CoreOfferingName_Id", SqlDbType.Int, ObjCreateNewOpportunity.CofID);
                db.AddInParameter(cd, "@iv_IgnioTMscope", SqlDbType.VarChar, ObjCreateNewOpportunity.IgnioTMScope);
                db.AddInParameter(cd, "@iv_IgnioTMscopeDetail", SqlDbType.VarChar, ObjCreateNewOpportunity.IgnioTMScopeDetails);
                db.AddInParameter(cd, "@iv_DigitalFlagging", SqlDbType.VarChar, ObjCreateNewOpportunity.DigitalFlagging);
                db.AddInParameter(cd, "@cboioffering", SqlDbType.VarChar, ObjCreateNewOpportunity.Cboi_Offering_id);
                db.AddInParameter(cd, "@dealflag", SqlDbType.VarChar, ObjCreateNewOpportunity.Deal_Flag_id);
                db.AddOutParameter(cd, "@on_Result", SqlDbType.Int, Int16.MaxValue);

                db.ExecuteNonQuery(cd);

                on_Result = db.GetParameterValue(cd, "@on_Result").ToString();

                strResult.Add(new CreateNewOpportunity()

                {

                    on_Result = db.GetParameterValue(cd, "@on_Result").ToString()



                });

            }

            catch (InvalidOperationException ex)
            {

                throw new DatabaseException(ex);

            }

            catch (ArgumentException ex)
            {

                throw new DatabaseException(ex);

            }

            return strResult;

        }
        /// <summary>
        /// Get Del_TM Details
        /// </summary>
        public List<CreateNewOpportunity> GetDel_TM_Dtls(string oppID)
        {
            DataSet ds = null;
            List<CreateNewOpportunity> modelList = new List<CreateNewOpportunity>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Get_Del_TM_Dtls);
                db.AddInParameter(cd, "@iv_OppID", SqlDbType.VarChar, oppID);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;

                        for (int i = 0; i < rowCount; i++)
                        {
                            modelList.Add(MapGet_Del_TM_Dtls(ds.Tables[0].Rows[i]));
                        }

                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }
            return modelList;
        }
        private static CreateNewOpportunity MapGet_Del_TM_Dtls(DataRow dr)
        {
            try
            {
                return new CreateNewOpportunity()
                {
                    OpportunityId = (dr.Table.Columns.Contains("OPPORTUNITY_ID")) ? (dr["OPPORTUNITY_ID"] == DBNull.Value) ? "" : Convert.ToString(dr["OPPORTUNITY_ID"]) : "",
                    TM_DEL_EMP_NO = (dr.Table.Columns.Contains("TM_DEL_EMP_NO")) ? (dr["TM_DEL_EMP_NO"] == DBNull.Value) ? "" : dr.Field<string>("TM_DEL_EMP_NO") : "",
                    TM_DEL_EMP_NAME = (dr.Table.Columns.Contains("TM_DEL_EMP_NAME")) ? (dr["TM_DEL_EMP_NAME"] == DBNull.Value) ? "" : dr.Field<string>("TM_DEL_EMP_NAME") : "",
                };
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
        }
        /// <summary>
        /// Get GetRecruitment Stage8 Details
        /// </summary>
        public List<CreateNewOpportunity> Get_stage8(int opportunityId, int stageId)
        {
            DataSet ds = null;
            List<CreateNewOpportunity> modelList = new List<CreateNewOpportunity>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.GetRecruitment_Stage8_sp);
                db.AddInParameter(cd, "@in_OpportunityId", SqlDbType.VarChar, opportunityId);
                db.AddInParameter(cd, "@in_StageId", SqlDbType.Int, stageId);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;

                        for (int i = 0; i < rowCount; i++)
                        {
                            modelList.Add(MapReqPopulate_Get_stage8(ds.Tables[0].Rows[i]));
                        }

                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }
            return modelList;
        }
        private CreateNewOpportunity MapReqPopulate_Get_stage8(DataRow dr)
        {
            try
            {
                return new CreateNewOpportunity()
                {

                    OpportunityId = (dr.Table.Columns.Contains("OPPORTUNITY_ID")) ? (dr["OPPORTUNITY_ID"] == DBNull.Value) ? "" : Convert.ToString(dr["OPPORTUNITY_ID"]) : "",
                    OPPORTUNITY_DESC = (dr.Table.Columns.Contains("OPPORTUNITY_DESC")) ? (dr["OPPORTUNITY_DESC"] == DBNull.Value) ? "" : dr.Field<string>("OPPORTUNITY_DESC") : "",
                    OLD_OPPORTUNITY_DESC = (dr.Table.Columns.Contains("OLD_OPPORTUNITY_DESC")) ? (dr["OLD_OPPORTUNITY_DESC"] == DBNull.Value) ? "" : dr.Field<string>("OLD_OPPORTUNITY_DESC") : "",
                    GEOGRAPHY_ID = (dr.Table.Columns.Contains("GEOGRAPHY_ID")) ? (dr["GEOGRAPHY_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["GEOGRAPHY_ID"]) : 0,
                    GEOGRAPHY_NAME = (dr.Table.Columns.Contains("GEOGRAPHY_NAME")) ? (dr["GEOGRAPHY_NAME"] == DBNull.Value) ? "" : dr.Field<string>("GEOGRAPHY_NAME") : "",
                    CUST_ID = (dr.Table.Columns.Contains("CUST_ID")) ? (dr["CUST_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CUST_ID"]) : 0,
                    CUST_NAME = (dr.Table.Columns.Contains("CUST_NAME")) ? (dr["CUST_NAME"] == DBNull.Value) ? "" : dr.Field<string>("CUST_NAME") : "",
                    CUST_TYPE_ID = (dr.Table.Columns.Contains("CUST_TYPE_ID")) ? (dr["CUST_TYPE_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CUST_TYPE_ID"]) : 0,
                    CUST_TYPE_NAME = (dr.Table.Columns.Contains("CUST_TYPE_NAME")) ? (dr["CUST_TYPE_NAME"] == DBNull.Value) ? "" : dr.Field<string>("CUST_TYPE_NAME") : "",
                    INDUSTRY_PRACTICE_ID = (dr.Table.Columns.Contains("INDUSTRY_PRACTICE_ID")) ? (dr["INDUSTRY_PRACTICE_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["INDUSTRY_PRACTICE_ID"]) : 0,
                    StageID = (dr.Table.Columns.Contains("STAGE_ID")) ? (dr["STAGE_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["STAGE_ID"]) : 0,
                    INDUSTRY_PRACTICE_NAME = (dr.Table.Columns.Contains("INDUSTRY_PRACTICE_NAME")) ? (dr["INDUSTRY_PRACTICE_NAME"] == DBNull.Value) ? "" : dr.Field<string>("INDUSTRY_PRACTICE_NAME") : "",
                    STAGE_NAME = (dr.Table.Columns.Contains("STAGE_NAME")) ? (dr["STAGE_NAME"] == DBNull.Value) ? "" : dr.Field<string>("STAGE_NAME") : "",
                    ISU_CD = (dr.Table.Columns.Contains("ISU_CD")) ? (dr["ISU_CD"] == DBNull.Value) ? "" : dr.Field<string>("ISU_CD") : "",
                    ISU_NAME = (dr.Table.Columns.Contains("ISU_NAME")) ? (dr["ISU_NAME"] == DBNull.Value) ? "" : dr.Field<string>("ISU_NAME") : "",
                    GEOGRAPHY_SALES_OWNER = (dr.Table.Columns.Contains("GEOGRAPHY_SALES_OWNER_ID")) ? (dr["GEOGRAPHY_SALES_OWNER_ID"] == DBNull.Value) ? "" : dr.Field<string>("GEOGRAPHY_SALES_OWNER_ID") : "",
                    ONSITE_OWNER = (dr.Table.Columns.Contains("ONSITE_OWNER_ID")) ? (dr["ONSITE_OWNER_ID"] == DBNull.Value) ? "" : dr.Field<string>("ONSITE_OWNER_ID") : "",
                    OFFSHORE_BD_LEAD = (dr.Table.Columns.Contains("OFFSHORE_BD_LEAD_ID")) ? (dr["OFFSHORE_BD_LEAD_ID"] == DBNull.Value) ? "" : dr.Field<string>("OFFSHORE_BD_LEAD_ID") : "",
                    OPPORTUNITY_DATE = (dr.Table.Columns.Contains("OPPORTUNITY_DATE")) ? (dr["OPPORTUNITY_DATE"] == DBNull.Value) ? "" : dr.Field<string>("OPPORTUNITY_DATE") : "",
                    DEAL_CLOSURE_EXP_DATE = (dr.Table.Columns.Contains("DEAL_CLOSURE_EXP_DATE")) ? (dr["DEAL_CLOSURE_EXP_DATE"] == DBNull.Value) ? "" : dr.Field<string>("DEAL_CLOSURE_EXP_DATE") : "",
                    DTOTAL_CONTRACT_VALUE = (dr.Table.Columns.Contains("TOTAL_CONTRACT_VALUE")) ? (dr["TOTAL_CONTRACT_VALUE"] == DBNull.Value) ? 0 : Convert.ToDouble(dr["TOTAL_CONTRACT_VALUE"]) : 0,
                    BUSINESS_ID = (dr.Table.Columns.Contains("BUSINESS_ID")) ? (dr["BUSINESS_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["BUSINESS_ID"]) : 0,
                    COUNTRY_ID = (dr.Table.Columns.Contains("COUNTRY_ID")) ? (dr["COUNTRY_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["COUNTRY_ID"]) : 0,
                    PIBS = (dr.Table.Columns.Contains("PIBS")) ? (dr["PIBS"] == DBNull.Value) ? "" : dr.Field<string>("PIBS") : "",
                    CRM_ID = (dr.Table.Columns.Contains("CRM_ID")) ? (dr["CRM_ID"] == DBNull.Value) ? "" : dr.Field<string>("CRM_ID") : "",
                    VALUE_BPS = (dr.Table.Columns.Contains("VALUE_BPS")) ? (dr["VALUE_BPS"] == DBNull.Value) ? "" : dr.Field<string>("VALUE_BPS") : "",
                    VALUE_BPS_TCV = (dr.Table.Columns.Contains("VALUE_BPS_TCV")) ? (dr["VALUE_BPS_TCV"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["VALUE_BPS_TCV"]) : 0,
                    OPP_TYPE = (dr.Table.Columns.Contains("OPP_TYPE")) ? (dr["OPP_TYPE"] == DBNull.Value) ? "" : dr.Field<string>("OPP_TYPE") : "",
                    IESTIMATED_FTE_SIZE = (dr.Table.Columns.Contains("ESTIMATED_FTE_SIZE")) ? (dr["ESTIMATED_FTE_SIZE"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["ESTIMATED_FTE_SIZE"]) : 0,
                    ContractLength = (dr.Table.Columns.Contains("CONTRACT_LENGTH")) ? (dr["CONTRACT_LENGTH"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CONTRACT_LENGTH"]) : 0,
                    ISU_OWNER_ID = (dr.Table.Columns.Contains("ISU_OWNER_ID")) ? (dr["ISU_OWNER_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["ISU_OWNER_ID"]) : 0,
                    ACCOUNT_SALES_OWNER_ID = (dr.Table.Columns.Contains("ACCOUNT_SALES_OWNER_ID")) ? (dr["ACCOUNT_SALES_OWNER_ID"] == DBNull.Value) ? "" : dr.Field<string>("ACCOUNT_SALES_OWNER_ID") : "",
                    GEOGRAPHY_SALES_OWNER_ID = (dr.Table.Columns.Contains("GEOGRAPHY_SALES_OWNER_ID")) ? (dr["GEOGRAPHY_SALES_OWNER_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["GEOGRAPHY_SALES_OWNER_ID"]) : 0,
                    OFFSHORE_BD_LEAD_ID = (dr.Table.Columns.Contains("OFFSHORE_BD_LEAD_ID")) ? (dr["OFFSHORE_BD_LEAD_ID"] == DBNull.Value) ? "" : dr.Field<string>("OFFSHORE_BD_LEAD_ID") : "",
                    LAST_UPDATE = (dr.Table.Columns.Contains("LAST_UPDATE")) ? (dr["LAST_UPDATE"] == DBNull.Value) ? "" : dr.Field<string>("LAST_UPDATE") : "",
                    DEAL_BD_LEAD_ID = (dr.Table.Columns.Contains("DEAL_BD_LEAD_ID")) ? (dr["DEAL_BD_LEAD_ID"] == DBNull.Value) ? "" : dr.Field<string>("DEAL_BD_LEAD_ID") : "",
                    DEAL_BD_LEAD_ID2 = (dr.Table.Columns.Contains("DEAL_BD_LEAD_ID2")) ? (dr["DEAL_BD_LEAD_ID2"] == DBNull.Value) ? "" : dr.Field<string>("DEAL_BD_LEAD_ID2") : "",
                    RFI_ReviewDate = (dr.Table.Columns.Contains("RFI_REVIEW_DT")) ? (dr["RFI_REVIEW_DT"] == DBNull.Value) ? "" : dr.Field<string>("RFI_REVIEW_DT") : "",
                    RFP_ReviewDate = (dr.Table.Columns.Contains("RFP_REVIEW_DT")) ? (dr["RFP_REVIEW_DT"] == DBNull.Value) ? "" : dr.Field<string>("RFP_REVIEW_DT") : "",
                    RFI_ReceivedDate = (dr.Table.Columns.Contains("RFI_RECEIVED_DT")) ? (dr["RFI_RECEIVED_DT"] == DBNull.Value) ? "" : dr.Field<string>("RFI_RECEIVED_DT") : "",
                    RFP_ReceivedDate = (dr.Table.Columns.Contains("RFP_RECEIVED_DT")) ? (dr["RFP_RECEIVED_DT"] == DBNull.Value) ? "" : dr.Field<string>("RFP_RECEIVED_DT") : "",
                    RFI_ProbableSubmissionDate = (dr.Table.Columns.Contains("RFI_PROBABLE_SUBMISSION_DT")) ? (dr["RFI_PROBABLE_SUBMISSION_DT"] == DBNull.Value) ? "" : dr.Field<string>("RFI_PROBABLE_SUBMISSION_DT") : "",
                    RFP_ProbableSubmissionDate = (dr.Table.Columns.Contains("RFP_PROBABLE_SUBMISSION_DT")) ? (dr["RFP_PROBABLE_SUBMISSION_DT"] == DBNull.Value) ? "" : dr.Field<string>("RFP_PROBABLE_SUBMISSION_DT") : "",
                    RFI_ActualSubmissionDate = (dr.Table.Columns.Contains("RFI_ACTUAL_SUBMISSION_DT")) ? (dr["RFI_ACTUAL_SUBMISSION_DT"] == DBNull.Value) ? "" : dr.Field<string>("RFI_ACTUAL_SUBMISSION_DT") : "",
                    RFP_ActualSubmissionDate = (dr.Table.Columns.Contains("RFP_ACTUAL_SUBMISSION_DT")) ? (dr["RFP_ACTUAL_SUBMISSION_DT"] == DBNull.Value) ? "" : dr.Field<string>("RFP_ACTUAL_SUBMISSION_DT") : "",
                    BCP_DRP_LOCATION = (dr.Table.Columns.Contains("BCP_DRP_LOCATION")) ? (dr["BCP_DRP_LOCATION"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["BCP_DRP_LOCATION"]) : 0,
                    RFI_REVIEW_BY = (dr.Table.Columns.Contains("RFI_REVIEW_BY")) ? (dr["RFI_REVIEW_BY"] == DBNull.Value) ? "" : dr.Field<string>("RFI_REVIEW_BY") : "",
                    RFP_REVIEW_BY = (dr.Table.Columns.Contains("RFP_REVIEW_BY")) ? (dr["RFP_REVIEW_BY"] == DBNull.Value) ? "" : dr.Field<string>("RFP_REVIEW_BY") : "",
                    CURRENCY_ID = (dr.Table.Columns.Contains("CURRENCY_ID")) ? (dr["CURRENCY_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CURRENCY_ID"]) : 0,
                    FTEOff = (dr.Table.Columns.Contains("FTE_OFFSHORE")) ? (dr["FTE_OFFSHORE"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["FTE_OFFSHORE"]) : 0,
                    FTEOn = (dr.Table.Columns.Contains("FTE_ONSITE")) ? (dr["FTE_ONSITE"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["FTE_ONSITE"]) : 0,
                    ClusterId = (dr.Table.Columns.Contains("CLUSTER_ID")) ? (dr["CLUSTER_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CLUSTER_ID"]) : 0,
                    DealCategory = (dr.Table.Columns.Contains("DEAL_CATEGORY")) ? (dr["DEAL_CATEGORY"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["DEAL_CATEGORY"]) : 0,
                    BPS_OFFERING_ID = (dr.Table.Columns.Contains("BPS_OFFERING_ID")) ? (dr["BPS_OFFERING_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["BPS_OFFERING_ID"]) : 0,
                    SERVICE_ID = (dr.Table.Columns.Contains("SERVICE_ID")) ? (dr["SERVICE_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["SERVICE_ID"]) : 0,
                    SUB_IOU = (dr.Table.Columns.Contains("SUB_IOU")) ? (dr["SUB_IOU"] == DBNull.Value) ? "" : dr.Field<string>("SUB_IOU") : "",
                    EXECUTIVE_SPONSOR = (dr.Table.Columns.Contains("EXECUTIVE_SPONSOR")) ? (dr["EXECUTIVE_SPONSOR"] == DBNull.Value) ? "" : dr.Field<string>("EXECUTIVE_SPONSOR") : "",
                    VALBPS_CON = (dr.Table.Columns.Contains("VALBPS_CON")) ? (dr["VALBPS_CON"] == DBNull.Value) ? "" : dr.Field<string>("VALBPS_CON") : "",
                    PROACTIVE_PROPOSAL = (dr.Table.Columns.Contains("PROACTIVE_PROPOSAL")) ? (dr["PROACTIVE_PROPOSAL"] == DBNull.Value) ? "" : dr.Field<string>("PROACTIVE_PROPOSAL") : "",
                    ISU_MAIN = (dr.Table.Columns.Contains("ISU_MAIN")) ? (dr["ISU_MAIN"] == DBNull.Value) ? "" : dr.Field<string>("ISU_MAIN") : "",
                    Quarter = (dr.Table.Columns.Contains("quarter")) ? (dr["quarter"] == DBNull.Value) ? "" : dr.Field<string>("quarter") : "",
                    FISCAL_YEAR = (dr.Table.Columns.Contains("FISCAL_YEAR")) ? (dr["FISCAL_YEAR"] == DBNull.Value) ? "" : dr.Field<string>("FISCAL_YEAR") : "",
                    PROPOSAL_FACTORY = (dr.Table.Columns.Contains("PROPOSAL_FACTORY")) ? (dr["PROPOSAL_FACTORY"] == DBNull.Value) ? "" : dr.Field<string>("PROPOSAL_FACTORY") : "",
                    PROPOSAL_FACTORY_OPTIONS = (dr.Table.Columns.Contains("PROPOSAL_FACTORY_OPTIONS")) ? (dr["PROPOSAL_FACTORY_OPTIONS"] == DBNull.Value) ? "" : dr.Field<string>("PROPOSAL_FACTORY_OPTIONS") : "",
                    PROPOSAL_FACTORY_COMMENTS = (dr.Table.Columns.Contains("PROPOSAL_FACTORY_COMMENTS")) ? (dr["PROPOSAL_FACTORY_COMMENTS"] == DBNull.Value) ? "" : dr.Field<string>("PROPOSAL_FACTORY_COMMENTS") : "",
                    DT_ID = (dr.Table.Columns.Contains("DT_ID")) ? (dr["DT_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["DT_ID"]) : 0,
                    Other_DT = (dr.Table.Columns.Contains("Other_DT")) ? (dr["Other_DT"] == DBNull.Value) ? "" : dr.Field<string>("Other_DT") : "",
                    CRM_TCV = (dr.Table.Columns.Contains("CRM_TCV")) ? (dr["CRM_TCV"] == DBNull.Value) ? "" : Convert.ToString(dr["CRM_TCV"]) : "",
                    CRM_STAGE = (dr.Table.Columns.Contains("CRM_STAGE")) ? (dr["CRM_STAGE"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CRM_STAGE"]) : 0,
                    strDigitalTcv = (dr.Table.Columns.Contains("Digital_TCV")) ? (dr["Digital_TCV"] == DBNull.Value) ? "" : dr.Field<string>("Digital_TCV") : "",
                    subSPId = (dr.Table.Columns.Contains("SubSPID")) ? (dr["SubSPID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["SubSPID"]) : 0,
                    CRM_Beacon = (dr.Table.Columns.Contains("CRM_Beacon")) ? (dr["CRM_Beacon"] == DBNull.Value) ? "" : Convert.ToString(dr["CRM_Beacon"]) : "",
                    MULTITOWER_DEAL = (dr.Table.Columns.Contains("MULTITOWER_DEAL")) ? (dr["MULTITOWER_DEAL"] == DBNull.Value) ? "" : dr.Field<string>("MULTITOWER_DEAL") : "",
                    TataGroupAccount = (dr.Table.Columns.Contains("TATA_GROUP_ACCOUNT")) ? (dr["TATA_GROUP_ACCOUNT"] == DBNull.Value) ? "" : Convert.ToString(dr["TATA_GROUP_ACCOUNT"]) : "",
                    ItisScope = (dr.Table.Columns.Contains("ItisScope")) ? (dr["ItisScope"] == DBNull.Value) ? "" : Convert.ToString(dr["ItisScope"]) : "",
                    IsContractRenewal = (dr.Table.Columns.Contains("IsContractRenewal")) ? (dr["IsContractRenewal"] == DBNull.Value) ? "" : Convert.ToString(dr["IsContractRenewal"]) : "",
                    ContractRenewalValue = (dr.Table.Columns.Contains("ContractRenewalValue")) ? (dr["ContractRenewalValue"] == DBNull.Value) ? "" : Convert.ToString(dr["ContractRenewalValue"]) : "",
                    RESOURCING_ID = (dr.Table.Columns.Contains("ResourcingId")) ? (dr["ResourcingId"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["ResourcingId"]) : 0,
                    SEAT_IDENTIFICATION_ID = (dr.Table.Columns.Contains("Seat_IdentificationId")) ? (dr["Seat_IdentificationId"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["Seat_IdentificationId"]) : 0,
                    SHORTLIST_DT = (dr.Table.Columns.Contains("SHORTLIST_DT")) ? (dr["SHORTLIST_DT"] == DBNull.Value) ? "" : Convert.ToString(dr["SHORTLIST_DT"]) : "",
                    SELECTION_DT = (dr.Table.Columns.Contains("SELECTION_DT")) ? (dr["SELECTION_DT"] == DBNull.Value) ? "" : Convert.ToString(dr["SELECTION_DT"]) : "",
                    ONSITE_TRAINING_NOS = (dr.Table.Columns.Contains("ONSITE_TRAINING_NOS")) ? (dr["ONSITE_TRAINING_NOS"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["ONSITE_TRAINING_NOS"]) : 0,
                    VISA_REQUIRED = (dr.Table.Columns.Contains("VISA_REQUIRED")) ? (dr["VISA_REQUIRED"] == DBNull.Value) ? "" : dr.Field<string>("VISA_REQUIRED") : "",
                    VISAS_REQUIRED = (dr.Table.Columns.Contains("VISAS_REQUIRED")) ? (dr["VISAS_REQUIRED"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["VISAS_REQUIRED"]) : 0,
                    TRAINING_DURATION = (dr.Table.Columns.Contains("TRAINING_DURATION")) ? (dr["TRAINING_DURATION"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["TRAINING_DURATION"]) : 0,


                };
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
        }
        /// <summary>
        /// save Sol_TeamMember Stage8 Details
        /// </summary>
        public int Ins_SolTeamMember(CreateNewOpportunity ObjCreateNewOpportunity)
        {
            try
            {
                int intResult;
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.InsertSolTeamMmber);
                db.AddInParameter(cd, "@iv_OppID", SqlDbType.VarChar, ObjCreateNewOpportunity.OpportunityId);
                db.AddInParameter(cd, "@iv_EmpID", SqlDbType.Int, ObjCreateNewOpportunity.EmpId);
                db.AddInParameter(cd, "@iv_EmpName", SqlDbType.VarChar, ObjCreateNewOpportunity.EmpName);
                db.AddInParameter(cd, "@iv_EmpAllocation", SqlDbType.Int, ObjCreateNewOpportunity.TM_SOL_ALLOCATION);
                db.AddInParameter(cd, "@iv_UserLogin", SqlDbType.VarChar, ObjCreateNewOpportunity.UserLogin);
                db.AddOutParameter(cd, "@on_Result", SqlDbType.Int, Int16.MaxValue);
                db.ExecuteNonQuery(cd);
                intResult = Convert.ToInt16(db.GetParameterValue(cd, "@on_Result"));
                return intResult;
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
        }
        /// <summary>
        /// Update Sol_TeamMember Details
        /// </summary>
        public int Upd_Sol_TM(CreateNewOpportunity ObjCreateNewOpportunity)
        {
            try
            {
                int intResult;
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.UpdateSolTM);
                db.AddInParameter(cd, "@iv_OppID", SqlDbType.VarChar, ObjCreateNewOpportunity.OpportunityId);
                db.AddInParameter(cd, "@iv_UserLogin", SqlDbType.VarChar, ObjCreateNewOpportunity.UserLogin);
                db.AddOutParameter(cd, "@on_Result", SqlDbType.Int, Int16.MaxValue);

                db.ExecuteNonQuery(cd);
                intResult = Convert.ToInt16(db.GetParameterValue(cd, "@on_Result"));
                return intResult;
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
        }
        /// <summary>
        /// Update Del_TeamMember Details
        /// </summary>
        public int Upd_Del_TM(CreateNewOpportunity ObjCreateNewOpportunity)
        {
            try
            {
                int intResult;
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Upd_Del_TM);
                db.AddInParameter(cd, "@iv_OppID", SqlDbType.VarChar, ObjCreateNewOpportunity.OpportunityId);
                db.AddInParameter(cd, "@iv_UserLogin", SqlDbType.VarChar, ObjCreateNewOpportunity.UserLogin);
                db.AddOutParameter(cd, "@on_Result", SqlDbType.Int, Int16.MaxValue);
                db.ExecuteNonQuery(cd);
                intResult = Convert.ToInt16(db.GetParameterValue(cd, "@on_Result"));
                return intResult;
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
        }
        /// <summary>
        /// Get Service Status Fiscal Details
        /// </summary>
        public List<OppDetails> Get_Status_Fiscal(string selectedvalue)
        {
            DataSet ds = null;
            List<OppDetails> customerList = new List<OppDetails>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Get_Service_Status_Fiscal);
                db.AddInParameter(cd, "@iv_selectedvalue", SqlDbType.Int, selectedvalue);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;

                        for (int i = 0; i < rowCount; i++)
                        {
                            customerList.Add(MapPopulate_Status_Fiscal(ds.Tables[0].Rows[i]));
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }

            return customerList;
        }
        private static OppDetails MapPopulate_Status_Fiscal(DataRow objRow)
        {
            return new OppDetails()
            {



                Status = (objRow.Table.Columns.Contains("status")) ? (objRow["status"] == DBNull.Value) ? "" : Convert.ToString(objRow["status"]) : ""
            };
        }
        /// <summary>
        /// Get Coach Availability Master Details
        /// </summary>
        public List<CreateNewOpportunity> Get_Coach_Availability(string selectedvalue)
        {
            DataSet ds = null;
            List<CreateNewOpportunity> customerList = new List<CreateNewOpportunity>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Get_COACH_AVAL_MASTER);

                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;

                        for (int i = 0; i < rowCount; i++)
                        {

                            customerList.Add(MapPopulate_Coach_Availability(ds.Tables[0].Rows[i]));

                        }

                    }
                }
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }

            return customerList;
        }
        private static CreateNewOpportunity MapPopulate_Coach_Availability(DataRow objRow)
        {

            return new CreateNewOpportunity()
            {

                COACH_AVAL_ID = (objRow.Table.Columns.Contains("COACH_AVAL_ID")) ? (objRow["COACH_AVAL_ID"] == DBNull.Value) ? "" : Convert.ToString(objRow["COACH_AVAL_ID"]) : "",
                COACH_AVAL_NAME = (objRow.Table.Columns.Contains("COACH_AVAL_NAME")) ? (objRow["COACH_AVAL_NAME"] == DBNull.Value) ? "" : Convert.ToString(objRow["COACH_AVAL_NAME"]) : ""

            };
        }
        /// <summary>
        /// Get PIBS STATUS MASTER Details
        /// </summary>
        public List<CreateNewOpportunity> Get_PIB_Status()
        {
            DataSet ds = null;
            List<CreateNewOpportunity> customerList = new List<CreateNewOpportunity>();
            try
            {


                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Get_PIBS_STATUS_MASTER);

                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;

                        for (int i = 0; i < rowCount; i++)
                        {

                            customerList.Add(MapPopulate_PIB_Status(ds.Tables[0].Rows[i]));

                        }

                    }
                }
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }

            return customerList;
        }
        private static CreateNewOpportunity MapPopulate_PIB_Status(DataRow objRow)
        {

            return new CreateNewOpportunity()
            {

                PIBS_STATUS_ID = (objRow.Table.Columns.Contains("PIBS_STATUS_ID")) ? (objRow["PIBS_STATUS_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(objRow["PIBS_STATUS_ID"]) : 0,

                PIBS_STATUS_NAME = (objRow.Table.Columns.Contains("PIBS_STATUS_NAME")) ? (objRow["PIBS_STATUS_NAME"] == DBNull.Value) ? "" : Convert.ToString(objRow["PIBS_STATUS_NAME"]) : ""

            };
        }
        /// <summary>
        /// Get BPO PreSalesLead Details
        /// </summary>
        public List<CreateNewOpportunity> Get_BPO_PreSalesLead(int bPO_DomainID)
        {
            DataSet ds = null;
            List<CreateNewOpportunity> customerList = new List<CreateNewOpportunity>();
            try
            {


                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Get_BPO_PreSalesLead);
                db.AddInParameter(cd, "@in_BPO_DomainID", SqlDbType.Int, bPO_DomainID);

                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;

                        for (int i = 0; i < rowCount; i++)
                        {

                            customerList.Add(MapsGet_BPO_PreSalesLead(ds.Tables[0].Rows[i]));

                        }

                    }
                }
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }

            return customerList;
        }
        private static CreateNewOpportunity MapsGet_BPO_PreSalesLead(DataRow objRow)
        {

            return new CreateNewOpportunity()
            {

                BPO_DOMAIN_ID = (objRow.Table.Columns.Contains("BPO_DOMAIN_ID")) ? (objRow["BPO_DOMAIN_ID"] == DBNull.Value) ? "" : Convert.ToString(objRow["BPO_DOMAIN_ID"]) : "",
                PRESALES_DOMAIN_LEAD = (objRow.Table.Columns.Contains("PRESALES_DOMAIN_LEAD")) ? (objRow["PRESALES_DOMAIN_LEAD"] == DBNull.Value) ? "" : Convert.ToString(objRow["PRESALES_DOMAIN_LEAD"]) : "",
                DomainPresalesLeadName = (objRow.Table.Columns.Contains("DOMAIN_PRESALES_LEAD_NAME")) ? (objRow["DOMAIN_PRESALES_LEAD_NAME"] == DBNull.Value) ? "" : Convert.ToString(objRow["DOMAIN_PRESALES_LEAD_NAME"]) : "",

            };
        }
        /// <summary>
        /// Get PIBS OUTCOME MASTER Details
        /// </summary>
        public List<CreateNewOpportunity> Get_PIBS_OUTCOME_MASTER()
        {
            DataSet ds = null;
            List<CreateNewOpportunity> customerList = new List<CreateNewOpportunity>();
            try
            {


                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Get_PIBS_OUTCOME_MASTER);

                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;

                        for (int i = 0; i < rowCount; i++)
                        {

                            customerList.Add(MapGet_PIBS_OUTCOME_MASTER(ds.Tables[0].Rows[i]));

                        }

                    }
                }
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }

            return customerList;
        }
        private static CreateNewOpportunity MapGet_PIBS_OUTCOME_MASTER(DataRow objRow)
        {

            return new CreateNewOpportunity()
            {
                PIBS_OUTCOME_ID = (objRow.Table.Columns.Contains("PIBS_OUTCOME_ID")) ? (objRow["PIBS_OUTCOME_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(objRow["PIBS_OUTCOME_ID"]) : 0,
                PIBS_OUTCOME_NAME = (objRow.Table.Columns.Contains("PIBS_OUTCOME_NAME")) ? (objRow["PIBS_OUTCOME_NAME"] == DBNull.Value) ? "" : Convert.ToString(objRow["PIBS_OUTCOME_NAME"]) : ""
            };
        }
        /// <summary>
        /// Get TotalContractValue_CRM Details
        /// </summary>
        public List<OppDetails> Get_TCV_CRM(string oppID)
        {
            DataSet ds = null;
            List<OppDetails> customerList = new List<OppDetails>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Get_TotalContractValue_CRM);
                db.AddInParameter(cd, "@iv_OppID", SqlDbType.VarChar, oppID);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;
                        for (int i = 0; i < rowCount; i++)
                        {
                            customerList.Add(MapGet_TCV_CRM(ds.Tables[0].Rows[i]));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }

            return customerList;
        }
        private static OppDetails MapGet_TCV_CRM(DataRow objRow)
        {
            return new OppDetails()
            {
                OpportunityId = (objRow.Table.Columns.Contains("OPPORTUNITY_ID")) ? (objRow["OPPORTUNITY_ID"] == DBNull.Value) ? "" : Convert.ToString(objRow["OPPORTUNITY_ID"]) : "",
                CRM_TCV = (objRow.Table.Columns.Contains("TCV_CRM")) ? (objRow["TCV_CRM"] == DBNull.Value) ? "" : Convert.ToString(objRow["TCV_CRM"]) : "",
                CRM_STAGE = (objRow.Table.Columns.Contains("CRM_STAGE")) ? (objRow["CRM_STAGE"] == DBNull.Value) ? 0 : Convert.ToInt32(objRow["CRM_STAGE"]) : 0,
            };
        }
        /// <summary>
        /// Update PIBS Details
        /// </summary>
        public int Update_PIBS_Deatils(CreateNewOpportunity ObjCreateNewOpportunity)
        {
            try
            {
                int intResult;
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Update_Pibs_Detail);
                db.AddInParameter(cd, "@iv_strOpportunityId", SqlDbType.VarChar, ObjCreateNewOpportunity.OpportunityId);
                db.AddInParameter(cd, "@iv_strQualificationTemplate", SqlDbType.VarChar, ObjCreateNewOpportunity.PIBS_QUALIFICATION);
                db.AddInParameter(cd, "@iv_strProposalDeck", SqlDbType.VarChar, ObjCreateNewOpportunity.PIBS_PROPOSALDECK);
                db.AddInParameter(cd, "@iv_strDataGathering", SqlDbType.VarChar, ObjCreateNewOpportunity.PIBS_DATAGATHERING);
                db.AddInParameter(cd, "@iv_strReportOut", SqlDbType.VarChar, ObjCreateNewOpportunity.PIBS_PPTSHARED);
                db.AddInParameter(cd, "@iv_strCustFeedback", SqlDbType.VarChar, ObjCreateNewOpportunity.PIBS_CUSTFEEDBACK);
                db.AddInParameter(cd, "@iv_strStudyLocation", SqlDbType.VarChar, ObjCreateNewOpportunity.PIBS_STUDYLOCATION);
                db.AddInParameter(cd, "@iv_strEstTCV", SqlDbType.VarChar, ObjCreateNewOpportunity.PIBS_ESTTCV);
                db.AddInParameter(cd, "@iv_strExecOwnerID", SqlDbType.VarChar, ObjCreateNewOpportunity.PIBS_EXEOWNEREMPID);
                db.AddInParameter(cd, "@iv_strExecOwnerName", SqlDbType.VarChar, ObjCreateNewOpportunity.PIBS_EXEOWNEREMPNAME);
                db.AddInParameter(cd, "@iv_strFinalReportDate", SqlDbType.VarChar, ObjCreateNewOpportunity.PIBS_FINALDATE);
                db.AddInParameter(cd, "@iv_strPibsTeamEmpId", SqlDbType.VarChar, ObjCreateNewOpportunity.PIBS_TEAMEMPID);
                db.AddInParameter(cd, "@iv_strPIBSTeamEmpName", SqlDbType.VarChar, ObjCreateNewOpportunity.PIBS_TEAMEMPNAME);
                db.AddInParameter(cd, "@iv_strPIBSTeamRole", SqlDbType.VarChar, ObjCreateNewOpportunity.PIBS_ROLEINTEAM);
                db.AddInParameter(cd, "@iv_strNoOfPIBSTeam", SqlDbType.VarChar, ObjCreateNewOpportunity.NoOf_TeamMemberPIBS);
                db.AddOutParameter(cd, "@on_Result", SqlDbType.Int, Int16.MaxValue);
                db.ExecuteNonQuery(cd);
                intResult = Convert.ToInt16(db.GetParameterValue(cd, "@on_Result"));
                return intResult;
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }

        }
        /// <summary>
        /// Get DealQualWeightage Details
        /// </summary>
        public List<CreateNewOpportunity> Get_DealQualWeightage(string oppID, int dealQualFieldID)
        {
            DataSet ds = null;
            List<CreateNewOpportunity> customerList = new List<CreateNewOpportunity>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Get_DealQualWeightage);
                db.AddInParameter(cd, "@iv_Opp_ID", SqlDbType.VarChar, oppID);
                db.AddInParameter(cd, "@in_DealQualID", SqlDbType.Int, dealQualFieldID);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount1 = ds.Tables[0].Rows.Count;
                        int rowCount2 = ds.Tables[1].Rows.Count;
                        int rowCount3 = ds.Tables[2].Rows.Count;

                        if (rowCount1 > 0)
                        {
                            for (int i = 0; i < rowCount1; i++)
                            {
                                customerList.Add(MapGet_DealQualWeightage(ds.Tables[0].Rows[i]));
                            }
                        }

                        if (rowCount2 > 0)
                        {
                            for (int i = 0; i < rowCount2; i++)
                            {
                                customerList.Add(TOTAL_SCORE1(ds.Tables[0].Rows[i]));
                            }
                        }
                        if (rowCount3 > 0)
                        {
                            for (int i = 0; i < rowCount3; i++)
                            {
                                customerList.Add(TOTAL_SCORE2(ds.Tables[0].Rows[i]));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }

            return customerList;
        }
        private static CreateNewOpportunity MapGet_DealQualWeightage(DataRow objRow)
        {
            return new CreateNewOpportunity()
            {
                DEAL_QUAL_SCORE_WEIGHTAGE = (objRow.Table.Columns.Contains("DEAL_QUAL_SCORE_WEIGHTAGE")) ? (objRow["DEAL_QUAL_SCORE_WEIGHTAGE"] == DBNull.Value) ? "" : Convert.ToString(objRow["DEAL_QUAL_SCORE_WEIGHTAGE"]) : "",
            };
        }
        private static CreateNewOpportunity TOTAL_SCORE1(DataRow objRow)
        {
            return new CreateNewOpportunity()
            {
                TOTAL_SCORE = (objRow.Table.Columns.Contains("TOTAL_SCORE")) ? (objRow["TOTAL_SCORE"] == DBNull.Value) ? "" : Convert.ToString(objRow["TOTAL_SCORE"]) : "",
            };
        }
        private static CreateNewOpportunity TOTAL_SCORE2(DataRow objRow)
        {
            return new CreateNewOpportunity()
            {
                TOTAL_SCORE = (objRow.Table.Columns.Contains("TOTAL_SCORE")) ? (objRow["TOTAL_SCORE"] == DBNull.Value) ? "" : Convert.ToString(objRow["TOTAL_SCORE"]) : "",
            };
        }
        /// <summary>
        /// Get DealQualScore Details
        /// </summary>
        public List<CreateNewOpportunity> Get_CandSQ(int dealQualID, int dealQualTitleID)
        {
            DataSet ds = null;
            List<CreateNewOpportunity> customerList = new List<CreateNewOpportunity>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Get_DealQualScore);
                db.AddInParameter(cd, "@in_DealQualID", SqlDbType.Int, dealQualID);
                db.AddInParameter(cd, "@in_DealQuaFieldlID", SqlDbType.Int, dealQualTitleID);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;
                        for (int i = 0; i < rowCount; i++)
                        {
                            customerList.Add(MapGet_CandSQ(ds.Tables[0].Rows[i]));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }
            return customerList;
        }
        private static CreateNewOpportunity MapGet_CandSQ(DataRow objRow)
        {

            return new CreateNewOpportunity()
            {
                DEAL_QUAL_SCORE_ID = (objRow.Table.Columns.Contains("DEAL_QUAL_SCORE_ID")) ? (objRow["DEAL_QUAL_SCORE_ID"] == DBNull.Value) ? "" : Convert.ToString(objRow["DEAL_QUAL_SCORE_ID"]) : "",
                DEAL_QUAL_SCORE_NAME = (objRow.Table.Columns.Contains("DEAL_QUAL_SCORE_NAME")) ? (objRow["DEAL_QUAL_SCORE_NAME"] == DBNull.Value) ? "" : Convert.ToString(objRow["DEAL_QUAL_SCORE_NAME"]) : "",
                DEAL_QUAL_SCORE_WEIGHTAGE = (objRow.Table.Columns.Contains("DEAL_QUAL_SCORE_WEIGHTAGE")) ? (objRow["DEAL_QUAL_SCORE_WEIGHTAGE"] == DBNull.Value) ? "" : Convert.ToString(objRow["DEAL_QUAL_SCORE_WEIGHTAGE"]) : "",
            };
        }
        /// <summary>
        /// Get DealQualScoreValue Details
        /// </summary>
        public List<CreateNewOpportunity> Get_DealQualScoreValue(int dealQualScoreID)
        {
            DataSet ds = null;
            List<CreateNewOpportunity> customerList = new List<CreateNewOpportunity>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Get_DealQualScoreValue);
                db.AddInParameter(cd, "@in_DealQuaScoreID", SqlDbType.Int, dealQualScoreID);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;

                        for (int i = 0; i < rowCount; i++)
                        {
                            customerList.Add(MapGet_DealQualScoreValue(ds.Tables[0].Rows[i]));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }

            return customerList;
        }
        private static CreateNewOpportunity MapGet_DealQualScoreValue(DataRow objRow)
        {

            return new CreateNewOpportunity()
            {

                DEAL_QUAL_SCORE_WEIGHTAGE = (objRow.Table.Columns.Contains("DEAL_QUAL_SCORE_WEIGHTAGE")) ? (objRow["DEAL_QUAL_SCORE_WEIGHTAGE"] == DBNull.Value) ? "" : Convert.ToString(objRow["DEAL_QUAL_SCORE_WEIGHTAGE"]) : ""
            };
        }
        /// <summary>
        /// Save OppDealQualification Details
        /// </summary>
        public int Save_OppDealQualificationDtls(string oppId, int dealQualScoreID, int dealQualFieldId, string empNo)
        {
            try
            {
                int intResult;
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Ins_OppDealQualificationDtls);
                db.AddInParameter(cd, "@iv_OppID", SqlDbType.VarChar, oppId);
                db.AddInParameter(cd, "@in_DealQualScoreID", SqlDbType.Int, dealQualScoreID);
                db.AddInParameter(cd, "@in_DealQualFieldID", SqlDbType.Int, dealQualFieldId);
                db.AddInParameter(cd, "@iv_UserLogin", SqlDbType.VarChar, empNo);
                db.AddOutParameter(cd, "@on_Result", SqlDbType.Int, Int16.MaxValue);
                db.ExecuteNonQuery(cd);
                intResult = Convert.ToInt16(db.GetParameterValue(cd, "@on_Result"));
                return intResult;
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
        }
        /// <summary>
        /// Save OppTotalScoreDealQualification Details
        /// </summary>
        public int Save_TotalOppDealQualificationDtls(string oppId, int dealQualGroupID, string totalScore, string empNo)
        {
            try
            {
                int intResult;
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Ins_OppTotalScoreDealQualificationDtls);
                db.AddInParameter(cd, "@iv_OppID", SqlDbType.VarChar, oppId);
                db.AddInParameter(cd, "@in_DealQualGroupID", SqlDbType.Int, dealQualGroupID);
                db.AddInParameter(cd, "@in_TotalScore", SqlDbType.VarChar, totalScore);
                db.AddInParameter(cd, "@iv_UserLogin", SqlDbType.VarChar, empNo);
                db.AddOutParameter(cd, "@on_Result", SqlDbType.Int, Int16.MaxValue);
                db.ExecuteNonQuery(cd);
                intResult = Convert.ToInt16(db.GetParameterValue(cd, "@on_Result"));
                return intResult;
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
        }
        /// <summary>
        /// Get Vertical_Opp_Data Details
        /// </summary>
        public List<OpportunityUnitID> Get_Vertical_Opp_Data(string strOppId)
        {
            DataSet ds = null;
            List<OpportunityUnitID> customerList = new List<OpportunityUnitID>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.GET_VERTICAL_OPP_DATA);
                db.AddInParameter(cd, "@in_opportunity", SqlDbType.VarChar, strOppId);

                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;
                        for (int i = 0; i < rowCount; i++)
                        {
                            customerList.Add(MapGet_Vertical_Opp_Date(ds.Tables[0].Rows[i]));
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }

            return customerList;
        }
        private static OpportunityUnitID MapGet_Vertical_Opp_Date(DataRow objRow)
        {

            return new OpportunityUnitID()
            {

                Id = (objRow.Table.Columns.Contains("id")) ? (objRow["id"] == DBNull.Value) ? 0 : Convert.ToInt32(objRow["id"]) : 0,
                BUSINESS_ID = (objRow.Table.Columns.Contains("BUSINESS_ID")) ? (objRow["BUSINESS_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(objRow["BUSINESS_ID"]) : 0,
                OpportunityId = (objRow.Table.Columns.Contains("OPPORTUNITY_ID")) ? (objRow["OPPORTUNITY_ID"] == DBNull.Value) ? "" : Convert.ToString(objRow["OPPORTUNITY_ID"]) : "",
                FTE = (objRow.Table.Columns.Contains("FTE")) ? (objRow["FTE"] == DBNull.Value) ? 0 : Convert.ToInt32(objRow["FTE"]) : 0,
                SOLUTION_LEAD = (objRow.Table.Columns.Contains("SOLUTION_LEAD")) ? (objRow["SOLUTION_LEAD"] == DBNull.Value) ? "" : Convert.ToString(objRow["SOLUTION_LEAD"]) : "",
                TCV = (objRow.Table.Columns.Contains("TCV")) ? (objRow["TCV"] == DBNull.Value) ? "" : Convert.ToString(objRow["TCV"]) : "",

            };
        }
        /// <summary>
        /// Get Service_Opp_Data Details
        /// </summary>
        public List<OpportunityUnitID> Get_Service_Opp_Date(string oppId)
        {
            DataSet ds = null;
            List<OpportunityUnitID> customerList = new List<OpportunityUnitID>();
            try
            {


                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.GET_SERVICE_OPP_DATA);
                db.AddInParameter(cd, "@in_opportunity", SqlDbType.VarChar, oppId);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;

                        for (int i = 0; i < rowCount; i++)
                        {
                            customerList.Add(MapGet_Service_Opp_Date(ds.Tables[0].Rows[i]));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }

            return customerList;
        }
        private static OpportunityUnitID MapGet_Service_Opp_Date(DataRow objRow)
        {

            return new OpportunityUnitID()
            {

                Id = (objRow.Table.Columns.Contains("id")) ? (objRow["id"] == DBNull.Value) ? 0 : Convert.ToInt32(objRow["id"]) : 0,
                OpportunityId = (objRow.Table.Columns.Contains("OPPORTUNITY_ID")) ? (objRow["OPPORTUNITY_ID"] == DBNull.Value) ? "" : Convert.ToString(objRow["OPPORTUNITY_ID"]) : "",
                HorizontalId = (objRow.Table.Columns.Contains("SERVICE_ID")) ? (objRow["SERVICE_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(objRow["SERVICE_ID"]) : 0,
                LEVEL_ID = (objRow.Table.Columns.Contains("LEVEL1_ID")) ? (objRow["LEVEL1_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(objRow["LEVEL1_ID"]) : 0,
                LEVEL2_ID = (objRow.Table.Columns.Contains("LEVEL2_ID")) ? (objRow["LEVEL2_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(objRow["LEVEL2_ID"]) : 0,
                FTE = (objRow.Table.Columns.Contains("FTE")) ? (objRow["FTE"] == DBNull.Value) ? 0 : Convert.ToInt32(objRow["FTE"]) : 0,
                SOLUTION_LEAD = (objRow.Table.Columns.Contains("SOLUTION_LEAD")) ? (objRow["SOLUTION_LEAD"] == DBNull.Value) ? "" : Convert.ToString(objRow["SOLUTION_LEAD"]) : "",
                TCV = (objRow.Table.Columns.Contains("TCV")) ? (objRow["TCV"] == DBNull.Value) ? "" : Convert.ToString(objRow["TCV"]) : "",

            };
        }
        /// <summary>
        /// Get Service Horizontal Details
        /// </summary>

        public List<NewOpportunity> GetServiceName(string unitId)
        {
            DataSet ds = null;
            int unit = 0;
            if (!String.IsNullOrEmpty(unitId))
            {
                unit = Convert.ToInt32(StringFunctions.Base64Decode(unitId));
            }
            List<NewOpportunity> modelList = new List<NewOpportunity>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.GetServiceHorizontal);
                db.AddInParameter(cd, "@iv_UnitId", SqlDbType.VarChar, unitId);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;

                        for (int i = 0; i < rowCount; i++)
                        {
                            if (ds.Tables[0].Rows[i]["STATUS"].ToString() == "AC")
                            {
                                modelList.Add(MapGetServiceName(ds.Tables[0].Rows[i]));
                            }
                        }

                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }
            return modelList;
        }

        private static NewOpportunity MapGetServiceName(DataRow dr)
        {
            try
            {
                return new NewOpportunity()
                {
                    HorizontalId = (dr.Table.Columns.Contains("HORIZONTAL_ID")) ? (dr["HORIZONTAL_ID"] == DBNull.Value) ? 0 : dr.Field<int>("HORIZONTAL_ID") : 0,
                    HorizontalName = (dr.Table.Columns.Contains("HORIZONTAL_NAME")) ? (dr["HORIZONTAL_NAME"] == DBNull.Value) ? "" : dr.Field<string>("HORIZONTAL_NAME") : "",
            };
        }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
        }


        /// <summary>
        /// Get Level1_Service Details
        /// </summary>
        public List<Services> Get_Level1_Services(string service)
        {
            DataSet ds = null;
            List<Services> customerList = new List<Services>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Get_Level1_Service);
                db.AddInParameter(cd, "@iv_serviceid", SqlDbType.Int, service);

                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;

                        for (int i = 0; i < rowCount; i++)
                        {
                            customerList.Add(MapPopulate_Level1_Services(ds.Tables[0].Rows[i]));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }

            return customerList;
        }
        private static Services MapPopulate_Level1_Services(DataRow objRow)
        {

            return new Services()
            {
                LEVEL_ID = (objRow.Table.Columns.Contains("LEVELID")) ? (objRow["LEVELID"] == DBNull.Value) ? 0 : Convert.ToInt32(objRow["LEVELID"]) : 0,
                LEVEL_NAME = (objRow.Table.Columns.Contains("LEVEL_NAME")) ? (objRow["LEVEL_NAME"] == DBNull.Value) ? "" : Convert.ToString(objRow["LEVEL_NAME"]) : "",
            };
        }
        /// <summary>
        /// Get Level2_Service Details
        /// </summary>
        public List<CreateNewOpportunity> Get_Level2_Services(string service)
        {
            DataSet ds = null;
            List<CreateNewOpportunity> customerList = new List<CreateNewOpportunity>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Get_Level2_Service);
                db.AddInParameter(cd, "@iv_serviceid", SqlDbType.Int, service);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;
                        for (int i = 0; i < rowCount; i++)
                        {
                            customerList.Add(MapPopulate_Level2_Services(ds.Tables[0].Rows[i]));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }

            return customerList;
        }
        private static CreateNewOpportunity MapPopulate_Level2_Services(DataRow objRow)
        {

            return new CreateNewOpportunity()
            {
                LEVELID = (objRow.Table.Columns.Contains("LEVELID")) ? (objRow["LEVELID"] == DBNull.Value) ? 0 : Convert.ToInt32(objRow["LEVELID"]) : 0,
                LEVEL_NAME = (objRow.Table.Columns.Contains("LEVEL_NAME")) ? (objRow["LEVEL_NAME"] == DBNull.Value) ? "" : Convert.ToString(objRow["LEVEL_NAME"]) : "",
            };
        }
        /// <summary>
        /// Get Business_BFS1 Details
        /// </summary>
        public List<OpportunityUnitID> Get_Business_BFS1(string unitid)
        {
            DataSet ds = null;
            List<OpportunityUnitID> customerList = new List<OpportunityUnitID>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Get_Business_BFS1);
                db.AddInParameter(cd, "@in_UnitId", SqlDbType.Int, unitid);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;

                        for (int i = 0; i < rowCount; i++)
                        {
                            customerList.Add(MapPopulate_cmb_Business_BFS1(ds.Tables[0].Rows[i]));
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }

            return customerList;
        }
        private static OpportunityUnitID MapPopulate_cmb_Business_BFS1(DataRow objRow)
        {

            return new OpportunityUnitID()
            {
                BUSINESS_ID = (objRow.Table.Columns.Contains("BUSINESS_ID")) ? (objRow["BUSINESS_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(objRow["BUSINESS_ID"]) : 0,
                BUSINESS_NAME = (objRow.Table.Columns.Contains("BUSINESS_NAME")) ? (objRow["BUSINESS_NAME"] == DBNull.Value) ? "" : Convert.ToString(objRow["BUSINESS_NAME"]) : "",
            };
        }
        /// <summary>
        /// Save Vertical_Data Details
        /// </summary>
        public int Save_VerticalOppdate(CreateNewOpportunity objVertical)
        {
            try
            {
                int intResult;
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.SAVE_Vertical_Data);
                db.AddInParameter(cd, "@in_OpportunityId", SqlDbType.VarChar, objVertical.strOpportunityId);
                db.AddInParameter(cd, "@in_Vertical", SqlDbType.VarChar, objVertical.BUSINESS_ID.ToString());
                db.AddInParameter(cd, "@in_FTE", SqlDbType.Int, objVertical.FTE);
                db.AddInParameter(cd, "@in_SolutionLead", SqlDbType.VarChar, objVertical.SOLUTION_LEAD);
                db.AddInParameter(cd, "@in_TCV", SqlDbType.VarChar, objVertical.TCV.ToString());
                db.AddInParameter(cd, "@in_EmpNo", SqlDbType.VarChar, objVertical.UserLogin);
                db.AddInParameter(cd, "@in_Unit", SqlDbType.VarChar, objVertical.UnitId);
                db.AddInParameter(cd, "@in_id", SqlDbType.VarChar, objVertical.Id);
                db.AddOutParameter(cd, "@on_Result", SqlDbType.Int, Int16.MaxValue);
                db.ExecuteNonQuery(cd);
                intResult = Convert.ToInt16(db.GetParameterValue(cd, "@on_Result"));
                return intResult;
            }

            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
        }
        /// <summary>
        /// Get PresalesLead_VerticalWise Details
        /// </summary>
        public List<OpportunityUnitID> Get_PresalesLead_VerticalWise(int unitid, int businessId)
        {
            DataSet ds = null;
            List<OpportunityUnitID> customerList = new List<OpportunityUnitID>();
            try
            {


                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Get_PresalesLead_VerticalWise);
                db.AddInParameter(cd, "@iv_UnitId", SqlDbType.Int, unitid);
                db.AddInParameter(cd, "@iv_Business_Id", SqlDbType.Int, businessId);

                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;

                        for (int i = 0; i < rowCount; i++)
                        {

                            customerList.Add(MapGet_PresalesLead_VerticalWise(ds.Tables[0].Rows[i]));

                        }

                    }
                }
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }

            return customerList;
        }
        private static OpportunityUnitID MapGet_PresalesLead_VerticalWise(DataRow objRow)
        {

            return new OpportunityUnitID()
            {

                PRESALES_LEAD = (objRow.Table.Columns.Contains("PRESALES_LEAD")) ? (objRow["PRESALES_LEAD"] == DBNull.Value) ? "" : Convert.ToString(objRow["PRESALES_LEAD"]) : ""

            };
        }
        /// <summary>
        /// Delete Vertical Data Details
        /// </summary>
        public int Delete_VerticalOppdate(CreateNewOpportunity objVertical)
        {
            try
            {
                int intResult = 0;
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.DELETE_Vertical_Data);
                db.AddInParameter(cd, "@in_Id", SqlDbType.VarChar, objVertical.Id);
                db.AddInParameter(cd, "@in_EmpNo", SqlDbType.VarChar, objVertical.UserLogin);
                db.AddInParameter(cd, "@in_OppId", SqlDbType.VarChar, objVertical.strOpportunityId);
                db.AddInParameter(cd, "@in_MultiTower", SqlDbType.VarChar, objVertical.MultiTower);
                db.AddOutParameter(cd, "@on_Result", SqlDbType.Int, Int16.MaxValue);
                db.ExecuteNonQuery(cd);
                intResult = Convert.ToInt16(db.GetParameterValue(cd, "@on_Result"));
                return intResult;
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
        }
        /// <summary>
        /// Get BPS_ISU_MASTER_MAIN Details
        /// </summary>
        public List<CreateNewOpportunity> GetIsuName(int unitid)
        {
            DataSet ds = null;
            List<CreateNewOpportunity> customerList = new List<CreateNewOpportunity>();
            try
            {


                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Get_BPS_ISU_MASTER_MAIN);
                db.AddInParameter(cd, "@iv_UnitId", SqlDbType.Int, unitid);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;
                        for (int i = 0; i < rowCount; i++)
                        {
                            customerList.Add(MapPopulate_cmb_BPS_ISUMASTERMAIN(ds.Tables[0].Rows[i]));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }
            return customerList;
        }
        private static CreateNewOpportunity MapPopulate_cmb_BPS_ISUMASTERMAIN(DataRow objRow)
        {
            return new CreateNewOpportunity()
            {
                ISU_CD = (objRow.Table.Columns.Contains("ISUCD")) ? (objRow["ISUCD"] == DBNull.Value) ? "" : Convert.ToString(objRow["ISUCD"]) : "",
                ISU_NAME = (objRow.Table.Columns.Contains("ISUNAME")) ? (objRow["ISUNAME"] == DBNull.Value) ? "" : Convert.ToString(objRow["ISUNAME"]) : "",
                Status = (objRow.Table.Columns.Contains("status")) ? (objRow["status"] == DBNull.Value) ? "" : Convert.ToString(objRow["status"]) : "",

            };
        }
        /// <summary>
        /// Get Executive Sponsor Name Details
        /// </summary>
        public List<CreateNewOpportunity> Get_ExecutiveSponsorOwner(int unitid)
        {
            DataSet ds = null;
            List<CreateNewOpportunity> customerList = new List<CreateNewOpportunity>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Get_EXECUTIVE_SPONSOR_NAME);
                db.AddInParameter(cd, "@iv_UnitId", SqlDbType.Int, unitid);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;
                        for (int i = 0; i < rowCount; i++)
                        {
                            customerList.Add(MapPopulate_cmb_ExecutiveSponsorOwner(ds.Tables[0].Rows[i]));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }
            return customerList;
        }
        private static CreateNewOpportunity MapPopulate_cmb_ExecutiveSponsorOwner(DataRow objRow)
        {
            return new CreateNewOpportunity()
            {
                EXECUTIVE_SPONSOR_ID = (objRow.Table.Columns.Contains("EXECUTIVE_SPONSOR_ID")) ? (objRow["EXECUTIVE_SPONSOR_ID"] == DBNull.Value) ? "" : Convert.ToString(objRow["EXECUTIVE_SPONSOR_ID"]) : "",
                EXECUTIVE_SPONSOR_NAME = (objRow.Table.Columns.Contains("EXECUTIVE_SPONSOR_NAME")) ? (objRow["EXECUTIVE_SPONSOR_NAME"] == DBNull.Value) ? "" : Convert.ToString(objRow["EXECUTIVE_SPONSOR_NAME"]) : "",
                Status = (objRow.Table.Columns.Contains("status")) ? (objRow["status"] == DBNull.Value) ? "" : Convert.ToString(objRow["status"]) : "",

            };
        }
        /// <summary>
        /// Get ValBPSCon_NAME Details
        /// </summary>
        public List<CreateNewOpportunity> Get_ValBPSCon(int unitid)
        {
            DataSet ds = null;
            List<CreateNewOpportunity> customerList = new List<CreateNewOpportunity>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Get_ValBPSCon_NAME);
                db.AddInParameter(cd, "@iv_UnitId", SqlDbType.Int, unitid);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;

                        for (int i = 0; i < rowCount; i++)
                        {
                            customerList.Add(MapPopulate_cmb_ValBPSCon(ds.Tables[0].Rows[i]));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }
            return customerList;
        }
        private static CreateNewOpportunity MapPopulate_cmb_ValBPSCon(DataRow objRow)
        {
            return new CreateNewOpportunity()
            {
                VALBPS_CON_ID = (objRow.Table.Columns.Contains("VALBPS_CON_ID")) ? (objRow["VALBPS_CON_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(objRow["VALBPS_CON_ID"]) : 0,
                VALBPS_CON_NAME = (objRow.Table.Columns.Contains("VALBPS_CON_NAME")) ? (objRow["VALBPS_CON_NAME"] == DBNull.Value) ? "" : Convert.ToString(objRow["VALBPS_CON_NAME"]) : "",
            };
        }
        /// <summary>
        /// Get PIBS_TM Details
        /// </summary>
        public List<CreateNewOpportunity> Get_PIBS_TM_Dtls(string oppID)
        {
            DataSet ds = null;
            List<CreateNewOpportunity> customerList = new List<CreateNewOpportunity>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Get_PIBS_TM_Dtls);
                db.AddInParameter(cd, "@iv_OppID", SqlDbType.VarChar, oppID);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;
                        for (int i = 0; i < rowCount; i++)
                        {
                            customerList.Add(MapGet_PIBS_TM_Dtls(ds.Tables[0].Rows[i]));
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }

            return customerList;
        }
        private static CreateNewOpportunity MapGet_PIBS_TM_Dtls(DataRow objRow)
        {
            return new CreateNewOpportunity()
            {
                OpportunityId = (objRow.Table.Columns.Contains("OPPORTUNITY_ID")) ? (objRow["OPPORTUNITY_ID"] == DBNull.Value) ? "" : Convert.ToString(objRow["OPPORTUNITY_ID"]) : "",
                TM_PIBS_EMP_NO = (objRow.Table.Columns.Contains("TM_PIBS_EMP_NO")) ? (objRow["TM_PIBS_EMP_NO"] == DBNull.Value) ? "" : Convert.ToString(objRow["TM_PIBS_EMP_NO"]) : "",
                TM_PIBS_EMP_NAME = (objRow.Table.Columns.Contains("TM_PIBS_EMP_NAME")) ? (objRow["TM_PIBS_EMP_NAME"] == DBNull.Value) ? "" : Convert.ToString(objRow["TM_PIBS_EMP_NAME"]) : "",
                TM_PIBS_ROLE = (objRow.Table.Columns.Contains("TM_PIBS_ROLE")) ? (objRow["TM_PIBS_ROLE"] == DBNull.Value) ? "" : Convert.ToString(objRow["TM_PIBS_ROLE"]) : "",
            };
        }
        /// <summary>
        /// Update PIBS_TM Details
        /// </summary>
        public int Upd_PIBS_TM(string oppID, string userLogin)
        {
            try
            {
                int intResult;
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Upd_PIBS_TM);
                db.AddInParameter(cd, "@iv_OppID", SqlDbType.VarChar, oppID);
                db.AddInParameter(cd, "@iv_UserLogin", SqlDbType.VarChar, userLogin);
                db.AddOutParameter(cd, "@on_Result", SqlDbType.Int, Int16.MaxValue);
                db.ExecuteNonQuery(cd);
                intResult = Convert.ToInt16(db.GetParameterValue(cd, "@on_Result"));
                return intResult;
            }

            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
        }
        /// <summary>
        /// Save PIBS_TM Details
        /// </summary>
        public int Ins_PIBSTeamMember(string oppId, int empId, string empName, string role, string userLogin)
        {
            try
            {
                int intResult;
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Ins_PIBSTeamMmber);
                db.AddInParameter(cd, "@iv_OppID", SqlDbType.VarChar, oppId);
                db.AddInParameter(cd, "@iv_EmpID", SqlDbType.Int, empId);
                db.AddInParameter(cd, "@iv_EmpName", SqlDbType.VarChar, empName);
                db.AddInParameter(cd, "@iv_EmpRole", SqlDbType.VarChar, role);
                db.AddInParameter(cd, "@iv_UserLogin", SqlDbType.VarChar, userLogin);
                db.AddOutParameter(cd, "@on_Result", SqlDbType.Int, Int16.MaxValue);
                db.ExecuteNonQuery(cd);
                intResult = Convert.ToInt16(db.GetParameterValue(cd, "@on_Result"));
                return intResult;
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }

        }
        /// <summary>
        /// Get Competitor Details
        /// </summary>
        public List<MultiSelect> Get_Competitor(int unitID)
        {
            DataSet ds = null;
            List<MultiSelect> customerList = new List<MultiSelect>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Get_Competitor);
                db.AddInParameter(cd, "@iv_UnitId", SqlDbType.VarChar, unitID);

                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;
                        for (int i = 0; i < rowCount; i++)
                        {
                            customerList.Add(MapPopulate_cmb_Competitor(ds.Tables[0].Rows[i]));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }

            return customerList;
        }
        private static MultiSelect MapPopulate_cmb_Competitor(DataRow objRow)
        {

            return new MultiSelect()
            {
                id = (objRow.Table.Columns.Contains("COMPETITOR_ID")) ? (objRow["COMPETITOR_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(objRow["COMPETITOR_ID"]) : 0,
                itemName = (objRow.Table.Columns.Contains("COMPETITOR_NAME")) ? (objRow["COMPETITOR_NAME"] == DBNull.Value) ? "" : Convert.ToString(objRow["COMPETITOR_NAME"]) : "",
            };
        }
        public List<MultiSelect> Get_PricingType(int unitID)
        {
            DataSet ds = null;
            List<MultiSelect> priceList = new List<MultiSelect>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Get_PricingType);
                db.AddInParameter(cd, "@iv_UnitId", SqlDbType.VarChar, unitID);

                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;
                        for (int i = 0; i < rowCount; i++)
                        {
                            priceList.Add(MapPopulate_cmb_PricingType(ds.Tables[0].Rows[i]));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }

            return priceList;
        }
        private static MultiSelect MapPopulate_cmb_PricingType(DataRow objRow)
        {

            return new MultiSelect()
            {
                id = (objRow.Table.Columns.Contains("Pricing_type_ID")) ? (objRow["Pricing_type_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(objRow["Pricing_type_ID"]) : 0,
                itemName = (objRow.Table.Columns.Contains("Pricing_type_NAME")) ? (objRow["Pricing_type_NAME"] == DBNull.Value) ? "" : Convert.ToString(objRow["Pricing_type_NAME"]) : "",
            };
        }


        public List<MultiSelectList> Get_OppPricingType(string oppId)
        {
            DataSet ds = null;
            List<MultiSelectList> customerList = new List<MultiSelectList>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Get_Opp_PricingType);
                db.AddInParameter(cd, "@iv_OppID", SqlDbType.VarChar, oppId);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;

                        for (int i = 0; i < rowCount; i++)
                        {
                            customerList.Add(MapGet_OppPricingType(ds.Tables[0].Rows[i]));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }

            return customerList;
        }
        private static MultiSelectList MapGet_OppPricingType(DataRow objRow)
        {

            return new MultiSelectList()
            {
                id = (objRow.Table.Columns.Contains("Pricing_type_ID")) ? (objRow["Pricing_type_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(objRow["Pricing_type_ID"]) : 0,
                itemName = (objRow.Table.Columns.Contains("Pricing_type_NAME")) ? (objRow["Pricing_type_NAME"] == DBNull.Value) ? "" : Convert.ToString(objRow["Pricing_type_NAME"]) : "",
            };
        }




        public int Del_OppPricingType(string oppId)
        {
            try
            {
                int intResult;
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Del_OppPricingType);
                db.AddInParameter(cd, "@iv_OppID", SqlDbType.VarChar, oppId);
                db.AddOutParameter(cd, "@on_Result", SqlDbType.Int, Int16.MaxValue);
                db.ExecuteNonQuery(cd);
                intResult = Convert.ToInt16(db.GetParameterValue(cd, "@on_Result"));
                return intResult;
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }

        }

        public int Upd_PricingType(CreateNewOpportunity ObjCreateNewOpportunity)
        {
            try
            {
                int intResult;
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Upd_OppPricingType);
                db.AddInParameter(cd, "@iv_OppID", SqlDbType.VarChar, ObjCreateNewOpportunity.OpportunityId);
                db.AddInParameter(cd, "@in_PricingTypeId", SqlDbType.Int, ObjCreateNewOpportunity.COMPETITOR_ID);
                db.AddInParameter(cd, "@iv_UserLogin", SqlDbType.VarChar, ObjCreateNewOpportunity.UserLogin);
                db.AddOutParameter(cd, "@on_Result", SqlDbType.Int, Int16.MaxValue);
                db.ExecuteNonQuery(cd);
                intResult = Convert.ToInt16(db.GetParameterValue(cd, "@on_Result"));
                return intResult;
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }

        }






        /// <summary>
        /// Get Opportunity Competitor Details
        /// </summary>
        public List<MultiSelectList> Get_OppCompetitors(string oppId)
        {
            DataSet ds = null;
            List<MultiSelectList> customerList = new List<MultiSelectList>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Get_Opp_Competitors);
                db.AddInParameter(cd, "@iv_OppID", SqlDbType.VarChar, oppId);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;

                        for (int i = 0; i < rowCount; i++)
                        {
                            customerList.Add(MapGet_OppCompetitors(ds.Tables[0].Rows[i]));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }

            return customerList;
        }
        private static MultiSelectList MapGet_OppCompetitors(DataRow objRow)
        {

            return new MultiSelectList()
            {
                id = (objRow.Table.Columns.Contains("COMPETITOR_ID")) ? (objRow["COMPETITOR_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(objRow["COMPETITOR_ID"]) : 0,
                itemName = (objRow.Table.Columns.Contains("COMPETITOR_NAME")) ? (objRow["COMPETITOR_NAME"] == DBNull.Value) ? "" : Convert.ToString(objRow["COMPETITOR_NAME"]) : "",
            };
        }
        /// <summary>
        /// Update Competitor Details
        /// </summary>
        public int Upd_Competitors(string oppid)
        {
            try
            {
                int intResult;
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Upd_OppCompetitors);
                db.AddInParameter(cd, "@iv_OppID", SqlDbType.VarChar, oppid);
               
                db.AddOutParameter(cd, "@on_Result", SqlDbType.Int, Int16.MaxValue);
                db.ExecuteNonQuery(cd);
                intResult = Convert.ToInt16(db.GetParameterValue(cd, "@on_Result"));
                return intResult;
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }

        }
        /// <summary>
        /// Save Service Data Details
        /// </summary>
        public int Save_ServiceOppdate(CreateNewOpportunity objService)
        {
            try
            {
                
                int intResult;
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.SAVE_Service_Data);
                db.AddInParameter(cd, "@in_OpportunityId", SqlDbType.VarChar, objService.strOpportunityId);
                db.AddInParameter(cd, "@in_Service", SqlDbType.VarChar, objService.HorizontalId);
                db.AddInParameter(cd, "@in_L1", SqlDbType.VarChar, objService.LEVEL_ID);
                db.AddInParameter(cd, "@in_L2", SqlDbType.VarChar, objService.LEVEL2_ID);
                db.AddInParameter(cd, "@in_FTE", SqlDbType.Int, objService.FTE);
                db.AddInParameter(cd, "@in_SolutionLead", SqlDbType.VarChar, objService.SOLUTION_LEAD);
                db.AddInParameter(cd, "@in_TCV", SqlDbType.VarChar, objService.TCV.ToString());
                db.AddInParameter(cd, "@in_EmpNo", SqlDbType.VarChar, objService.UserLogin);
                db.AddInParameter(cd, "@in_Unit", SqlDbType.VarChar, objService.UnitId);
                db.AddInParameter(cd, "@in_id", SqlDbType.VarChar, objService.Id);
                db.AddOutParameter(cd, "@on_Result", SqlDbType.Int, Int16.MaxValue);
                db.ExecuteNonQuery(cd);
                intResult = Convert.ToInt16(db.GetParameterValue(cd, "@on_Result"));
                return intResult;
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }

        }
        /// <summary>
        /// Delete Service Data Details
        /// </summary>
        public int Delete_ServiceOppdate(CreateNewOpportunity objService)
        {
            try
            {
                int intResult;
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.DELETE_Service_Data);
                db.AddInParameter(cd, "@in_Id", SqlDbType.VarChar, objService.Id);
                db.AddInParameter(cd, "@in_EmpNo", SqlDbType.VarChar, objService.UserLogin);
                db.AddInParameter(cd, "@in_OppId", SqlDbType.VarChar, objService.UnitId);
                db.AddInParameter(cd, "@in_MultiTower", SqlDbType.VarChar, objService.MultiTower);
                db.AddOutParameter(cd, "@on_Result", SqlDbType.Int, Int16.MaxValue);
                db.ExecuteNonQuery(cd);
                intResult = Convert.ToInt16(db.GetParameterValue(cd, "@on_Result"));
                return intResult;
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }


        }
        /// <summary>
        /// GET VERTICAL_DOMAIN_OPP_DATA Details
        /// </summary>
        public List<OpportunityUnitID> GET_VERTICAL_DOMAIN_OPP_DATA(string oppId)
        {
            DataSet ds = null;
            List<OpportunityUnitID> customerList = new List<OpportunityUnitID>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.GET_VERTICAL_DOMAIN_OPP_DATA);
                db.AddInParameter(cd, "@in_opportunity", SqlDbType.VarChar, oppId);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;
                        for (int i = 0; i < rowCount; i++)
                        {
                            customerList.Add(MapGET_VERTICAL_DOMAIN_OPP_DATA(ds.Tables[0].Rows[i]));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }
            return customerList;
        }
        private static OpportunityUnitID MapGET_VERTICAL_DOMAIN_OPP_DATA(DataRow objRow)
        {

            return new OpportunityUnitID()
            {

                Id = (objRow.Table.Columns.Contains("id")) ? (objRow["id"] == DBNull.Value) ? 0 : Convert.ToInt32(objRow["id"]) : 0,
                OpportunityId = (objRow.Table.Columns.Contains("OPPORTUNITY_ID")) ? (objRow["OPPORTUNITY_ID"] == DBNull.Value) ? "" : Convert.ToString(objRow["OPPORTUNITY_ID"]) : "",
                BUSINESS_ID = (objRow.Table.Columns.Contains("BUSINESS_ID")) ? (objRow["BUSINESS_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(objRow["BUSINESS_ID"]) : 0,
                LEVEL_ID = (objRow.Table.Columns.Contains("LEVEL1_ID")) ? (objRow["LEVEL1_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(objRow["LEVEL1_ID"]) : 0,
                //LEVEL2_ID = (objRow.Table.Columns.Contains("LEVEL2_ID")) ? (objRow["LEVEL2_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(objRow["LEVEL2_ID"]) : 0,
                FTE = (objRow.Table.Columns.Contains("FTE")) ? (objRow["FTE"] == DBNull.Value) ? 0 : Convert.ToInt32(objRow["FTE"]) : 0,
                SOLUTION_LEAD = (objRow.Table.Columns.Contains("SOLUTION_LEAD")) ? (objRow["SOLUTION_LEAD"] == DBNull.Value) ? "" : Convert.ToString(objRow["SOLUTION_LEAD"]) : "",
                TCV = (objRow.Table.Columns.Contains("TCV")) ? (objRow["TCV"] == DBNull.Value) ? "" : Convert.ToString(objRow["TCV"]) : "",

            };
        }
        /// <summary>
        /// GET Business_Domain Details
        /// </summary>
        public List<OpportunityUnitID> Get_Business_Domain(string unitId)
        {
            DataSet ds = null;
            List<OpportunityUnitID> customerList = new List<OpportunityUnitID>();
            try
            {

                int unit = 0;
                if (!String.IsNullOrEmpty(unitId))
                {
                    unit = Convert.ToInt32(StringFunctions.Base64Decode(unitId));
                }
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Get_Business_Domain);
                db.AddInParameter(cd, "@in_UnitId", SqlDbType.Int, unit);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;
                        for (int i = 0; i < rowCount; i++)
                        {
                            customerList.Add(MapPopulate_cmb_Business_Domain(ds.Tables[0].Rows[i]));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }

            return customerList;
        }
        private static OpportunityUnitID MapPopulate_cmb_Business_Domain(DataRow objRow)
        {

            return new OpportunityUnitID()
            {

                BUSINESS_ID = (objRow.Table.Columns.Contains("BUSINESS_ID")) ? (objRow["BUSINESS_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(objRow["BUSINESS_ID"]) : 0,
                BUSINESS_NAME = (objRow.Table.Columns.Contains("BUSINESS_NAME")) ? (objRow["BUSINESS_NAME"] == DBNull.Value) ? "" : Convert.ToString(objRow["BUSINESS_NAME"]) : "",
                ClusterId = (objRow.Table.Columns.Contains("Cluster_id")) ? (objRow["Cluster_id"] == DBNull.Value) ? 0 : Convert.ToInt32(objRow["Cluster_id"]) : 0,
            };
        }
        /// <summary>
        /// GET Level1_Vertical Details
        /// </summary>
        public List<OpportunityUnitID> Get_Level1_Vertical(string vertical)
        {
            DataSet ds = null;
            List<OpportunityUnitID> customerList = new List<OpportunityUnitID>();
            try
            {


                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Get_Level1_Vertical);
                db.AddInParameter(cd, "@iv_verticalid", SqlDbType.Int, vertical);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;
                        for (int i = 0; i < rowCount; i++)
                        {

                            customerList.Add(MapPopulate_LevelVertical(ds.Tables[0].Rows[i]));

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }

            return customerList;
        }
        /// <summary>
        /// GET Level2_Vertical Details
        /// </summary>
        public List<OpportunityUnitID> Get_Level2_Vertical(string vertical)
        {
            DataSet ds = null;
            List<OpportunityUnitID> customerList = new List<OpportunityUnitID>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Get_Level2_Vertical);
                db.AddInParameter(cd, "@iv_verticalid", SqlDbType.Int, vertical);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;
                        for (int i = 0; i < rowCount; i++)
                        {

                            customerList.Add(MapPopulate_LevelVertical(ds.Tables[0].Rows[i]));

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }

            return customerList;
        }
        private static OpportunityUnitID MapPopulate_LevelVertical(DataRow objRow)
        {

            return new OpportunityUnitID()
            {

                LEVEL_ID = (objRow.Table.Columns.Contains("LEVEL_ID")) ? (objRow["LEVEL_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(objRow["LEVEL_ID"]) : 0,
                LEVEL_NAME = (objRow.Table.Columns.Contains("LEVEL_NAME")) ? (objRow["LEVEL_NAME"] == DBNull.Value) ? "" : Convert.ToString(objRow["LEVEL_NAME"]) : "",

            };
        }
        /// <summary>
        /// SAVE Vertical Domain Data Details
        /// </summary>
        public int Save_VerticalDomainOppdata(CreateNewOpportunity objVertical)
        {
            try
            {
                int intResult;
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.SAVE_Vertical_Domain_Data);
                db.AddInParameter(cd, "@in_OpportunityId", SqlDbType.VarChar, objVertical.strOpportunityId);
                db.AddInParameter(cd, "@in_Vertical", SqlDbType.VarChar, objVertical.BUSINESS_ID.ToString());
                db.AddInParameter(cd, "@in_L1", SqlDbType.VarChar, objVertical.LEVEL_ID);
                db.AddInParameter(cd, "@in_L2", SqlDbType.VarChar, objVertical.LEVEL2_ID);
                db.AddInParameter(cd, "@in_FTE", SqlDbType.Int, objVertical.FTE);
                db.AddInParameter(cd, "@in_SolutionLead", SqlDbType.VarChar, objVertical.SOLUTION_LEAD);
                db.AddInParameter(cd, "@in_TCV", SqlDbType.VarChar, objVertical.TCV.ToString());
                db.AddInParameter(cd, "@in_EmpNo", SqlDbType.VarChar, objVertical.UserLogin);
                db.AddInParameter(cd, "@in_Unit", SqlDbType.VarChar, objVertical.UnitId);
                db.AddInParameter(cd, "@in_id", SqlDbType.VarChar, objVertical.Id);
                db.AddOutParameter(cd, "@on_Result", SqlDbType.Int, Int16.MaxValue);
                db.ExecuteNonQuery(cd);
                intResult = Convert.ToInt16(db.GetParameterValue(cd, "@on_Result"));
                return intResult;
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }

        }
        /// <summary>
        /// DELETE Vertical Domain Data Details
        /// </summary>
        public int Delete_VerticalDomainOppdate(CreateNewOpportunity objVertical)
        {
            try
            {
                int intResult;
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.DELETE_Vertical_Domain_Data);
                db.AddInParameter(cd, "@in_Id", SqlDbType.VarChar, objVertical.Id);
                db.AddInParameter(cd, "@in_EmpNo", SqlDbType.VarChar, objVertical.UserLogin);
                db.AddInParameter(cd, "@in_OppId", SqlDbType.VarChar, objVertical.strOpportunityId);
                db.AddInParameter(cd, "@in_MultiTower", SqlDbType.VarChar, objVertical.MultiTower);
                db.AddOutParameter(cd, "@on_Result", SqlDbType.Int, Int16.MaxValue);
                db.ExecuteNonQuery(cd);
                intResult = Convert.ToInt16(db.GetParameterValue(cd, "@on_Result"));
                return intResult;
            }

            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
        }
        /// <summary>
        /// Get Stage7 Details
        /// </summary>
        public List<CreateNewOpportunity> Get_stage7(string opportunityId, int stageId)
        {
            DataSet ds = null;
            List<CreateNewOpportunity> modelList = new List<CreateNewOpportunity>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.GetOpportunity_Stage7_sp);
                db.AddInParameter(cd, "@in_OpportunityId", SqlDbType.VarChar, opportunityId);
                db.AddInParameter(cd, "@in_StageId", SqlDbType.Int, stageId);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;

                        for (int i = 0; i < rowCount; i++)
                        {
                            modelList.Add(MapGet_stage7(ds.Tables[0].Rows[i]));
                        }

                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }

            return modelList;
        }
        private static CreateNewOpportunity MapGet_stage7(DataRow dr)
        {
            try
            {
                return new CreateNewOpportunity()
                {
                    OpportunityId = (dr.Table.Columns.Contains("OPPORTUNITY_ID")) ? (dr["OPPORTUNITY_ID"] == DBNull.Value) ? "" : Convert.ToString(dr["OPPORTUNITY_ID"]) : "",
                    OPPORTUNITY_DESC = (dr.Table.Columns.Contains("OPPORTUNITY_DESC")) ? (dr["OPPORTUNITY_DESC"] == DBNull.Value) ? "" : dr.Field<string>("OPPORTUNITY_DESC") : "",
                    OLD_OPPORTUNITY_DESC = (dr.Table.Columns.Contains("OLD_OPPORTUNITY_DESC")) ? (dr["OLD_OPPORTUNITY_DESC"] == DBNull.Value) ? "" : dr.Field<string>("OLD_OPPORTUNITY_DESC") : "",
                    GEOGRAPHY_ID = (dr.Table.Columns.Contains("GEOGRAPHY_ID")) ? (dr["GEOGRAPHY_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["GEOGRAPHY_ID"]) : 0,
                    GEOGRAPHY_NAME = (dr.Table.Columns.Contains("GEOGRAPHY_NAME")) ? (dr["GEOGRAPHY_NAME"] == DBNull.Value) ? "" : dr.Field<string>("GEOGRAPHY_NAME") : "",
                    CUST_ID = (dr.Table.Columns.Contains("CUST_ID")) ? (dr["CUST_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CUST_ID"]) : 0,
                    CUST_NAME = (dr.Table.Columns.Contains("CUST_NAME")) ? (dr["CUST_NAME"] == DBNull.Value) ? "" : dr.Field<string>("CUST_NAME") : "",
                    CUST_TYPE_ID = (dr.Table.Columns.Contains("CUST_TYPE_ID")) ? (dr["CUST_TYPE_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CUST_TYPE_ID"]) : 0,
                    CUST_TYPE_NAME = (dr.Table.Columns.Contains("CUST_TYPE_NAME")) ? (dr["CUST_TYPE_NAME"] == DBNull.Value) ? "" : dr.Field<string>("CUST_TYPE_NAME") : "",
                    INDUSTRY_PRACTICE_ID = (dr.Table.Columns.Contains("INDUSTRY_PRACTICE_ID")) ? (dr["INDUSTRY_PRACTICE_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["INDUSTRY_PRACTICE_ID"]) : 0,
                    StageID = (dr.Table.Columns.Contains("STAGE_ID")) ? (dr["STAGE_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["STAGE_ID"]) : 0,
                    INDUSTRY_PRACTICE_NAME = (dr.Table.Columns.Contains("INDUSTRY_PRACTICE_NAME")) ? (dr["INDUSTRY_PRACTICE_NAME"] == DBNull.Value) ? "" : dr.Field<string>("INDUSTRY_PRACTICE_NAME") : "",
                    STAGE_NAME = (dr.Table.Columns.Contains("STAGE_NAME")) ? (dr["STAGE_NAME"] == DBNull.Value) ? "" : dr.Field<string>("STAGE_NAME") : "",
                    ISU_CD = (dr.Table.Columns.Contains("ISU_CD")) ? (dr["ISU_CD"] == DBNull.Value) ? "" : dr.Field<string>("ISU_CD") : "",
                    ISU_NAME = (dr.Table.Columns.Contains("ISU_NAME")) ? (dr["ISU_NAME"] == DBNull.Value) ? "" : dr.Field<string>("ISU_NAME") : "",
                    GEOGRAPHY_SALES_OWNER = (dr.Table.Columns.Contains("GEOGRAPHY_SALES_OWNER_ID")) ? (dr["GEOGRAPHY_SALES_OWNER_ID"] == DBNull.Value) ? "" : dr.Field<string>("GEOGRAPHY_SALES_OWNER_ID") : "",
                    ONSITE_OWNER = (dr.Table.Columns.Contains("ONSITE_OWNER_ID")) ? (dr["ONSITE_OWNER_ID"] == DBNull.Value) ? "" : dr.Field<string>("ONSITE_OWNER_ID") : "",
                    OFFSHORE_BD_LEAD = (dr.Table.Columns.Contains("OFFSHORE_BD_LEAD_ID")) ? (dr["OFFSHORE_BD_LEAD_ID"] == DBNull.Value) ? "" : dr.Field<string>("OFFSHORE_BD_LEAD_ID") : "",
                    OPPORTUNITY_DATE = (dr.Table.Columns.Contains("OPPORTUNITY_DATE")) ? (dr["OPPORTUNITY_DATE"] == DBNull.Value) ? "" : dr.Field<string>("OPPORTUNITY_DATE") : "",
                    DEAL_CLOSURE_EXP_DATE = (dr.Table.Columns.Contains("DEAL_CLOSURE_EXP_DATE")) ? (dr["DEAL_CLOSURE_EXP_DATE"] == DBNull.Value) ? "" : dr.Field<string>("DEAL_CLOSURE_EXP_DATE") : "",
                    DTOTAL_CONTRACT_VALUE = (dr.Table.Columns.Contains("TOTAL_CONTRACT_VALUE")) ? (dr["TOTAL_CONTRACT_VALUE"] == DBNull.Value) ? 0 : Convert.ToDouble(dr["TOTAL_CONTRACT_VALUE"]) : 0,
                    BUSINESS_ID = (dr.Table.Columns.Contains("BUSINESS_ID")) ? (dr["BUSINESS_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["BUSINESS_ID"]) : 0,
                    COUNTRY_ID = (dr.Table.Columns.Contains("COUNTRY_ID")) ? (dr["COUNTRY_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["COUNTRY_ID"]) : 0,
                    PIBS = (dr.Table.Columns.Contains("PIBS")) ? (dr["PIBS"] == DBNull.Value) ? "" : dr.Field<string>("PIBS") : "",
                    CRM_ID = (dr.Table.Columns.Contains("CRM_ID")) ? (dr["CRM_ID"] == DBNull.Value) ? "" : dr.Field<string>("CRM_ID") : "",
                    VALUE_BPS = (dr.Table.Columns.Contains("VALUE_BPS")) ? (dr["VALUE_BPS"] == DBNull.Value) ? "" : dr.Field<string>("VALUE_BPS") : "",
                    VALUE_BPS_TCV = (dr.Table.Columns.Contains("VALUE_BPS_TCV")) ? (dr["VALUE_BPS_TCV"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["VALUE_BPS_TCV"]) : 0,
                    OPP_TYPE = (dr.Table.Columns.Contains("OPP_TYPE")) ? (dr["OPP_TYPE"] == DBNull.Value) ? "" : dr.Field<string>("OPP_TYPE") : "",
                    IESTIMATED_FTE_SIZE = (dr.Table.Columns.Contains("ESTIMATED_FTE_SIZE")) ? (dr["ESTIMATED_FTE_SIZE"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["ESTIMATED_FTE_SIZE"]) : 0,
                    ContractLength = (dr.Table.Columns.Contains("CONTRACT_LENGTH")) ? (dr["CONTRACT_LENGTH"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CONTRACT_LENGTH"]) : 0,
                    ISU_OWNER_ID = (dr.Table.Columns.Contains("ISU_OWNER_ID")) ? (dr["ISU_OWNER_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["ISU_OWNER_ID"]) : 0,
                    ACCOUNT_SALES_OWNER_ID = (dr.Table.Columns.Contains("ACCOUNT_SALES_OWNER_ID")) ? (dr["ACCOUNT_SALES_OWNER_ID"] == DBNull.Value) ? "" : dr.Field<string>("ACCOUNT_SALES_OWNER_ID") : "",
                    GEOGRAPHY_SALES_OWNER_ID = (dr.Table.Columns.Contains("GEOGRAPHY_SALES_OWNER_ID")) ? (dr["GEOGRAPHY_SALES_OWNER_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["GEOGRAPHY_SALES_OWNER_ID"]) : 0,
                    OFFSHORE_BD_LEAD_ID = (dr.Table.Columns.Contains("OFFSHORE_BD_LEAD_ID")) ? (dr["OFFSHORE_BD_LEAD_ID"] == DBNull.Value) ? "" : dr.Field<string>("OFFSHORE_BD_LEAD_ID") : "",
                    LAST_UPDATE = (dr.Table.Columns.Contains("LAST_UPDATE")) ? (dr["LAST_UPDATE"] == DBNull.Value) ? "" : dr.Field<string>("LAST_UPDATE") : "",
                    DEAL_BD_LEAD_ID = (dr.Table.Columns.Contains("DEAL_BD_LEAD_ID")) ? (dr["DEAL_BD_LEAD_ID"] == DBNull.Value) ? "" : dr.Field<string>("DEAL_BD_LEAD_ID") : "",
                    DEAL_BD_LEAD_ID2 = (dr.Table.Columns.Contains("DEAL_BD_LEAD_ID2")) ? (dr["DEAL_BD_LEAD_ID2"] == DBNull.Value) ? "" : dr.Field<string>("DEAL_BD_LEAD_ID2") : "",
                    RFI_ReviewDate = (dr.Table.Columns.Contains("RFI_REVIEW_DT")) ? (dr["RFI_REVIEW_DT"] == DBNull.Value) ? "" : dr.Field<string>("RFI_REVIEW_DT") : "",
                    RFP_ReviewDate = (dr.Table.Columns.Contains("RFP_REVIEW_DT")) ? (dr["RFP_REVIEW_DT"] == DBNull.Value) ? "" : dr.Field<string>("RFP_REVIEW_DT") : "",
                    RFI_ReceivedDate = (dr.Table.Columns.Contains("RFI_RECEIVED_DT")) ? (dr["RFI_RECEIVED_DT"] == DBNull.Value) ? "" : dr.Field<string>("RFI_RECEIVED_DT") : "",
                    RFP_ReceivedDate = (dr.Table.Columns.Contains("RFP_RECEIVED_DT")) ? (dr["RFP_RECEIVED_DT"] == DBNull.Value) ? "" : dr.Field<string>("RFP_RECEIVED_DT") : "",
                    RFI_ProbableSubmissionDate = (dr.Table.Columns.Contains("RFI_PROBABLE_SUBMISSION_DT")) ? (dr["RFI_PROBABLE_SUBMISSION_DT"] == DBNull.Value) ? "" : dr.Field<string>("RFI_PROBABLE_SUBMISSION_DT") : "",
                    RFP_ProbableSubmissionDate = (dr.Table.Columns.Contains("RFP_PROBABLE_SUBMISSION_DT")) ? (dr["RFP_PROBABLE_SUBMISSION_DT"] == DBNull.Value) ? "" : dr.Field<string>("RFP_PROBABLE_SUBMISSION_DT") : "",
                    RFI_ActualSubmissionDate = (dr.Table.Columns.Contains("RFI_ACTUAL_SUBMISSION_DT")) ? (dr["RFI_ACTUAL_SUBMISSION_DT"] == DBNull.Value) ? "" : dr.Field<string>("RFI_ACTUAL_SUBMISSION_DT") : "",
                    RFP_ActualSubmissionDate = (dr.Table.Columns.Contains("RFP_ACTUAL_SUBMISSION_DT")) ? (dr["RFP_ACTUAL_SUBMISSION_DT"] == DBNull.Value) ? "" : dr.Field<string>("RFP_ACTUAL_SUBMISSION_DT") : "",
                    BCP_DRP_LOCATION = (dr.Table.Columns.Contains("BCP_DRP_LOCATION")) ? (dr["BCP_DRP_LOCATION"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["BCP_DRP_LOCATION"]) : 0,
                    RFI_REVIEW_BY = (dr.Table.Columns.Contains("RFI_REVIEW_BY")) ? (dr["RFI_REVIEW_BY"] == DBNull.Value) ? "" : dr.Field<string>("RFI_REVIEW_BY") : "",
                    RFP_REVIEW_BY = (dr.Table.Columns.Contains("RFP_REVIEW_BY")) ? (dr["RFP_REVIEW_BY"] == DBNull.Value) ? "" : dr.Field<string>("RFP_REVIEW_BY") : "",
                    CURRENCY_ID = (dr.Table.Columns.Contains("CURRENCY_ID")) ? (dr["CURRENCY_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CURRENCY_ID"]) : 0,
                    FTEOff = (dr.Table.Columns.Contains("FTE_OFFSHORE")) ? (dr["FTE_OFFSHORE"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["FTE_OFFSHORE"]) : 0,
                    FTEOn = (dr.Table.Columns.Contains("FTE_ONSITE")) ? (dr["FTE_ONSITE"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["FTE_ONSITE"]) : 0,
                    ClusterId = (dr.Table.Columns.Contains("CLUSTER_ID")) ? (dr["CLUSTER_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CLUSTER_ID"]) : 0,
                    DealCategory = (dr.Table.Columns.Contains("DEAL_CATEGORY")) ? (dr["DEAL_CATEGORY"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["DEAL_CATEGORY"]) : 0,
                    BPS_OFFERING_ID = (dr.Table.Columns.Contains("BPS_OFFERING_ID")) ? (dr["BPS_OFFERING_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["BPS_OFFERING_ID"]) : 0,
                    SERVICE_ID = (dr.Table.Columns.Contains("SERVICE_ID")) ? (dr["SERVICE_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["SERVICE_ID"]) : 0,
                    SUB_IOU = (dr.Table.Columns.Contains("SUB_IOU")) ? (dr["SUB_IOU"] == DBNull.Value) ? "" : dr.Field<string>("SUB_IOU") : "",
                    EXECUTIVE_SPONSOR = (dr.Table.Columns.Contains("EXECUTIVE_SPONSOR")) ? (dr["EXECUTIVE_SPONSOR"] == DBNull.Value) ? "" : dr.Field<string>("EXECUTIVE_SPONSOR") : "",
                    VALBPS_CON = (dr.Table.Columns.Contains("VALBPS_CON")) ? (dr["VALBPS_CON"] == DBNull.Value) ? "" : dr.Field<string>("VALBPS_CON") : "",
                    PROACTIVE_PROPOSAL = (dr.Table.Columns.Contains("PROACTIVE_PROPOSAL")) ? (dr["PROACTIVE_PROPOSAL"] == DBNull.Value) ? "" : dr.Field<string>("PROACTIVE_PROPOSAL") : "",
                    ISU_MAIN = (dr.Table.Columns.Contains("ISU_MAIN")) ? (dr["ISU_MAIN"] == DBNull.Value) ? "" : dr.Field<string>("ISU_MAIN") : "",
                    Quarter = (dr.Table.Columns.Contains("quarter")) ? (dr["quarter"] == DBNull.Value) ? "" : dr.Field<string>("quarter") : "",
                    FISCAL_YEAR = (dr.Table.Columns.Contains("FISCAL_YEAR")) ? (dr["FISCAL_YEAR"] == DBNull.Value) ? "" : dr.Field<string>("FISCAL_YEAR") : "",
                    PROPOSAL_FACTORY = (dr.Table.Columns.Contains("PROPOSAL_FACTORY")) ? (dr["PROPOSAL_FACTORY"] == DBNull.Value) ? "" : dr.Field<string>("PROPOSAL_FACTORY") : "",
                    PROPOSAL_FACTORY_OPTIONS = (dr.Table.Columns.Contains("PROPOSAL_FACTORY_OPTIONS")) ? (dr["PROPOSAL_FACTORY_OPTIONS"] == DBNull.Value) ? "" : dr.Field<string>("PROPOSAL_FACTORY_OPTIONS") : "",
                    PROPOSAL_FACTORY_COMMENTS = (dr.Table.Columns.Contains("PROPOSAL_FACTORY_COMMENTS")) ? (dr["PROPOSAL_FACTORY_COMMENTS"] == DBNull.Value) ? "" : dr.Field<string>("PROPOSAL_FACTORY_COMMENTS") : "",
                    DT_ID = (dr.Table.Columns.Contains("DT_ID")) ? (dr["DT_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["DT_ID"]) : 0,
                    Other_DT = (dr.Table.Columns.Contains("Other_DT")) ? (dr["Other_DT"] == DBNull.Value) ? "" : dr.Field<string>("Other_DT") : "",
                    CRM_TCV = (dr.Table.Columns.Contains("CRM_TCV")) ? (dr["CRM_TCV"] == DBNull.Value) ? "" : Convert.ToString(dr["CRM_TCV"]) : "",
                    CRM_STAGE = (dr.Table.Columns.Contains("CRM_STAGE")) ? (dr["CRM_STAGE"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CRM_STAGE"]) : 0,
                    strDigitalTcv = (dr.Table.Columns.Contains("Digital_TCV")) ? (dr["Digital_TCV"] == DBNull.Value) ? "" : dr.Field<string>("Digital_TCV") : "",
                    subSPId = (dr.Table.Columns.Contains("SubSPID")) ? (dr["SubSPID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["SubSPID"]) : 0,
                    CRM_Beacon = (dr.Table.Columns.Contains("CRM_Beacon")) ? (dr["CRM_Beacon"] == DBNull.Value) ? "" : Convert.ToString(dr["CRM_Beacon"]) : "",
                    MULTITOWER_DEAL = (dr.Table.Columns.Contains("MULTITOWER_DEAL")) ? (dr["MULTITOWER_DEAL"] == DBNull.Value) ? "" : dr.Field<string>("MULTITOWER_DEAL") : "",
                    TataGroupAccount = (dr.Table.Columns.Contains("TATA_GROUP_ACCOUNT")) ? (dr["TATA_GROUP_ACCOUNT"] == DBNull.Value) ? "" : Convert.ToString(dr["TATA_GROUP_ACCOUNT"]) : "",
                    ItisScope = (dr.Table.Columns.Contains("ItisScope")) ? (dr["ItisScope"] == DBNull.Value) ? "" : Convert.ToString(dr["ItisScope"]) : "",
                    IsContractRenewal = (dr.Table.Columns.Contains("IsContractRenewal")) ? (dr["IsContractRenewal"] == DBNull.Value) ? "" : Convert.ToString(dr["IsContractRenewal"]) : "",
                    ContractRenewalValue = (dr.Table.Columns.Contains("ContractRenewalValue")) ? (dr["ContractRenewalValue"] == DBNull.Value) ? "" : Convert.ToString(dr["ContractRenewalValue"]) : "",                  
                    RESOURCING_ID = (dr.Table.Columns.Contains("ResourcingId")) ? (dr["ResourcingId"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["ResourcingId"]) : 0,
                    SEAT_IDENTIFICATION_ID = (dr.Table.Columns.Contains("Seat_IdentificationId")) ? (dr["Seat_IdentificationId"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["Seat_IdentificationId"]) : 0,
                    SHORTLIST_DT = (dr.Table.Columns.Contains("SHORTLIST_DT")) ? (dr["SHORTLIST_DT"] == DBNull.Value) ? "" : Convert.ToString(dr["SHORTLIST_DT"]) : "",
                    SELECTION_DT = (dr.Table.Columns.Contains("SELECTION_DT")) ? (dr["SELECTION_DT"] == DBNull.Value) ? "" : Convert.ToString(dr["SELECTION_DT"]) : "",
                    ONSITE_TRAINING_NOS = (dr.Table.Columns.Contains("ONSITE_TRAINING_NOS")) ? (dr["ONSITE_TRAINING_NOS"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["ONSITE_TRAINING_NOS"]) : 0,
                    VISA_REQUIRED = (dr.Table.Columns.Contains("VISA_REQUIRED")) ? (dr["VISA_REQUIRED"] == DBNull.Value) ? "" : dr.Field<string>("VISA_REQUIRED") : "",
                    VISAS_REQUIRED = (dr.Table.Columns.Contains("VISAS_REQUIRED")) ? (dr["VISAS_REQUIRED"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["VISAS_REQUIRED"]) : 0,
                    TRAINING_DURATION = (dr.Table.Columns.Contains("TRAINING_DURATION")) ? (dr["TRAINING_DURATION"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["TRAINING_DURATION"]) : 0,
                    DealStatus = (dr.Table.Columns.Contains("DealStatus_Id")) ? (dr["DealStatus_Id"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["DealStatus_Id"]) : 0,
                    ServicePractice = (dr.Table.Columns.Contains("ServicePractice_Id")) ? (dr["ServicePractice_Id"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["ServicePractice_Id"]) : 0,
                    CoreOffering = (dr.Table.Columns.Contains("CoreOffering_Id")) ? (dr["CoreOffering_Id"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CoreOffering_Id"]) : 0,
                    OpportunityDescDetails = (dr.Table.Columns.Contains("Opportunity_Desc_Details")) ? (dr["Opportunity_Desc_Details"] == DBNull.Value) ? "" : dr.Field<string>("Opportunity_Desc_Details") : "",
                    offeringType = (dr.Table.Columns.Contains("OfferingType_Id")) ? (dr["OfferingType_Id"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["OfferingType_Id"]) : 0,
                    CofID = (dr.Table.Columns.Contains("CoreOfferingName_Id")) ? (dr["CoreOfferingName_Id"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CoreOfferingName_Id"]) : 0,

                    PROPOSAL_SUBMISSION_DATE = (dr.Table.Columns.Contains("PROPOSAL_SUBMISSION_DATE")) ? (dr["PROPOSAL_SUBMISSION_DATE"] == DBNull.Value) ? "" : dr.Field<string>("PROPOSAL_SUBMISSION_DATE") : "",
                    SALES_STAGE_MOVED_ONDATE = (dr.Table.Columns.Contains("SALES_STAGE_MOVED_ON_DATE")) ? (dr["SALES_STAGE_MOVED_ON_DATE"] == DBNull.Value) ? "" : dr.Field<string>("SALES_STAGE_MOVED_ON_DATE") : "",

                    
                    DigitalFlagging = (dr.Table.Columns.Contains("Digital_Flagging")) ? (dr["Digital_Flagging"] == DBNull.Value) ? "" : Convert.ToString(dr["Digital_Flagging"]) : "",
                    

                    Previous_Deal_Stage = (dr.Table.Columns.Contains("Previous_Deal_Stage")) ? (dr["Previous_Deal_Stage"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["Previous_Deal_Stage"]) : 0,

                    DELIVERY_LOCATION_PROPOSED = (dr.Table.Columns.Contains("DELIVERY_LOCATION_PROPOSED")) ? (dr["DELIVERY_LOCATION_PROPOSED"] == DBNull.Value) ? "" : dr.Field<string>("DELIVERY_LOCATION_PROPOSED") : "",

                    Cboi_Offering_id = (dr.Table.Columns.Contains("cboi_offering_id")) ? (dr["cboi_offering_id"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["cboi_offering_id"]) : 0,
                    Deal_Flag_id = (dr.Table.Columns.Contains("deal_flag")) ? (dr["deal_flag"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["deal_flag"]) : 0,
                    PLATFORM = (dr.Table.Columns.Contains("PLATFORM")) ? (dr["PLATFORM"] == DBNull.Value) ? "" : dr.Field<string>("PLATFORM") : "",
                    PLATFORM_OPTION = (dr.Table.Columns.Contains("PLATFORM_OPTION")) ? (dr["PLATFORM_OPTION"] == DBNull.Value) ? "" : dr.Field<string>("PLATFORM_OPTION") : "",




                };
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
        }
        /// <summary>
        /// Get Deal Reason Details
        /// </summary>
        public List<DealReason> Get_Deal_Reason()
        {
            DataSet ds = null;
            List<DealReason> customerList = new List<DealReason>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Get_Deal_Reason);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;
                        for (int i = 0; i < rowCount; i++)
                        {
                            customerList.Add(MapGet_Deal_Reason(ds.Tables[0].Rows[i]));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }

            return customerList;
        }
        private static DealReason MapGet_Deal_Reason(DataRow objRow)
        {

            return new DealReason()
            {

                DEAL_REASON_ID = (objRow.Table.Columns.Contains("DEAL_REASON_ID")) ? (objRow["DEAL_REASON_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(objRow["DEAL_REASON_ID"]) : 0,
                DEAL_REASON_NAME = (objRow.Table.Columns.Contains("DEAL_REASON_NAME")) ? (objRow["DEAL_REASON_NAME"] == DBNull.Value) ? "" : Convert.ToString(objRow["DEAL_REASON_NAME"]) : "",

            };
        }
        /// <summary>
        /// Get Product Details
        /// </summary>
        public List<CreateNewOpportunity> Get_Product()
        {
            DataSet ds = null;
            List<CreateNewOpportunity> customerList = new List<CreateNewOpportunity>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Get_Product);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;
                        for (int i = 0; i < rowCount; i++)
                        {
                            customerList.Add(MapGet_Product(ds.Tables[0].Rows[i]));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }

            return customerList;
        }
        private static CreateNewOpportunity MapGet_Product(DataRow objRow)
        {

            return new CreateNewOpportunity()
            {

                PRODUCT_ID = (objRow.Table.Columns.Contains("PRODUCT_ID")) ? (objRow["PRODUCT_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(objRow["PRODUCT_ID"]) : 0,
                PRODUCT_NAME = (objRow.Table.Columns.Contains("PRODUCT_NAME")) ? (objRow["PRODUCT_NAME"] == DBNull.Value) ? "" : Convert.ToString(objRow["PRODUCT_NAME"]) : "",

            };
        }
        /// <summary>
        /// Get BCP Details
        /// </summary>
        public List<Location> Get_BCP()
        {
            DataSet ds = null;
            List<Location> customerList = new List<Location>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Get_BCP);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;
                        for (int i = 0; i < rowCount; i++)
                        {
                            customerList.Add(MapGet_BCP(ds.Tables[0].Rows[i]));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }

            return customerList;
        }
        private static Location MapGet_BCP(DataRow objRow)
        {

            return new Location()
            {

                LOCATION_ID = (objRow.Table.Columns.Contains("LOCATION_ID")) ? (objRow["LOCATION_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(objRow["LOCATION_ID"]) : 0,
                LOCATION_NAME = (objRow.Table.Columns.Contains("LOCATION_NAME")) ? (objRow["LOCATION_NAME"] == DBNull.Value) ? "" : Convert.ToString(objRow["LOCATION_NAME"]) : "",

            };
        }
        /// <summary>
        /// Get Win Reason Master Details
        /// </summary>
        public List<MultiSelectList> Get_WIN_REASON_MASTER()
        {
            DataSet ds = null;
            List<MultiSelectList> customerList = new List<MultiSelectList>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Get_WIN_REASON_MASTER);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;
                        for (int i = 0; i < rowCount; i++)
                        {
                            customerList.Add(MapGet_WIN_REASON_MASTER(ds.Tables[0].Rows[i]));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }

            return customerList;
        }
        private static MultiSelectList MapGet_WIN_REASON_MASTER(DataRow objRow)
        {
            return new MultiSelectList()
            {

                id = (objRow.Table.Columns.Contains("WIN_REASON_ID")) ? (objRow["WIN_REASON_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(objRow["WIN_REASON_ID"]) : 0,
                itemName = (objRow.Table.Columns.Contains("WIN_REASON_NAME")) ? (objRow["WIN_REASON_NAME"] == DBNull.Value) ? "" : Convert.ToString(objRow["WIN_REASON_NAME"]) : "",

            };
        }
        /// <summary>
        /// Get Opp_Win_Loss_Reason Details
        /// </summary>
        public List<MultiSelectList> Get_Opp_Win_Loss_Reason(string oppID)
        {
            DataSet ds = null;
            List<MultiSelectList> customerList = new List<MultiSelectList>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Get_Opp_Win_Loss_Reason);
                db.AddInParameter(cd, "@iv_OppID", SqlDbType.VarChar, oppID);

                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;
                        for (int i = 0; i < rowCount; i++)
                        {
                            customerList.Add(MapGet_Opp_Win_Loss_Reason(ds.Tables[0].Rows[i]));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }

            return customerList;
        }
        private static MultiSelectList MapGet_Opp_Win_Loss_Reason(DataRow objRow)
        {

            return new MultiSelectList()
            {

                id = (objRow.Table.Columns.Contains("WIN_LOSS_REASON_ID")) ? (objRow["WIN_LOSS_REASON_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(objRow["WIN_LOSS_REASON_ID"]) : 0,
                itemName= (objRow.Table.Columns.Contains("WIN_REASON_NAME")) ? (objRow["WIN_REASON_NAME"] == DBNull.Value) ? "" : Convert.ToString(objRow["WIN_REASON_NAME"]) : "",

            };
        }
        /// <summary>
        /// Get Deal_Qual_Questions Details
        /// </summary>
        public List<CreateNewOpportunity> Get_Deal_Qual_Questions(int DealQualID)
        {
            DataSet ds = null;
            List<CreateNewOpportunity> customerList = new List<CreateNewOpportunity>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Get_Deal_Qual_Questions);
                db.AddInParameter(cd, "@in_DealQualID", SqlDbType.Int, DealQualID);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;

                        for (int i = 0; i < rowCount; i++)
                        {
                            customerList.Add(MapGet_Deal_Qual_Questions(ds.Tables[0].Rows[i]));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }

            return customerList;
        }

        private static CreateNewOpportunity MapGet_Deal_Qual_Questions(DataRow objRow)
        {

            return new CreateNewOpportunity()
            {

                DEAL_QUAL_ID = (objRow.Table.Columns.Contains("DEAL_QUAL_ID")) ? (objRow["DEAL_QUAL_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(objRow["DEAL_QUAL_ID"]) : 0,
                DEAL_QUAL_GRP_ID = (objRow.Table.Columns.Contains("DEAL_QUAL_GRP_ID")) ? (objRow["DEAL_QUAL_GRP_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(objRow["DEAL_QUAL_GRP_ID"]) : 0,
                DEAL_QUAL_GRP_NAME = (objRow.Table.Columns.Contains("DEAL_QUAL_GRP_NAME")) ? (objRow["DEAL_QUAL_GRP_NAME"] == DBNull.Value) ? "" : Convert.ToString(objRow["DEAL_QUAL_GRP_NAME"]) : "",
                DEAL_QUAL_FIELD_ID = (objRow.Table.Columns.Contains("DEAL_QUAL_FIELD_ID")) ? (objRow["DEAL_QUAL_FIELD_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(objRow["DEAL_QUAL_FIELD_ID"]) : 0,
                DEAL_QUAL_FIELD_NAME = (objRow.Table.Columns.Contains("DEAL_QUAL_FIELD_NAME")) ? (objRow["DEAL_QUAL_FIELD_NAME"] == DBNull.Value) ? "" : Convert.ToString(objRow["DEAL_QUAL_FIELD_NAME"]) : "",
                DEAL_QUAL_WEIGHTAGE = (objRow.Table.Columns.Contains("DEAL_QUAL_WEIGHTAGE")) ? (objRow["DEAL_QUAL_WEIGHTAGE"] == DBNull.Value) ? "" : Convert.ToString(objRow["DEAL_QUAL_WEIGHTAGE"]) : "",

            };
        }
        /// <summary>
        /// Get Competitor_WithoutDontKnow Details
        /// </summary>
        public List<MultiSelect> Get_Competitor_WithoutDontKnow()
        {
            DataSet ds = null;
            List<MultiSelect> customerList = new List<MultiSelect>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Get_Competitor_WithoutDontKnow);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;
                        for (int i = 0; i < rowCount; i++)
                        {
                            customerList.Add(MapPopulate_cmb_Competitor(ds.Tables[0].Rows[i]));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }

            return customerList;
        }
        /// <summary>
        /// Get OperationWindow Details
        /// </summary>
        public List<CreateNewOpportunity> Get_OperationWindow()
        {
            DataSet ds = null;
            List<CreateNewOpportunity> customerList = new List<CreateNewOpportunity>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Get_OperationWindow);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;

                        for (int i = 0; i < rowCount; i++)
                        {
                            customerList.Add(MapGet_OperationWindow(ds.Tables[0].Rows[i]));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }

            return customerList;
        }

        private static CreateNewOpportunity MapGet_OperationWindow(DataRow objRow)
        {

            return new CreateNewOpportunity()
            {

                OPEATION_WINDOW_ID = (objRow.Table.Columns.Contains("OPEATION_WINDOW_ID")) ? (objRow["OPEATION_WINDOW_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(objRow["OPEATION_WINDOW_ID"]) : 0,
                OPERATION_WINDOW_NAME = (objRow.Table.Columns.Contains("OPERATION_WINDOW_NAME")) ? (objRow["OPERATION_WINDOW_NAME"] == DBNull.Value) ? "" : Convert.ToString(objRow["OPERATION_WINDOW_NAME"]) : "",

            };
        }
        /// <summary>
        /// Get TypesOfSeat Details
        /// </summary>
        public List<Seat> Get_TypesOfSeat()
        {
            DataSet ds = null;
            List<Seat> customerList = new List<Seat>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Get_TypesOfSeat);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;
                        for (int i = 0; i < rowCount; i++)
                        {
                            customerList.Add(MaPGet_TypesOfSeat(ds.Tables[0].Rows[i]));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }

            return customerList;
        }

        private static Seat MaPGet_TypesOfSeat(DataRow objRow)
        {

            return new Seat()
            {

                TYPES_OF_SEAT_ID = (objRow.Table.Columns.Contains("TYPES_OF_SEAT_ID")) ? (objRow["TYPES_OF_SEAT_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(objRow["TYPES_OF_SEAT_ID"]) : 0,
                TYPES_OF_SEAT_NAME = (objRow.Table.Columns.Contains("TYPES_OF_SEAT_NAME")) ? (objRow["TYPES_OF_SEAT_NAME"] == DBNull.Value) ? "" : Convert.ToString(objRow["TYPES_OF_SEAT_NAME"]) : "",

            };
        }



        /// <summary>
        /// Get Opportunity Stage1 System Details
        /// </summary>
        public List<CreateNewOpportunity> GetOpportunity_Stage1_SYS_sp(string OpportunityId, int StageId)
        {
            DataSet ds = null;
            List<CreateNewOpportunity> customerList = new List<CreateNewOpportunity>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.GetOpportunity_Stage1_SYS_sp);
                db.AddInParameter(cd, "@in_OpportunityId", SqlDbType.VarChar, OpportunityId);
                db.AddInParameter(cd, "@in_StageId", SqlDbType.Int, StageId);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;
                        for (int i = 0; i < rowCount; i++)
                        {
                            customerList.Add(MaPGetOpportunity_Stage1_SYS_sp(ds.Tables[0].Rows[i]));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }
            return customerList;
        }

        private static CreateNewOpportunity MaPGetOpportunity_Stage1_SYS_sp(DataRow objRow)
        {

            return new CreateNewOpportunity()
            {

                STAGESTS = (objRow.Table.Columns.Contains("STAGESTS")) ? (objRow["STAGESTS"] == DBNull.Value) ? "" : Convert.ToString(objRow["STAGESTS"]) : "",
                PCS_REQUIRED = (objRow.Table.Columns.Contains("PCS_REQUIRED")) ? (objRow["PCS_REQUIRED"] == DBNull.Value) ? 0 : Convert.ToInt32(objRow["PCS_REQUIRED"]) : 0,
                DESKS_REQUIRED = (objRow.Table.Columns.Contains("DESKS_REQUIRED")) ? (objRow["DESKS_REQUIRED"] == DBNull.Value) ? 0 : Convert.ToInt32(objRow["DESKS_REQUIRED"]) : 0,
                PHONES_REQUIRED = (objRow.Table.Columns.Contains("PHONES_REQUIRED")) ? (objRow["PHONES_REQUIRED"] == DBNull.Value) ? 0 : Convert.ToInt32(objRow["PHONES_REQUIRED"]) : 0,
                CABINS_REQUIRED = (objRow.Table.Columns.Contains("CABINS_REQUIRED")) ? (objRow["CABINS_REQUIRED"] == DBNull.Value) ? 0 : Convert.ToInt32(objRow["CABINS_REQUIRED"]) : 0,
                LAPTOPS_REQUIRED = (objRow.Table.Columns.Contains("LAPTOPS_REQUIRED")) ? (objRow["LAPTOPS_REQUIRED"] == DBNull.Value) ? 0 : Convert.ToInt32(objRow["LAPTOPS_REQUIRED"]) : 0,

            };
        }
        /// <summary>
        /// Get Opportunity Stage1 Resource Details
        /// </summary>
        public List<CreateNewOpportunity> GetOpportunity_Stage1_Resource_sp(string OpportunityId, int StageId)
        {
            DataSet ds = null;
            List<CreateNewOpportunity> customerList = new List<CreateNewOpportunity>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.GetOpportunity_Stage1_Resource_sp);
                db.AddInParameter(cd, "@in_OpportunityId", SqlDbType.VarChar, OpportunityId);
                db.AddInParameter(cd, "@in_StageId", SqlDbType.Int, StageId);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;
                        for (int i = 0; i < rowCount; i++)
                        {
                            customerList.Add(MaPGetOpportunity_Stage1_Resource_sp(ds.Tables[0].Rows[i]));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }
            return customerList;
        }

        private static CreateNewOpportunity MaPGetOpportunity_Stage1_Resource_sp(DataRow objRow)
        {
            return new CreateNewOpportunity()
            {
                STAGESTS = (objRow.Table.Columns.Contains("STAGESTS")) ? (objRow["STAGESTS"] == DBNull.Value) ? "" : Convert.ToString(objRow["STAGESTS"]) : "",
                NO_SOL_TEAM_MEM = (objRow.Table.Columns.Contains("NO_SOL_TEAM_MEM")) ? (objRow["NO_SOL_TEAM_MEM"] == DBNull.Value) ? "" : Convert.ToString(objRow["NO_SOL_TEAM_MEM"]) : "",
                NO_DEL_TEAM_MEM = (objRow.Table.Columns.Contains("NO_DEL_TEAM_MEM")) ? (objRow["NO_DEL_TEAM_MEM"] == DBNull.Value) ? "" : Convert.ToString(objRow["NO_DEL_TEAM_MEM"]) : "",
                BID_MANAGER = (objRow.Table.Columns.Contains("BID_MANAGER")) ? (objRow["BID_MANAGER"] == DBNull.Value) ? "" : Convert.ToString(objRow["BID_MANAGER"]) : "",
                BID_EXEC_OWNER = (objRow.Table.Columns.Contains("BID_EXEC_OWNER")) ? (objRow["BID_EXEC_OWNER"] == DBNull.Value) ? "" : Convert.ToString(objRow["BID_EXEC_OWNER"]) : "",
                PRICING_OWNER = (objRow.Table.Columns.Contains("PRICING_OWNER")) ? (objRow["PRICING_OWNER"] == DBNull.Value) ? "" : Convert.ToString(objRow["PRICING_OWNER"]) : "",
                TRANSITION_TEAM = (objRow.Table.Columns.Contains("TRANSITION_TEAM")) ? (objRow["TRANSITION_TEAM"] == DBNull.Value) ? "" : Convert.ToString(objRow["TRANSITION_TEAM"]) : "",
                TRANSITION_REQUIRED = (objRow.Table.Columns.Contains("TRANSITION_REQUIRED")) ? (objRow["TRANSITION_REQUIRED"] == DBNull.Value) ? "" : Convert.ToString(objRow["TRANSITION_REQUIRED"]) : "",
                EXPECTED_START_DATE = (objRow.Table.Columns.Contains("EXPECTED_START_DATE")) ? (objRow["EXPECTED_START_DATE"] == DBNull.Value) ? "" : Convert.ToString(objRow["EXPECTED_START_DATE"]) : "",
                IMMEDIATE_COMMENT = (objRow.Table.Columns.Contains("IMMEDIATE_COMMENT")) ? (objRow["IMMEDIATE_COMMENT"] == DBNull.Value) ? "" : Convert.ToString(objRow["IMMEDIATE_COMMENT"]) : "",
                FTE_DD = (objRow.Table.Columns.Contains("FTE_DD")) ? (objRow["FTE_DD"] == DBNull.Value) ? "" : Convert.ToString(objRow["FTE_DD"]) : "",
                SOLUTION_LEADER = (objRow.Table.Columns.Contains("SOLUTION_LEADER")) ? (objRow["SOLUTION_LEADER"] == DBNull.Value) ? "" : Convert.ToString(objRow["SOLUTION_LEADER"]) : "",
                RUR = (objRow.Table.Columns.Contains("RUR")) ? (objRow["RUR"] == DBNull.Value) ? "" : Convert.ToString(objRow["RUR"]) : "",
                HRT_COMMENTS = (objRow.Table.Columns.Contains("HRT_COMMENTS")) ? (objRow["HRT_COMMENTS"] == DBNull.Value) ? "" : Convert.ToString(objRow["HRT_COMMENTS"]) : "",
                BID_MANAGER_EMPID = (objRow.Table.Columns.Contains("BID_MANAGER_EMPID")) ? (objRow["BID_MANAGER_EMPID"] == DBNull.Value) ? "" : Convert.ToString(objRow["BID_MANAGER_EMPID"]) : "",
                BID_EXEC_OWNER_EMPID = (objRow.Table.Columns.Contains("BID_EXEC_OWNER_EMPID")) ? (objRow["BID_EXEC_OWNER_EMPID"] == DBNull.Value) ? "" : Convert.ToString(objRow["BID_EXEC_OWNER_EMPID"]) : "",
                PRICING_OWNER_EMPID = (objRow.Table.Columns.Contains("PRICING_OWNER_EMPID")) ? (objRow["PRICING_OWNER_EMPID"] == DBNull.Value) ? "" : Convert.ToString(objRow["PRICING_OWNER_EMPID"]) : "",
                SOLUTION_LEADER_EMPID = (objRow.Table.Columns.Contains("SOLUTION_LEADER_EMPID")) ? (objRow["SOLUTION_LEADER_EMPID"] == DBNull.Value) ? "" : Convert.ToString(objRow["SOLUTION_LEADER_EMPID"]) : "",
                TRANSITION_EMPID = (objRow.Table.Columns.Contains("TRANSITION_EMPID")) ? (objRow["TRANSITION_EMPID"] == DBNull.Value) ? "" : Convert.ToString(objRow["TRANSITION_EMPID"]) : "",
                TRANSITION_EMPNAME = (objRow.Table.Columns.Contains("TRANSITION_EMPNAME")) ? (objRow["TRANSITION_EMPNAME"] == DBNull.Value) ? "" : Convert.ToString(objRow["TRANSITION_EMPNAME"]) : "",
                TRANSITION_TYPE = (objRow.Table.Columns.Contains("TRANSITION_TYPE")) ? (objRow["TRANSITION_TYPE"] == DBNull.Value) ? "" : Convert.ToString(objRow["TRANSITION_TYPE"]) : "",
                TRANSITION_APPROACH = (objRow.Table.Columns.Contains("TRANSITION_APPROACH")) ? (objRow["TRANSITION_APPROACH"] == DBNull.Value) ? "" : Convert.ToString(objRow["TRANSITION_APPROACH"]) : "",
                TRANSITION_MODEL = (objRow.Table.Columns.Contains("TRANSITION_MODEL")) ? (objRow["TRANSITION_MODEL"] == DBNull.Value) ? "" : Convert.ToString(objRow["TRANSITION_MODEL"]) : "",

            };
        }
        /// <summary>
        /// Update OppWINLossReason Details
        /// </summary>
        public int Upd_OppWINLossReason(CreateNewOpportunity obj)
        {
            try
            {
                int intResult;
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Upd_OppWINLossReason);
                db.AddInParameter(cd, "@iv_OppID", SqlDbType.VarChar, obj.OpportunityId);
                db.AddInParameter(cd, "@in_WINLossID", SqlDbType.Int, obj.WIN_LOSS_REASON_ID);
                db.AddInParameter(cd, "@iv_UserLogin", SqlDbType.VarChar, obj.UserLogin);
                db.AddOutParameter(cd, "@on_Result", SqlDbType.Int, Int32.MaxValue);
                db.ExecuteNonQuery(cd);
                intResult = Convert.ToInt16(db.GetParameterValue(cd, "@on_Result"));
                return intResult;
            }

            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
        }

        /// <summary>
        /// Save OppWINLossReason Details
        /// </summary>
        public int Save_OppWINLossReason(CreateNewOpportunity obj)
        {
            try
            {
                int intResult;
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Ins_OppWINLossReason);
                db.AddInParameter(cd, "@iv_OppID", SqlDbType.VarChar, obj.OpportunityId);
                db.AddInParameter(cd, "@in_WINLOSSID", SqlDbType.Int, obj.WIN_LOSS_REASON_ID);
                db.AddInParameter(cd, "@iv_UserLogin", SqlDbType.VarChar, obj.UserLogin);
                db.AddOutParameter(cd, "@on_Result", SqlDbType.Int, Int32.MaxValue);
                db.ExecuteNonQuery(cd);
                intResult = Convert.ToInt16(db.GetParameterValue(cd, "@on_Result"));
                return intResult;
            }

            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
        }

        /// <summary>
        /// Get LAST_STAGE_FOREMAIL Details
        /// </summary>
        public List<CreateNewOpportunity> GET_LAST_STAGE_FOREMAIL(string OpportunityId)
        {
            DataSet ds = null;
            List<CreateNewOpportunity> customerList = new List<CreateNewOpportunity>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.GET_LAST_STAGE_FOREMAIL);
                db.AddInParameter(cd, "@in_OpportunityId", SqlDbType.VarChar, OpportunityId);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;

                        for (int i = 0; i < rowCount; i++)
                        {
                            customerList.Add(MaPGET_LAST_STAGE_FOREMAIL(ds.Tables[0].Rows[i]));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }
            return customerList;
        }

        private static CreateNewOpportunity MaPGET_LAST_STAGE_FOREMAIL(DataRow objRow)
        {

            return new CreateNewOpportunity()
            {

                StageID = (objRow.Table.Columns.Contains("stage_id")) ? (objRow["stage_id"] == DBNull.Value) ? 0 : Convert.ToInt32(objRow["stage_id"]) : 0,
                opportunity_rec_id = (objRow.Table.Columns.Contains("opportunity_rec_id")) ? (objRow["opportunity_rec_id"] == DBNull.Value) ? "" : Convert.ToString(objRow["opportunity_rec_id"]) : "",

            };
        }
        /// <summary>
        /// Get SubCompetency Details
        /// </summary>
        public List<CreateNewOpportunity> Get_Sub_Competency()
        {
            DataSet ds = null;
            List<CreateNewOpportunity> customerList = new List<CreateNewOpportunity>();
            try
            {


                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Get_Sub_Competency);

                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;
                        for (int i = 0; i < rowCount; i++)
                        {
                            customerList.Add(MaPGet_Sub_Competency(ds.Tables[0].Rows[i]));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }
            return customerList;
        }

        private static CreateNewOpportunity MaPGet_Sub_Competency(DataRow objRow)
        {

            return new CreateNewOpportunity()
            {

                SUB_COMPETENCY_ID = (objRow.Table.Columns.Contains("SUB_COMPETENCY_ID")) ? (objRow["SUB_COMPETENCY_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(objRow["SUB_COMPETENCY_ID"]) : 0,
                SUB_COMPETENCY_NAME = (objRow.Table.Columns.Contains("SUB_COMPETENCY_NAME")) ? (objRow["SUB_COMPETENCY_NAME"] == DBNull.Value) ? "" : Convert.ToString(objRow["SUB_COMPETENCY_NAME"]) : "",

            };
        }
        /// <summary>
        /// Save OppCompetitors Details
        /// </summary>
        public int SaveOppCompetitors(CreateNewOpportunity ObjCreateNewOpportunity)
        {
            int result = 0;
            try
            {
             
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.InsertOppCompetitors);
                db.AddInParameter(cd, "@iv_OppID", SqlDbType.VarChar, ObjCreateNewOpportunity.OpportunityId);
                db.AddInParameter(cd, "@in_CompetitorID", SqlDbType.Int, ObjCreateNewOpportunity.COMPETITOR_ID);
                db.AddInParameter(cd, "@iv_UserLogin", SqlDbType.VarChar, ObjCreateNewOpportunity.UserLogin);
                
                db.AddOutParameter(cd, "@on_Result", SqlDbType.Int, Int16.MaxValue);
                db.ExecuteNonQuery(cd);
                result = Convert.ToInt16(db.GetParameterValue(cd, "@on_Result"));
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
            return result;
        }

        //rajat
        public List<MultiSelectList> Get_OppBpsOffering(string oppId)
        {
            DataSet ds = null;
            List<MultiSelectList> customerList = new List<MultiSelectList>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Get_Opp_BpsOffering);
                db.AddInParameter(cd, "@iv_OppID", SqlDbType.VarChar, oppId);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;

                        for (int i = 0; i < rowCount; i++)
                        {
                            customerList.Add(MapGet_OppBpsOffering(ds.Tables[0].Rows[i]));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }

            return customerList;
        }

        private static MultiSelectList MapGet_OppBpsOffering(DataRow objRow)
        {

            return new MultiSelectList()
            {
                id = (objRow.Table.Columns.Contains("OFFERING_ID")) ? (objRow["OFFERING_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(objRow["OFFERING_ID"]) : 0,
                itemName = (objRow.Table.Columns.Contains("BPS_OFFERING_NAME")) ? (objRow["BPS_OFFERING_NAME"] == DBNull.Value) ? "" : Convert.ToString(objRow["BPS_OFFERING_NAME"]) : "",
            };
        }

        public int SaveOppPlatform(CreateNewOpportunity ObjCreateNewOpportunity)
        {
            int result = 0;
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.InsertOppPlatform);
                db.AddInParameter(cd, "@iv_OppID", SqlDbType.VarChar, ObjCreateNewOpportunity.OpportunityId);
                db.AddInParameter(cd, "@in_PlatformID", SqlDbType.Int, ObjCreateNewOpportunity.Platform_id);
                db.AddInParameter(cd, "@iv_UserLogin", SqlDbType.VarChar, ObjCreateNewOpportunity.UserLogin);
                db.AddInParameter(cd, "@unit_id", SqlDbType.VarChar, ObjCreateNewOpportunity.UnitId);
                db.AddOutParameter(cd, "@on_Result", SqlDbType.Int, Int16.MaxValue);
                db.ExecuteNonQuery(cd);
                result = Convert.ToInt16(db.GetParameterValue(cd, "@on_Result"));
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
            return result;
        }

        public int SaveOppBpsOffering(CreateNewOpportunity ObjCreateNewOpportunity)
        {
            
            int result = 0;
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.InsertOppBpsOffering);
                db.AddInParameter(cd, "@iv_OppID", SqlDbType.VarChar, ObjCreateNewOpportunity.OpportunityId);
                db.AddInParameter(cd, "@in_OfferingID", SqlDbType.Int, ObjCreateNewOpportunity.BPSOfferingID);
                db.AddInParameter(cd, "@iv_UserLogin", SqlDbType.VarChar, ObjCreateNewOpportunity.UserLogin);
                db.AddInParameter(cd, "@iv_ServiceID", SqlDbType.VarChar, ObjCreateNewOpportunity.ServiceId);
                db.AddOutParameter(cd, "@on_Result", SqlDbType.Int, Int16.MaxValue);
                db.ExecuteNonQuery(cd);
                result = Convert.ToInt16(db.GetParameterValue(cd, "@on_Result"));
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
            return result;
        }

        public List<MultiSelectList> Get_OppPlatform(string oppId)
        {
            DataSet ds = null;
            List<MultiSelectList> customerList = new List<MultiSelectList>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Get_Opp_Platform);
                db.AddInParameter(cd, "@iv_OppID", SqlDbType.VarChar, oppId);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;

                        for (int i = 0; i < rowCount; i++)
                        {
                            customerList.Add(MapGet_OppPlatform(ds.Tables[0].Rows[i]));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }

            return customerList;
        }

        private static MultiSelectList MapGet_OppPlatform(DataRow objRow)
        {

            return new MultiSelectList()
            {
                id = (objRow.Table.Columns.Contains("Platform_id")) ? (objRow["Platform_id"] == DBNull.Value) ? 0 : Convert.ToInt32(objRow["Platform_id"]) : 0,
                itemName = (objRow.Table.Columns.Contains("Platform_NAME")) ? (objRow["Platform_NAME"] == DBNull.Value) ? "" : Convert.ToString(objRow["Platform_NAME"]) : "",
            };
        }



        public int SaveOppPricingType(CreateNewOpportunity ObjCreateNewOpportunity)
        {
            int result = 0;
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.InsertOppPricingType);
                db.AddInParameter(cd, "@iv_OppID", SqlDbType.VarChar, ObjCreateNewOpportunity.OpportunityId);
                db.AddInParameter(cd, "@in_PricingTypeID", SqlDbType.Int, ObjCreateNewOpportunity.PRICING_TYPE_ID);
                db.AddInParameter(cd, "@iv_UserLogin", SqlDbType.VarChar, ObjCreateNewOpportunity.UserLogin);
                db.AddOutParameter(cd, "@on_Result", SqlDbType.Int, Int16.MaxValue);
                db.ExecuteNonQuery(cd);
                result = Convert.ToInt16(db.GetParameterValue(cd, "@on_Result"));
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
            return result;
        }





        public int Upd_BpsOffering(string oppid)
        {
            try
            {
                int intResult;
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Upd_OppBpsOffering);
                db.AddInParameter(cd, "@iv_OppID", SqlDbType.VarChar, oppid);
               
                db.AddOutParameter(cd, "@on_Result", SqlDbType.Int, Int16.MaxValue);
                db.ExecuteNonQuery(cd);
                intResult = Convert.ToInt16(db.GetParameterValue(cd, "@on_Result"));
                return intResult;
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }

        }


        public int Upd_Platform(string oppid)
        {
            try
            {
                int intResult;
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Upd_OppPlatform);
                db.AddInParameter(cd, "@iv_OppID", SqlDbType.VarChar, oppid);

                db.AddOutParameter(cd, "@on_Result", SqlDbType.Int, Int16.MaxValue);
                db.ExecuteNonQuery(cd);
                intResult = Convert.ToInt16(db.GetParameterValue(cd, "@on_Result"));
                return intResult;
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }

        }
        //rajat
        /// <summary>
        /// Check Opportunity Fiscal Details
        /// </summary>
        public int CheckOpportunityFiscal(string opportunityId, int stageId)
        {
            int result = 0;
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.CheckOpportunityFiscal);
                db.AddInParameter(cd, "@in_OpportunityId", SqlDbType.VarChar, opportunityId);
                db.AddInParameter(cd, "@in_StageId", SqlDbType.Int, stageId);
                db.AddOutParameter(cd, "@on_ChkCount", SqlDbType.Int, Int16.MaxValue);
                db.ExecuteNonQuery(cd);
                result = Convert.ToInt16(db.GetParameterValue(cd, "@on_ChkCount"));
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
            return result;
        }
        /// <summary>
        /// Check Opportunity Projections Details
        /// </summary>
        public int CheckOpportunityProjections(string opportunityId, int stageId)
        {
            int result = 0;
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.CheckOpportunityProjections);
                db.AddInParameter(cd, "@in_OpportunityId", SqlDbType.VarChar, opportunityId);
                db.AddInParameter(cd, "@in_StageId", SqlDbType.Int, stageId);
                db.AddOutParameter(cd, "@on_ChkCount", SqlDbType.Int, Int16.MaxValue);
                db.ExecuteNonQuery(cd);
                result = Convert.ToInt16(db.GetParameterValue(cd, "@on_ChkCount"));

            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
            return result;
        }
        /// <summary>
        /// Get Opportunity Stage5 Details
        /// </summary>
        public List<CreateNewOpportunity> GetOpportunityStage5(string opportunityId, int stageId)
        {
            DataSet ds = null;
            List<CreateNewOpportunity> modelList = new List<CreateNewOpportunity>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.GetOpportunityStage5);
                db.AddInParameter(cd, "@in_OpportunityId", SqlDbType.VarChar, opportunityId);
                db.AddInParameter(cd, "@in_StageId", SqlDbType.Int, stageId);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;
                        for (int i = 0; i < rowCount; i++)
                        {
                            modelList.Add(MapStage5(ds.Tables[0].Rows[i]));
                        }
                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }
            return modelList;
        }

        private static CreateNewOpportunity MapStage5(DataRow dr)
        {
            try
            {
                return new CreateNewOpportunity()
                {
                    OpportunityId = (dr.Table.Columns.Contains("OPPORTUNITY_ID")) ? (dr["OPPORTUNITY_ID"] == DBNull.Value) ? "" : Convert.ToString(dr["OPPORTUNITY_ID"]) : "",
                    OPPORTUNITY_DESC = (dr.Table.Columns.Contains("OPPORTUNITY_DESC")) ? (dr["OPPORTUNITY_DESC"] == DBNull.Value) ? "" : dr.Field<string>("OPPORTUNITY_DESC") : "",
                    OLD_OPPORTUNITY_DESC = (dr.Table.Columns.Contains("OLD_OPPORTUNITY_DESC")) ? (dr["OLD_OPPORTUNITY_DESC"] == DBNull.Value) ? "" : dr.Field<string>("OLD_OPPORTUNITY_DESC") : "",
                    GEOGRAPHY_ID = (dr.Table.Columns.Contains("GEOGRAPHY_ID")) ? (dr["GEOGRAPHY_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["GEOGRAPHY_ID"]) : 0,
                    GEOGRAPHY_NAME = (dr.Table.Columns.Contains("GEOGRAPHY_NAME")) ? (dr["GEOGRAPHY_NAME"] == DBNull.Value) ? "" : dr.Field<string>("GEOGRAPHY_NAME") : "",
                    CUST_ID = (dr.Table.Columns.Contains("CUST_ID")) ? (dr["CUST_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CUST_ID"]) : 0,
                    CUST_NAME = (dr.Table.Columns.Contains("CUST_NAME")) ? (dr["CUST_NAME"] == DBNull.Value) ? "" : dr.Field<string>("CUST_NAME") : "",
                    CUST_TYPE_ID = (dr.Table.Columns.Contains("CUST_TYPE_ID")) ? (dr["CUST_TYPE_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CUST_TYPE_ID"]) : 0,
                    CUST_TYPE_NAME = (dr.Table.Columns.Contains("CUST_TYPE_NAME")) ? (dr["CUST_TYPE_NAME"] == DBNull.Value) ? "" : dr.Field<string>("CUST_TYPE_NAME") : "",
                    INDUSTRY_PRACTICE_ID = (dr.Table.Columns.Contains("INDUSTRY_PRACTICE_ID")) ? (dr["INDUSTRY_PRACTICE_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["INDUSTRY_PRACTICE_ID"]) : 0,
                    StageID = (dr.Table.Columns.Contains("STAGE_ID")) ? (dr["STAGE_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["STAGE_ID"]) : 0,
                    INDUSTRY_PRACTICE_NAME = (dr.Table.Columns.Contains("INDUSTRY_PRACTICE_NAME")) ? (dr["INDUSTRY_PRACTICE_NAME"] == DBNull.Value) ? "" : dr.Field<string>("INDUSTRY_PRACTICE_NAME") : "",
                    STAGE_NAME = (dr.Table.Columns.Contains("STAGE_NAME")) ? (dr["STAGE_NAME"] == DBNull.Value) ? "" : dr.Field<string>("STAGE_NAME") : "",
                    ISU_CD = (dr.Table.Columns.Contains("ISU_CD")) ? (dr["ISU_CD"] == DBNull.Value) ? "" : dr.Field<string>("ISU_CD") : "",
                    ISU_NAME = (dr.Table.Columns.Contains("ISU_NAME")) ? (dr["ISU_NAME"] == DBNull.Value) ? "" : dr.Field<string>("ISU_NAME") : "",
                    GEOGRAPHY_SALES_OWNER = (dr.Table.Columns.Contains("GEOGRAPHY_SALES_OWNER_ID")) ? (dr["GEOGRAPHY_SALES_OWNER_ID"] == DBNull.Value) ? "" : dr.Field<string>("GEOGRAPHY_SALES_OWNER_ID") : "",
                    ONSITE_OWNER = (dr.Table.Columns.Contains("ONSITE_OWNER_ID")) ? (dr["ONSITE_OWNER_ID"] == DBNull.Value) ? "" : dr.Field<string>("ONSITE_OWNER_ID") : "",
                    OFFSHORE_BD_LEAD = (dr.Table.Columns.Contains("OFFSHORE_BD_LEAD_ID")) ? (dr["OFFSHORE_BD_LEAD_ID"] == DBNull.Value) ? "" : dr.Field<string>("OFFSHORE_BD_LEAD_ID") : "",
                    OPPORTUNITY_DATE = (dr.Table.Columns.Contains("OPPORTUNITY_DATE")) ? (dr["OPPORTUNITY_DATE"] == DBNull.Value) ? "" : dr.Field<string>("OPPORTUNITY_DATE") : "",
                    DEAL_CLOSURE_EXP_DATE = (dr.Table.Columns.Contains("DEAL_CLOSURE_EXP_DATE")) ? (dr["DEAL_CLOSURE_EXP_DATE"] == DBNull.Value) ? "" : dr.Field<string>("DEAL_CLOSURE_EXP_DATE") : "",
                    DTOTAL_CONTRACT_VALUE = (dr.Table.Columns.Contains("TOTAL_CONTRACT_VALUE")) ? (dr["TOTAL_CONTRACT_VALUE"] == DBNull.Value) ? 0 : Convert.ToDouble(dr["TOTAL_CONTRACT_VALUE"]) : 0,
                    BUSINESS_ID = (dr.Table.Columns.Contains("BUSINESS_ID")) ? (dr["BUSINESS_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["BUSINESS_ID"]) : 0,
                    COUNTRY_ID = (dr.Table.Columns.Contains("COUNTRY_ID")) ? (dr["COUNTRY_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["COUNTRY_ID"]) : 0,
                    PIBS = (dr.Table.Columns.Contains("PIBS")) ? (dr["PIBS"] == DBNull.Value) ? "" : dr.Field<string>("PIBS") : "",
                    CRM_ID = (dr.Table.Columns.Contains("CRM_ID")) ? (dr["CRM_ID"] == DBNull.Value) ? "" : dr.Field<string>("CRM_ID") : "",
                    VALUE_BPS = (dr.Table.Columns.Contains("VALUE_BPS")) ? (dr["VALUE_BPS"] == DBNull.Value) ? "" : dr.Field<string>("VALUE_BPS") : "",
                    VALUE_BPS_TCV = (dr.Table.Columns.Contains("VALUE_BPS_TCV")) ? (dr["VALUE_BPS_TCV"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["VALUE_BPS_TCV"]) : 0,
                    OPP_TYPE = (dr.Table.Columns.Contains("OPP_TYPE")) ? (dr["OPP_TYPE"] == DBNull.Value) ? "" : dr.Field<string>("OPP_TYPE") : "",
                    IESTIMATED_FTE_SIZE = (dr.Table.Columns.Contains("ESTIMATED_FTE_SIZE")) ? (dr["ESTIMATED_FTE_SIZE"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["ESTIMATED_FTE_SIZE"]) : 0,
                    ContractLength = (dr.Table.Columns.Contains("CONTRACT_LENGTH")) ? (dr["CONTRACT_LENGTH"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CONTRACT_LENGTH"]) : 0,
                    ISU_OWNER_ID = (dr.Table.Columns.Contains("ISU_OWNER_ID")) ? (dr["ISU_OWNER_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["ISU_OWNER_ID"]) : 0,
                    ACCOUNT_SALES_OWNER_ID = (dr.Table.Columns.Contains("ACCOUNT_SALES_OWNER_ID")) ? (dr["ACCOUNT_SALES_OWNER_ID"] == DBNull.Value) ? "" : dr.Field<string>("ACCOUNT_SALES_OWNER_ID") : "",
                    GEOGRAPHY_SALES_OWNER_ID = (dr.Table.Columns.Contains("GEOGRAPHY_SALES_OWNER_ID")) ? (dr["GEOGRAPHY_SALES_OWNER_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["GEOGRAPHY_SALES_OWNER_ID"]) : 0,
                    OFFSHORE_BD_LEAD_ID = (dr.Table.Columns.Contains("OFFSHORE_BD_LEAD_ID")) ? (dr["OFFSHORE_BD_LEAD_ID"] == DBNull.Value) ? "" : dr.Field<string>("OFFSHORE_BD_LEAD_ID") : "",
                    LAST_UPDATE = (dr.Table.Columns.Contains("LAST_UPDATE")) ? (dr["LAST_UPDATE"] == DBNull.Value) ? "" : dr.Field<string>("LAST_UPDATE") : "",
                    DEAL_BD_LEAD_ID = (dr.Table.Columns.Contains("DEAL_BD_LEAD_ID")) ? (dr["DEAL_BD_LEAD_ID"] == DBNull.Value) ? "" : dr.Field<string>("DEAL_BD_LEAD_ID") : "",
                    DEAL_BD_LEAD_ID2 = (dr.Table.Columns.Contains("DEAL_BD_LEAD_ID2")) ? (dr["DEAL_BD_LEAD_ID2"] == DBNull.Value) ? "" : dr.Field<string>("DEAL_BD_LEAD_ID2") : "",
                    RFI_ReviewDate = (dr.Table.Columns.Contains("RFI_REVIEW_DT")) ? (dr["RFI_REVIEW_DT"] == DBNull.Value) ? "" : dr.Field<string>("RFI_REVIEW_DT") : "",
                    RFP_ReviewDate = (dr.Table.Columns.Contains("RFP_REVIEW_DT")) ? (dr["RFP_REVIEW_DT"] == DBNull.Value) ? "" : dr.Field<string>("RFP_REVIEW_DT") : "",
                    RFI_ReceivedDate = (dr.Table.Columns.Contains("RFI_RECEIVED_DT")) ? (dr["RFI_RECEIVED_DT"] == DBNull.Value) ? "" : dr.Field<string>("RFI_RECEIVED_DT") : "",
                    RFP_ReceivedDate = (dr.Table.Columns.Contains("RFP_RECEIVED_DT")) ? (dr["RFP_RECEIVED_DT"] == DBNull.Value) ? "" : dr.Field<string>("RFP_RECEIVED_DT") : "",
                    RFI_ProbableSubmissionDate = (dr.Table.Columns.Contains("RFI_PROBABLE_SUBMISSION_DT")) ? (dr["RFI_PROBABLE_SUBMISSION_DT"] == DBNull.Value) ? "" : dr.Field<string>("RFI_PROBABLE_SUBMISSION_DT") : "",
                    RFP_ProbableSubmissionDate = (dr.Table.Columns.Contains("RFP_PROBABLE_SUBMISSION_DT")) ? (dr["RFP_PROBABLE_SUBMISSION_DT"] == DBNull.Value) ? "" : dr.Field<string>("RFP_PROBABLE_SUBMISSION_DT") : "",
                    RFI_ActualSubmissionDate = (dr.Table.Columns.Contains("RFI_ACTUAL_SUBMISSION_DT")) ? (dr["RFI_ACTUAL_SUBMISSION_DT"] == DBNull.Value) ? "" : dr.Field<string>("RFI_ACTUAL_SUBMISSION_DT") : "",
                    RFP_ActualSubmissionDate = (dr.Table.Columns.Contains("RFP_ACTUAL_SUBMISSION_DT")) ? (dr["RFP_ACTUAL_SUBMISSION_DT"] == DBNull.Value) ? "" : dr.Field<string>("RFP_ACTUAL_SUBMISSION_DT") : "",
                    BCP_DRP_LOCATION = (dr.Table.Columns.Contains("BCP_DRP_LOCATION")) ? (dr["BCP_DRP_LOCATION"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["BCP_DRP_LOCATION"]) : 0,
                    RFI_REVIEW_BY = (dr.Table.Columns.Contains("RFI_REVIEW_BY")) ? (dr["RFI_REVIEW_BY"] == DBNull.Value) ? "" : dr.Field<string>("RFI_REVIEW_BY") : "",
                    RFP_REVIEW_BY = (dr.Table.Columns.Contains("RFP_REVIEW_BY")) ? (dr["RFP_REVIEW_BY"] == DBNull.Value) ? "" : dr.Field<string>("RFP_REVIEW_BY") : "",
                    CURRENCY_ID = (dr.Table.Columns.Contains("CURRENCY_ID")) ? (dr["CURRENCY_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CURRENCY_ID"]) : 0,
                    FTEOff = (dr.Table.Columns.Contains("FTE_OFFSHORE")) ? (dr["FTE_OFFSHORE"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["FTE_OFFSHORE"]) : 0,
                    FTEOn = (dr.Table.Columns.Contains("FTE_ONSITE")) ? (dr["FTE_ONSITE"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["FTE_ONSITE"]) : 0,
                    ClusterId = (dr.Table.Columns.Contains("CLUSTER_ID")) ? (dr["CLUSTER_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CLUSTER_ID"]) : 0,
                    DealCategory = (dr.Table.Columns.Contains("DEAL_CATEGORY")) ? (dr["DEAL_CATEGORY"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["DEAL_CATEGORY"]) : 0,
                    BPS_OFFERING_ID = (dr.Table.Columns.Contains("BPS_OFFERING_ID")) ? (dr["BPS_OFFERING_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["BPS_OFFERING_ID"]) : 0,
                    SERVICE_ID = (dr.Table.Columns.Contains("SERVICE_ID")) ? (dr["SERVICE_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["SERVICE_ID"]) : 0,
                    SUB_IOU = (dr.Table.Columns.Contains("SUB_IOU")) ? (dr["SUB_IOU"] == DBNull.Value) ? "" : dr.Field<string>("SUB_IOU") : "",
                    EXECUTIVE_SPONSOR = (dr.Table.Columns.Contains("EXECUTIVE_SPONSOR")) ? (dr["EXECUTIVE_SPONSOR"] == DBNull.Value) ? "" : dr.Field<string>("EXECUTIVE_SPONSOR") : "",
                    VALBPS_CON = (dr.Table.Columns.Contains("VALBPS_CON")) ? (dr["VALBPS_CON"] == DBNull.Value) ? "" : dr.Field<string>("VALBPS_CON") : "",
                    PROACTIVE_PROPOSAL = (dr.Table.Columns.Contains("PROACTIVE_PROPOSAL")) ? (dr["PROACTIVE_PROPOSAL"] == DBNull.Value) ? "" : dr.Field<string>("PROACTIVE_PROPOSAL") : "",
                    ISU_MAIN = (dr.Table.Columns.Contains("ISU_MAIN")) ? (dr["ISU_MAIN"] == DBNull.Value) ? "" : dr.Field<string>("ISU_MAIN") : "",
                    Quarter = (dr.Table.Columns.Contains("quarter")) ? (dr["quarter"] == DBNull.Value) ? "" : dr.Field<string>("quarter") : "",
                    FISCAL_YEAR = (dr.Table.Columns.Contains("FISCAL_YEAR")) ? (dr["FISCAL_YEAR"] == DBNull.Value) ? "" : dr.Field<string>("FISCAL_YEAR") : "",
                    PROPOSAL_FACTORY = (dr.Table.Columns.Contains("PROPOSAL_FACTORY")) ? (dr["PROPOSAL_FACTORY"] == DBNull.Value) ? "" : dr.Field<string>("PROPOSAL_FACTORY") : "",
                    PROPOSAL_FACTORY_OPTIONS = (dr.Table.Columns.Contains("PROPOSAL_FACTORY_OPTIONS")) ? (dr["PROPOSAL_FACTORY_OPTIONS"] == DBNull.Value) ? "" : dr.Field<string>("PROPOSAL_FACTORY_OPTIONS") : "",
                    PROPOSAL_FACTORY_COMMENTS = (dr.Table.Columns.Contains("PROPOSAL_FACTORY_COMMENTS")) ? (dr["PROPOSAL_FACTORY_COMMENTS"] == DBNull.Value) ? "" : dr.Field<string>("PROPOSAL_FACTORY_COMMENTS") : "",
                    DT_ID = (dr.Table.Columns.Contains("DT_ID")) ? (dr["DT_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["DT_ID"]) : 0,
                    Other_DT = (dr.Table.Columns.Contains("Other_DT")) ? (dr["Other_DT"] == DBNull.Value) ? "" : dr.Field<string>("Other_DT") : "",
                    CRM_TCV = (dr.Table.Columns.Contains("CRM_TCV")) ? (dr["CRM_TCV"] == DBNull.Value) ? "" : Convert.ToString(dr["CRM_TCV"]) : "",
                    CRM_STAGE = (dr.Table.Columns.Contains("CRM_STAGE")) ? (dr["CRM_STAGE"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CRM_STAGE"]) : 0,
                    strDigitalTcv = (dr.Table.Columns.Contains("Digital_TCV")) ? (dr["Digital_TCV"] == DBNull.Value) ? "" : dr.Field<string>("Digital_TCV") : "",
                    subSPId = (dr.Table.Columns.Contains("SubSPID")) ? (dr["SubSPID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["SubSPID"]) : 0,
                    CRM_Beacon = (dr.Table.Columns.Contains("CRM_Beacon")) ? (dr["CRM_Beacon"] == DBNull.Value) ? "" : Convert.ToString(dr["CRM_Beacon"]) : "",
                    MULTITOWER_DEAL = (dr.Table.Columns.Contains("MULTITOWER_DEAL")) ? (dr["MULTITOWER_DEAL"] == DBNull.Value) ? "" : dr.Field<string>("MULTITOWER_DEAL") : "",

                    TataGroupAccount = (dr.Table.Columns.Contains("TATA_GROUP_ACCOUNT")) ? (dr["TATA_GROUP_ACCOUNT"] == DBNull.Value) ? "" : Convert.ToString(dr["TATA_GROUP_ACCOUNT"]) : "",
                    ItisScope = (dr.Table.Columns.Contains("ItisScope")) ? (dr["ItisScope"] == DBNull.Value) ? "" : Convert.ToString(dr["ItisScope"]) : "",
                    IsContractRenewal = (dr.Table.Columns.Contains("IsContractRenewal")) ? (dr["IsContractRenewal"] == DBNull.Value) ? "" : Convert.ToString(dr["IsContractRenewal"]) : "",
                    ContractRenewalValue = (dr.Table.Columns.Contains("ContractRenewalValue")) ? (dr["ContractRenewalValue"] == DBNull.Value) ? "" : Convert.ToString(dr["ContractRenewalValue"]) : "",
                    //changess
                    RESOURCING_ID = (dr.Table.Columns.Contains("ResourcingId")) ? (dr["ResourcingId"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["ResourcingId"]) : 0,
                    SEAT_IDENTIFICATION_ID = (dr.Table.Columns.Contains("Seat_IdentificationId")) ? (dr["Seat_IdentificationId"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["Seat_IdentificationId"]) : 0,
                    DealStatus = (dr.Table.Columns.Contains("DealStatus_Id")) ? (dr["DealStatus_Id"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["DealStatus_Id"]) : 0,
                    ServicePractice = (dr.Table.Columns.Contains("ServicePractice_Id")) ? (dr["ServicePractice_Id"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["ServicePractice_Id"]) : 0,
                    CoreOffering = (dr.Table.Columns.Contains("CoreOffering_Id")) ? (dr["CoreOffering_Id"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CoreOffering_Id"]) : 0,
                    OpportunityDescDetails = (dr.Table.Columns.Contains("Opportunity_Desc_Details")) ? (dr["Opportunity_Desc_Details"] == DBNull.Value) ? "" : dr.Field<string>("Opportunity_Desc_Details") : "",
                    offeringType = (dr.Table.Columns.Contains("OfferingType_Id")) ? (dr["OfferingType_Id"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["OfferingType_Id"]) : 0,
                    CofID = (dr.Table.Columns.Contains("CoreOfferingName_Id")) ? (dr["CoreOfferingName_Id"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CoreOfferingName_Id"]) : 0,


                    DigitalFlagging = (dr.Table.Columns.Contains("Digital_Flagging")) ? (dr["Digital_Flagging"] == DBNull.Value) ? "" : Convert.ToString(dr["Digital_Flagging"]) : "",

                    //End

                    PROPOSAL_SUBMISSION_DATE = (dr.Table.Columns.Contains("PROPOSAL_SUBMISSION_DATE")) ? (dr["PROPOSAL_SUBMISSION_DATE"] == DBNull.Value) ? "" : dr.Field<string>("PROPOSAL_SUBMISSION_DATE") : "",
                    SALES_STAGE_MOVED_ONDATE = (dr.Table.Columns.Contains("SALES_STAGE_MOVED_ON_DATE")) ? (dr["SALES_STAGE_MOVED_ON_DATE"] == DBNull.Value) ? "" : dr.Field<string>("SALES_STAGE_MOVED_ON_DATE") : "",

                    Previous_Deal_Stage = (dr.Table.Columns.Contains("Previous_Deal_Stage")) ? (dr["Previous_Deal_Stage"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["Previous_Deal_Stage"]) : 0,

                    DELIVERY_LOCATION_PROPOSED = (dr.Table.Columns.Contains("DELIVERY_LOCATION_PROPOSED")) ? (dr["DELIVERY_LOCATION_PROPOSED"] == DBNull.Value) ? "" : dr.Field<string>("DELIVERY_LOCATION_PROPOSED") : "",
                    Cboi_Offering_id = (dr.Table.Columns.Contains("cboi_offering_id")) ? (dr["cboi_offering_id"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["cboi_offering_id"]) : 0,
                    Deal_Flag_id = (dr.Table.Columns.Contains("deal_flag")) ? (dr["deal_flag"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["deal_flag"]) : 0,
                    PLATFORM = (dr.Table.Columns.Contains("PLATFORM")) ? (dr["PLATFORM"] == DBNull.Value) ? "" : dr.Field<string>("PLATFORM") : "",
                    PLATFORM_OPTION = (dr.Table.Columns.Contains("PLATFORM_OPTION")) ? (dr["PLATFORM_OPTION"] == DBNull.Value) ? "" : dr.Field<string>("PLATFORM_OPTION") : "",




                };
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }

        }
        /// <summary>
        /// Save Opportunity Stage5 Details
        /// </summary>
        public List<CreateNewOpportunity> InsertOpportunitystage5(CreateNewOpportunity objCreateNewOpportunity)
        {
            List<CreateNewOpportunity> strResult = new List<CreateNewOpportunity>();
            try
            {

                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.InsertOpportunitystage5);
                db.AddInParameter(cd, "@in_OpportunityId", SqlDbType.VarChar, objCreateNewOpportunity.OpportunityId);
                db.AddInParameter(cd, "@iv_OpportunityDesc", SqlDbType.VarChar, objCreateNewOpportunity.OPPORTUNITY_DESC);
                db.AddInParameter(cd, "@iv_OldOpportunityDesc", SqlDbType.VarChar, objCreateNewOpportunity.OLD_OPPORTUNITY_DESC);
                db.AddInParameter(cd, "@in_GeographyId", SqlDbType.Int, objCreateNewOpportunity.GEOGRAPHY_ID);
                db.AddInParameter(cd, "@in_CustId", SqlDbType.Int, objCreateNewOpportunity.CUST_ID);
                db.AddInParameter(cd, "@in_CustTypeId", SqlDbType.Int, objCreateNewOpportunity.CUST_TYPE_ID);
                db.AddInParameter(cd, "@in_IndustryPracticeId", SqlDbType.Int, objCreateNewOpportunity.INDUSTRY_PRACTICE_ID);
                db.AddInParameter(cd, "@in_StageId", SqlDbType.Int, objCreateNewOpportunity.StageID);
                db.AddInParameter(cd, "@iv_GeographySalesOwner", SqlDbType.VarChar, objCreateNewOpportunity.GeosalesOwner);
                db.AddInParameter(cd, "@iv_OffshorePracticeOwner", SqlDbType.VarChar, objCreateNewOpportunity.OffPracOwner);
                db.AddInParameter(cd, "@iv_RdCrd", SqlDbType.VarChar, objCreateNewOpportunity.RDCrd);
                db.AddInParameter(cd, "@iv_OffshoreBDLead", SqlDbType.VarChar, objCreateNewOpportunity.OffShoreBDLead);
                db.AddInParameter(cd, "@iv_OnsiteOwner", SqlDbType.VarChar, objCreateNewOpportunity.OnsiteOwner);
                db.AddInParameter(cd, "@in_ProbabilityOfwin", SqlDbType.Int, objCreateNewOpportunity.PROBABILITY_OF_WIN);
                db.AddInParameter(cd, "@in_CurencyId", SqlDbType.Int, objCreateNewOpportunity.CURRENCY_ID);
                db.AddInParameter(cd, "@in_TCV", SqlDbType.VarChar, objCreateNewOpportunity.TCV);
                db.AddInParameter(cd, "@in_ContractLength", SqlDbType.Int, objCreateNewOpportunity.ContractLength);
                db.AddInParameter(cd, "@in_FiscalRev", SqlDbType.Float, objCreateNewOpportunity.FiscRev);
                db.AddInParameter(cd, "@in_FTE", SqlDbType.Int, objCreateNewOpportunity.FTE);
                db.AddInParameter(cd, "@iv_Remark", SqlDbType.VarChar, objCreateNewOpportunity.REMARK);
                db.AddInParameter(cd, "@in_OppDate", SqlDbType.Int, objCreateNewOpportunity.OppDate);
                db.AddInParameter(cd, "@in_RFIReceivedDt", SqlDbType.Int, objCreateNewOpportunity.RFIReceivedDate);
                db.AddInParameter(cd, "@in_RFIProbSubmissiondDt", SqlDbType.Int, objCreateNewOpportunity.RFIProbableSubmissionDate);
                db.AddInParameter(cd, "@in_RFIActSubmissiondDt", SqlDbType.Int, objCreateNewOpportunity.RFIActualSubmissionDate);
                db.AddInParameter(cd, "@in_RFPReceivedDt", SqlDbType.Int, objCreateNewOpportunity.RFPReceivedDate);
                db.AddInParameter(cd, "@in_RFPProbSubmissiondDt", SqlDbType.Int, objCreateNewOpportunity.RFPProbableSubmissionDate);
                db.AddInParameter(cd, "@in_RFPActSubmissionDt", SqlDbType.Int, objCreateNewOpportunity.RFPActualSubmissionDate);
                db.AddInParameter(cd, "@in_BCPDRPLocation", SqlDbType.Int, objCreateNewOpportunity.BCP_DRP_LOCATION);
                db.AddInParameter(cd, "@iv_EmpNo", SqlDbType.VarChar, objCreateNewOpportunity.EmpNo);
                db.AddInParameter(cd, "@in_ClosureDate", SqlDbType.Int, objCreateNewOpportunity.ClosureDate);
                db.AddInParameter(cd, "@in_RFIRwDt", SqlDbType.Int, objCreateNewOpportunity.RFI_REVIEW_DT);
                db.AddInParameter(cd, "@in_RFPRwDt", SqlDbType.Int, objCreateNewOpportunity.RFP_REVIEW_DT);
                db.AddInParameter(cd, "@iv_RFIBy", SqlDbType.VarChar, objCreateNewOpportunity.RFI_REVIEW_BY);
                db.AddInParameter(cd, "@iv_RFPBy", SqlDbType.VarChar, objCreateNewOpportunity.RFP_REVIEW_BY);
                db.AddInParameter(cd, "@iv_NGM", SqlDbType.VarChar, objCreateNewOpportunity.OPP_NGM);
                db.AddInParameter(cd, "@iv_CRMReason", SqlDbType.VarChar, objCreateNewOpportunity.CRM_REASON);
                db.AddInParameter(cd, "@iv_BidExeEmpId", SqlDbType.VarChar, objCreateNewOpportunity.BID_EXECUTIVE_EMPID);
                db.AddInParameter(cd, "@iv_Disqual", SqlDbType.VarChar, objCreateNewOpportunity.Disqual);
                db.AddInParameter(cd, "@iv_AddDeal", SqlDbType.VarChar, objCreateNewOpportunity.AddDeal);
                db.AddInParameter(cd, "@iv_BidExeName", SqlDbType.VarChar, objCreateNewOpportunity.BID_EXECUTIVE_NAME);
                db.AddInParameter(cd, "@iv_DealOwner", SqlDbType.VarChar, objCreateNewOpportunity.DealOwner);
                db.AddInParameter(cd, "@iv_DealOwner2", SqlDbType.VarChar, objCreateNewOpportunity.DealOwner2);
                db.AddInParameter(cd, "@in_OperationWindow", SqlDbType.Int, objCreateNewOpportunity.OPERATION_WINDOW);
                db.AddInParameter(cd, "@in_Area", SqlDbType.Int, objCreateNewOpportunity.AREA);
                db.AddInParameter(cd, "@in_TypesOfSeat", SqlDbType.Int, objCreateNewOpportunity.TYPES_OF_SEAT);
                db.AddInParameter(cd, "@in_PCsRequired", SqlDbType.Int, objCreateNewOpportunity.PCS_REQUIRED);
                db.AddInParameter(cd, "@in_DesksRequired", SqlDbType.Int, objCreateNewOpportunity.DESKS_REQUIRED);
                db.AddInParameter(cd, "@in_PhonesRequired", SqlDbType.Int, objCreateNewOpportunity.PHONES_REQUIRED);
                db.AddInParameter(cd, "@in_CabinsRequired", SqlDbType.Int, objCreateNewOpportunity.CABINS_REQUIRED);
                db.AddInParameter(cd, "@in_LaptopsRequired", SqlDbType.Int, objCreateNewOpportunity.LAPTOPS_REQUIRED);
                db.AddInParameter(cd, "@in_Comp1", SqlDbType.Int, objCreateNewOpportunity.COMPETITOR_1);
                db.AddInParameter(cd, "@in_Comp2", SqlDbType.Int, objCreateNewOpportunity.COMPETITOR_2);
                db.AddInParameter(cd, "@in_Comp3", SqlDbType.Int, objCreateNewOpportunity.COMPETITOR_3);
                db.AddInParameter(cd, "@in_Comp4", SqlDbType.Int, objCreateNewOpportunity.COMPETITOR_4);
                db.AddInParameter(cd, "@in_Comp5", SqlDbType.Int, objCreateNewOpportunity.COMPETITOR_5);
                db.AddInParameter(cd, "@in_AdvisoryId", SqlDbType.Int, objCreateNewOpportunity.ADVISORY_ID);
                db.AddInParameter(cd, "@iv_Platform", SqlDbType.VarChar, objCreateNewOpportunity.PLATFORM);
                db.AddInParameter(cd, "@in_PIBSTCV", SqlDbType.VarChar, objCreateNewOpportunity.PibsSaleValue);
                db.AddInParameter(cd, "@iv_NextStep", SqlDbType.VarChar, objCreateNewOpportunity.NextStep);
                db.AddInParameter(cd, "@in_BusinessId", SqlDbType.Int, objCreateNewOpportunity.BUSINESS_ID);
                db.AddInParameter(cd, "@in_ProductId", SqlDbType.Int, objCreateNewOpportunity.PRODUCT_ID);
                db.AddInParameter(cd, "@in_CompetencyId", SqlDbType.Int, objCreateNewOpportunity.COMPETENCY_ID);
                db.AddInParameter(cd, "@in_SubCompetencyId", SqlDbType.Int, objCreateNewOpportunity.SUB_COMPETENCY_ID);
                db.AddInParameter(cd, "@in_AnnualSaleValue", SqlDbType.Decimal, objCreateNewOpportunity.AnnualSaleValue);
                db.AddInParameter(cd, "@in_PricingTypeId", SqlDbType.Int, objCreateNewOpportunity.PRICING_TYPE_ID);
                db.AddInParameter(cd, "@iv_KeyRmk", SqlDbType.VarChar, objCreateNewOpportunity.KeyRmk);
                db.AddInParameter(cd, "@iv_AccountSalesOwner", SqlDbType.VarChar, objCreateNewOpportunity.AccountSalesOwner);
                db.AddInParameter(cd, "@iv_ExeSponser", SqlDbType.VarChar, objCreateNewOpportunity.ExeSponser);
                db.AddInParameter(cd, "@iv_ValBPSCon", SqlDbType.VarChar, objCreateNewOpportunity.ValBPSCon);
                db.AddInParameter(cd, "@iv_ProactiveProposal", SqlDbType.VarChar, objCreateNewOpportunity.ProactiveProposal);
                db.AddInParameter(cd, "@iv_IsuMain", SqlDbType.VarChar, objCreateNewOpportunity.IsuMain);
                db.AddInParameter(cd, "@iv_PlatformNew", SqlDbType.VarChar, objCreateNewOpportunity.PlatformNew);
                db.AddInParameter(cd, "@iv_StatusUpdate", SqlDbType.VarChar, objCreateNewOpportunity.StatusUpdate);
                db.AddInParameter(cd, "@in_CategoryId", SqlDbType.Int, objCreateNewOpportunity.Category_Id);
                db.AddInParameter(cd, "@in_CountryId", SqlDbType.Int, objCreateNewOpportunity.CountryId);
                db.AddInParameter(cd, "@in_NextStepDueDt", SqlDbType.Int, objCreateNewOpportunity.NextStepDueDt);
                db.AddInParameter(cd, "@in_OffFTE  ", SqlDbType.Int, objCreateNewOpportunity.FTEOff);
                db.AddInParameter(cd, "@in_OnFTE  ", SqlDbType.Int, objCreateNewOpportunity.FTEOn);
                db.AddInParameter(cd, "@iv_ISUOwner", SqlDbType.VarChar, objCreateNewOpportunity.ISU_OWNER_ID);
                db.AddInParameter(cd, "@in_UnitID", SqlDbType.Int, objCreateNewOpportunity.UnitId);
                db.AddInParameter(cd, "@iv_ISU", SqlDbType.VarChar, objCreateNewOpportunity.ISU_CD);
                db.AddInParameter(cd, "@iv_PIBS", SqlDbType.VarChar, objCreateNewOpportunity.PIBS);
                db.AddInParameter(cd, "@iv_TCS_INVESTMENT", SqlDbType.VarChar, objCreateNewOpportunity.TCSInvestment);
                db.AddInParameter(cd, "@in_PIBStartDate", SqlDbType.Int, objCreateNewOpportunity.PIBStartDate);
                db.AddInParameter(cd, "@in_PIBEndDate", SqlDbType.Int, objCreateNewOpportunity.PIBSEndDate);
                db.AddInParameter(cd, "@in_NoOfFTEsEngaged", SqlDbType.Int, objCreateNewOpportunity.FTEsEngaged);
                db.AddInParameter(cd, "@in_PIBStatus", SqlDbType.Int, objCreateNewOpportunity.PIBStatus);
                db.AddInParameter(cd, "@in_PIBSOutcome", SqlDbType.Int, objCreateNewOpportunity.PIBS_OUTCOME_ID);
                db.AddInParameter(cd, "@iv_PIBStatusRemarks", SqlDbType.VarChar, objCreateNewOpportunity.PIBStatusRemarks);
                db.AddInParameter(cd, "@iv_FTEType", SqlDbType.VarChar, objCreateNewOpportunity.chkVariousFTEs);
                db.AddInParameter(cd, "@in_FTETypeCount", SqlDbType.Int, objCreateNewOpportunity.FTE_TYPE_COUNT);
                db.AddInParameter(cd, "@in_BPODomain", SqlDbType.Int, objCreateNewOpportunity.BPODomain);
                db.AddInParameter(cd, "@iv_DomainPresalesLead", SqlDbType.VarChar, objCreateNewOpportunity.DOMAIN_PRESALES_LEAD);
                db.AddInParameter(cd, "@in_DealCategory", SqlDbType.Int, objCreateNewOpportunity.DealCategory);
                db.AddInParameter(cd, "@iv_DealCoachName", SqlDbType.VarChar, objCreateNewOpportunity.DealCoachName);
                db.AddInParameter(cd, "@in_DemandType", SqlDbType.Int, objCreateNewOpportunity.DemandType);
                db.AddInParameter(cd, "@iv_KeyDeal", SqlDbType.VarChar, objCreateNewOpportunity.KEY_DEAL);
                db.AddInParameter(cd, "@iv_ProposedSolution", SqlDbType.VarChar, objCreateNewOpportunity.ProposedSolution);
                db.AddInParameter(cd, "@iv_WinningTeam", SqlDbType.VarChar, objCreateNewOpportunity.WinningTheme);
                db.AddInParameter(cd, "@iv_KeyCustExp", SqlDbType.VarChar, objCreateNewOpportunity.KeyCustExp);
                db.AddInParameter(cd, "@iv_OperatingModel", SqlDbType.VarChar, objCreateNewOpportunity.operatingModel);
                db.AddInParameter(cd, "@iv_PricingModel", SqlDbType.VarChar, objCreateNewOpportunity.PRICING_MODEL);
                db.AddInParameter(cd, "@iv_Differentiators", SqlDbType.VarChar, objCreateNewOpportunity.Differentiators);
                db.AddInParameter(cd, "@iv_Risks", SqlDbType.VarChar, Risks);
                db.AddInParameter(cd, "@iv_KeyCustomerConnects", SqlDbType.VarChar, objCreateNewOpportunity.KeyCustomerConnects);
                db.AddInParameter(cd, "@iv_BPOOfferingDescription", SqlDbType.VarChar, objCreateNewOpportunity.BPOOfferingDescription);
                db.AddInParameter(cd, "@iv_FirstTimeOutsource", SqlDbType.VarChar, objCreateNewOpportunity.chkFirstTimeOutsource);
                db.AddInParameter(cd, "@iv_Incumbents", SqlDbType.VarChar, objCreateNewOpportunity.INCUMBENTS);
                db.AddInParameter(cd, "@iv_NameOfIncumbents", SqlDbType.VarChar, objCreateNewOpportunity.NAME_OF_INCUMBENTS);
                db.AddInParameter(cd, "@iv_TCSOfferingCapability", SqlDbType.VarChar, objCreateNewOpportunity.TCS_OFFERING_CAPABILITY);
                db.AddInParameter(cd, "@iv_SpecifyOffering", SqlDbType.VarChar, objCreateNewOpportunity.SpecifyOffering);
                db.AddInParameter(cd, "@iv_CoachAvailable", SqlDbType.VarChar, objCreateNewOpportunity.CoachAvailable);
                db.AddInParameter(cd, "@iv_FnA", SqlDbType.VarChar, objCreateNewOpportunity.FnA);
                db.AddInParameter(cd, "@in_Fna_FTE", SqlDbType.Int, objCreateNewOpportunity.FnA_FTE);
                db.AddInParameter(cd, "@iv_HRO", SqlDbType.VarChar, objCreateNewOpportunity.HRO);
                db.AddInParameter(cd, "@in_HRO_FTE", SqlDbType.Int, objCreateNewOpportunity.HRO_FTE);
                db.AddInParameter(cd, "@iv_SCM", SqlDbType.VarChar, objCreateNewOpportunity.SCM);
                db.AddInParameter(cd, "@in_SCM_FTE", SqlDbType.Int, objCreateNewOpportunity.SCM_FTE);
                db.AddInParameter(cd, "@iv_KPO", SqlDbType.VarChar, objCreateNewOpportunity.KPO);
                db.AddInParameter(cd, "@in_KPO_FTE", SqlDbType.Int, objCreateNewOpportunity.KPO_FTE);
                db.AddInParameter(cd, "@iv_LPO", SqlDbType.VarChar, objCreateNewOpportunity.LPO);
                db.AddInParameter(cd, "@in_LPO_FTE", SqlDbType.Int, objCreateNewOpportunity.LPO_FTE);
                db.AddInParameter(cd, "@iv_Vertical", SqlDbType.VarChar, objCreateNewOpportunity.VERTICAL);
                db.AddInParameter(cd, "@in_Vertical_FTE", SqlDbType.Int, objCreateNewOpportunity.VerticalFTE);
                db.AddInParameter(cd, "@iv_Voice", SqlDbType.VarChar, objCreateNewOpportunity.Voice);
                db.AddInParameter(cd, "@in_Voice_FTE", SqlDbType.Int, objCreateNewOpportunity.VoiceFTE);
                db.AddInParameter(cd, "@iv_Bpm", SqlDbType.VarChar, objCreateNewOpportunity.BPM);
                db.AddInParameter(cd, "@in_Bpm_FTE", SqlDbType.Int, objCreateNewOpportunity.BPM_FTE);
                db.AddInParameter(cd, "@in_SolTM", SqlDbType.Int, objCreateNewOpportunity.SolTM);
                db.AddInParameter(cd, "@in_DelTM", SqlDbType.Int, objCreateNewOpportunity.DelTM);
                db.AddInParameter(cd, "@iv_BidManager", SqlDbType.VarChar, objCreateNewOpportunity.BID_MANAGER);
                db.AddInParameter(cd, "@iv_BidExec", SqlDbType.VarChar, objCreateNewOpportunity.BID_EXEC_OWNER);
                db.AddInParameter(cd, "@iv_PricingOwner", SqlDbType.VarChar, objCreateNewOpportunity.PRICING_OWNER);
                db.AddInParameter(cd, "@in_TransitionTeam", SqlDbType.Int, objCreateNewOpportunity.TransitionTeam);
                db.AddInParameter(cd, "@iv_ExpectedDate", SqlDbType.Int, objCreateNewOpportunity.ExpectedDate);
                db.AddInParameter(cd, "@iv_TransitionReq", SqlDbType.VarChar, objCreateNewOpportunity.TransitionReq);
                db.AddInParameter(cd, "@iv_Entity", SqlDbType.VarChar, objCreateNewOpportunity.ENTITY);
                db.AddInParameter(cd, "@iv_Quarter", SqlDbType.VarChar, objCreateNewOpportunity.Quarter);
                db.AddInParameter(cd, "@iv_FiscalYear", SqlDbType.VarChar, objCreateNewOpportunity.FiscalYear);
                db.AddInParameter(cd, "@iv_CurrentlyActive", SqlDbType.VarChar, objCreateNewOpportunity.CURRENTLY_ACTIVE);
                db.AddInParameter(cd, "@iv_FTEDD", SqlDbType.VarChar, objCreateNewOpportunity.FTEDD);
                db.AddInParameter(cd, "@iv_SolutionLeader", SqlDbType.VarChar, objCreateNewOpportunity.SolutionLeader);
                db.AddInParameter(cd, "@in_Seat_Requirements", SqlDbType.Int, objCreateNewOpportunity.SeatRequirements);
                db.AddInParameter(cd, "@iv_RUR", SqlDbType.VarChar, objCreateNewOpportunity.RUR);
                db.AddInParameter(cd, "@iv_HRT_Comments", SqlDbType.VarChar, objCreateNewOpportunity.HRTComments);
                db.AddInParameter(cd, "@iv_CRMId", SqlDbType.VarChar, objCreateNewOpportunity.CRM_ID);
                db.AddInParameter(cd, "@iv_ValueBPS", SqlDbType.VarChar, objCreateNewOpportunity.ValueBPS);
                db.AddInParameter(cd, "@in_ValueBPSTCV", SqlDbType.Decimal, objCreateNewOpportunity.ValueBPSTCV);
                db.AddInParameter(cd, "@iv_OppType", SqlDbType.VarChar, objCreateNewOpportunity.OPP_TYPE);
                db.AddInParameter(cd, "@iv_ImmediateComment", SqlDbType.VarChar, objCreateNewOpportunity.ImmediateComment);
                db.AddInParameter(cd, "@iv_MultiTower", SqlDbType.VarChar, objCreateNewOpportunity.MultiTower);
                db.AddInParameter(cd, "@in_StatusFlag", SqlDbType.Int, objCreateNewOpportunity.StatusFlag);
                db.AddInParameter(cd, "@iv_Fna_Lead", SqlDbType.VarChar, objCreateNewOpportunity.FnA_Lead);
                db.AddInParameter(cd, "@iv_HRO_Lead", SqlDbType.VarChar, objCreateNewOpportunity.HRO_Lead);
                db.AddInParameter(cd, "@iv_SCM_Lead", SqlDbType.VarChar, objCreateNewOpportunity.SCM_Lead);
                db.AddInParameter(cd, "@iv_KPO_Lead", SqlDbType.VarChar, objCreateNewOpportunity.KPO_Lead);
                db.AddInParameter(cd, "@iv_LPO_Lead", SqlDbType.VarChar, objCreateNewOpportunity.LPO_Lead);
                db.AddInParameter(cd, "@iv_Vertical_Lead", SqlDbType.VarChar, objCreateNewOpportunity.VERTICAL_LEAD);
                db.AddInParameter(cd, "@iv_Voice_Lead", SqlDbType.VarChar, objCreateNewOpportunity.Voice_Lead);
                db.AddInParameter(cd, "@iv_Bpm_Lead", SqlDbType.VarChar, objCreateNewOpportunity.BPM_LEAD);
                db.AddInParameter(cd, "@iv_BidManagerId", SqlDbType.VarChar, objCreateNewOpportunity.BID_MANAGER_EMPID);
                db.AddInParameter(cd, "@iv_BidExecId", SqlDbType.VarChar, objCreateNewOpportunity.BID_EXEC_OWNER_EMPID);
                db.AddInParameter(cd, "@iv_PricingOwnerId", SqlDbType.VarChar, objCreateNewOpportunity.PRICING_OWNER_EMPID);
                db.AddInParameter(cd, "@iv_SolutionLeaderId", SqlDbType.VarChar, objCreateNewOpportunity.SolutionLeaderId);
                db.AddInParameter(cd, "@iv_FnaTCV", SqlDbType.VarChar, objCreateNewOpportunity.FnATCV);
                db.AddInParameter(cd, "@iv_HROTCV", SqlDbType.VarChar, objCreateNewOpportunity.HROTCV);
                db.AddInParameter(cd, "@iv_SCMTCV", SqlDbType.VarChar, objCreateNewOpportunity.SCMTCV);
                db.AddInParameter(cd, "@iv_KPOTCV", SqlDbType.VarChar, objCreateNewOpportunity.KPOTCV);
                db.AddInParameter(cd, "@iv_LPOTCV", SqlDbType.VarChar, objCreateNewOpportunity.LPOTCV);
                db.AddInParameter(cd, "@iv_VerticalTCV", SqlDbType.VarChar, objCreateNewOpportunity.VERTICALTCV);
                db.AddInParameter(cd, "@iv_VoiceTCV", SqlDbType.VarChar, objCreateNewOpportunity.VOICETCV);
                db.AddInParameter(cd, "@iv_BpmTCV", SqlDbType.VarChar, objCreateNewOpportunity.BPMTCV);
                db.AddInParameter(cd, "@in_ClusterId", SqlDbType.Int, objCreateNewOpportunity.ClusterId);
                db.AddInParameter(cd, "@in_BPSSubSPID", SqlDbType.Int, objCreateNewOpportunity.BPSSubSPID);
                db.AddInParameter(cd, "@in_BPSOfferingID", SqlDbType.Int, objCreateNewOpportunity.BPSOfferingID);
                db.AddInParameter(cd, "@in_ServiceId", SqlDbType.Int, objCreateNewOpportunity.ServiceId);
                db.AddInParameter(cd, "@in_SUBIOU", SqlDbType.VarChar, objCreateNewOpportunity.SUBIOU);
                db.AddInParameter(cd, "@in_strTransitionEmpId", SqlDbType.VarChar, objCreateNewOpportunity.TransitionEmpId);
                db.AddInParameter(cd, "@in_strTransitionName", SqlDbType.VarChar, objCreateNewOpportunity.TransitionName);
                db.AddInParameter(cd, "@in_strTransitionType", SqlDbType.VarChar, objCreateNewOpportunity.TransitionType);
                db.AddInParameter(cd, "@in_strTransitionApproach", SqlDbType.VarChar, objCreateNewOpportunity.TransitionApproach);
                db.AddInParameter(cd, "@in_strTransitionModel", SqlDbType.VarChar, objCreateNewOpportunity.TransitionModel);
                db.AddInParameter(cd, "@in_strProposalfactory", SqlDbType.VarChar, objCreateNewOpportunity.Proposalfactory);
                db.AddInParameter(cd, "@in_strProposalfactoryOptions", SqlDbType.VarChar, objCreateNewOpportunity.ProposalfactoryOptions);
                db.AddInParameter(cd, "@in_strProposalComments", SqlDbType.VarChar, objCreateNewOpportunity.ProposalComments);
                db.AddInParameter(cd, "@iv_DTValue", SqlDbType.VarChar, objCreateNewOpportunity.DTValue);
                db.AddInParameter(cd, "@iv_OtherDT", SqlDbType.VarChar, objCreateNewOpportunity.Other_DT);
                db.AddInParameter(cd, "@in_CRMTCV", SqlDbType.VarChar, objCreateNewOpportunity.CRM_TCV);
                db.AddInParameter(cd, "@in_CRMStage", SqlDbType.Int, objCreateNewOpportunity.CRM_STAGE);
                db.AddInParameter(cd, "@in_TGA", SqlDbType.VarChar, objCreateNewOpportunity.TataGroupAccount);
                db.AddInParameter(cd, "@in_TPA", SqlDbType.VarChar, objCreateNewOpportunity.TPA);
                db.AddInParameter(cd, "@in_TPA_Name", SqlDbType.VarChar, objCreateNewOpportunity.TPA_Name);
                db.AddInParameter(cd, "@in_ItisScope", SqlDbType.VarChar, objCreateNewOpportunity.ItisScope);
                db.AddInParameter(cd, "@in_IsContractRenewal", SqlDbType.VarChar, objCreateNewOpportunity.IsContractRenewal);
                db.AddInParameter(cd, "@in_ContractRenewalValue", SqlDbType.VarChar, objCreateNewOpportunity.ContractRenewalValue);
                db.AddInParameter(cd, "@iv_DigitalTCV", SqlDbType.VarChar, objCreateNewOpportunity.strDigitalTcv);

                db.AddInParameter(cd, "@in_SubSP", SqlDbType.Int, objCreateNewOpportunity.subSPId);
                db.AddInParameter(cd, "@in_CRMBeacon", SqlDbType.VarChar, objCreateNewOpportunity.CRM_Beacon);
                //changess
                db.AddInParameter(cd, "@in_ResourcingId", SqlDbType.Int, objCreateNewOpportunity.RESOURCING_ID);
                db.AddInParameter(cd, "@in_Seat_IdentificationId", SqlDbType.Int, objCreateNewOpportunity.SEAT_IDENTIFICATION_ID);
                db.AddInParameter(cd, "@DealStatus_Id", SqlDbType.Int, objCreateNewOpportunity.DealStatus);
                db.AddInParameter(cd, "@ServicePractice_Id", SqlDbType.Int, objCreateNewOpportunity.ServicePractice);
                db.AddInParameter(cd, "@CoreOffering_Id", SqlDbType.Int, objCreateNewOpportunity.CoreOffering);
                db.AddInParameter(cd, "@in_modernisedOfferingId", SqlDbType.Int, objCreateNewOpportunity.ModernisedOffering);
                db.AddInParameter(cd, "@in_cognitiveSolutionId", SqlDbType.Int, objCreateNewOpportunity.CognitiveSolutions);
                db.AddInParameter(cd, "@in_offerings", SqlDbType.VarChar, objCreateNewOpportunity.Offerings);
                db.AddInParameter(cd, "@in_Opportunity_Desc_Details", SqlDbType.VarChar, objCreateNewOpportunity.OpportunityDescDetails);
                db.AddInParameter(cd, "@OfferingType_Id", SqlDbType.Int, objCreateNewOpportunity.offeringType);
                db.AddInParameter(cd, "@CoreOfferingName_Id", SqlDbType.Int, objCreateNewOpportunity.CofID);
                db.AddInParameter(cd, "@iv_IgnioTMscope", SqlDbType.VarChar, objCreateNewOpportunity.IgnioTMScope);
                db.AddInParameter(cd, "@iv_IgnioTMscopeDetail", SqlDbType.VarChar, objCreateNewOpportunity.IgnioTMScopeDetails);
                db.AddInParameter(cd, "@iv_DigitalFlagging", SqlDbType.VarChar, objCreateNewOpportunity.DigitalFlagging);
                //End

                db.AddInParameter(cd, "@in_proposalSubmissionDate", SqlDbType.VarChar, objCreateNewOpportunity.PROPOSAL_SUBMISSION_DATE);
                db.AddInParameter(cd, "@in_salesStageMovedOnDate", SqlDbType.VarChar, objCreateNewOpportunity.SALES_STAGE_MOVED_ONDATE);

                db.AddInParameter(cd, "@iv_deliveryLocationProposed", SqlDbType.VarChar, objCreateNewOpportunity.DELIVERY_LOCATION_PROPOSED);
                db.AddInParameter(cd, "@cboioffering", SqlDbType.VarChar, objCreateNewOpportunity.Cboi_Offering_id);
                db.AddInParameter(cd, "@dealflag", SqlDbType.VarChar, objCreateNewOpportunity.Deal_Flag_id);
                db.AddOutParameter(cd, "@on_Result", SqlDbType.Int, Int16.MaxValue);
                db.ExecuteNonQuery(cd);
                on_Result = db.GetParameterValue(cd, "@on_Result").ToString();
                strResult.Add(new CreateNewOpportunity()
                {
                    on_Result = db.GetParameterValue(cd, "@on_Result").ToString()
                });

            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
            return strResult;
        }
        /// <summary>
        /// Save Opportunity Stage7 Details
        /// </summary>
        public List<CreateNewOpportunity> InsertOpportunitystage7(CreateNewOpportunity objCreateNewOpportunity)
        {
            List<CreateNewOpportunity> strResult = new List<CreateNewOpportunity>();
            try
            {

                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Ins_Opportunity_stage7_sp);
                db.AddInParameter(cd, "@in_OpportunityId", SqlDbType.VarChar, objCreateNewOpportunity.OpportunityId);
                db.AddInParameter(cd, "@iv_OpportunityDesc", SqlDbType.VarChar, objCreateNewOpportunity.OPPORTUNITY_DESC);
                db.AddInParameter(cd, "@iv_OldOpportunityDesc", SqlDbType.VarChar, objCreateNewOpportunity.OLD_OPPORTUNITY_DESC);
                db.AddInParameter(cd, "@in_GeographyId", SqlDbType.Int, objCreateNewOpportunity.GEOGRAPHY_ID);
                db.AddInParameter(cd, "@in_CustId", SqlDbType.Int, objCreateNewOpportunity.CUST_ID);
                db.AddInParameter(cd, "@in_CustTypeId", SqlDbType.Int, objCreateNewOpportunity.CUST_TYPE_ID);
                db.AddInParameter(cd, "@in_IndustryPracticeId", SqlDbType.Int, objCreateNewOpportunity.INDUSTRY_PRACTICE_ID);
                db.AddInParameter(cd, "@in_StageId", SqlDbType.Int, objCreateNewOpportunity.StageID);
                db.AddInParameter(cd, "@iv_GeographySalesOwner", SqlDbType.VarChar, objCreateNewOpportunity.GeosalesOwner);
                db.AddInParameter(cd, "@iv_OffshorePracticeOwner", SqlDbType.VarChar, objCreateNewOpportunity.OffPracOwner);
                db.AddInParameter(cd, "@iv_RdCrd", SqlDbType.VarChar, objCreateNewOpportunity.RDCrd);
                db.AddInParameter(cd, "@iv_OffshoreBDLead", SqlDbType.VarChar, objCreateNewOpportunity.OffShoreBDLead);
                db.AddInParameter(cd, "@iv_OnsiteOwner", SqlDbType.VarChar, objCreateNewOpportunity.OnsiteOwner);
                db.AddInParameter(cd, "@in_ProbabilityOfwin", SqlDbType.Int, objCreateNewOpportunity.PROBABILITY_OF_WIN);
                db.AddInParameter(cd, "@in_CurencyId", SqlDbType.Int, objCreateNewOpportunity.CURRENCY_ID);
                db.AddInParameter(cd, "@in_TCV", SqlDbType.VarChar, objCreateNewOpportunity.TCV);
                db.AddInParameter(cd, "@in_ContractLength", SqlDbType.Int, objCreateNewOpportunity.ContractLength);
                db.AddInParameter(cd, "@in_FiscalRev", SqlDbType.Float, objCreateNewOpportunity.FiscRev);
                db.AddInParameter(cd, "@in_FTE", SqlDbType.Int, objCreateNewOpportunity.FTE);
                db.AddInParameter(cd, "@iv_Remark", SqlDbType.VarChar, objCreateNewOpportunity.REMARK);
                db.AddInParameter(cd, "@in_OppDate", SqlDbType.Int, objCreateNewOpportunity.OppDate);
                db.AddInParameter(cd, "@in_RFIReceivedDt", SqlDbType.Int, objCreateNewOpportunity.RFIReceivedDate);
                db.AddInParameter(cd, "@in_RFIProbSubmissiondDt", SqlDbType.Int, objCreateNewOpportunity.RFIProbableSubmissionDate);
                db.AddInParameter(cd, "@in_RFIActSubmissiondDt", SqlDbType.Int, objCreateNewOpportunity.RFIActualSubmissionDate);
                db.AddInParameter(cd, "@in_RFPReceivedDt", SqlDbType.Int, objCreateNewOpportunity.RFPReceivedDate);
                db.AddInParameter(cd, "@in_RFPProbSubmissiondDt", SqlDbType.Int, objCreateNewOpportunity.RFPProbableSubmissionDate);
                db.AddInParameter(cd, "@in_RFPActSubmissiondDt", SqlDbType.Int, objCreateNewOpportunity.RFPActualSubmissionDate);
                db.AddInParameter(cd, "@in_BCPDRPLoc", SqlDbType.Int, objCreateNewOpportunity.BCP_DRP_LOCATION);
                db.AddInParameter(cd, "@iv_EmpNo", SqlDbType.VarChar, objCreateNewOpportunity.EmpNo);
                db.AddInParameter(cd, "@in_ClosureDate", SqlDbType.Int, objCreateNewOpportunity.ClosureDate);
                db.AddInParameter(cd, "@in_RFIRwDt", SqlDbType.Int, objCreateNewOpportunity.RFI_REVIEW_DT);
                db.AddInParameter(cd, "@in_RFPRwDt", SqlDbType.Int, objCreateNewOpportunity.RFP_REVIEW_DT);
                db.AddInParameter(cd, "@iv_RFIBy", SqlDbType.VarChar, objCreateNewOpportunity.RFI_REVIEW_BY);
                db.AddInParameter(cd, "@iv_RFPBy", SqlDbType.VarChar, objCreateNewOpportunity.RFP_REVIEW_BY);
                db.AddInParameter(cd, "@iv_NGM", SqlDbType.VarChar, objCreateNewOpportunity.OPP_NGM);
                db.AddInParameter(cd, "@iv_CRMReason", SqlDbType.VarChar, objCreateNewOpportunity.CRM_REASON);
                db.AddInParameter(cd, "@iv_BidExeEmpId", SqlDbType.VarChar, objCreateNewOpportunity.BID_EXECUTIVE_EMPID);
                db.AddInParameter(cd, "@iv_Disqual", SqlDbType.VarChar, objCreateNewOpportunity.Disqual);
                db.AddInParameter(cd, "@iv_AddDeal", SqlDbType.VarChar, objCreateNewOpportunity.AddDeal);
                db.AddInParameter(cd, "@iv_BidExeName", SqlDbType.VarChar, objCreateNewOpportunity.BID_EXECUTIVE_NAME);
                db.AddInParameter(cd, "@iv_DealOwner", SqlDbType.VarChar, objCreateNewOpportunity.DealOwner);
                db.AddInParameter(cd, "@iv_DealOwner2", SqlDbType.VarChar, objCreateNewOpportunity.DealOwner2);
                db.AddInParameter(cd, "@in_OperationWindow", SqlDbType.Int, objCreateNewOpportunity.OPERATION_WINDOW);
                db.AddInParameter(cd, "@in_Area", SqlDbType.Int, objCreateNewOpportunity.AREA);
                db.AddInParameter(cd, "@in_TypesOfSeat", SqlDbType.Int, objCreateNewOpportunity.TYPES_OF_SEAT);
                db.AddInParameter(cd, "@in_PCsRequired", SqlDbType.Int, objCreateNewOpportunity.PCS_REQUIRED);
                db.AddInParameter(cd, "@in_DesksRequired", SqlDbType.Int, objCreateNewOpportunity.DESKS_REQUIRED);
                db.AddInParameter(cd, "@in_PhonesRequired", SqlDbType.Int, objCreateNewOpportunity.PHONES_REQUIRED);
                db.AddInParameter(cd, "@in_CabinsRequired", SqlDbType.Int, objCreateNewOpportunity.CABINS_REQUIRED);
                db.AddInParameter(cd, "@in_LaptopsRequired", SqlDbType.Int, objCreateNewOpportunity.LAPTOPS_REQUIRED);
                db.AddInParameter(cd, "@in_Comp1", SqlDbType.Int, objCreateNewOpportunity.COMPETITOR_1);
                db.AddInParameter(cd, "@in_Comp2", SqlDbType.Int, objCreateNewOpportunity.COMPETITOR_2);
                db.AddInParameter(cd, "@in_Comp3", SqlDbType.Int, objCreateNewOpportunity.COMPETITOR_3);
                db.AddInParameter(cd, "@in_Comp4", SqlDbType.Int, objCreateNewOpportunity.COMPETITOR_4);
                db.AddInParameter(cd, "@in_Comp5", SqlDbType.Int, objCreateNewOpportunity.COMPETITOR_5);
                db.AddInParameter(cd, "@in_AdvisoryId", SqlDbType.Int, objCreateNewOpportunity.ADVISORY_ID);
                db.AddInParameter(cd, "@iv_Platform", SqlDbType.VarChar, objCreateNewOpportunity.PLATFORM);
                db.AddInParameter(cd, "@in_PIBSTCV", SqlDbType.VarChar, objCreateNewOpportunity.PibsSaleValue);
                db.AddInParameter(cd, "@iv_NextStep", SqlDbType.VarChar, objCreateNewOpportunity.NextStep);
                db.AddInParameter(cd, "@in_BusinessId", SqlDbType.Int, objCreateNewOpportunity.BUSINESS_ID);
                db.AddInParameter(cd, "@in_ProductId", SqlDbType.Int, objCreateNewOpportunity.PRODUCT_ID);
                db.AddInParameter(cd, "@in_CompetencyId", SqlDbType.Int, objCreateNewOpportunity.COMPETENCY_ID);
                db.AddInParameter(cd, "@in_SubCompetencyId", SqlDbType.Int, objCreateNewOpportunity.SUB_COMPETENCY_ID);
                db.AddInParameter(cd, "@in_AnnualSaleValue", SqlDbType.Decimal, objCreateNewOpportunity.AnnualSaleValue);
                db.AddInParameter(cd, "@in_PricingTypeId", SqlDbType.Int, objCreateNewOpportunity.PRICING_TYPE_ID);
                db.AddInParameter(cd, "@iv_KeyRmk", SqlDbType.VarChar, objCreateNewOpportunity.KeyRmk);
                db.AddInParameter(cd, "@iv_AccountSalesOwner", SqlDbType.VarChar, objCreateNewOpportunity.AccountSalesOwner);
                db.AddInParameter(cd, "@iv_ExeSponser", SqlDbType.VarChar, objCreateNewOpportunity.ExeSponser);
                db.AddInParameter(cd, "@iv_ValBPSCon", SqlDbType.VarChar, objCreateNewOpportunity.ValBPSCon);
                db.AddInParameter(cd, "@iv_ProactiveProposal", SqlDbType.VarChar, objCreateNewOpportunity.ProactiveProposal);
                db.AddInParameter(cd, "@iv_IsuMain", SqlDbType.VarChar, objCreateNewOpportunity.IsuMain);
                db.AddInParameter(cd, "@iv_PlatformNew", SqlDbType.VarChar, objCreateNewOpportunity.PlatformNew);
                db.AddInParameter(cd, "@iv_StatusUpdate", SqlDbType.VarChar, objCreateNewOpportunity.StatusUpdate);
                db.AddInParameter(cd, "@in_CategoryId", SqlDbType.Int, objCreateNewOpportunity.Category_Id);
                db.AddInParameter(cd, "@in_CountryId", SqlDbType.Int, objCreateNewOpportunity.CountryId);
                db.AddInParameter(cd, "@in_NextStepDueDt", SqlDbType.Int, objCreateNewOpportunity.NextStepDueDt);
                db.AddInParameter(cd, "@in_OffFTE  ", SqlDbType.Int, objCreateNewOpportunity.FTEOff);
                db.AddInParameter(cd, "@in_OnFTE  ", SqlDbType.Int, objCreateNewOpportunity.FTEOn);
                db.AddInParameter(cd, "@iv_ISUOwner", SqlDbType.VarChar, objCreateNewOpportunity.ISU_OWNER_ID);
                db.AddInParameter(cd, "@in_UnitID", SqlDbType.Int, objCreateNewOpportunity.UnitId);
                db.AddInParameter(cd, "@iv_ISU", SqlDbType.VarChar, objCreateNewOpportunity.ISU_CD);
                db.AddInParameter(cd, "@iv_PIBS", SqlDbType.VarChar, objCreateNewOpportunity.PIBS);
                db.AddInParameter(cd, "@iv_TCS_INVESTMENT", SqlDbType.VarChar, objCreateNewOpportunity.TCSInvestment);
                db.AddInParameter(cd, "@in_PIBStartDate", SqlDbType.Int, objCreateNewOpportunity.PIBStartDate);
                db.AddInParameter(cd, "@in_PIBEndDate", SqlDbType.Int, objCreateNewOpportunity.PIBSEndDate);
                db.AddInParameter(cd, "@in_NoOfFTEsEngaged", SqlDbType.Int, objCreateNewOpportunity.FTEsEngaged);
                db.AddInParameter(cd, "@in_PIBStatus", SqlDbType.Int, objCreateNewOpportunity.PIBStatus);
                db.AddInParameter(cd, "@in_PIBSOutcome", SqlDbType.Int, objCreateNewOpportunity.PIBS_OUTCOME_ID);
                db.AddInParameter(cd, "@iv_PIBStatusRemarks", SqlDbType.VarChar, objCreateNewOpportunity.PIBStatusRemarks);
                db.AddInParameter(cd, "@iv_FTEType", SqlDbType.VarChar, objCreateNewOpportunity.chkVariousFTEs);
                db.AddInParameter(cd, "@in_FTETypeCount", SqlDbType.Int, objCreateNewOpportunity.FTE_TYPE_COUNT);
                db.AddInParameter(cd, "@in_BPODomain", SqlDbType.Int, objCreateNewOpportunity.BPODomain);
                db.AddInParameter(cd, "@iv_DomainPresalesLead", SqlDbType.VarChar, objCreateNewOpportunity.DOMAIN_PRESALES_LEAD);
                db.AddInParameter(cd, "@in_DealCategory", SqlDbType.Int, objCreateNewOpportunity.DealCategory);
                db.AddInParameter(cd, "@iv_DealCoachName", SqlDbType.VarChar, objCreateNewOpportunity.DealCoachName);
                db.AddInParameter(cd, "@in_DemandType", SqlDbType.Int, objCreateNewOpportunity.DemandType);
                db.AddInParameter(cd, "@iv_KeyDeal", SqlDbType.VarChar, objCreateNewOpportunity.KEY_DEAL);
                db.AddInParameter(cd, "@iv_ProposedSolution", SqlDbType.VarChar, objCreateNewOpportunity.ProposedSolution);
                db.AddInParameter(cd, "@iv_WinningTeam", SqlDbType.VarChar, objCreateNewOpportunity.WinningTheme);
                db.AddInParameter(cd, "@iv_KeyCustExp", SqlDbType.VarChar, objCreateNewOpportunity.KeyCustExp);
                db.AddInParameter(cd, "@iv_OperatingModel", SqlDbType.VarChar, objCreateNewOpportunity.operatingModel);
                db.AddInParameter(cd, "@iv_PricingModel", SqlDbType.VarChar, objCreateNewOpportunity.PRICING_MODEL);
                db.AddInParameter(cd, "@iv_Differentiators", SqlDbType.VarChar, objCreateNewOpportunity.Differentiators);
                db.AddInParameter(cd, "@iv_Risks", SqlDbType.VarChar, Risks);
                db.AddInParameter(cd, "@iv_KeyCustomerConnects", SqlDbType.VarChar, objCreateNewOpportunity.KeyCustomerConnects);
                db.AddInParameter(cd, "@iv_BPOOfferingDescription", SqlDbType.VarChar, objCreateNewOpportunity.BPOOfferingDescription);
                db.AddInParameter(cd, "@iv_FirstTimeOutsource", SqlDbType.VarChar, objCreateNewOpportunity.chkFirstTimeOutsource);
                db.AddInParameter(cd, "@iv_Incumbents", SqlDbType.VarChar, objCreateNewOpportunity.INCUMBENTS);
                db.AddInParameter(cd, "@iv_NameOfIncumbents", SqlDbType.VarChar, objCreateNewOpportunity.NAME_OF_INCUMBENTS);
                db.AddInParameter(cd, "@iv_TCSOfferingCapability", SqlDbType.VarChar, objCreateNewOpportunity.TCS_OFFERING_CAPABILITY);
                db.AddInParameter(cd, "@iv_SpecifyOffering", SqlDbType.VarChar, objCreateNewOpportunity.SpecifyOffering);
                db.AddInParameter(cd, "@iv_CoachAvailable", SqlDbType.VarChar, objCreateNewOpportunity.CoachAvailable);
                db.AddInParameter(cd, "@iv_FnA", SqlDbType.VarChar, objCreateNewOpportunity.FnA);
                db.AddInParameter(cd, "@in_Fna_FTE", SqlDbType.Int, objCreateNewOpportunity.FnA_FTE);
                db.AddInParameter(cd, "@iv_HRO", SqlDbType.VarChar, objCreateNewOpportunity.HRO);
                db.AddInParameter(cd, "@in_HRO_FTE", SqlDbType.Int, objCreateNewOpportunity.HRO_FTE);
                db.AddInParameter(cd, "@iv_SCM", SqlDbType.VarChar, objCreateNewOpportunity.SCM);
                db.AddInParameter(cd, "@in_SCM_FTE", SqlDbType.Int, objCreateNewOpportunity.SCM_FTE);
                db.AddInParameter(cd, "@iv_KPO", SqlDbType.VarChar, objCreateNewOpportunity.KPO);
                db.AddInParameter(cd, "@in_KPO_FTE", SqlDbType.Int, objCreateNewOpportunity.KPO_FTE);
                db.AddInParameter(cd, "@iv_LPO", SqlDbType.VarChar, objCreateNewOpportunity.LPO);
                db.AddInParameter(cd, "@in_LPO_FTE", SqlDbType.Int, objCreateNewOpportunity.LPO_FTE);
                db.AddInParameter(cd, "@iv_Vertical", SqlDbType.VarChar, objCreateNewOpportunity.VERTICAL);
                db.AddInParameter(cd, "@in_Vertical_FTE", SqlDbType.Int, objCreateNewOpportunity.VerticalFTE);
                db.AddInParameter(cd, "@iv_Voice", SqlDbType.VarChar, objCreateNewOpportunity.Voice);
                db.AddInParameter(cd, "@in_Voice_FTE", SqlDbType.Int, objCreateNewOpportunity.VoiceFTE);
                db.AddInParameter(cd, "@iv_Bpm", SqlDbType.VarChar, objCreateNewOpportunity.BPM);
                db.AddInParameter(cd, "@in_Bpm_FTE", SqlDbType.Int, objCreateNewOpportunity.BPM_FTE);
                db.AddInParameter(cd, "@in_SolTM", SqlDbType.Int, objCreateNewOpportunity.SolTM);
                db.AddInParameter(cd, "@in_DelTM", SqlDbType.Int, objCreateNewOpportunity.DelTM);
                db.AddInParameter(cd, "@iv_BidManager", SqlDbType.VarChar, objCreateNewOpportunity.BID_MANAGER);
                db.AddInParameter(cd, "@iv_BidExec", SqlDbType.VarChar, objCreateNewOpportunity.BID_EXEC_OWNER);
                db.AddInParameter(cd, "@iv_PricingOwner", SqlDbType.VarChar, objCreateNewOpportunity.PRICING_OWNER);
                db.AddInParameter(cd, "@in_TransitionTeam", SqlDbType.Int, objCreateNewOpportunity.TransitionTeam);
                db.AddInParameter(cd, "@iv_ExpectedDate", SqlDbType.Int, objCreateNewOpportunity.ExpectedDate);
                db.AddInParameter(cd, "@iv_TransitionReq", SqlDbType.VarChar, objCreateNewOpportunity.TransitionReq);
                db.AddInParameter(cd, "@iv_Entity", SqlDbType.VarChar, objCreateNewOpportunity.ENTITY);
                db.AddInParameter(cd, "@iv_Quarter", SqlDbType.VarChar, objCreateNewOpportunity.Quarter);
                db.AddInParameter(cd, "@iv_FiscalYear", SqlDbType.VarChar, objCreateNewOpportunity.FiscalYear);
                db.AddInParameter(cd, "@iv_CurrentlyActive", SqlDbType.VarChar, objCreateNewOpportunity.CURRENTLY_ACTIVE);
                db.AddInParameter(cd, "@iv_FTEDD", SqlDbType.VarChar, objCreateNewOpportunity.FTEDD);
                db.AddInParameter(cd, "@iv_SolutionLeader", SqlDbType.VarChar, objCreateNewOpportunity.SolutionLeader);
                db.AddInParameter(cd, "@in_Seat_Requirements", SqlDbType.Int, objCreateNewOpportunity.SeatRequirements);
                db.AddInParameter(cd, "@iv_RUR", SqlDbType.VarChar, objCreateNewOpportunity.RUR);
                db.AddInParameter(cd, "@iv_HRT_Comments", SqlDbType.VarChar, objCreateNewOpportunity.HRTComments);
                db.AddInParameter(cd, "@iv_CRMId", SqlDbType.VarChar, objCreateNewOpportunity.CRM_ID);
                db.AddInParameter(cd, "@iv_ValueBPS", SqlDbType.VarChar, objCreateNewOpportunity.ValueBPS);
                db.AddInParameter(cd, "@in_ValueBPSTCV", SqlDbType.Decimal, objCreateNewOpportunity.ValueBPSTCV);
                db.AddInParameter(cd, "@iv_OppType", SqlDbType.VarChar, objCreateNewOpportunity.OPP_TYPE);
                db.AddInParameter(cd, "@iv_ImmediateComment", SqlDbType.VarChar, objCreateNewOpportunity.ImmediateComment);
                db.AddInParameter(cd, "@iv_MultiTower", SqlDbType.VarChar, objCreateNewOpportunity.MultiTower);
                db.AddInParameter(cd, "@in_StatusFlag", SqlDbType.Int, objCreateNewOpportunity.StatusFlag);
                db.AddInParameter(cd, "@iv_Fna_Lead", SqlDbType.VarChar, objCreateNewOpportunity.FnA_Lead);
                db.AddInParameter(cd, "@iv_HRO_Lead", SqlDbType.VarChar, objCreateNewOpportunity.HRO_Lead);
                db.AddInParameter(cd, "@iv_SCM_Lead", SqlDbType.VarChar, objCreateNewOpportunity.SCM_Lead);
                db.AddInParameter(cd, "@iv_KPO_Lead", SqlDbType.VarChar, objCreateNewOpportunity.KPO_Lead);
                db.AddInParameter(cd, "@iv_LPO_Lead", SqlDbType.VarChar, objCreateNewOpportunity.LPO_Lead);
                db.AddInParameter(cd, "@iv_Vertical_Lead", SqlDbType.VarChar, objCreateNewOpportunity.VERTICAL_LEAD);
                db.AddInParameter(cd, "@iv_Voice_Lead", SqlDbType.VarChar, objCreateNewOpportunity.Voice_Lead);
                db.AddInParameter(cd, "@iv_Bpm_Lead", SqlDbType.VarChar, objCreateNewOpportunity.BPM_LEAD);
                db.AddInParameter(cd, "@iv_BidManagerId", SqlDbType.VarChar, objCreateNewOpportunity.BID_MANAGER_EMPID);
                db.AddInParameter(cd, "@iv_BidExecId", SqlDbType.VarChar, objCreateNewOpportunity.BID_EXEC_OWNER_EMPID);
                db.AddInParameter(cd, "@iv_PricingOwnerId", SqlDbType.VarChar, objCreateNewOpportunity.PRICING_OWNER_EMPID);
                db.AddInParameter(cd, "@iv_SolutionLeaderId", SqlDbType.VarChar, objCreateNewOpportunity.SolutionLeaderId);
                db.AddInParameter(cd, "@iv_FnaTCV", SqlDbType.VarChar, objCreateNewOpportunity.FnATCV);
                db.AddInParameter(cd, "@iv_HROTCV", SqlDbType.VarChar, objCreateNewOpportunity.HROTCV);
                db.AddInParameter(cd, "@iv_SCMTCV", SqlDbType.VarChar, objCreateNewOpportunity.SCMTCV);
                db.AddInParameter(cd, "@iv_KPOTCV", SqlDbType.VarChar, objCreateNewOpportunity.KPOTCV);
                db.AddInParameter(cd, "@iv_LPOTCV", SqlDbType.VarChar, objCreateNewOpportunity.LPOTCV);
                db.AddInParameter(cd, "@iv_VerticalTCV", SqlDbType.VarChar, objCreateNewOpportunity.VERTICALTCV);
                db.AddInParameter(cd, "@iv_VoiceTCV", SqlDbType.VarChar, objCreateNewOpportunity.VOICETCV);
                db.AddInParameter(cd, "@iv_BpmTCV", SqlDbType.VarChar, objCreateNewOpportunity.BPMTCV);
                db.AddInParameter(cd, "@in_ClusterId", SqlDbType.Int, objCreateNewOpportunity.ClusterId);
                db.AddInParameter(cd, "@in_BPSSubSPID", SqlDbType.Int, objCreateNewOpportunity.BPSSubSPID);
                db.AddInParameter(cd, "@in_BPSOfferingID", SqlDbType.Int, objCreateNewOpportunity.BPSOfferingID);
                db.AddInParameter(cd, "@in_ServiceId", SqlDbType.Int, objCreateNewOpportunity.ServiceId);
                db.AddInParameter(cd, "@in_SUBIOU", SqlDbType.VarChar, objCreateNewOpportunity.SUBIOU);
                db.AddInParameter(cd, "@in_strTransitionEmpId", SqlDbType.VarChar, objCreateNewOpportunity.TransitionEmpId);
                db.AddInParameter(cd, "@in_strTransitionName", SqlDbType.VarChar, objCreateNewOpportunity.TransitionName);
                db.AddInParameter(cd, "@in_strTransitionType", SqlDbType.VarChar, objCreateNewOpportunity.TransitionType);
                db.AddInParameter(cd, "@in_strTransitionApproach", SqlDbType.VarChar, objCreateNewOpportunity.TransitionApproach);
                db.AddInParameter(cd, "@in_strTransitionModel", SqlDbType.VarChar, objCreateNewOpportunity.TransitionModel);
                db.AddInParameter(cd, "@in_strProposalfactory", SqlDbType.VarChar, objCreateNewOpportunity.Proposalfactory);
                db.AddInParameter(cd, "@in_strProposalfactoryOptions", SqlDbType.VarChar, objCreateNewOpportunity.ProposalfactoryOptions);
                db.AddInParameter(cd, "@in_strProposalComments", SqlDbType.VarChar, objCreateNewOpportunity.ProposalComments);
                db.AddInParameter(cd, "@iv_DTValue", SqlDbType.VarChar, objCreateNewOpportunity.DTValue);
                db.AddInParameter(cd, "@iv_OtherDT", SqlDbType.VarChar, objCreateNewOpportunity.Other_DT);
                db.AddInParameter(cd, "@in_CRMTCV", SqlDbType.VarChar, objCreateNewOpportunity.CRM_TCV);
                db.AddInParameter(cd, "@in_CRMStage", SqlDbType.Int, objCreateNewOpportunity.CRM_STAGE);
                db.AddInParameter(cd, "@in_TGA", SqlDbType.VarChar, objCreateNewOpportunity.TataGroupAccount);
                db.AddInParameter(cd, "@in_TPA", SqlDbType.VarChar, objCreateNewOpportunity.TPA);
                db.AddInParameter(cd, "@in_TPA_Name", SqlDbType.VarChar, objCreateNewOpportunity.TPA_Name);
                db.AddInParameter(cd, "@in_ItisScope", SqlDbType.VarChar, objCreateNewOpportunity.ItisScope);
                db.AddInParameter(cd, "@in_IsContractRenewal", SqlDbType.VarChar, objCreateNewOpportunity.IsContractRenewal);
                db.AddInParameter(cd, "@in_ContractRenewalValue", SqlDbType.VarChar, objCreateNewOpportunity.ContractRenewalValue);
                db.AddInParameter(cd, "@iv_DigitalTCV", SqlDbType.VarChar, objCreateNewOpportunity.strDigitalTcv);

                db.AddInParameter(cd, "@in_SubSP", SqlDbType.Int, objCreateNewOpportunity.subSPId);
                db.AddInParameter(cd, "@in_CRMBeacon", SqlDbType.VarChar, objCreateNewOpportunity.CRM_Beacon);
                //changess
                db.AddInParameter(cd, "@in_ResourcingId", SqlDbType.Int, objCreateNewOpportunity.RESOURCING_ID);
                db.AddInParameter(cd, "@in_Seat_IdentificationId", SqlDbType.Int, objCreateNewOpportunity.SEAT_IDENTIFICATION_ID);

                //End
                db.AddInParameter(cd, "@in_OnsiteTrainingNos", SqlDbType.Int, objCreateNewOpportunity.ONSITE_TRAINING_NOS);
                db.AddInParameter(cd, "@iv_VisaRequired", SqlDbType.VarChar, objCreateNewOpportunity.VISA_REQUIRED);
                db.AddInParameter(cd, "@in_TrainingDuration", SqlDbType.Int, objCreateNewOpportunity.TRAINING_DURATION);
                db.AddInParameter(cd, "@in_VisasRequired", SqlDbType.Int, objCreateNewOpportunity.VISAS_REQUIRED);
                db.AddInParameter(cd, "@in_ShortListDt", SqlDbType.Int, objCreateNewOpportunity.ShortListDate);
                db.AddInParameter(cd, "@in_SelectionDt", SqlDbType.Int, objCreateNewOpportunity.SelectionDate);
                db.AddInParameter(cd, "@DealStatus_Id", SqlDbType.Int, objCreateNewOpportunity.DealStatus);
                db.AddInParameter(cd, "@ServicePractice_Id", SqlDbType.Int, objCreateNewOpportunity.ServicePractice);
                db.AddInParameter(cd, "@CoreOffering_Id", SqlDbType.Int, objCreateNewOpportunity.CoreOffering);
                db.AddInParameter(cd, "@in_modernisedOfferingId", SqlDbType.Int, objCreateNewOpportunity.ModernisedOffering);
                db.AddInParameter(cd, "@in_cognitiveSolutionId", SqlDbType.Int, objCreateNewOpportunity.CognitiveSolutions);
                db.AddInParameter(cd, "@in_offerings", SqlDbType.VarChar, objCreateNewOpportunity.Offerings);
                db.AddInParameter(cd, "@in_Opportunity_Desc_Details", SqlDbType.VarChar, objCreateNewOpportunity.OpportunityDescDetails);
                
                db.AddInParameter(cd, "@in_proposalSubmissionDate", SqlDbType.VarChar, objCreateNewOpportunity.PROPOSAL_SUBMISSION_DATE);
                db.AddInParameter(cd, "@in_salesStageMovedOnDate", SqlDbType.VarChar, objCreateNewOpportunity.SALES_STAGE_MOVED_ONDATE);

                db.AddInParameter(cd, "@iv_deliveryLocationProposed", SqlDbType.VarChar, objCreateNewOpportunity.DELIVERY_LOCATION_PROPOSED);

                db.AddInParameter(cd, "@OfferingType_Id", SqlDbType.Int, objCreateNewOpportunity.offeringType);
                db.AddInParameter(cd, "@CoreOfferingName_Id", SqlDbType.Int, objCreateNewOpportunity.CofID);
                db.AddInParameter(cd, "@iv_IgnioTMscope", SqlDbType.VarChar, objCreateNewOpportunity.IgnioTMScope);
                db.AddInParameter(cd, "@iv_IgnioTMscopeDetail", SqlDbType.VarChar, objCreateNewOpportunity.IgnioTMScopeDetails);
                db.AddInParameter(cd, "@iv_DigitalFlagging", SqlDbType.VarChar, objCreateNewOpportunity.DigitalFlagging);
                db.AddInParameter(cd, "@cboioffering", SqlDbType.VarChar, objCreateNewOpportunity.Cboi_Offering_id);
                db.AddInParameter(cd, "@dealflag", SqlDbType.VarChar, objCreateNewOpportunity.Deal_Flag_id);
                db.AddOutParameter(cd, "@on_Result", SqlDbType.Int, Int16.MaxValue);
                db.ExecuteNonQuery(cd);
                on_Result = db.GetParameterValue(cd, "@on_Result").ToString();
                strResult.Add(new CreateNewOpportunity()
                {
                    on_Result = db.GetParameterValue(cd, "@on_Result").ToString()
                });

            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
            return strResult;
        }
        /// <summary>
        /// Check Opp Stake Holders Involvement Details
        /// </summary>
        public List<CreateNewOpportunity> CheckOppStakeHoldersInvolvement(string opportunityId, int currStageId, int nxtStageId)
        {
            DataSet ds = null;
            List<CreateNewOpportunity> modelList = new List<CreateNewOpportunity>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.CheckOppStakeHoldersInvolvement);
                db.AddInParameter(cd, "@in_OppId", SqlDbType.VarChar, opportunityId);
                db.AddInParameter(cd, "@in_Curr_StageId", SqlDbType.Int, currStageId);
                db.AddInParameter(cd, "@in_Next_StageId", SqlDbType.Int, nxtStageId);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;

                        for (int i = 0; i < rowCount; i++)
                        {
                            modelList.Add(MapStackHolderInvolvement(ds.Tables[0].Rows[i]));
                        }

                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }
            return modelList;
        }

        private static CreateNewOpportunity MapStackHolderInvolvement(DataRow dr)
        {
            try
            {
                return new CreateNewOpportunity()
                {
                    StakeHolder = (dr.Table.Columns.Contains("STAKEHOLDERS")) ? (dr["STAKEHOLDERS"] == DBNull.Value) ? "" : dr.Field<string>("STAKEHOLDERS") : "",
                };
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
        }
        /// <summary>
        /// Update Opportunity Stage Details
        /// </summary>
        public void UpdateOpportunityStage(UpdateOpportunityStage obj)
        {
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.UpdateOpportunityStage);
                db.AddInParameter(cd, "@in_OpportunityId", SqlDbType.VarChar, obj.OpportunityId);
                db.AddInParameter(cd, "@in_StageId_Old", SqlDbType.VarChar, obj.CurrentStageID.ToString());
                db.AddInParameter(cd, "@in_StageId_New", SqlDbType.VarChar, obj.NextStageID.ToString());
                db.AddInParameter(cd, "@in_StageId_New", SqlDbType.VarChar, obj.EmpId.ToString());
                db.ExecuteNonQuery(cd);
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }

        }
        /// <summary>
        /// Proceed Next Stage
        /// </summary>
        public List<CreateNewOpportunity> ProceedNextStage(string opportunityId, string empId, int currStageId, int nxtStageId)
        {
            DataSet ds = null;
            List<CreateNewOpportunity> modelList = new List<CreateNewOpportunity>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.ProceedNextStage);
                db.AddInParameter(cd, "@in_OppId", SqlDbType.VarChar, opportunityId);
                db.AddInParameter(cd, "@iv_EmpId", SqlDbType.VarChar, empId);
                db.AddInParameter(cd, "@in_Curr_StageId", SqlDbType.Int, currStageId);
                db.AddInParameter(cd, "@in_Next_StageId", SqlDbType.Int, nxtStageId);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;

                        for (int i = 0; i < rowCount; i++)
                        {
                            modelList.Add(MapProceedNextStage(ds.Tables[0].Rows[i]));
                        }

                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }
            return modelList;
        }
        private static CreateNewOpportunity MapProceedNextStage(DataRow dr)
        {
            try
            {
                return new CreateNewOpportunity()
                {
                    StakeHolder = (dr[0] == DBNull.Value) ? "" : dr.Field<string>(0),
                };
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
        }
        /// <summary>
        /// Check Infra Qual DL Details
        /// </summary>
        public Dictionary<int, List<CreateNewOpportunity>> CheckInfraQualDLDetails(int unitId, string opportunityId)
        {
            DataSet ds = null;
            Dictionary<int, List<CreateNewOpportunity>> modelList = new Dictionary<int, List<CreateNewOpportunity>>();
            List<CreateNewOpportunity> newList = new List<CreateNewOpportunity>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.CheckInfraQualDLDetails);
                db.AddInParameter(cd, "@in_UnitID", SqlDbType.Int, unitId);
                db.AddInParameter(cd, "@iv_OppId", SqlDbType.VarChar, opportunityId);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;

                        for (int i = 0; i < rowCount; i++)
                        {
                            newList.Add(MapCheckInfraQualDLDetails1(ds.Tables[0].Rows[i]));
                        }
                        modelList.Add(0, newList);
                        newList = null;
                        int rowCount1 = ds.Tables[1].Rows.Count;
                        for (int i = 0; i < rowCount1; i++)
                        {
                            if (ds.Tables[0].Rows[i] != null)
                            {
                                newList.Add(MapCheckInfraQualDLDetails2(ds.Tables[1].Rows[i]));
                            }
                        }
                        modelList.Add(1, newList);
                        newList = null;
                        int rowCount2 = ds.Tables[2].Rows.Count;
                        for (int i = 0; i < rowCount2; i++)
                        {
                            if (ds.Tables[0].Rows[i] != null)
                            {
                                newList.Add(MapCheckInfraQualDLDetails3(ds.Tables[2].Rows[i]));
                            }
                            
                        }
                        modelList.Add(2, newList);
                        newList = null;
                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }
            return modelList;
        }
        private static CreateNewOpportunity MapCheckInfraQualDLDetails1(DataRow dr)
        {
            try
            {
                return new CreateNewOpportunity()
                {
                    InfraHeadEmpId = (dr.Table.Columns.Contains("INFRA_HEAD_EMP_ID")) ? (dr["INFRA_HEAD_EMP_ID"] == DBNull.Value) ? "" : dr.Field<string>("INFRA_HEAD_EMP_ID") : "",
                    InfraHeadEmpName = (dr.Table.Columns.Contains("INFRA_HEAD_EMP_NAME")) ? (dr["INFRA_HEAD_EMP_NAME"] == DBNull.Value) ? "" : dr.Field<string>("INFRA_HEAD_EMP_NAME") : "",
                    InfraHeadEmpMail = (dr.Table.Columns.Contains("INFRA_HEAD_EMP_EMAIL")) ? (dr["INFRA_HEAD_EMP_EMAIL"] == DBNull.Value) ? "" : dr.Field<string>("INFRA_HEAD_EMP_EMAIL") : "",
                };
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
        }
        private static CreateNewOpportunity MapCheckInfraQualDLDetails2(DataRow dr)
        {
            try
            {
                return new CreateNewOpportunity()
                {
                    QualityHeadEmpId = (dr.Table.Columns.Contains("QUALITY_HEAD_EMP_ID")) ? (dr["QUALITY_HEAD_EMP_ID"] == DBNull.Value) ? "" : dr.Field<string>("QUALITY_HEAD_EMP_ID") : "",
                    QualityHeadEmpName = (dr.Table.Columns.Contains("QUALITY_HEAD_EMP_NAME")) ? (dr["QUALITY_HEAD_EMP_NAME"] == DBNull.Value) ? "" : dr.Field<string>("QUALITY_HEAD_EMP_NAME") : "",
                    QualityHeadEmpMail = (dr.Table.Columns.Contains("QUALITY_HEAD_EMP_EMAIL")) ? (dr["QUALITY_HEAD_EMP_EMAIL"] == DBNull.Value) ? "" : dr.Field<string>("QUALITY_HEAD_EMP_EMAIL") : "",
                };
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
        }
        private static CreateNewOpportunity MapCheckInfraQualDLDetails3(DataRow dr)
        {
            try
            {
                return new CreateNewOpportunity()
                {
                    HCLHeadEmpId = (dr.Table.Columns.Contains("HCL_HEAD_EMP_ID")) ? (dr["HCL_HEAD_EMP_ID"] == DBNull.Value) ? "" : dr.Field<string>("HCL_HEAD_EMP_ID") : "",
                    HCLHeadEmpName = (dr.Table.Columns.Contains("HCL_HEAD_EMP_NAME")) ? (dr["HCL_HEAD_EMP_NAME"] == DBNull.Value) ? "" : dr.Field<string>("HCL_HEAD_EMP_NAME") : "",
                    HCLHeadEmpMail = (dr.Table.Columns.Contains("HCL_HEAD_EMP_EMAIL")) ? (dr["HCL_HEAD_EMP_EMAIL"] == DBNull.Value) ? "" : dr.Field<string>("HCL_HEAD_EMP_EMAIL") : "",
                };
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
        }
        /// <summary>
        /// Get Competency BFS Details
        /// </summary>
        public List<CreateNewOpportunity> GetCompetencyBFS()
        {
            DataSet ds = null;
            List<CreateNewOpportunity> modelList = new List<CreateNewOpportunity>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.GetCompetencyBFS);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;

                        for (int i = 0; i < rowCount; i++)
                        {
                            modelList.Add(MapGetCompetencyBFS(ds.Tables[0].Rows[i]));
                        }

                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }
            return modelList;
        }
        private static CreateNewOpportunity MapGetCompetencyBFS(DataRow dr)
        {
            try
            {
                return new CreateNewOpportunity()
                {
                    COMPETENCY_ID = (dr.Table.Columns.Contains("COMPETENCY_ID")) ? (dr["COMPETENCY_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["COMPETENCY_ID"]) : 0,
                    CompetencyName = (dr.Table.Columns.Contains("COMPETENCY_NAME")) ? (dr["COMPETENCY_NAME"] == DBNull.Value) ? "" : dr.Field<string>("COMPETENCY_NAME") : "",
                };
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
        }
        /// <summary>
        /// Get Current Infra Stage Details
        /// </summary>
        public List<CreateNewOpportunity> GetCurrentInfraStage(string opportunityId)
        {
            DataSet ds = null;
            List<CreateNewOpportunity> modelList = new List<CreateNewOpportunity>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.GetCurrentInfraStage);
                db.AddInParameter(cd, "@iv_OpportunityID", SqlDbType.VarChar, opportunityId);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;

                        for (int i = 0; i < rowCount; i++)
                        {
                            modelList.Add(MapCurrentInfraStage(ds.Tables[0].Rows[i]));
                        }

                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }
            return modelList;
        }
        private static CreateNewOpportunity MapCurrentInfraStage(DataRow dr)
        {
            try
            {
                return new CreateNewOpportunity()
                {
                    StageID = (dr.Table.Columns.Contains("COMPETENCY_ID")) ? (dr["COMPETENCY_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["COMPETENCY_ID"]) : 0,
                };
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
        }
        /// <summary>
        /// Update SOL_TM_Details
        /// </summary>
        public void Update_SOL_TM_Details(string opportunityId, string userLogin)
        {

            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.UpdateSolTM);
                db.AddInParameter(cd, "@iv_OppID", SqlDbType.VarChar, opportunityId);
                db.AddInParameter(cd, "@iv_UserLogin", SqlDbType.VarChar, userLogin);
                db.AddOutParameter(cd, "@on_Result", SqlDbType.Int, Int16.MaxValue);
                DataSet ds = db.ExecuteDataSet(cd);

            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
        }
        /// <summary>
        /// Save SOL_TM_Details
        /// </summary>
        public void InsertSolTeamMmber(string opportunityId, int empId, string empName, int empAllocation, string userLogin)
        {

            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.InsertSolTeamMmber);
                db.AddInParameter(cd, "@iv_OppID", SqlDbType.VarChar, opportunityId);
                db.AddInParameter(cd, "@iv_EmpID", SqlDbType.Int, empId);
                db.AddInParameter(cd, "@iv_EmpName", SqlDbType.VarChar, empName);
                db.AddInParameter(cd, "@iv_EmpAllocation", SqlDbType.Int, empAllocation);
                db.AddInParameter(cd, "@iv_UserLogin", SqlDbType.VarChar, userLogin);
                db.AddOutParameter(cd, "@on_Result", SqlDbType.Int, Int16.MaxValue);
                DataSet ds = db.ExecuteDataSet(cd);

            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
        }
        /// <summary>
        /// Get ServiceData Details
        /// </summary>
        public List<CreateNewOpportunity> GetServiceData(string opportunityId)
        {
            DataSet ds = null;
            List<CreateNewOpportunity> modelList = new List<CreateNewOpportunity>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.GetServiceData);
                db.AddInParameter(cd, "@iv_id", SqlDbType.VarChar, opportunityId);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;

                        for (int i = 0; i < rowCount; i++)
                        {
                            modelList.Add(MapServiceData(ds.Tables[0].Rows[i]));
                        }

                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }
            return modelList;
        }
        private static CreateNewOpportunity MapServiceData(DataRow dr)
        {
            try
            {
                return new CreateNewOpportunity()
                {
                    Id = (dr.Table.Columns.Contains("ID")) ? (dr["ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["ID"]) : 0,
                    OpportunityId = (dr.Table.Columns.Contains("OPPORTUNITY_ID")) ? (dr["OPPORTUNITY_ID"] == DBNull.Value) ? "" : dr.Field<string>("OPPORTUNITY_ID") : "",
                    SERVICE_ID = (dr.Table.Columns.Contains("SERVICE_ID")) ? (dr["SERVICE_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["SERVICE_ID"]) : 0,
                    LEVEL1_ID = (dr.Table.Columns.Contains("LEVEL1_ID")) ? (dr["LEVEL1_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["LEVEL1_ID"]) : 0,
                    LEVEL2_ID = (dr.Table.Columns.Contains("LEVEL2_ID")) ? (dr["LEVEL2_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["LEVEL2_ID"]) : 0,
                    FTE = (dr.Table.Columns.Contains("FTE")) ? (dr["FTE"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["FTE"]) : 0,
                    SOLUTION_LEAD = (dr.Table.Columns.Contains("SOLUTION_LEAD")) ? (dr["SOLUTION_LEAD"] == DBNull.Value) ? "" : dr.Field<string>("SOLUTION_LEAD") : "",
                    TCV = (dr.Table.Columns.Contains("TCV")) ? (dr["TCV"] == DBNull.Value) ? "" : dr.Field<string>("TCV") : "",
                    FromDate = (dr.Table.Columns.Contains("FROM_DT")) ? (dr["FROM_DT"] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(dr.Field<DateTime>("FROM_DT")) : (DateTime?)null,
                    ToDate = (dr.Table.Columns.Contains("TO_DT")) ? (dr["TO_DT"] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(dr.Field<DateTime>("TO_DT")) : (DateTime?)null,
                    CREATED_BY = (dr.Table.Columns.Contains("CREATED_BY")) ? (dr["CREATED_BY"] == DBNull.Value) ? "" : dr.Field<string>("CREATED_BY") : "",
                    CreatedDate = (dr.Table.Columns.Contains("CREATED_DT")) ? (dr["CREATED_DT"] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(dr.Field<DateTime>("CREATED_DT")) : (DateTime?)null,
                    CHANGED_BY = (dr.Table.Columns.Contains("CHANGED_BY")) ? (dr["CHANGED_BY"] == DBNull.Value) ? "" : dr.Field<string>("CHANGED_BY") : "",
                    CHANGED_DT = (dr.Table.Columns.Contains("CHANGED_DT")) ? (dr["CHANGED_DT"] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(dr.Field<DateTime>("CHANGED_DT")) : (DateTime?)null,
                    UnitId = (dr.Table.Columns.Contains("UNIT_ID")) ? (dr["UNIT_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["UNIT_ID"]) : 0,
                };
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
        }
        /// <summary>
        /// Get VerticalDomainData Details
        /// </summary>
        public List<CreateNewOpportunity> GetVerticalDomainData(string opportunityId)
        {
            DataSet ds = null;
            List<CreateNewOpportunity> modelList = new List<CreateNewOpportunity>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.GetVerticalDomainData);
                db.AddInParameter(cd, "@iv_id", SqlDbType.VarChar, opportunityId);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;

                        for (int i = 0; i < rowCount; i++)
                        {
                            modelList.Add(MapVerticalDomainData(ds.Tables[0].Rows[i]));
                        }

                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }
            return modelList;
        }
        private static CreateNewOpportunity MapVerticalDomainData(DataRow dr)
        {
            try
            {
                return new CreateNewOpportunity()
                {
                    Id = (dr.Table.Columns.Contains("ID")) ? (dr["ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["ID"]) : 0,
                    OpportunityId = (dr.Table.Columns.Contains("OPPORTUNITY_ID")) ? (dr["OPPORTUNITY_ID"] == DBNull.Value) ? "" : dr.Field<string>("OPPORTUNITY_ID") : "",
                    BUSINESS_ID = (dr.Table.Columns.Contains("BUSINESS_ID")) ? (dr["BUSINESS_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["BUSINESS_ID"]) : 0,
                    LEVEL1_ID = (dr.Table.Columns.Contains("LEVEL1_ID")) ? (dr["LEVEL1_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["LEVEL1_ID"]) : 0,
                    LEVEL2_ID = (dr.Table.Columns.Contains("LEVEL2_ID")) ? (dr["LEVEL2_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["LEVEL2_ID"]) : 0,
                    FTE = (dr.Table.Columns.Contains("FTE")) ? (dr["FTE"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["FTE"]) : 0,
                    SOLUTION_LEAD = (dr.Table.Columns.Contains("SOLUTION_LEAD")) ? (dr["SOLUTION_LEAD"] == DBNull.Value) ? "" : dr.Field<string>("SOLUTION_LEAD") : "",
                    TCV = (dr.Table.Columns.Contains("TCV")) ? (dr["TCV"] == DBNull.Value) ? "" : dr.Field<string>("TCV") : "",
                    FromDate = (dr.Table.Columns.Contains("FROM_DT")) ? (dr["FROM_DT"] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(dr.Field<DateTime>("FROM_DT")) : (DateTime?)null,
                    ToDate = (dr.Table.Columns.Contains("TO_DT")) ? (dr["TO_DT"] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(dr.Field<DateTime>("TO_DT")) : (DateTime?)null,
                    CREATED_BY = (dr.Table.Columns.Contains("CREATED_BY")) ? (dr["CREATED_BY"] == DBNull.Value) ? "" : dr.Field<string>("CREATED_BY") : "",
                    CreatedDate = (dr.Table.Columns.Contains("CREATED_DT")) ? (dr["CREATED_DT"] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(dr.Field<DateTime>("CREATED_DT")) : (DateTime?)null,
                    CHANGED_BY = (dr.Table.Columns.Contains("CHANGED_BY")) ? (dr["CHANGED_BY"] == DBNull.Value) ? "" : dr.Field<string>("CHANGED_BY") : "",
                    CHANGED_DT = (dr.Table.Columns.Contains("CHANGED_DT")) ? (dr["CHANGED_DT"] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(dr.Field<DateTime>("CHANGED_DT")) : (DateTime?)null,
                    UnitId = (dr.Table.Columns.Contains("UNIT_ID")) ? (dr["UNIT_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["UNIT_ID"]) : 0,
                };
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
        }
         /// <summary>
         /// Get PricingType Details
         /// </summary>

        public List<PricingType> GetPricingType()
        {
            DataSet ds = null;
            //List<CreateNewOpportunity> modelList = new List<CreateNewOpportunity>();
            List<PricingType> modelList = new List<PricingType>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.GetPricingType);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;

                        for (int i = 0; i < rowCount; i++)
                        {
                            modelList.Add(MapPricingType(ds.Tables[0].Rows[i]));
                        }

                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }
            return modelList;
        }

       
        private static PricingType MapPricingType(DataRow dr)
        {
            try
            {
                return new PricingType()
                {
                    PRICING_TYPE_ID = (dr.Table.Columns.Contains("PRICING_TYPE_ID")) ? (dr["PRICING_TYPE_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["PRICING_TYPE_ID"]) : 0,
                    PRICING_TYPE_NAME = (dr.Table.Columns.Contains("PRICING_TYPE_NAME")) ? (dr["PRICING_TYPE_NAME"] == DBNull.Value) ? "" : dr.Field<string>("PRICING_TYPE_NAME") : "",
                };
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<OfferingType> GetOfferingType()
        {
            DataSet ds = null;
            List<OfferingType> modelList = new List<OfferingType>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Get_Offering_Types);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;

                        for (int i = 0; i < rowCount; i++)
                        {
                            modelList.Add(MapOfferingType(ds.Tables[0].Rows[i]));
                        }

                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }
            return modelList;
        }

        private static OfferingType MapOfferingType(DataRow dr)
        {
            try
            {
                return new OfferingType()
                {
                    offeringType = (dr.Table.Columns.Contains("id")) ? (dr["id"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["id"]) : 0,
                    offeringTypeName = (dr.Table.Columns.Contains("name")) ? (dr["name"] == DBNull.Value) ? "" : dr.Field<string>("name") : "",
                };
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
        }
        /// <summary>
        /// Get Business Details
        /// </summary>
        public List<OpportunityUnitID> GetBusiness()
        {
            DataSet ds = null;
            List<OpportunityUnitID> modelList = new List<OpportunityUnitID>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.GetBusiness);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;

                        for (int i = 0; i < rowCount; i++)
                        {
                            modelList.Add(MapPopulate_cmb_Business_BFS1(ds.Tables[0].Rows[i]));
                        }

                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }
            return modelList;
        }

        /// <summary>
        /// Get Business Type Details
        /// </summary>
        public List<BusinessBFS> Get_BusinessType()
        {
            DataSet ds = null;
            List<BusinessBFS> modelList = new List<BusinessBFS>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Get_BussType);

                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;

                        for (int i = 0; i < rowCount; i++)
                        {
                            modelList.Add(MapGet_BusinessType(ds.Tables[0].Rows[i]));
                        }

                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }
            return modelList;
        }
        private static BusinessBFS MapGet_BusinessType(DataRow dr)
        {
            try
            {
                return new BusinessBFS()
                {

                    BUSINESS_TYPE_ID = (dr.Table.Columns.Contains("BUSINESS_TYPE_ID")) ? (dr["BUSINESS_TYPE_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["BUSINESS_TYPE_ID"]) : 0,

                    BUSINESS_TYPE_NAME = (dr.Table.Columns.Contains("BUSINESS_TYPE_NAME")) ? (dr["BUSINESS_TYPE_NAME"] == DBNull.Value) ? "" : dr.Field<string>("BUSINESS_TYPE_NAME") : "",

                };
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
        }
        /// <summary>
        /// Get Stage3 Details
        /// </summary>
        public List<CreateNewOpportunity> Getstage3(string strOpportunityId, string strStageId)
        {
            DataSet ds = null;
            List<CreateNewOpportunity> modelList = new List<CreateNewOpportunity>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.GetOpportunity_Stage3_sp);
                db.AddInParameter(cd, "@in_OpportunityId", SqlDbType.VarChar, strOpportunityId);
                db.AddInParameter(cd, "@in_StageId", SqlDbType.Int, strStageId);

                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;

                        for (int i = 0; i < rowCount; i++)
                        {
                            modelList.Add(Objstage3(ds.Tables[0].Rows[i]));
                        }

                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }
            return modelList;
        }





        private static CreateNewOpportunity Objstage3(DataRow dr)
        {
            try
            {
                return new CreateNewOpportunity()
                {

                    OpportunityId = (dr.Table.Columns.Contains("OPPORTUNITY_ID")) ? (dr["OPPORTUNITY_ID"] == DBNull.Value) ? "" : Convert.ToString(dr["OPPORTUNITY_ID"]) : "",
                    OPPORTUNITY_DESC = (dr.Table.Columns.Contains("OPPORTUNITY_DESC")) ? (dr["OPPORTUNITY_DESC"] == DBNull.Value) ? "" : dr.Field<string>("OPPORTUNITY_DESC") : "",
                    OLD_OPPORTUNITY_DESC = (dr.Table.Columns.Contains("OLD_OPPORTUNITY_DESC")) ? (dr["OLD_OPPORTUNITY_DESC"] == DBNull.Value) ? "" : dr.Field<string>("OLD_OPPORTUNITY_DESC") : "",
                    GEOGRAPHY_ID = (dr.Table.Columns.Contains("GEOGRAPHY_ID")) ? (dr["GEOGRAPHY_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["GEOGRAPHY_ID"]) : 0,
                    GEOGRAPHY_NAME = (dr.Table.Columns.Contains("GEOGRAPHY_NAME")) ? (dr["GEOGRAPHY_NAME"] == DBNull.Value) ? "" : dr.Field<string>("GEOGRAPHY_NAME") : "",
                    CUST_ID = (dr.Table.Columns.Contains("CUST_ID")) ? (dr["CUST_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CUST_ID"]) : 0,
                    CUST_NAME = (dr.Table.Columns.Contains("CUST_NAME")) ? (dr["CUST_NAME"] == DBNull.Value) ? "" : dr.Field<string>("CUST_NAME") : "",
                    CUST_TYPE_ID = (dr.Table.Columns.Contains("CUST_TYPE_ID")) ? (dr["CUST_TYPE_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CUST_TYPE_ID"]) : 0,
                    CUST_TYPE_NAME = (dr.Table.Columns.Contains("CUST_TYPE_NAME")) ? (dr["CUST_TYPE_NAME"] == DBNull.Value) ? "" : dr.Field<string>("CUST_TYPE_NAME") : "",
                    INDUSTRY_PRACTICE_ID = (dr.Table.Columns.Contains("INDUSTRY_PRACTICE_ID")) ? (dr["INDUSTRY_PRACTICE_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["INDUSTRY_PRACTICE_ID"]) : 0,
                    StageID = (dr.Table.Columns.Contains("STAGE_ID")) ? (dr["STAGE_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["STAGE_ID"]) : 0,
                    INDUSTRY_PRACTICE_NAME = (dr.Table.Columns.Contains("INDUSTRY_PRACTICE_NAME")) ? (dr["INDUSTRY_PRACTICE_NAME"] == DBNull.Value) ? "" : dr.Field<string>("INDUSTRY_PRACTICE_NAME") : "",
                    STAGE_NAME = (dr.Table.Columns.Contains("STAGE_NAME")) ? (dr["STAGE_NAME"] == DBNull.Value) ? "" : dr.Field<string>("STAGE_NAME") : "",
                    ISU_CD = (dr.Table.Columns.Contains("ISU_CD")) ? (dr["ISU_CD"] == DBNull.Value) ? "" : dr.Field<string>("ISU_CD") : "",
                    ISU_NAME = (dr.Table.Columns.Contains("ISU_NAME")) ? (dr["ISU_NAME"] == DBNull.Value) ? "" : dr.Field<string>("ISU_NAME") : "",
                    GEOGRAPHY_SALES_OWNER = (dr.Table.Columns.Contains("GEOGRAPHY_SALES_OWNER_ID")) ? (dr["GEOGRAPHY_SALES_OWNER_ID"] == DBNull.Value) ? "" : dr.Field<string>("GEOGRAPHY_SALES_OWNER_ID") : "",
                    ONSITE_OWNER = (dr.Table.Columns.Contains("ONSITE_OWNER_ID")) ? (dr["ONSITE_OWNER_ID"] == DBNull.Value) ? "" : dr.Field<string>("ONSITE_OWNER_ID") : "",
                    OFFSHORE_BD_LEAD = (dr.Table.Columns.Contains("OFFSHORE_BD_LEAD_ID")) ? (dr["OFFSHORE_BD_LEAD_ID"] == DBNull.Value) ? "" : dr.Field<string>("OFFSHORE_BD_LEAD_ID") : "",
                    OPPORTUNITY_DATE = (dr.Table.Columns.Contains("OPPORTUNITY_DATE")) ? (dr["OPPORTUNITY_DATE"] == DBNull.Value) ? "" : dr.Field<string>("OPPORTUNITY_DATE") : "",
                    DEAL_CLOSURE_EXP_DATE = (dr.Table.Columns.Contains("DEAL_CLOSURE_EXP_DATE")) ? (dr["DEAL_CLOSURE_EXP_DATE"] == DBNull.Value) ? "" : dr.Field<string>("DEAL_CLOSURE_EXP_DATE") : "",
                    DTOTAL_CONTRACT_VALUE = (dr.Table.Columns.Contains("TOTAL_CONTRACT_VALUE")) ? (dr["TOTAL_CONTRACT_VALUE"] == DBNull.Value) ? 0 : Convert.ToDouble(dr["TOTAL_CONTRACT_VALUE"]) : 0,
                    BUSINESS_ID = (dr.Table.Columns.Contains("BUSINESS_ID")) ? (dr["BUSINESS_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["BUSINESS_ID"]) : 0,
                    COUNTRY_ID = (dr.Table.Columns.Contains("COUNTRY_ID")) ? (dr["COUNTRY_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["COUNTRY_ID"]) : 0,
                    PIBS = (dr.Table.Columns.Contains("PIBS")) ? (dr["PIBS"] == DBNull.Value) ? "" : dr.Field<string>("PIBS") : "",
                    CRM_ID = (dr.Table.Columns.Contains("CRM_ID")) ? (dr["CRM_ID"] == DBNull.Value) ? "" : dr.Field<string>("CRM_ID") : "",
                    VALUE_BPS = (dr.Table.Columns.Contains("VALUE_BPS")) ? (dr["VALUE_BPS"] == DBNull.Value) ? "" : dr.Field<string>("VALUE_BPS") : "",
                    VALUE_BPS_TCV = (dr.Table.Columns.Contains("VALUE_BPS_TCV")) ? (dr["VALUE_BPS_TCV"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["VALUE_BPS_TCV"]) : 0,
                    OPP_TYPE = (dr.Table.Columns.Contains("OPP_TYPE")) ? (dr["OPP_TYPE"] == DBNull.Value) ? "" : dr.Field<string>("OPP_TYPE") : "",
                    IESTIMATED_FTE_SIZE = (dr.Table.Columns.Contains("ESTIMATED_FTE_SIZE")) ? (dr["ESTIMATED_FTE_SIZE"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["ESTIMATED_FTE_SIZE"]) : 0,
                    ContractLength = (dr.Table.Columns.Contains("CONTRACT_LENGTH")) ? (dr["CONTRACT_LENGTH"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CONTRACT_LENGTH"]) : 0,
                    ISU_OWNER_ID = (dr.Table.Columns.Contains("ISU_OWNER_ID")) ? (dr["ISU_OWNER_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["ISU_OWNER_ID"]) : 0,
                    ACCOUNT_SALES_OWNER_ID = (dr.Table.Columns.Contains("ACCOUNT_SALES_OWNER_ID")) ? (dr["ACCOUNT_SALES_OWNER_ID"] == DBNull.Value) ? "" : dr.Field<string>("ACCOUNT_SALES_OWNER_ID") : "",
                    GEOGRAPHY_SALES_OWNER_ID = (dr.Table.Columns.Contains("GEOGRAPHY_SALES_OWNER_ID")) ? (dr["GEOGRAPHY_SALES_OWNER_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["GEOGRAPHY_SALES_OWNER_ID"]) : 0,
                    OFFSHORE_BD_LEAD_ID = (dr.Table.Columns.Contains("OFFSHORE_BD_LEAD_ID")) ? (dr["OFFSHORE_BD_LEAD_ID"] == DBNull.Value) ? "" : dr.Field<string>("OFFSHORE_BD_LEAD_ID") : "",
                    LAST_UPDATE = (dr.Table.Columns.Contains("LAST_UPDATE")) ? (dr["LAST_UPDATE"] == DBNull.Value) ? "" : dr.Field<string>("LAST_UPDATE") : "",
                    DEAL_BD_LEAD_ID = (dr.Table.Columns.Contains("DEAL_BD_LEAD_ID")) ? (dr["DEAL_BD_LEAD_ID"] == DBNull.Value) ? "" : dr.Field<string>("DEAL_BD_LEAD_ID") : "",
                    DEAL_BD_LEAD_ID2 = (dr.Table.Columns.Contains("DEAL_BD_LEAD_ID2")) ? (dr["DEAL_BD_LEAD_ID2"] == DBNull.Value) ? "" : dr.Field<string>("DEAL_BD_LEAD_ID2") : "",
                    ClusterId = (dr.Table.Columns.Contains("CLUSTER_ID")) ? (dr["CLUSTER_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CLUSTER_ID"]) : 0,
                    DealCategory = (dr.Table.Columns.Contains("DEAL_CATEGORY")) ? (dr["DEAL_CATEGORY"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["DEAL_CATEGORY"]) : 0,
                    BPS_OFFERING_ID = (dr.Table.Columns.Contains("BPS_OFFERING_ID")) ? (dr["BPS_OFFERING_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["BPS_OFFERING_ID"]) : 0,
                    SERVICE_ID = (dr.Table.Columns.Contains("SERVICE_ID")) ? (dr["SERVICE_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["SERVICE_ID"]) : 0,
                    SUB_IOU = (dr.Table.Columns.Contains("SUB_IOU")) ? (dr["SUB_IOU"] == DBNull.Value) ? "" : dr.Field<string>("SUB_IOU") : "",
                    EXECUTIVE_SPONSOR = (dr.Table.Columns.Contains("EXECUTIVE_SPONSOR")) ? (dr["EXECUTIVE_SPONSOR"] == DBNull.Value) ? "" : dr.Field<string>("EXECUTIVE_SPONSOR") : "",
                    VALBPS_CON = (dr.Table.Columns.Contains("VALBPS_CON")) ? (dr["VALBPS_CON"] == DBNull.Value) ? "" : dr.Field<string>("VALBPS_CON") : "",
                    PROACTIVE_PROPOSAL = (dr.Table.Columns.Contains("PROACTIVE_PROPOSAL")) ? (dr["PROACTIVE_PROPOSAL"] == DBNull.Value) ? "" : dr.Field<string>("PROACTIVE_PROPOSAL") : "",
                    ISU_MAIN = (dr.Table.Columns.Contains("ISU_MAIN")) ? (dr["ISU_MAIN"] == DBNull.Value) ? "" : dr.Field<string>("ISU_MAIN") : "",
                    Quarter = (dr.Table.Columns.Contains("quarter")) ? (dr["quarter"] == DBNull.Value) ? "" : dr.Field<string>("quarter") : "",
                    FISCAL_YEAR = (dr.Table.Columns.Contains("FISCAL_YEAR")) ? (dr["FISCAL_YEAR"] == DBNull.Value) ? "" : dr.Field<string>("FISCAL_YEAR") : "",
                    PROPOSAL_FACTORY = (dr.Table.Columns.Contains("PROPOSAL_FACTORY")) ? (dr["PROPOSAL_FACTORY"] == DBNull.Value) ? "" : dr.Field<string>("PROPOSAL_FACTORY") : "",
                    PROPOSAL_FACTORY_OPTIONS = (dr.Table.Columns.Contains("PROPOSAL_FACTORY_OPTIONS")) ? (dr["PROPOSAL_FACTORY_OPTIONS"] == DBNull.Value) ? "" : dr.Field<string>("PROPOSAL_FACTORY_OPTIONS") : "",
                    PROPOSAL_FACTORY_COMMENTS = (dr.Table.Columns.Contains("PROPOSAL_FACTORY_COMMENTS")) ? (dr["PROPOSAL_FACTORY_COMMENTS"] == DBNull.Value) ? "" : dr.Field<string>("PROPOSAL_FACTORY_COMMENTS") : "",
                    DT_ID = (dr.Table.Columns.Contains("DT_ID")) ? (dr["DT_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["DT_ID"]) : 0,
                    Other_DT = (dr.Table.Columns.Contains("Other_DT")) ? (dr["Other_DT"] == DBNull.Value) ? "" : dr.Field<string>("Other_DT") : "",
                    RFI_REVIEW_BY = (dr.Table.Columns.Contains("RFI_REVIEW_BY")) ? (dr["RFI_REVIEW_BY"] == DBNull.Value) ? "" : dr.Field<string>("RFI_REVIEW_BY") : "",
                    RFI_ReviewDate = (dr.Table.Columns.Contains("RFI_REVIEW_DT")) ? (dr["RFI_REVIEW_DT"] == DBNull.Value) ? "" : dr.Field<string>("RFI_REVIEW_DT") : "",
                    CRM_TCV = (dr.Table.Columns.Contains("CRM_TCV")) ? (dr["CRM_TCV"] == DBNull.Value) ? "" : Convert.ToString(dr["CRM_TCV"]) : "",
                    CRM_STAGE = (dr.Table.Columns.Contains("CRM_STAGE")) ? (dr["CRM_STAGE"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CRM_STAGE"]) : 0,
                    strDigitalTcv = (dr.Table.Columns.Contains("Digital_TCV")) ? (dr["Digital_TCV"] == DBNull.Value) ? "" : dr.Field<string>("Digital_TCV") : "",

                    subSPId = (dr.Table.Columns.Contains("SubSPID")) ? (dr["SubSPID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["SubSPID"]) : 0,
                    CRM_Beacon = (dr.Table.Columns.Contains("CRM_Beacon")) ? (dr["CRM_Beacon"] == DBNull.Value) ? "" : Convert.ToString(dr["CRM_Beacon"]) : "",


                    TataGroupAccount = (dr.Table.Columns.Contains("TATA_GROUP_ACCOUNT")) ? (dr["TATA_GROUP_ACCOUNT"] == DBNull.Value) ? "" : Convert.ToString(dr["TATA_GROUP_ACCOUNT"]) : "",
                    ItisScope = (dr.Table.Columns.Contains("ItisScope")) ? (dr["ItisScope"] == DBNull.Value) ? "" : Convert.ToString(dr["ItisScope"]) : "",
                    IsContractRenewal = (dr.Table.Columns.Contains("IsContractRenewal")) ? (dr["IsContractRenewal"] == DBNull.Value) ? "" : Convert.ToString(dr["IsContractRenewal"]) : "",
                    ContractRenewalValue = (dr.Table.Columns.Contains("ContractRenewalValue")) ? (dr["ContractRenewalValue"] == DBNull.Value) ? "" : Convert.ToString(dr["ContractRenewalValue"]) : "",
                    //changess
                    RESOURCING_ID = (dr.Table.Columns.Contains("ResourcingId")) ? (dr["ResourcingId"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["ResourcingId"]) : 0,
                    SEAT_IDENTIFICATION_ID = (dr.Table.Columns.Contains("Seat_IdentificationId")) ? (dr["Seat_IdentificationId"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["Seat_IdentificationId"]) : 0,
                    //End
                    MULTITOWER_DEAL = (dr.Table.Columns.Contains("MULTITOWER_DEAL")) ? (dr["MULTITOWER_DEAL"] == DBNull.Value) ? "" : dr.Field<string>("MULTITOWER_DEAL") : "",
                    DealStatus = (dr.Table.Columns.Contains("DealStatus_Id")) ? (dr["DealStatus_Id"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["DealStatus_Id"]) : 0,
                    ServicePractice = (dr.Table.Columns.Contains("ServicePractice_Id")) ? (dr["ServicePractice_Id"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["ServicePractice_Id"]) : 0,
                    CoreOffering = (dr.Table.Columns.Contains("CoreOffering_Id")) ? (dr["CoreOffering_Id"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CoreOffering_Id"]) : 0,
                    OpportunityDescDetails = (dr.Table.Columns.Contains("Opportunity_Desc_Details")) ? (dr["Opportunity_Desc_Details"] == DBNull.Value) ? "" : dr.Field<string>("Opportunity_Desc_Details") : "",

                    PROPOSAL_SUBMISSION_DATE = (dr.Table.Columns.Contains("PROPOSAL_SUBMISSION_DATE")) ? (dr["PROPOSAL_SUBMISSION_DATE"] == DBNull.Value) ? "" : dr.Field<string>("PROPOSAL_SUBMISSION_DATE") : "",
                    SALES_STAGE_MOVED_ONDATE = (dr.Table.Columns.Contains("SALES_STAGE_MOVED_ON_DATE")) ? (dr["SALES_STAGE_MOVED_ON_DATE"] == DBNull.Value) ? "" : dr.Field<string>("SALES_STAGE_MOVED_ON_DATE") : "",

                    Previous_Deal_Stage = (dr.Table.Columns.Contains("Previous_Deal_Stage")) ? (dr["Previous_Deal_Stage"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["Previous_Deal_Stage"]) : 0,

                    DELIVERY_LOCATION_PROPOSED = (dr.Table.Columns.Contains("DELIVERY_LOCATION_PROPOSED")) ? (dr["DELIVERY_LOCATION_PROPOSED"] == DBNull.Value) ? "" : dr.Field<string>("DELIVERY_LOCATION_PROPOSED") : "",
                    DigitalFlagging = (dr.Table.Columns.Contains("Digital_Flagging")) ? (dr["Digital_Flagging"] == DBNull.Value) ? "" : Convert.ToString(dr["Digital_Flagging"]) : "",
                    offeringType = (dr.Table.Columns.Contains("OfferingType_Id")) ? (dr["OfferingType_Id"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["OfferingType_Id"]) : 0,
                    offeringTypeName = (dr.Table.Columns.Contains("offeringTypeName")) ? (dr["offeringTypeName"] == DBNull.Value) ? "" : dr.Field<string>("offeringTypeName") : "",
                    CofID = (dr.Table.Columns.Contains("CoreOfferingName_Id")) ? (dr["CoreOfferingName_Id"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CoreOfferingName_Id"]) : 0,
                    Cboi_Offering_id = (dr.Table.Columns.Contains("cboi_offering_id")) ? (dr["cboi_offering_id"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["cboi_offering_id"]) : 0,
                    Deal_Flag_id = (dr.Table.Columns.Contains("deal_flag")) ? (dr["deal_flag"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["deal_flag"]) : 0,
                    PLATFORM = (dr.Table.Columns.Contains("PLATFORM")) ? (dr["PLATFORM"] == DBNull.Value) ? "" : dr.Field<string>("PLATFORM") : "",
                    PLATFORM_OPTION = (dr.Table.Columns.Contains("PLATFORM_OPTION")) ? (dr["PLATFORM_OPTION"] == DBNull.Value) ? "" : dr.Field<string>("PLATFORM_OPTION") : "",



                };
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
        }
        /// <summary>
        /// Get Stage4 Details
        /// </summary>
        public List<CreateNewOpportunity> Getstage4(string OpportunityId, string strStageId)
        {
            DataSet ds = null;
            char a;
            int b = 100;
            a = 100.ToString()[0];
            List<CreateNewOpportunity> modelList = new List<CreateNewOpportunity>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.GetOpportunity_Stage4_sp);
                db.AddInParameter(cd, "@in_OpportunityId", SqlDbType.VarChar, OpportunityId);
                db.AddInParameter(cd, "@in_StageId", SqlDbType.Int, strStageId);

                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;

                        for (int i = 0; i < rowCount; i++)
                        {
                            modelList.Add(Objstage4(ds.Tables[0].Rows[i]));
                        }

                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }
            return modelList;
        }

        private static CreateNewOpportunity Objstage4(DataRow dr)
        {
            try
            {
                return new CreateNewOpportunity()
                {
                    OpportunityId = (dr.Table.Columns.Contains("OPPORTUNITY_ID")) ? (dr["OPPORTUNITY_ID"] == DBNull.Value) ? "" : Convert.ToString(dr["OPPORTUNITY_ID"]) : "",
                    OPPORTUNITY_DESC = (dr.Table.Columns.Contains("OPPORTUNITY_DESC")) ? (dr["OPPORTUNITY_DESC"] == DBNull.Value) ? "" : dr.Field<string>("OPPORTUNITY_DESC") : "",
                    OLD_OPPORTUNITY_DESC = (dr.Table.Columns.Contains("OLD_OPPORTUNITY_DESC")) ? (dr["OLD_OPPORTUNITY_DESC"] == DBNull.Value) ? "" : dr.Field<string>("OLD_OPPORTUNITY_DESC") : "",
                    GEOGRAPHY_ID = (dr.Table.Columns.Contains("GEOGRAPHY_ID")) ? (dr["GEOGRAPHY_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["GEOGRAPHY_ID"]) : 0,
                    GEOGRAPHY_NAME = (dr.Table.Columns.Contains("GEOGRAPHY_NAME")) ? (dr["GEOGRAPHY_NAME"] == DBNull.Value) ? "" : dr.Field<string>("GEOGRAPHY_NAME") : "",
                    CUST_ID = (dr.Table.Columns.Contains("CUST_ID")) ? (dr["CUST_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CUST_ID"]) : 0,
                    CUST_NAME = (dr.Table.Columns.Contains("CUST_NAME")) ? (dr["CUST_NAME"] == DBNull.Value) ? "" : dr.Field<string>("CUST_NAME") : "",
                    CUST_TYPE_ID = (dr.Table.Columns.Contains("CUST_TYPE_ID")) ? (dr["CUST_TYPE_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CUST_TYPE_ID"]) : 0,
                    CUST_TYPE_NAME = (dr.Table.Columns.Contains("CUST_TYPE_NAME")) ? (dr["CUST_TYPE_NAME"] == DBNull.Value) ? "" : dr.Field<string>("CUST_TYPE_NAME") : "",
                    INDUSTRY_PRACTICE_ID = (dr.Table.Columns.Contains("INDUSTRY_PRACTICE_ID")) ? (dr["INDUSTRY_PRACTICE_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["INDUSTRY_PRACTICE_ID"]) : 0,
                    StageID = (dr.Table.Columns.Contains("STAGE_ID")) ? (dr["STAGE_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["STAGE_ID"]) : 0,
                    INDUSTRY_PRACTICE_NAME = (dr.Table.Columns.Contains("INDUSTRY_PRACTICE_NAME")) ? (dr["INDUSTRY_PRACTICE_NAME"] == DBNull.Value) ? "" : dr.Field<string>("INDUSTRY_PRACTICE_NAME") : "",
                    STAGE_NAME = (dr.Table.Columns.Contains("STAGE_NAME")) ? (dr["STAGE_NAME"] == DBNull.Value) ? "" : dr.Field<string>("STAGE_NAME") : "",
                    ISU_CD = (dr.Table.Columns.Contains("ISU_CD")) ? (dr["ISU_CD"] == DBNull.Value) ? "" : dr.Field<string>("ISU_CD") : "",
                    ISU_NAME = (dr.Table.Columns.Contains("ISU_NAME")) ? (dr["ISU_NAME"] == DBNull.Value) ? "" : dr.Field<string>("ISU_NAME") : "",
                    GEOGRAPHY_SALES_OWNER = (dr.Table.Columns.Contains("GEOGRAPHY_SALES_OWNER_ID")) ? (dr["GEOGRAPHY_SALES_OWNER_ID"] == DBNull.Value) ? "" : dr.Field<string>("GEOGRAPHY_SALES_OWNER_ID") : "",
                    ONSITE_OWNER = (dr.Table.Columns.Contains("ONSITE_OWNER_ID")) ? (dr["ONSITE_OWNER_ID"] == DBNull.Value) ? "" : dr.Field<string>("ONSITE_OWNER_ID") : "",
                    OFFSHORE_BD_LEAD = (dr.Table.Columns.Contains("OFFSHORE_BD_LEAD_ID")) ? (dr["OFFSHORE_BD_LEAD_ID"] == DBNull.Value) ? "" : dr.Field<string>("OFFSHORE_BD_LEAD_ID") : "",
                    OPPORTUNITY_DATE = (dr.Table.Columns.Contains("OPPORTUNITY_DATE")) ? (dr["OPPORTUNITY_DATE"] == DBNull.Value) ? "" : dr.Field<string>("OPPORTUNITY_DATE") : "",
                    DEAL_CLOSURE_EXP_DATE = (dr.Table.Columns.Contains("DEAL_CLOSURE_EXP_DATE")) ? (dr["DEAL_CLOSURE_EXP_DATE"] == DBNull.Value) ? "" : dr.Field<string>("DEAL_CLOSURE_EXP_DATE") : "",
                    DTOTAL_CONTRACT_VALUE = (dr.Table.Columns.Contains("TOTAL_CONTRACT_VALUE")) ? (dr["TOTAL_CONTRACT_VALUE"] == DBNull.Value) ? 0 : Convert.ToDouble(dr["TOTAL_CONTRACT_VALUE"]) : 0,
                    BUSINESS_ID = (dr.Table.Columns.Contains("BUSINESS_ID")) ? (dr["BUSINESS_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["BUSINESS_ID"]) : 0,
                    COUNTRY_ID = (dr.Table.Columns.Contains("COUNTRY_ID")) ? (dr["COUNTRY_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["COUNTRY_ID"]) : 0,
                    PIBS = (dr.Table.Columns.Contains("PIBS")) ? (dr["PIBS"] == DBNull.Value) ? "" : dr.Field<string>("PIBS") : "",
                    CRM_ID = (dr.Table.Columns.Contains("CRM_ID")) ? (dr["CRM_ID"] == DBNull.Value) ? "" : dr.Field<string>("CRM_ID") : "",
                    VALUE_BPS = (dr.Table.Columns.Contains("VALUE_BPS")) ? (dr["VALUE_BPS"] == DBNull.Value) ? "" : dr.Field<string>("VALUE_BPS") : "",
                    VALUE_BPS_TCV = (dr.Table.Columns.Contains("VALUE_BPS_TCV")) ? (dr["VALUE_BPS_TCV"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["VALUE_BPS_TCV"]) : 0,
                    OPP_TYPE = (dr.Table.Columns.Contains("OPP_TYPE")) ? (dr["OPP_TYPE"] == DBNull.Value) ? "" : dr.Field<string>("OPP_TYPE") : "",
                    IESTIMATED_FTE_SIZE = (dr.Table.Columns.Contains("ESTIMATED_FTE_SIZE")) ? (dr["ESTIMATED_FTE_SIZE"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["ESTIMATED_FTE_SIZE"]) : 0,
                    ContractLength = (dr.Table.Columns.Contains("CONTRACT_LENGTH")) ? (dr["CONTRACT_LENGTH"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CONTRACT_LENGTH"]) : 0,
                    ISU_OWNER_ID = (dr.Table.Columns.Contains("ISU_OWNER_ID")) ? (dr["ISU_OWNER_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["ISU_OWNER_ID"]) : 0,
                    ACCOUNT_SALES_OWNER_ID = (dr.Table.Columns.Contains("ACCOUNT_SALES_OWNER_ID")) ? (dr["ACCOUNT_SALES_OWNER_ID"] == DBNull.Value) ? "" : dr.Field<string>("ACCOUNT_SALES_OWNER_ID") : "",
                    GEOGRAPHY_SALES_OWNER_ID = (dr.Table.Columns.Contains("GEOGRAPHY_SALES_OWNER_ID")) ? (dr["GEOGRAPHY_SALES_OWNER_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["GEOGRAPHY_SALES_OWNER_ID"]) : 0,
                    OFFSHORE_BD_LEAD_ID = (dr.Table.Columns.Contains("OFFSHORE_BD_LEAD_ID")) ? (dr["OFFSHORE_BD_LEAD_ID"] == DBNull.Value) ? "" : dr.Field<string>("OFFSHORE_BD_LEAD_ID") : "",
                    LAST_UPDATE = (dr.Table.Columns.Contains("LAST_UPDATE")) ? (dr["LAST_UPDATE"] == DBNull.Value) ? "" : dr.Field<string>("LAST_UPDATE") : "",
                    DEAL_BD_LEAD_ID = (dr.Table.Columns.Contains("DEAL_BD_LEAD_ID")) ? (dr["DEAL_BD_LEAD_ID"] == DBNull.Value) ? "" : dr.Field<string>("DEAL_BD_LEAD_ID") : "",
                    DEAL_BD_LEAD_ID2 = (dr.Table.Columns.Contains("DEAL_BD_LEAD_ID2")) ? (dr["DEAL_BD_LEAD_ID2"] == DBNull.Value) ? "" : dr.Field<string>("DEAL_BD_LEAD_ID2") : "",
                    RFI_ReviewDate = (dr.Table.Columns.Contains("RFI_REVIEW_DT")) ? (dr["RFI_REVIEW_DT"] == DBNull.Value) ? "" : dr.Field<string>("RFI_REVIEW_DT") : "",
                    RFP_ReviewDate = (dr.Table.Columns.Contains("RFP_REVIEW_DT")) ? (dr["RFP_REVIEW_DT"] == DBNull.Value) ? "" : dr.Field<string>("RFP_REVIEW_DT") : "",
                    RFI_ReceivedDate = (dr.Table.Columns.Contains("RFI_RECEIVED_DT")) ? (dr["RFI_RECEIVED_DT"] == DBNull.Value) ? "" : dr.Field<string>("RFI_RECEIVED_DT") : "",
                    RFP_ReceivedDate = (dr.Table.Columns.Contains("RFP_RECEIVED_DT")) ? (dr["RFP_RECEIVED_DT"] == DBNull.Value) ? "" : dr.Field<string>("RFP_RECEIVED_DT") : "",
                    RFI_ProbableSubmissionDate = (dr.Table.Columns.Contains("RFI_PROBABLE_SUBMISSION_DT")) ? (dr["RFI_PROBABLE_SUBMISSION_DT"] == DBNull.Value) ? "" : dr.Field<string>("RFI_PROBABLE_SUBMISSION_DT") : "",
                    RFP_ProbableSubmissionDate = (dr.Table.Columns.Contains("RFP_PROBABLE_SUBMISSION_DT")) ? (dr["RFI_PROBABLE_SUBMISSION_DT"] == DBNull.Value) ? "" : dr.Field<string>("RFI_PROBABLE_SUBMISSION_DT") : "",
                    RFI_ActualSubmissionDate = (dr.Table.Columns.Contains("RFI_ACTUAL_SUBMISSION_DT")) ? (dr["RFI_ACTUAL_SUBMISSION_DT"] == DBNull.Value) ? "" : dr.Field<string>("RFI_ACTUAL_SUBMISSION_DT") : "",
                    RFI_REVIEW_BY = (dr.Table.Columns.Contains("RFI_REVIEW_BY")) ? (dr["RFI_REVIEW_BY"] == DBNull.Value) ? "" : dr.Field<string>("RFI_REVIEW_BY") : "",
                    RFP_REVIEW_BY = (dr.Table.Columns.Contains("RFP_REVIEW_BY")) ? (dr["RFP_REVIEW_BY"] == DBNull.Value) ? "" : dr.Field<string>("RFP_REVIEW_BY") : "",
                    CURRENCY_ID = (dr.Table.Columns.Contains("CURRENCY_ID")) ? (dr["CURRENCY_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CURRENCY_ID"]) : 0,
                    FTEOff = (dr.Table.Columns.Contains("FTE_OFFSHORE")) ? (dr["FTE_OFFSHORE"] == DBNull.Value) ? 0 : dr.Field<Int32>("FTE_OFFSHORE") : 0,
                    FTEOn = (dr.Table.Columns.Contains("FTE_ONSITE")) ? (dr["FTE_ONSITE"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["FTE_ONSITE"]) : 0,
                    ENTITY = (dr.Table.Columns.Contains("ENTITY")) ? (dr["ENTITY"] == DBNull.Value) ? "" : dr.Field<string>("ENTITY") : "",
                    ClusterId = (dr.Table.Columns.Contains("CLUSTER_ID")) ? (dr["CLUSTER_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CLUSTER_ID"]) : 0,
                    DealCategory = (dr.Table.Columns.Contains("DEAL_CATEGORY")) ? (dr["DEAL_CATEGORY"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["DEAL_CATEGORY"]) : 0,
                    BPS_OFFERING_ID = (dr.Table.Columns.Contains("BPS_OFFERING_ID")) ? (dr["BPS_OFFERING_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["BPS_OFFERING_ID"]) : 0,
                    SERVICE_ID = (dr.Table.Columns.Contains("SERVICE_ID")) ? (dr["SERVICE_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["SERVICE_ID"]) : 0,
                    SUB_IOU = (dr.Table.Columns.Contains("SUB_IOU")) ? (dr["SUB_IOU"] == DBNull.Value) ? "" : dr.Field<string>("SUB_IOU") : "",
                    EXECUTIVE_SPONSOR = (dr.Table.Columns.Contains("EXECUTIVE_SPONSOR")) ? (dr["EXECUTIVE_SPONSOR"] == DBNull.Value) ? "" : dr.Field<string>("EXECUTIVE_SPONSOR") : "",
                    VALBPS_CON = (dr.Table.Columns.Contains("VALBPS_CON")) ? (dr["VALBPS_CON"] == DBNull.Value) ? "" : dr.Field<string>("VALBPS_CON") : "",
                    PROACTIVE_PROPOSAL = (dr.Table.Columns.Contains("PROACTIVE_PROPOSAL")) ? (dr["PROACTIVE_PROPOSAL"] == DBNull.Value) ? "" : dr.Field<string>("PROACTIVE_PROPOSAL") : "",
                    ISU_MAIN = (dr.Table.Columns.Contains("ISU_MAIN")) ? (dr["ISU_MAIN"] == DBNull.Value) ? "" : dr.Field<string>("ISU_MAIN") : "",
                    Quarter = (dr.Table.Columns.Contains("quarter")) ? (dr["quarter"] == DBNull.Value) ? "" : dr.Field<string>("quarter") : "",
                    FISCAL_YEAR = (dr.Table.Columns.Contains("FISCAL_YEAR")) ? (dr["FISCAL_YEAR"] == DBNull.Value) ? "" : dr.Field<string>("FISCAL_YEAR") : "",
                    PROPOSAL_FACTORY = (dr.Table.Columns.Contains("PROPOSAL_FACTORY")) ? (dr["PROPOSAL_FACTORY"] == DBNull.Value) ? "" : dr.Field<string>("PROPOSAL_FACTORY") : "",
                    PROPOSAL_FACTORY_OPTIONS = (dr.Table.Columns.Contains("PROPOSAL_FACTORY_OPTIONS")) ? (dr["PROPOSAL_FACTORY_OPTIONS"] == DBNull.Value) ? "" : dr.Field<string>("PROPOSAL_FACTORY_OPTIONS") : "",
                    PROPOSAL_FACTORY_COMMENTS = (dr.Table.Columns.Contains("PROPOSAL_FACTORY_COMMENTS")) ? (dr["PROPOSAL_FACTORY_COMMENTS"] == DBNull.Value) ? "" : dr.Field<string>("PROPOSAL_FACTORY_COMMENTS") : "",
                    DT_ID = (dr.Table.Columns.Contains("DT_ID")) ? (dr["DT_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["DT_ID"]) : 0,
                    Other_DT = (dr.Table.Columns.Contains("Other_DT")) ? (dr["Other_DT"] == DBNull.Value) ? "" : dr.Field<string>("Other_DT") : "",
                    CRM_TCV = (dr.Table.Columns.Contains("CRM_TCV")) ? (dr["CRM_TCV"] == DBNull.Value) ? "" : Convert.ToString(dr["CRM_TCV"]) : "",
                    CRM_STAGE = (dr.Table.Columns.Contains("CRM_STAGE")) ? (dr["CRM_STAGE"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CRM_STAGE"]) : 0,
                    TataGroupAccount = (dr.Table.Columns.Contains("TATA_GROUP_ACCOUNT")) ? (dr["TATA_GROUP_ACCOUNT"] == DBNull.Value) ? "" : Convert.ToString(dr["TATA_GROUP_ACCOUNT"]) : "",
                    ItisScope = (dr.Table.Columns.Contains("ItisScope")) ? (dr["ItisScope"] == DBNull.Value) ? "" : Convert.ToString(dr["ItisScope"]) : "",
                    IsContractRenewal = (dr.Table.Columns.Contains("IsContractRenewal")) ? (dr["IsContractRenewal"] == DBNull.Value) ? "" : Convert.ToString(dr["IsContractRenewal"]) : "",
                    ContractRenewalValue = (dr.Table.Columns.Contains("ContractRenewalValue")) ? (dr["ContractRenewalValue"] == DBNull.Value) ? "" : Convert.ToString(dr["ContractRenewalValue"]) : "",
                    strDigitalTcv = (dr.Table.Columns.Contains("Digital_TCV")) ? (dr["Digital_TCV"] == DBNull.Value) ? "" : dr.Field<string>("Digital_TCV") : "",
                    MULTITOWER_DEAL = (dr.Table.Columns.Contains("MULTITOWER_DEAL")) ? (dr["MULTITOWER_DEAL"] == DBNull.Value) ? "" : dr.Field<string>("MULTITOWER_DEAL") : "",

                    DealStatus = (dr.Table.Columns.Contains("DealStatus_Id")) ? (dr["DealStatus_Id"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["DealStatus_Id"]) : 0,
                    ServicePractice = (dr.Table.Columns.Contains("ServicePractice_Id")) ? (dr["ServicePractice_Id"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["ServicePractice_Id"]) : 0,
                    CoreOffering = (dr.Table.Columns.Contains("CoreOffering_Id")) ? (dr["CoreOffering_Id"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CoreOffering_Id"]) : 0,
                    OpportunityDescDetails = (dr.Table.Columns.Contains("Opportunity_Desc_Details")) ? (dr["Opportunity_Desc_Details"] == DBNull.Value) ? "" : dr.Field<string>("Opportunity_Desc_Details") : "",
                    DigitalFlagging = (dr.Table.Columns.Contains("Digital_Flagging")) ? (dr["Digital_Flagging"] == DBNull.Value) ? "" : Convert.ToString(dr["Digital_Flagging"]) : "",





                    subSPId = (dr.Table.Columns.Contains("SubSPID")) ? (dr["SubSPID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["SubSPID"]) : 0,
                    CRM_Beacon = (dr.Table.Columns.Contains("CRM_Beacon")) ? (dr["CRM_Beacon"] == DBNull.Value) ? "" : Convert.ToString(dr["CRM_Beacon"]) : "",

                    //changess
                    RESOURCING_ID = (dr.Table.Columns.Contains("ResourcingId")) ? (dr["ResourcingId"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["ResourcingId"]) : 0,
                    SEAT_IDENTIFICATION_ID = (dr.Table.Columns.Contains("Seat_IdentificationId")) ? (dr["Seat_IdentificationId"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["Seat_IdentificationId"]) : 0,
                    offeringType = (dr.Table.Columns.Contains("OfferingType_Id")) ? (dr["OfferingType_Id"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["OfferingType_Id"]) : 0,
                      CofID = (dr.Table.Columns.Contains("CoreOfferingName_Id")) ? (dr["CoreOfferingName_Id"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CoreOfferingName_Id"]) : 0,

                    //End


                    PROPOSAL_SUBMISSION_DATE = (dr.Table.Columns.Contains("PROPOSAL_SUBMISSION_DATE")) ? (dr["PROPOSAL_SUBMISSION_DATE"] == DBNull.Value) ? "" : dr.Field<string>("PROPOSAL_SUBMISSION_DATE") : "",
                    SALES_STAGE_MOVED_ONDATE = (dr.Table.Columns.Contains("SALES_STAGE_MOVED_ON_DATE")) ? (dr["SALES_STAGE_MOVED_ON_DATE"] == DBNull.Value) ? "" : dr.Field<string>("SALES_STAGE_MOVED_ON_DATE") : "",

                    Previous_Deal_Stage = (dr.Table.Columns.Contains("Previous_Deal_Stage")) ? (dr["Previous_Deal_Stage"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["Previous_Deal_Stage"]) : 0,

                    DELIVERY_LOCATION_PROPOSED = (dr.Table.Columns.Contains("DELIVERY_LOCATION_PROPOSED")) ? (dr["DELIVERY_LOCATION_PROPOSED"] == DBNull.Value) ? "" : dr.Field<string>("DELIVERY_LOCATION_PROPOSED") : "",
                    Cboi_Offering_id= (dr.Table.Columns.Contains("cboi_offering_id")) ? (dr["cboi_offering_id"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["cboi_offering_id"]) : 0,
                    Deal_Flag_id= (dr.Table.Columns.Contains("deal_flag")) ? (dr["deal_flag"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["deal_flag"]) : 0,
                    PLATFORM = (dr.Table.Columns.Contains("PLATFORM")) ? (dr["PLATFORM"] == DBNull.Value) ? "" : dr.Field<string>("PLATFORM") : "",
                    PLATFORM_OPTION = (dr.Table.Columns.Contains("PLATFORM_OPTION")) ? (dr["PLATFORM_OPTION"] == DBNull.Value) ? "" : dr.Field<string>("PLATFORM_OPTION") : "",



                    //PROBABILITY_OF_WIN = (dr.Table.Columns.Contains("PROBABILITY_OF_WIN")) ? (dr["PROBABILITY_OF_WIN"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["PROBABILITY_OF_WIN"]) : 0,
                    //REMARK = (dr.Table.Columns.Contains("REMARK")) ? (dr["REMARK"] == DBNull.Value) ? "" : dr.Field<string>("REMARK") : "",
                    //OpportunityId = (dr.Table.Columns.Contains("OPPORTUNITY_ID")) ? (dr["OPPORTUNITY_ID"] == DBNull.Value) ? "" : Convert.ToString(dr["OPPORTUNITY_ID"]) : "",
                    //OPPORTUNITY_DESC = (dr.Table.Columns.Contains("OPPORTUNITY_DESC")) ? (dr["OPPORTUNITY_DESC"] == DBNull.Value) ? "" : dr.Field<string>("OPPORTUNITY_DESC") : "",
                    //OLD_OPPORTUNITY_DESC = (dr.Table.Columns.Contains("OLD_OPPORTUNITY_DESC")) ? (dr["OLD_OPPORTUNITY_DESC"] == DBNull.Value) ? "" : dr.Field<string>("OLD_OPPORTUNITY_DESC") : "",
                    //GEOGRAPHY_ID = (dr.Table.Columns.Contains("GEOGRAPHY_ID")) ? (dr["GEOGRAPHY_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["GEOGRAPHY_ID"]) : 0,
                    //GEOGRAPHY_NAME = (dr.Table.Columns.Contains("GEOGRAPHY_NAME")) ? (dr["GEOGRAPHY_NAME"] == DBNull.Value) ? "" : dr.Field<string>("GEOGRAPHY_NAME") : "",
                    //CUST_ID = (dr.Table.Columns.Contains("CUST_ID")) ? (dr["CUST_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CUST_ID"]) : 0,
                    //CUST_NAME = (dr.Table.Columns.Contains("CUST_NAME")) ? (dr["CUST_NAME"] == DBNull.Value) ? "" : dr.Field<string>("CUST_NAME") : "",
                    //CUST_TYPE_ID = (dr.Table.Columns.Contains("CUST_TYPE_ID")) ? (dr["CUST_TYPE_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CUST_TYPE_ID"]) : 0,
                    //CUST_TYPE_NAME = (dr.Table.Columns.Contains("CUST_TYPE_NAME")) ? (dr["CUST_TYPE_NAME"] == DBNull.Value) ? "" : dr.Field<string>("CUST_TYPE_NAME") : "",
                    //INDUSTRY_PRACTICE_ID = (dr.Table.Columns.Contains("INDUSTRY_PRACTICE_ID")) ? (dr["INDUSTRY_PRACTICE_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["INDUSTRY_PRACTICE_ID"]) : 0,
                    //StageID = (dr.Table.Columns.Contains("STAGE_ID")) ? (dr["STAGE_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["STAGE_ID"]) : 0,
                    //INDUSTRY_PRACTICE_NAME = (dr.Table.Columns.Contains("INDUSTRY_PRACTICE_NAME")) ? (dr["INDUSTRY_PRACTICE_NAME"] == DBNull.Value) ? "" : dr.Field<string>("INDUSTRY_PRACTICE_NAME") : "",
                    //STAGE_NAME = (dr.Table.Columns.Contains("STAGE_NAME")) ? (dr["STAGE_NAME"] == DBNull.Value) ? "" : dr.Field<string>("STAGE_NAME") : "",
                    //ISU_CD = (dr.Table.Columns.Contains("ISU_CD")) ? (dr["ISU_CD"] == DBNull.Value) ? "" : dr.Field<string>("ISU_CD") : "",
                    //ISU_NAME = (dr.Table.Columns.Contains("ISU_NAME")) ? (dr["ISU_NAME"] == DBNull.Value) ? "" : dr.Field<string>("ISU_NAME") : "",
                    //GEOGRAPHY_SALES_OWNER = (dr.Table.Columns.Contains("GEOGRAPHY_SALES_OWNER")) ? (dr["GEOGRAPHY_SALES_OWNER"] == DBNull.Value) ? "" : dr.Field<string>("GEOGRAPHY_SALES_OWNER") : "",
                    //OFFSHORE_PRACTICE_OWNER = (dr.Table.Columns.Contains("OFFSHORE_PRACTICE_OWNER")) ? (dr["OFFSHORE_PRACTICE_OWNER"] == DBNull.Value) ? "" : dr.Field<string>("OFFSHORE_PRACTICE_OWNER") : "",
                    //RD_CRD = (dr.Table.Columns.Contains("RD_CRD")) ? (dr["RD_CRD"] == DBNull.Value) ? "" : dr.Field<string>("RD_CRD") : "",
                    //ONSITE_OWNER = (dr.Table.Columns.Contains("ONSITE_OWNER")) ? (dr["ONSITE_OWNER"] == DBNull.Value) ? "" : dr.Field<string>("ONSITE_OWNER") : "",
                    //OFFSHORE_BD_LEAD = (dr.Table.Columns.Contains("OFFSHORE_BD_LEAD")) ? (dr["OFFSHORE_BD_LEAD"] == DBNull.Value) ? "" : dr.Field<string>("OFFSHORE_BD_LEAD") : "",
                    //DAYS_IN_THIS_STAGE = (dr.Table.Columns.Contains("DAYS_IN_THIS_STAGE")) ? (dr["DAYS_IN_THIS_STAGE"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["DAYS_IN_THIS_STAGE"]) : 0,
                    //OPPORTUNITY_DATE = (dr.Table.Columns.Contains("OPPORTUNITY_DATE")) ? (dr["OPPORTUNITY_DATE"] == DBNull.Value) ? "" : dr.Field<string>("OPPORTUNITY_DATE") : "",
                    //RFIReceivedDate = dr.Table.Columns.Contains("RFI_RECEIVED_DT") ? (dr["RFI_RECEIVED_DT"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["RFI_RECEIVED_DT"]) : 0,
                    //RFIProbableSubmissionDate = dr.Table.Columns.Contains("RFI_PROBABLE_SUBMISSION_DT") ? (dr["RFI_PROBABLE_SUBMISSION_DT"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["RFI_PROBABLE_SUBMISSION_DT"]) : 0,
                    //RFIActualSubmissionDate = dr.Table.Columns.Contains("RFI_ACTUAL_SUBMISSION_DT") ? (dr["RFI_ACTUAL_SUBMISSION_DT"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["RFI_ACTUAL_SUBMISSION_DT"]) : 0,
                    //RFISubmissionDate = dr.Table.Columns.Contains("RFI_SUBMISSION_DT") ? (dr["RFI_SUBMISSION_DT"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["RFI_SUBMISSION_DT"]) : 0,
                    //RFPReceivedDate = (dr.Table.Columns.Contains("RFP_RECEIVED_DT")) ? (dr["RFP_RECEIVED_DT"] == DBNull.Value) ? 0 : Convert.ToInt32(dr.Field<DateTime>("RFP_RECEIVED_DT")) : 0,
                    //RFPProbableSubmissionDate = dr.Table.Columns.Contains("RFP_PROBABLE_SUBMISSION_DT") ? (dr["RFP_PROBABLE_SUBMISSION_DT"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["RFP_PROBABLE_SUBMISSION_DT"]) : 0,
                    //RFPActualSubmissionDate = dr.Table.Columns.Contains("RFP_ACTUAL_SUBMISSION_DT") ? (dr["RFP_ACTUAL_SUBMISSION_DT"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["RFP_ACTUAL_SUBMISSION_DT"]) : 0,
                    //RFPSubmissionDate = dr.Table.Columns.Contains("RFP_SUBMISSION_DT") ? (dr["RFP_SUBMISSION_DT"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["RFP_SUBMISSION_DT"]) : 0,
                    //RFIApprovedBy = (dr.Table.Columns.Contains("RFI_APPROVED_BY")) ? (dr["RFI_APPROVED_BY"] == DBNull.Value) ? "" : Convert.ToString(dr["RFI_APPROVED_BY"]) : "",
                    //RFPApprovedBy = (dr.Table.Columns.Contains("RFP_APPROVED_BY")) ? (dr["RFP_APPROVED_BY"] == DBNull.Value) ? "" : Convert.ToString(dr["RFP_APPROVED_BY"]) : "",
                    //ContractLength = (dr.Table.Columns.Contains("CONTRACT_LENGTH")) ? (dr["CONTRACT_LENGTH"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CONTRACT_LENGTH"]) : 0,
                    //CURRENTLY_ACTIVE = (dr.Table.Columns.Contains("CURRENTLY_ACTIVE")) ? (dr["CURRENTLY_ACTIVE"] == DBNull.Value) ? "" : dr.Field<string>("CURRENTLY_ACTIVE") : "",
                    //IMMEDIATE_COMMENT = (dr.Table.Columns.Contains("IMMEDIATE_COMMENT")) ? (dr["IMMEDIATE_COMMENT"] == DBNull.Value) ? "" : dr.Field<string>("IMMEDIATE_COMMENT") : "",
                    //FTE_DD = (dr.Table.Columns.Contains("FTE_DD")) ? (dr["FTE_DD"] == DBNull.Value) ? "" : dr.Field<string>("FTE_DD") : "",
                    //SOLUTION_LEADER = (dr.Table.Columns.Contains("SOLUTION_LEADER")) ? (dr["SOLUTION_LEADER"] == DBNull.Value) ? "" : dr.Field<string>("SOLUTION_LEADER") : "",
                    //RUR = (dr.Table.Columns.Contains("RUR")) ? (dr["RUR"] == DBNull.Value) ? "" : dr.Field<string>("RUR") : "",
                    //HRT_COMMENTS = (dr.Table.Columns.Contains("HRT_COMMENTS")) ? (dr["HRT_COMMENTS"] == DBNull.Value) ? "" : dr.Field<string>("HRT_COMMENTS") : "",
                    //CRM_ID = (dr.Table.Columns.Contains("CRM_ID")) ? (dr["CRM_ID"] == DBNull.Value) ? "" : Convert.ToString(dr["CRM_ID"]) : "",
                    //TOTAL_CONTRACT_VALUE = (dr.Table.Columns.Contains("TOTAL_CONTRACT_VALUE")) ? (dr["TOTAL_CONTRACT_VALUE"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["TOTAL_CONTRACT_VALUE"]) : 0,
                    //FnA_LEAD = (dr.Table.Columns.Contains("FnA_LEAD")) ? (dr["FnA_LEAD"] == DBNull.Value) ? "" : dr.Field<string>("FnA_LEAD") : "",
                    //HRO_LEAD = (dr.Table.Columns.Contains("HRO_LEAD")) ? (dr["HRO_LEAD"] == DBNull.Value) ? "" : dr.Field<string>("HRO_LEAD") : "",
                    //SCM_LEAD = (dr.Table.Columns.Contains("SCM_LEAD")) ? (dr["SCM_LEAD"] == DBNull.Value) ? "" : dr.Field<string>("SCM_LEAD") : "",
                    //KPO_LEAD = (dr.Table.Columns.Contains("KPO_LEAD")) ? (dr["KPO_LEAD"] == DBNull.Value) ? "" : dr.Field<string>("KPO_LEAD") : "",
                    //LPO_LEAD = (dr.Table.Columns.Contains("LPO_LEAD")) ? (dr["LPO_LEAD"] == DBNull.Value) ? "" : dr.Field<string>("LPO_LEAD") : "",
                    //VERTICAL_LEAD = (dr.Table.Columns.Contains("VERTICAL_LEAD")) ? (dr["VERTICAL_LEAD"] == DBNull.Value) ? "" : dr.Field<string>("VERTICAL_LEAD") : "",
                    //Voice_Lead = (dr.Table.Columns.Contains("VOICE_LEAD")) ? (dr["VOICE_LEAD"] == DBNull.Value) ? "" : dr.Field<string>("VOICE_LEAD") : "",
                    //BPM_LEAD = (dr.Table.Columns.Contains("BPM_LEAD")) ? (dr["BPM_LEAD"] == DBNull.Value) ? "" : dr.Field<string>("BPM_LEAD") : "",
                    //BID_MANAGER_EMPID = (dr.Table.Columns.Contains("BID_MANAGER_EMPID")) ? (dr["BID_MANAGER_EMPID"] == DBNull.Value) ? "" : dr.Field<string>("BID_MANAGER_EMPID") : "",
                    //BID_EXEC_OWNER_EMPID = (dr.Table.Columns.Contains("BID_EXEC_OWNER_EMPID")) ? (dr["BID_EXEC_OWNER_EMPID"] == DBNull.Value) ? "" : dr.Field<string>("BID_EXEC_OWNER_EMPID") : "",
                    //PRICING_OWNER_EMPID = (dr.Table.Columns.Contains("PRICING_OWNER_EMPID")) ? (dr["PRICING_OWNER_EMPID"] == DBNull.Value) ? "" : dr.Field<string>("PRICING_OWNER_EMPID") : "",
                    //SOLUTION_LEADER_EMPID = (dr.Table.Columns.Contains("SOLUTION_LEADER_EMPID")) ? (dr["SOLUTION_LEADER_EMPID"] == DBNull.Value) ? "" : dr.Field<string>("SOLUTION_LEADER_EMPID") : "",
                    //FnATCV = (dr.Table.Columns.Contains("FnATCV")) ? (dr["FnATCV"] == DBNull.Value) ? "" : dr.Field<string>("FnATCV") : "",
                    //HROTCV = (dr.Table.Columns.Contains("HROTCV")) ? (dr["HROTCV"] == DBNull.Value) ? "" : dr.Field<string>("HROTCV") : "",
                    //SCMTCV = (dr.Table.Columns.Contains("SCMTCV")) ? (dr["SCMTCV"] == DBNull.Value) ? "" : dr.Field<string>("SCMTCV") : "",
                    //KPOTCV = (dr.Table.Columns.Contains("KPOTCV")) ? (dr["KPOTCV"] == DBNull.Value) ? "" : dr.Field<string>("KPOTCV") : "",
                    //LPOTCV = (dr.Table.Columns.Contains("LPOTCV")) ? (dr["LPOTCV"] == DBNull.Value) ? "" : dr.Field<string>("LPOTCV") : "",
                    //VERTICALTCV = (dr.Table.Columns.Contains("VERTICALTCV")) ? (dr["VERTICALTCV"] == DBNull.Value) ? "" : dr.Field<string>("VERTICALTCV") : "",
                    //VOICETCV = (dr.Table.Columns.Contains("VOICETCV")) ? (dr["VOICETCV"] == DBNull.Value) ? "" : dr.Field<string>("VOICETCV") : "",
                    //BPMTCV = (dr.Table.Columns.Contains("BPMTCV")) ? (dr["BPMTCV"] == DBNull.Value) ? "" : dr.Field<string>("BPMTCV") : "",
                    //STATUS_UPDATE = (dr.Table.Columns.Contains("STATUS_UPDATE")) ? (dr["STATUS_UPDATE"] == DBNull.Value) ? "" : dr.Field<string>("STATUS_UPDATE") : "",
                    //NO_SOL_TEAM_MEM = (dr.Table.Columns.Contains("NO_SOL_TEAM_MEM")) ? (dr["NO_SOL_TEAM_MEM"] == DBNull.Value) ? "" : dr.Field<string>("NO_SOL_TEAM_MEM") : "",
                    //NO_DEL_TEAM_MEM = (dr.Table.Columns.Contains("NO_DEL_TEAM_MEM")) ? (dr["NO_DEL_TEAM_MEM"] == DBNull.Value) ? "" : dr.Field<string>("NO_DEL_TEAM_MEM") : "",
                    //BID_MANAGER = (dr.Table.Columns.Contains("BID_MANAGER")) ? (dr["BID_MANAGER"] == DBNull.Value) ? "" : dr.Field<string>("BID_MANAGER") : "",
                    //BID_EXEC_OWNER = (dr.Table.Columns.Contains("BID_EXEC_OWNER")) ? (dr["BID_EXEC_OWNER"] == DBNull.Value) ? "" : dr.Field<string>("BID_EXEC_OWNER") : "",
                    //PRICING_OWNER = (dr.Table.Columns.Contains("PRICING_OWNER")) ? (dr["PRICING_OWNER"] == DBNull.Value) ? "" : dr.Field<string>("PRICING_OWNER") : "",
                    //TRANSITION_TEAM = (dr.Table.Columns.Contains("TRANSITION_TEAM")) ? (dr["TRANSITION_TEAM"] == DBNull.Value) ? "" : dr.Field<string>("TRANSITION_TEAM") : "",
                    //TRANSITION_REQUIRED = (dr.Table.Columns.Contains("TRANSITION_REQUIRED")) ? (dr["TRANSITION_REQUIRED"] == DBNull.Value) ? "" : dr.Field<string>("TRANSITION_REQUIRED") : "",
                    //EXPECTED_START_DATE = (dr.Table.Columns.Contains("EXPECTED_START_DATE")) ? (dr["EXPECTED_START_DATE"] == DBNull.Value) ? "" : dr.Field<string>("EXPECTED_START_DATE") : "",
                    //PIBS = (dr.Table.Columns.Contains("PIBS")) ? (dr["PIBS"] == DBNull.Value) ? "" : dr.Field<string>("PIBS") : "",
                    //TCS_INVESTMENT = (dr.Table.Columns.Contains("TCS_INVESTMENT")) ? (dr["TCS_INVESTMENT"] == DBNull.Value) ? "" : dr.Field<string>("TCS_INVESTMENT") : "",
                    //PIB_START_DT = (dr.Table.Columns.Contains("PIB_START_DT")) ? (dr["PIB_START_DT"] == DBNull.Value) ? "" : dr.Field<string>("PIB_START_DT") : "",
                    //PIB_END_DT = (dr.Table.Columns.Contains("PIB_END_DT")) ? (dr["PIB_END_DT"] == DBNull.Value) ? "" : dr.Field<string>("PIB_END_DT") : "",
                    //NO_OF_FTES_ENGAGED = (dr.Table.Columns.Contains("NO_OF_FTES_ENGAGED")) ? (dr["NO_OF_FTES_ENGAGED"] == DBNull.Value) ? "" : dr.Field<string>("NO_OF_FTES_ENGAGED") : "",
                    //PIB_STATUS = (dr.Table.Columns.Contains("PIB_STATUS")) ? (dr["PIB_STATUS"] == DBNull.Value) ? "" : dr.Field<string>("PIB_STATUS") : "",
                    //PIBS_OUTCOME_NAME = (dr.Table.Columns.Contains("PIBS_OUTCOME")) ? (dr["PIBS_OUTCOME"] == DBNull.Value) ? "" : dr.Field<string>("PIBS_OUTCOME") : "",
                    //PIB_STATUS_REMARKS = (dr.Table.Columns.Contains("PIB_STATUS_REMARKS")) ? (dr["PIB_STATUS_REMARKS"] == DBNull.Value) ? "" : dr.Field<string>("PIB_STATUS_REMARKS") : "",
                    //BPODomain = (dr.Table.Columns.Contains("BPO_DOMAIN")) ? (dr["BPO_DOMAIN"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["BPO_DOMAIN"]) : 0,
                    //DOMAIN_PRESALES_LEAD = (dr.Table.Columns.Contains("DOMAIN_PRESALES_LEAD")) ? (dr["DOMAIN_PRESALES_LEAD"] == DBNull.Value) ? "" : dr.Field<string>("DOMAIN_PRESALES_LEAD") : "",
                    //DomainPresalesLeadName = (dr.Table.Columns.Contains("DOMAIN_PRESALES_LEAD_NAME")) ? (dr["DOMAIN_PRESALES_LEAD_NAME"] == DBNull.Value) ? "" : dr.Field<string>("DOMAIN_PRESALES_LEAD_NAME") : "",
                    //DealCategory = (dr.Table.Columns.Contains("DEAL_CATEGORY")) ? (dr["DEAL_CATEGORY"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["DEAL_CATEGORY"]) : 0,
                    //DEAL_COACH_NAME = (dr.Table.Columns.Contains("DEAL_COACH_NAME")) ? (dr["DEAL_COACH_NAME"] == DBNull.Value) ? "" : dr.Field<string>("DEAL_COACH_NAME") : "",
                    //DEMAND_TYPE = (dr.Table.Columns.Contains("DEMAND_TYPE")) ? (dr["DEMAND_TYPE"] == DBNull.Value) ? "" : dr.Field<string>("DEMAND_TYPE") : "",
                    //PROPOSED_SOLUTION = (dr.Table.Columns.Contains("PROPOSED_SOLUTION")) ? (dr["PROPOSED_SOLUTION"] == DBNull.Value) ? "" : dr.Field<string>("PROPOSED_SOLUTION") : "",
                    //WINNING_TEAM = (dr.Table.Columns.Contains("WINNING_TEAM")) ? (dr["WINNING_TEAM"] == DBNull.Value) ? "" : dr.Field<string>("WINNING_TEAM") : "",
                    //OPERATING_MODEL = (dr.Table.Columns.Contains("OPERATING_MODEL")) ? (dr["OPERATING_MODEL"] == DBNull.Value) ? "" : dr.Field<string>("OPERATING_MODEL") : "",
                    //PRICING_MODEL = (dr.Table.Columns.Contains("PRICING_MODEL")) ? (dr["PRICING_MODEL"] == DBNull.Value) ? "" : dr.Field<string>("PRICING_MODEL") : "",
                    //DIFFERENTIATORS = (dr.Table.Columns.Contains("DIFFERENTIATORS")) ? (dr["DIFFERENTIATORS"] == DBNull.Value) ? "" : dr.Field<string>("DIFFERENTIATORS") : "",
                    //RISKS = (dr.Table.Columns.Contains("RISKS")) ? (dr["RISKS"] == DBNull.Value) ? "" : dr.Field<string>("RISKS") : "",
                    //KEY_CUSTOMER_CONNECTS = (dr.Table.Columns.Contains("KEY_CUSTOMER_CONNECTS")) ? (dr["KEY_CUSTOMER_CONNECTS"] == DBNull.Value) ? "" : dr.Field<string>("KEY_CUSTOMER_CONNECTS") : "",
                    //BPO_OFFERING_DESCRIPTION = (dr.Table.Columns.Contains("BPO_OFFERING_DESCRIPTION")) ? (dr["BPO_OFFERING_DESCRIPTION"] == DBNull.Value) ? "" : dr.Field<string>("BPO_OFFERING_DESCRIPTION") : "",
                    //FIRST_TIME_OUTSOURCE = (dr.Table.Columns.Contains("FIRST_TIME_OUTSOURCE")) ? (dr["FIRST_TIME_OUTSOURCE"] == DBNull.Value) ? "" : dr.Field<string>("FIRST_TIME_OUTSOURCE") : "",
                    //INCUMBENTS = (dr.Table.Columns.Contains("INCUMBENTS")) ? (dr["INCUMBENTS"] == DBNull.Value) ? "" : dr.Field<string>("INCUMBENTS") : "",
                    //NAME_OF_INCUMBENTS = (dr.Table.Columns.Contains("NAME_OF_INCUMBENTS")) ? (dr["NAME_OF_INCUMBENTS"] == DBNull.Value) ? "" : dr.Field<string>("NAME_OF_INCUMBENTS") : "",
                    //TCS_OFFERING_CAPABILITY = (dr.Table.Columns.Contains("TCS_OFFERING_CAPABILITY")) ? (dr["TCS_OFFERING_CAPABILITY"] == DBNull.Value) ? "" : dr.Field<string>("TCS_OFFERING_CAPABILITY") : "",
                    //COACH_AVAILABLE = (dr.Table.Columns.Contains("COACH_AVAILABLE")) ? (dr["COACH_AVAILABLE"] == DBNull.Value) ? "" : dr.Field<string>("COACH_AVAILABLE") : "",
                    //FnA = (dr.Table.Columns.Contains("FnA")) ? (dr["FnA"] == DBNull.Value) ? "" : dr.Field<string>("FnA") : "",
                    //FnA_FTE = (dr.Table.Columns.Contains("FnA_FTE")) ? (dr["FnA_FTE"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["FnA_FTE"]) : 0,
                    //HRO = (dr.Table.Columns.Contains("HRO")) ? (dr["HRO"] == DBNull.Value) ? "" : dr.Field<string>("HRO") : "",
                    //HRO_FTE = (dr.Table.Columns.Contains("HRO_FTE")) ? (dr["HRO_FTE"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["HRO_FTE"]) : 0,
                    //SCM = (dr.Table.Columns.Contains("SCM")) ? (dr["SCM"] == DBNull.Value) ? "" : dr.Field<string>("SCM") : "",
                    //SCM_FTE = (dr.Table.Columns.Contains("SCM_FTE")) ? (dr["SCM_FTE"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["SCM_FTE"]) : 0,
                    //KPO = (dr.Table.Columns.Contains("KPO")) ? (dr["KPO"] == DBNull.Value) ? "" : dr.Field<string>("KPO") : "",
                    //KPO_FTE = (dr.Table.Columns.Contains("KPO_FTE")) ? (dr["KPO_FTE"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["KPO_FTE"]) : 0,
                    //LPO = (dr.Table.Columns.Contains("LPO")) ? (dr["LPO"] == DBNull.Value) ? "" : dr.Field<string>("LPO") : "",
                    //LPO_FTE = (dr.Table.Columns.Contains("LPO_FTE")) ? (dr["LPO_FTE"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["LPO_FTE"]) : 0,
                    //VERTICAL = (dr.Table.Columns.Contains("VERTICAL")) ? (dr["VERTICAL"] == DBNull.Value) ? "" : dr.Field<string>("VERTICAL") : "",
                    //VerticalFTE = (dr.Table.Columns.Contains("VERTICAL_FTE")) ? (dr["VERTICAL_FTE"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["VERTICAL_FTE"]) : 0,
                    //Voice = (dr.Table.Columns.Contains("VOICE")) ? (dr["VOICE"] == DBNull.Value) ? "" : dr.Field<string>("VOICE") : "",
                    //VoiceFTE = (dr.Table.Columns.Contains("VOICE_FTE")) ? (dr["VOICE_FTE"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["VOICE_FTE"]) : 0,
                    //BPM = (dr.Table.Columns.Contains("BPM")) ? (dr["BPM"] == DBNull.Value) ? "" : dr.Field<string>("BPM") : "",
                    //BPM_FTE = (dr.Table.Columns.Contains("BPM_FTE")) ? (dr["BPM_FTE"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["BPM_FTE"]) : 0,
                    //SEAT_REQUIREMENTS = (dr.Table.Columns.Contains("SEAT_REQUIREMENTS")) ? (dr["SEAT_REQUIREMENTS"] == DBNull.Value) ? "" : dr.Field<string>("SEAT_REQUIREMENTS") : "",
                    //WEEKS = (dr.Table.Columns.Contains("WEEKS")) ? (dr["WEEKS"] == DBNull.Value) ? "" : dr.Field<string>("WEEKS") : "",
                    //DEAL_CLOSURE_EXP_DATE = (dr.Table.Columns.Contains("DEAL_CLOSURE_EXP_DATE")) ? (dr["DEAL_CLOSURE_EXP_DATE"] == DBNull.Value) ? "" : dr.Field<string>("DEAL_CLOSURE_EXP_DATE") : "",
                    //ADVISORY_ID = (dr.Table.Columns.Contains("ADVISORY_ID")) ? (dr["ADVISORY_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["ADVISORY_ID"]) : 0,
                    //PLATFORM = (dr.Table.Columns.Contains("PLATFORM")) ? (dr["PLATFORM"] == DBNull.Value) ? "" : dr.Field<string>("PLATFORM") : "",
                    //BUSINESS_ID = (dr.Table.Columns.Contains("BUSINESS_ID")) ? (dr["BUSINESS_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["BUSINESS_ID"]) : 0,
                    //COUNTRY_ID = (dr.Table.Columns.Contains("COUNTRY_ID")) ? (dr["COUNTRY_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["COUNTRY_ID"]) : 0,
                    //FTE_TYPE = (dr.Table.Columns.Contains("FTE_TYPE")) ? (dr["FTE_TYPE"] == DBNull.Value) ? "" : dr.Field<string>("FTE_TYPE") : "",
                    //FTE_TYPE_COUNT = (dr.Table.Columns.Contains("FTE_TYPE_COUNT")) ? (dr["FTE_TYPE_COUNT"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["FTE_TYPE_COUNT"]) : 0,
                    //VALUE_BPS = (dr.Table.Columns.Contains("VALUE_BPS")) ? (dr["VALUE_BPS"] == DBNull.Value) ? "" : dr.Field<string>("VALUE_BPS") : "",
                    //// VALUE_BPS_TCV = (dr.Table.Columns.Contains("VALUE_BPS_TCV")) ? (dr["VALUE_BPS_TCV"] == DBNull.Value) ? "" : dr.Field<string>("VALUE_BPS_TCV") : "",
                    //OPP_TYPE = (dr.Table.Columns.Contains("OPP_TYPE")) ? (dr["OPP_TYPE"] == DBNull.Value) ? "" : dr.Field<string>("OPP_TYPE") : "",
                    //MULTITOWER_DEAL = (dr.Table.Columns.Contains("MULTITOWER_DEAL")) ? (dr["MULTITOWER_DEAL"] == DBNull.Value) ? "" : dr.Field<string>("MULTITOWER_DEAL") : "",
                    //OPPSTATUS_FLAG = (dr.Table.Columns.Contains("OPPSTATUS_FLAG")) ? (dr["OPPSTATUS_FLAG"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["OPPSTATUS_FLAG"]) : 0,
                    //ESTIMATED_FTE_SIZE = (dr.Table.Columns.Contains("ESTIMATED_FTE_SIZE")) ? (dr["ESTIMATED_FTE_SIZE"] == DBNull.Value) ? 0 : dr.Field<Decimal>("ESTIMATED_FTE_SIZE") : 0,
                    //ISU_OWNER_ID = (dr.Table.Columns.Contains("ISU_OWNER_ID")) ? (dr["ISU_OWNER_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["ISU_OWNER_ID"]) : 0,
                    //PRODUCT_ID = (dr.Table.Columns.Contains("PRODUCT_ID")) ? (dr["PRODUCT_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["PRODUCT_ID"]) : 0,
                    //SUB_COMPETENCY_ID = (dr.Table.Columns.Contains("SUB_COMPETENCY_ID")) ? (dr["SUB_COMPETENCY_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["SUB_COMPETENCY_ID"]) : 0,
                    //COMPETENCY_ID = (dr.Table.Columns.Contains("COMPETENCY_ID")) ? (dr["COMPETENCY_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["COMPETENCY_ID"]) : 0,
                    //Category_Id = (dr.Table.Columns.Contains("CATEGORY_ID")) ? (dr["CATEGORY_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CATEGORY_ID"]) : 0,
                    //NEXT_STEP = (dr.Table.Columns.Contains("NEXT_STEP")) ? (dr["NEXT_STEP"] == DBNull.Value) ? "" : dr.Field<string>("NEXT_STEP") : "",
                    //NEXT_STEP_DUE_DT = (dr.Table.Columns.Contains("NEXT_STEP_DUE_DT")) ? (dr["NEXT_STEP_DUE_DT"] == DBNull.Value) ? "" : dr.Field<string>("NEXT_STEP_DUE_DT") : "",
                    //ACCOUNT_SALES_OWNER_ID = (dr.Table.Columns.Contains("ACCOUNT_SALES_OWNER_ID")) ? (dr["ACCOUNT_SALES_OWNER_ID"] == DBNull.Value) ? "" : dr.Field<string>("ACCOUNT_SALES_OWNER_ID") : "",
                    //GEOGRAPHY_SALES_OWNER_ID = (dr.Table.Columns.Contains("GEOGRAPHY_SALES_OWNER_ID")) ? (dr["GEOGRAPHY_SALES_OWNER_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["GEOGRAPHY_SALES_OWNER_ID"]) : 0,
                    //PRACTICE_SALES_OWNER_ID = (dr.Table.Columns.Contains("PRACTICE_SALES_OWNER_ID")) ? (dr["PRACTICE_SALES_OWNER_ID"] == DBNull.Value) ? "" : Convert.ToString(dr["PRACTICE_SALES_OWNER_ID"]) : "",
                    //ONSITE_OWNER_ID =  (dr.Table.Columns.Contains("ONSITE_OWNER_ID")) ? (dr["ONSITE_OWNER_ID"] == DBNull.Value) ? "" : Convert.ToString(dr["ONSITE_OWNER_ID"]) : "",
                    //OFFSHORE_BD_LEAD_ID = (dr.Table.Columns.Contains("OFFSHORE_BD_LEAD_ID")) ? (dr["OFFSHORE_BD_LEAD_ID"] == DBNull.Value) ? "" : Convert.ToString(dr["OFFSHORE_BD_LEAD_ID"]) : "",
                    //DEFAULTERS = (dr.Table.Columns.Contains("DEFAULTERS")) ? (dr["DEFAULTERS"] == DBNull.Value) ? "" : dr.Field<string>("DEFAULTERS") : "",
                    //LAST_UPDATE = (dr.Table.Columns.Contains("LAST_UPDATE")) ? (dr["LAST_UPDATE"] == DBNull.Value) ? "" : dr.Field<string>("LAST_UPDATE") : "",
                    //CHANGED_BY = (dr.Table.Columns.Contains("CHANGED_BY")) ? (dr["CHANGED_BY"] == DBNull.Value) ? "" : dr.Field<string>("CHANGED_BY") : "",
                    //CHANGED_DT = (dr.Table.Columns.Contains("CHANGED_DT")) ? (dr["CHANGED_DT"] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(dr.Field<DateTime>("CHANGED_DT")) : (DateTime?)null,
                    //DEAL_BD_LEAD_ID = (dr.Table.Columns.Contains("DEAL_BD_LEAD_ID")) ? (dr["DEAL_BD_LEAD_ID"] == DBNull.Value) ? "" : Convert.ToString(dr["DEAL_BD_LEAD_ID"]) : "",
                    //DEAL_BD_LEAD_ID2 =  (dr.Table.Columns.Contains("DEAL_BD_LEAD_ID2")) ? (dr["DEAL_BD_LEAD_ID2"] == DBNull.Value) ? "" : Convert.ToString(dr["DEAL_BD_LEAD_ID2"]) : "",
                    //RFI_REVIEW_DT = (dr.Table.Columns.Contains("RFI_REVIEW_DT")) ? (dr["RFI_REVIEW_DT"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["RFI_REVIEW_DT"]) : 0,
                    //RFP_REVIEW_DT = (dr.Table.Columns.Contains("RFP_REVIEW_DT")) ? (dr["RFP_REVIEW_DT"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["RFP_REVIEW_DT"]) : 0,
                    //PIBS_SALE_VALUE = (dr.Table.Columns.Contains("PIBS_SALE_VALUE")) ? (dr["PIBS_SALE_VALUE"] == DBNull.Value) ? "" : dr.Field<string>("PIBS_SALE_VALUE") : "",
                    //RFI_REVIEW_BY = (dr.Table.Columns.Contains("RFI_REVIEW_BY")) ? (dr["RFI_REVIEW_BY"] == DBNull.Value) ? "" : dr.Field<string>("RFI_REVIEW_BY") : "",
                    //RFP_REVIEW_BY = (dr.Table.Columns.Contains("RFP_REVIEW_BY")) ? (dr["RFP_REVIEW_BY"] == DBNull.Value) ? "" : dr.Field<string>("RFP_REVIEW_BY") : "",
                    //DEAL_QUAL = (dr.Table.Columns.Contains("DEAL_QUAL")) ? (dr["DEAL_QUAL"] == DBNull.Value) ? "" : dr.Field<string>("DEAL_QUAL") : "",
                    //CRM_REASON = (dr.Table.Columns.Contains("CRM_REASON")) ? (dr["CRM_REASON"] == DBNull.Value) ? "" : dr.Field<string>("CRM_REASON") : "",
                    //DEAL_DISQUAL = (dr.Table.Columns.Contains("DEAL_DISQUAL")) ? (dr["DEAL_DISQUAL"] == DBNull.Value) ? "" : dr.Field<string>("DEAL_DISQUAL") : "",
                    //OPP_NGM = (dr.Table.Columns.Contains("OPP_NGM")) ? (dr["OPP_NGM"] == DBNull.Value) ? "" : dr.Field<string>("OPP_NGM") : "",
                    //BID_EXECUTIVE_EMPID = (dr.Table.Columns.Contains("BID_EXECUTIVE_EMPID")) ? (dr["BID_EXECUTIVE_EMPID"] == DBNull.Value) ? "" : dr.Field<string>("BID_EXECUTIVE_EMPID") : "",
                    //BID_EXECUTIVE_NAME = (dr.Table.Columns.Contains("BID_EXECUTIVE_NAME")) ? (dr["BID_EXECUTIVE_NAME"] == DBNull.Value) ? "" : dr.Field<string>("BID_EXECUTIVE_NAME") : "",
                    //KEY_DEAL_CEO = (dr.Table.Columns.Contains("KEY_DEAL_CEO")) ? (dr["KEY_DEAL_CEO"] == DBNull.Value) ? "" : dr.Field<string>("KEY_DEAL_CEO") : "",
                    //KEY_DEAL_REMARKS = (dr.Table.Columns.Contains("KEY_DEAL_REMARKS")) ? (dr["KEY_DEAL_REMARKS"] == DBNull.Value) ? "" : dr.Field<string>("KEY_DEAL_REMARKS") : "",
                    //ClusterId = (dr.Table.Columns.Contains("CLUSTER_ID")) ? (dr["CLUSTER_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CLUSTER_ID"]) : 0,
                    //BPS_SUB_SP_ID = (dr.Table.Columns.Contains("BPS_SUB_SP_ID")) ? (dr["BPS_SUB_SP_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["BPS_SUB_SP_ID"]) : 0,
                    //BPS_OFFERING_ID = (dr.Table.Columns.Contains("BPS_OFFERING_ID")) ? (dr["BPS_OFFERING_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["BPS_OFFERING_ID"]) : 0,
                    //SERVICE_ID = (dr.Table.Columns.Contains("SERVICE_ID")) ? (dr["SERVICE_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["SERVICE_ID"]) : 0,
                    //ANNUAL_SALE_VALUE = (dr.Table.Columns.Contains("ANNUAL_SALE_VALUE")) ? (dr["ANNUAL_SALE_VALUE"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["ANNUAL_SALE_VALUE"]) : 0,
                    //SUB_IOU = (dr.Table.Columns.Contains("SUB_IOU")) ? (dr["SUB_IOU"] == DBNull.Value) ? "" : dr.Field<string>("SUB_IOU") : "",
                    //EXECUTIVE_SPONSOR = (dr.Table.Columns.Contains("EXECUTIVE_SPONSOR")) ? (dr["EXECUTIVE_SPONSOR"] == DBNull.Value) ? "" : dr.Field<string>("EXECUTIVE_SPONSOR") : "",
                    //VALBPS_CON = (dr.Table.Columns.Contains("VALBPS_CON")) ? (dr["VALBPS_CON"] == DBNull.Value) ? "" : dr.Field<string>("VALBPS_CON") : "",
                    //PROACTIVE_PROPOSAL = (dr.Table.Columns.Contains("PROACTIVE_PROPOSAL")) ? (dr["PROACTIVE_PROPOSAL"] == DBNull.Value) ? "" : dr.Field<string>("PROACTIVE_PROPOSAL") : "",
                    //OPP_AGE = (dr.Table.Columns.Contains("OPP_AGE")) ? (dr["OPP_AGE"] == DBNull.Value) ? "" : dr.Field<string>("OPP_AGE") : "",
                    //ISU_MAIN = (dr.Table.Columns.Contains("ISU_MAIN")) ? (dr["ISU_MAIN"] == DBNull.Value) ? "" : dr.Field<string>("ISU_MAIN") : "",
                    //PLATFORM_OPTION = (dr.Table.Columns.Contains("PLATFORM_OPTION")) ? (dr["PLATFORM_OPTION"] == DBNull.Value) ? "" : dr.Field<string>("PLATFORM_OPTION") : "",
                    //KEY_CUST_EXP = (dr.Table.Columns.Contains("KEY_CUST_EXP")) ? (dr["KEY_CUST_EXP"] == DBNull.Value) ? "" : dr.Field<string>("KEY_CUST_EXP") : "",
                    //Quarter = (dr.Table.Columns.Contains("quarter")) ? (dr["quarter"] == DBNull.Value) ? "" : dr.Field<string>("quarter") : "",
                    //FISCAL_YEAR = (dr.Table.Columns.Contains("FISCAL_YEAR")) ? (dr["FISCAL_YEAR"] == DBNull.Value) ? "" : dr.Field<string>("FISCAL_YEAR") : "",
                    //PROPOSAL_FACTORY = (dr.Table.Columns.Contains("PROPOSAL_FACTORY")) ? (dr["PROPOSAL_FACTORY"] == DBNull.Value) ? "" : dr.Field<string>("PROPOSAL_FACTORY") : "",
                    //PROPOSAL_FACTORY_OPTIONS = (dr.Table.Columns.Contains("PROPOSAL_FACTORY_OPTIONS")) ? (dr["PROPOSAL_FACTORY_OPTIONS"] == DBNull.Value) ? "" : dr.Field<string>("PROPOSAL_FACTORY_OPTIONS") : "",
                    //PROPOSAL_FACTORY_COMMENTS = (dr.Table.Columns.Contains("PROPOSAL_FACTORY_COMMENTS")) ? (dr["PROPOSAL_FACTORY_COMMENTS"] == DBNull.Value) ? "" : dr.Field<string>("PROPOSAL_FACTORY_COMMENTS") : "",
                    //NoOf_TeamMemberPIBS = (dr.Table.Columns.Contains("NoOf_TeamMemberPIBS")) ? (dr["NoOf_TeamMemberPIBS"] == DBNull.Value) ? "" : dr.Field<string>("NoOf_TeamMemberPIBS") : "",
                    //DT_ID = (dr.Table.Columns.Contains("DT_ID")) ? (dr["DT_ID"] == DBNull.Value) ? "" : dr.Field<string>("DT_ID") : "",
                    //DT_NAME = (dr.Table.Columns.Contains("DT_NAME")) ? (dr["DT_NAME"] == DBNull.Value) ? "" : dr.Field<string>("DT_NAME") : "",
                    //Other_DT = (dr.Table.Columns.Contains("Other_DT")) ? (dr["Other_DT"] == DBNull.Value) ? "" : dr.Field<string>("Other_DT") : "",


                };
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
        }
        /// <summary>
        /// Save Stage3 Details
        /// </summary>
        public List<CreateNewOpportunity> Save_Stage3Opportunity(CreateNewOpportunity ObjCreateNewOpportunity)
        {
            List<CreateNewOpportunity> strResult = new List<CreateNewOpportunity>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Ins_Opportunity_stage3_sp);
                db.AddInParameter(cd, "@in_OpportunityId", SqlDbType.VarChar, ObjCreateNewOpportunity.OpportunityId);
                db.AddInParameter(cd, "@iv_OpportunityDesc", SqlDbType.VarChar, ObjCreateNewOpportunity.OPPORTUNITY_DESC);
                db.AddInParameter(cd, "@iv_OldOpportunityDesc", SqlDbType.VarChar, ObjCreateNewOpportunity.OLD_OPPORTUNITY_DESC);
                db.AddInParameter(cd, "@in_GeographyId", SqlDbType.Int, ObjCreateNewOpportunity.GEOGRAPHY_ID);
                db.AddInParameter(cd, "@in_CustId", SqlDbType.Int, ObjCreateNewOpportunity.CUST_ID);
                db.AddInParameter(cd, "@in_CustTypeId", SqlDbType.Int, ObjCreateNewOpportunity.CUST_TYPE_ID);
                db.AddInParameter(cd, "@in_IndustryPracticeId", SqlDbType.Int, ObjCreateNewOpportunity.INDUSTRY_PRACTICE_ID);
                db.AddInParameter(cd, "@in_StageId", SqlDbType.Int, ObjCreateNewOpportunity.StageID);
                db.AddInParameter(cd, "@iv_GeographySalesOwner", SqlDbType.VarChar, ObjCreateNewOpportunity.GeosalesOwner);
                db.AddInParameter(cd, "@iv_OffshorePracticeOwner", SqlDbType.VarChar, ObjCreateNewOpportunity.OffPracOwner);
                db.AddInParameter(cd, "@iv_RdCrd", SqlDbType.VarChar, ObjCreateNewOpportunity.RDCrd);
                db.AddInParameter(cd, "@iv_OffshoreBDLead", SqlDbType.VarChar, ObjCreateNewOpportunity.OffShoreBDLead);
                db.AddInParameter(cd, "@iv_OnsiteOwner", SqlDbType.VarChar, ObjCreateNewOpportunity.OnsiteOwner);
                db.AddInParameter(cd, "@in_ProbabilityOfwin", SqlDbType.Int, ObjCreateNewOpportunity.PROBABILITY_OF_WIN);
                db.AddInParameter(cd, "@in_ContractLength", SqlDbType.Int, ObjCreateNewOpportunity.ContractLength);
                db.AddInParameter(cd, "@in_FTE", SqlDbType.Int, ObjCreateNewOpportunity.FTE);
                db.AddInParameter(cd, "@in_RFIReceivedDt", SqlDbType.Int, ObjCreateNewOpportunity.RFIReceivedDate);
                db.AddInParameter(cd, "@in_RFIProbSubmissiondDt", SqlDbType.Int, ObjCreateNewOpportunity.RFIProbableSubmissionDate);
                db.AddInParameter(cd, "@in_RFIActSubmissiondDt", SqlDbType.Int, ObjCreateNewOpportunity.RFIActualSubmissionDate);
                db.AddInParameter(cd, "@iv_Remark", SqlDbType.VarChar, ObjCreateNewOpportunity.REMARK);
                db.AddInParameter(cd, "@in_OppDate", SqlDbType.Int, ObjCreateNewOpportunity.OppDate);
                db.AddInParameter(cd, "@iv_EmpNo", SqlDbType.VarChar, ObjCreateNewOpportunity.EmpNo);
                db.AddInParameter(cd, "@in_ClosureDate", SqlDbType.Int, ObjCreateNewOpportunity.ClosureDate);
                db.AddInParameter(cd, "@in_AdvisoryId", SqlDbType.Int, ObjCreateNewOpportunity.ADVISORY_ID);
                db.AddInParameter(cd, "@iv_Platform", SqlDbType.VarChar, ObjCreateNewOpportunity.PLATFORM);
                db.AddInParameter(cd, "@iv_NextStep", SqlDbType.VarChar, ObjCreateNewOpportunity.NextStep);
                db.AddInParameter(cd, "@in_BusinessId", SqlDbType.Int, ObjCreateNewOpportunity.BUSINESS_ID);
                db.AddInParameter(cd, "@in_ProductId", SqlDbType.Int, ObjCreateNewOpportunity.PRODUCT_ID);
                db.AddInParameter(cd, "@in_CompetencyId", SqlDbType.Int, ObjCreateNewOpportunity.COMPETENCY_ID);
                db.AddInParameter(cd, "@in_SubCompetencyId", SqlDbType.Int, ObjCreateNewOpportunity.SUB_COMPETENCY_ID);
                db.AddInParameter(cd, "@in_AnnualSaleValue", SqlDbType.Decimal, ObjCreateNewOpportunity.AnnualSaleValue);
                db.AddInParameter(cd, "@iv_AccountSalesOwner", SqlDbType.VarChar, ObjCreateNewOpportunity.AccountSalesOwner);
                db.AddInParameter(cd, "@iv_StatusUpdate", SqlDbType.VarChar, ObjCreateNewOpportunity.StatusUpdate);
                db.AddInParameter(cd, "@in_CategoryId", SqlDbType.Int, ObjCreateNewOpportunity.Category_Id);
                db.AddInParameter(cd, "@in_CountryId", SqlDbType.Int, ObjCreateNewOpportunity.CountryId);
                db.AddInParameter(cd, "@in_NextStepDueDt", SqlDbType.Int, ObjCreateNewOpportunity.NextStepDueDt);
                db.AddInParameter(cd, "@in_UnitID", SqlDbType.Int, ObjCreateNewOpportunity.UnitId);
                db.AddInParameter(cd, "@iv_ISUOwner", SqlDbType.VarChar, ObjCreateNewOpportunity.ISU_OWNER_ID);
                db.AddInParameter(cd, "@iv_ISU", SqlDbType.VarChar, ObjCreateNewOpportunity.ISU_CD);
                db.AddInParameter(cd, "@iv_PIBS", SqlDbType.VarChar, ObjCreateNewOpportunity.PIBS);
                db.AddInParameter(cd, "@iv_TCS_INVESTMENT", SqlDbType.VarChar, ObjCreateNewOpportunity.TCSInvestment);
                db.AddInParameter(cd, "@in_PIBStartDate", SqlDbType.Int, ObjCreateNewOpportunity.PIBStartDate);
                db.AddInParameter(cd, "@in_PIBEndDate", SqlDbType.Int, ObjCreateNewOpportunity.PIBSEndDate);
                db.AddInParameter(cd, "@in_NoOfFTEsEngaged", SqlDbType.Int, ObjCreateNewOpportunity.FTEsEngaged);
                db.AddInParameter(cd, "@in_PIBStatus", SqlDbType.Int, ObjCreateNewOpportunity.PIBStatus);
                db.AddInParameter(cd, "@in_PIBSOutcome", SqlDbType.Int, ObjCreateNewOpportunity.PIBS_OUTCOME_ID);
                db.AddInParameter(cd, "@iv_PIBStatusRemarks", SqlDbType.VarChar, ObjCreateNewOpportunity.PIBStatusRemarks);
                db.AddInParameter(cd, "@iv_FTEType", SqlDbType.VarChar, ObjCreateNewOpportunity.FTE_TYPE);
                db.AddInParameter(cd, "@in_FTETypeCount", SqlDbType.Int, FTE_TYPE_COUNT);
                db.AddInParameter(cd, "@in_BPODomain", SqlDbType.Int, ObjCreateNewOpportunity.BPODomain);
                db.AddInParameter(cd, "@iv_DomainPresalesLead", SqlDbType.VarChar, ObjCreateNewOpportunity.DOMAIN_PRESALES_LEAD);
                db.AddInParameter(cd, "@in_DealCategory", SqlDbType.Int, ObjCreateNewOpportunity.DealCategory);
                db.AddInParameter(cd, "@iv_DealCoachName", SqlDbType.VarChar, ObjCreateNewOpportunity.DealCoachName);
                db.AddInParameter(cd, "@in_DemandType", SqlDbType.Int, ObjCreateNewOpportunity.DemandType);
                db.AddInParameter(cd, "@iv_KeyDeal", SqlDbType.VarChar, ObjCreateNewOpportunity.KEY_DEAL);
                db.AddInParameter(cd, "@iv_ProposedSolution", SqlDbType.VarChar, ObjCreateNewOpportunity.ProposedSolution);
                db.AddInParameter(cd, "@iv_KeyRmk", SqlDbType.VarChar, ObjCreateNewOpportunity.KeyRmk);
                db.AddInParameter(cd, "@iv_WinningTeam", SqlDbType.VarChar, ObjCreateNewOpportunity.WinningTheme);
                db.AddInParameter(cd, "@iv_KeyCustExp", SqlDbType.VarChar, ObjCreateNewOpportunity.KeyCustExp);
                db.AddInParameter(cd, "@iv_OperatingModel", SqlDbType.VarChar, ObjCreateNewOpportunity.operatingModel);
                db.AddInParameter(cd, "@iv_PricingModel", SqlDbType.VarChar, ObjCreateNewOpportunity.PRICING_MODEL);
                db.AddInParameter(cd, "@iv_Differentiators", SqlDbType.VarChar, ObjCreateNewOpportunity.Differentiators);
                db.AddInParameter(cd, "@iv_Risks", SqlDbType.VarChar, ObjCreateNewOpportunity.Risks);
                db.AddInParameter(cd, "@iv_KeyCustomerConnects", SqlDbType.VarChar, ObjCreateNewOpportunity.KeyCustomerConnects);
                db.AddInParameter(cd, "@iv_BPOOfferingDescription", SqlDbType.VarChar, ObjCreateNewOpportunity.BPOOfferingDescription);
                db.AddInParameter(cd, "@iv_FirstTimeOutsource", SqlDbType.VarChar, ObjCreateNewOpportunity.chkFirstTimeOutsource);
                db.AddInParameter(cd, "@iv_Incumbents", SqlDbType.VarChar, ObjCreateNewOpportunity.INCUMBENTS);
                db.AddInParameter(cd, "@iv_NameOfIncumbents", SqlDbType.VarChar, ObjCreateNewOpportunity.NAME_OF_INCUMBENTS);
                db.AddInParameter(cd, "@iv_TCSOfferingCapability", SqlDbType.VarChar, ObjCreateNewOpportunity.TCS_OFFERING_CAPABILITY);
                db.AddInParameter(cd, "@iv_SpecifyOffering", SqlDbType.VarChar, ObjCreateNewOpportunity.SpecifyOffering);
                db.AddInParameter(cd, "@iv_CoachAvailable", SqlDbType.VarChar, ObjCreateNewOpportunity.CoachAvailable);
                db.AddInParameter(cd, "@iv_FnA", SqlDbType.VarChar, ObjCreateNewOpportunity.FnA);
                db.AddInParameter(cd, "@in_Fna_FTE", SqlDbType.Int, ObjCreateNewOpportunity.FnA_FTE);
                db.AddInParameter(cd, "@iv_HRO", SqlDbType.VarChar, ObjCreateNewOpportunity.HRO);
                db.AddInParameter(cd, "@in_HRO_FTE", SqlDbType.Int, ObjCreateNewOpportunity.HRO_FTE);
                db.AddInParameter(cd, "@iv_SCM", SqlDbType.VarChar, ObjCreateNewOpportunity.SCM);
                db.AddInParameter(cd, "@in_SCM_FTE", SqlDbType.Int, ObjCreateNewOpportunity.SCM_FTE);
                db.AddInParameter(cd, "@iv_KPO", SqlDbType.VarChar, ObjCreateNewOpportunity.KPO);
                db.AddInParameter(cd, "@in_KPO_FTE", SqlDbType.Int, ObjCreateNewOpportunity.KPO_FTE);
                db.AddInParameter(cd, "@iv_LPO", SqlDbType.VarChar, ObjCreateNewOpportunity.LPO);
                db.AddInParameter(cd, "@in_LPO_FTE", SqlDbType.Int, ObjCreateNewOpportunity.LPO_FTE);
                db.AddInParameter(cd, "@iv_Vertical", SqlDbType.VarChar, ObjCreateNewOpportunity.VERTICAL);
                db.AddInParameter(cd, "@in_Vertical_FTE", SqlDbType.Int, ObjCreateNewOpportunity.VerticalFTE);
                db.AddInParameter(cd, "@iv_Voice", SqlDbType.VarChar, ObjCreateNewOpportunity.Voice);
                db.AddInParameter(cd, "@in_Voice_FTE", SqlDbType.Int, ObjCreateNewOpportunity.VoiceFTE);
                db.AddInParameter(cd, "@iv_Bpm", SqlDbType.VarChar, ObjCreateNewOpportunity.BPM);
                db.AddInParameter(cd, "@in_Bpm_FTE", SqlDbType.Int, ObjCreateNewOpportunity.BPM_FTE);
                db.AddInParameter(cd, "@in_SolTM", SqlDbType.Int, ObjCreateNewOpportunity.SolTM);
                db.AddInParameter(cd, "@in_DelTM", SqlDbType.Int, ObjCreateNewOpportunity.DelTM);
                db.AddInParameter(cd, "@iv_BidManager", SqlDbType.VarChar, ObjCreateNewOpportunity.BID_MANAGER);
                db.AddInParameter(cd, "@iv_BidExec", SqlDbType.VarChar, ObjCreateNewOpportunity.BID_EXEC_OWNER);
                db.AddInParameter(cd, "@iv_PricingOwner", SqlDbType.VarChar, ObjCreateNewOpportunity.PRICING_OWNER);
                db.AddInParameter(cd, "@in_TransitionTeam", SqlDbType.Int, ObjCreateNewOpportunity.TransitionTeam);
                db.AddInParameter(cd, "@iv_ExpectedDate", SqlDbType.Int, ObjCreateNewOpportunity.ExpectedDate);
                db.AddInParameter(cd, "@iv_TransitionReq", SqlDbType.VarChar, ObjCreateNewOpportunity.TransitionReq);
                db.AddInParameter(cd, "@iv_Quarter", SqlDbType.VarChar, ObjCreateNewOpportunity.Quarter);
                db.AddInParameter(cd, "@iv_FiscalYear", SqlDbType.VarChar, ObjCreateNewOpportunity.FiscalYear);
                db.AddInParameter(cd, "@in_Seat_Requirements", SqlDbType.Int, ObjCreateNewOpportunity.SeatRequirements);
                db.AddInParameter(cd, "@iv_CurrentlyActive", SqlDbType.VarChar, ObjCreateNewOpportunity.CURRENTLY_ACTIVE);
                db.AddInParameter(cd, "@iv_ImmediateComment", SqlDbType.VarChar, ObjCreateNewOpportunity.ImmediateComment);
                db.AddInParameter(cd, "@iv_FTEDD", SqlDbType.VarChar, ObjCreateNewOpportunity.FTEDD);
                db.AddInParameter(cd, "@iv_SolutionLeader", SqlDbType.VarChar, ObjCreateNewOpportunity.SolutionLeader);
                db.AddInParameter(cd, "@iv_RUR", SqlDbType.VarChar, ObjCreateNewOpportunity.RUR);
                db.AddInParameter(cd, "@iv_HRT_Comments", SqlDbType.VarChar, ObjCreateNewOpportunity.HRTComments);
                db.AddInParameter(cd, "@iv_CRMId", SqlDbType.VarChar, ObjCreateNewOpportunity.CRM_ID);
                db.AddInParameter(cd, "@in_TCV", SqlDbType.VarChar, ObjCreateNewOpportunity.TCV);
                db.AddInParameter(cd, "@iv_ValueBPS", SqlDbType.VarChar, ObjCreateNewOpportunity.ValueBPS);
                db.AddInParameter(cd, "@in_ValueBPSTCV", SqlDbType.Decimal, ObjCreateNewOpportunity.ValueBPSTCV);
                db.AddInParameter(cd, "@iv_OppType", SqlDbType.VarChar, ObjCreateNewOpportunity.OPP_TYPE);
                db.AddInParameter(cd, "@iv_Fna_Lead", SqlDbType.VarChar, ObjCreateNewOpportunity.FnA_Lead);
                db.AddInParameter(cd, "@iv_HRO_Lead", SqlDbType.VarChar, ObjCreateNewOpportunity.HRO_Lead);
                db.AddInParameter(cd, "@iv_SCM_Lead", SqlDbType.VarChar, ObjCreateNewOpportunity.SCM_Lead);
                db.AddInParameter(cd, "@iv_KPO_Lead", SqlDbType.VarChar, ObjCreateNewOpportunity.KPO_Lead);
                db.AddInParameter(cd, "@iv_LPO_Lead", SqlDbType.VarChar, ObjCreateNewOpportunity.LPO_Lead);
                db.AddInParameter(cd, "@iv_Vertical_Lead", SqlDbType.VarChar, ObjCreateNewOpportunity.VERTICAL_LEAD);
                db.AddInParameter(cd, "@iv_Voice_Lead", SqlDbType.VarChar, ObjCreateNewOpportunity.Voice_Lead);
                db.AddInParameter(cd, "@iv_Bpm_Lead", SqlDbType.VarChar, ObjCreateNewOpportunity.BPM_LEAD);
                db.AddInParameter(cd, "@iv_MultiTower", SqlDbType.VarChar, ObjCreateNewOpportunity.MultiTower);
                db.AddInParameter(cd, "@in_StatusFlag", SqlDbType.Int, ObjCreateNewOpportunity.StatusFlag);
                db.AddInParameter(cd, "@iv_BidManagerId", SqlDbType.VarChar, ObjCreateNewOpportunity.BID_MANAGER_EMPID);
                db.AddInParameter(cd, "@iv_BidExecId", SqlDbType.VarChar, ObjCreateNewOpportunity.BID_EXEC_OWNER_EMPID);
                db.AddInParameter(cd, "@iv_PricingOwnerId", SqlDbType.VarChar, ObjCreateNewOpportunity.PRICING_OWNER_EMPID);
                db.AddInParameter(cd, "@iv_SolutionLeaderId", SqlDbType.VarChar, ObjCreateNewOpportunity.SolutionLeaderId);
                db.AddInParameter(cd, "@iv_FnaTCV", SqlDbType.VarChar, ObjCreateNewOpportunity.FnATCV);
                db.AddInParameter(cd, "@iv_HROTCV", SqlDbType.VarChar, ObjCreateNewOpportunity.HROTCV);
                db.AddInParameter(cd, "@iv_SCMTCV", SqlDbType.VarChar, ObjCreateNewOpportunity.SCMTCV);
                db.AddInParameter(cd, "@iv_KPOTCV", SqlDbType.VarChar, ObjCreateNewOpportunity.KPOTCV);
                db.AddInParameter(cd, "@iv_LPOTCV", SqlDbType.VarChar, ObjCreateNewOpportunity.LPOTCV);
                db.AddInParameter(cd, "@iv_VerticalTCV", SqlDbType.VarChar, ObjCreateNewOpportunity.VERTICALTCV);
                db.AddInParameter(cd, "@iv_VoiceTCV", SqlDbType.VarChar, ObjCreateNewOpportunity.VOICETCV);
                db.AddInParameter(cd, "@iv_BpmTCV", SqlDbType.VarChar, ObjCreateNewOpportunity.BPMTCV);
                db.AddInParameter(cd, "@in_RFIRwDt", SqlDbType.Int, ObjCreateNewOpportunity.RFI_REVIEW_DT);
                db.AddInParameter(cd, "@in_RFPRwDt", SqlDbType.Int, ObjCreateNewOpportunity.RFP_REVIEW_DT);
                db.AddInParameter(cd, "@iv_RFIBy", SqlDbType.VarChar, ObjCreateNewOpportunity.RFI_REVIEW_BY);
                db.AddInParameter(cd, "@iv_RFPBy", SqlDbType.VarChar, ObjCreateNewOpportunity.RFP_REVIEW_BY);
                db.AddInParameter(cd, "@iv_CRMReason", SqlDbType.VarChar, ObjCreateNewOpportunity.CRM_REASON);
                db.AddInParameter(cd, "@iv_NGM", SqlDbType.VarChar, ObjCreateNewOpportunity.OPP_NGM);
                db.AddInParameter(cd, "@iv_BidExeEmpId", SqlDbType.VarChar, ObjCreateNewOpportunity.BID_EXECUTIVE_EMPID);
                db.AddInParameter(cd, "@iv_Disqual", SqlDbType.VarChar, ObjCreateNewOpportunity.Disqual);
                db.AddInParameter(cd, "@iv_AddDeal", SqlDbType.VarChar, ObjCreateNewOpportunity.AddDeal);
                db.AddInParameter(cd, "@iv_BidExeName", SqlDbType.VarChar, ObjCreateNewOpportunity.BID_EXECUTIVE_NAME);
                db.AddInParameter(cd, "@iv_DealOwner", SqlDbType.VarChar, ObjCreateNewOpportunity.DealOwner);
                db.AddInParameter(cd, "@iv_DealOwner2", SqlDbType.VarChar, ObjCreateNewOpportunity.DealOwner2);
                db.AddInParameter(cd, "@in_PIBSTCV", SqlDbType.VarChar, ObjCreateNewOpportunity.PibsSaleValue);
                db.AddInParameter(cd, "@in_ClusterId", SqlDbType.Int, ObjCreateNewOpportunity.ClusterId);
                db.AddInParameter(cd, "@in_BPSSubSPID", SqlDbType.Int, ObjCreateNewOpportunity.BPSSubSPID);
                db.AddInParameter(cd, "@in_BPSOfferingID", SqlDbType.Int, ObjCreateNewOpportunity.BPSOfferingID);
                db.AddInParameter(cd, "@in_ServiceId", SqlDbType.Int, ObjCreateNewOpportunity.ServiceId);
                db.AddInParameter(cd, "@in_SUBIOU", SqlDbType.VarChar, ObjCreateNewOpportunity.SUBIOU);
                db.AddInParameter(cd, "@iv_ExeSponser", SqlDbType.VarChar, ObjCreateNewOpportunity.ExeSponser);
                db.AddInParameter(cd, "@iv_ValBPSCon", SqlDbType.VarChar, ObjCreateNewOpportunity.ValBPSCon);
                db.AddInParameter(cd, "@iv_ProactiveProposal", SqlDbType.VarChar, ObjCreateNewOpportunity.ProactiveProposal);
                db.AddInParameter(cd, "@iv_IsuMain", SqlDbType.VarChar, ObjCreateNewOpportunity.IsuMain);
                db.AddInParameter(cd, "@iv_PlatformNew", SqlDbType.VarChar, ObjCreateNewOpportunity.PlatformNew);
                db.AddInParameter(cd, "@in_strTransitionEmpId", SqlDbType.VarChar, ObjCreateNewOpportunity.TransitionEmpId);
                db.AddInParameter(cd, "@in_strTransitionName", SqlDbType.VarChar, ObjCreateNewOpportunity.TransitionName);
                db.AddInParameter(cd, "@in_strTransitionType", SqlDbType.VarChar, ObjCreateNewOpportunity.TransitionType);
                db.AddInParameter(cd, "@in_strTransitionApproach", SqlDbType.VarChar, ObjCreateNewOpportunity.TransitionApproach);
                db.AddInParameter(cd, "@in_strTransitionModel", SqlDbType.VarChar, ObjCreateNewOpportunity.TransitionModel);
                db.AddInParameter(cd, "@in_strProposalfactory", SqlDbType.VarChar, ObjCreateNewOpportunity.Proposalfactory);
                db.AddInParameter(cd, "@in_strProposalfactoryOptions", SqlDbType.VarChar, ObjCreateNewOpportunity.ProposalfactoryOptions);
                db.AddInParameter(cd, "@in_strProposalComments", SqlDbType.VarChar, ObjCreateNewOpportunity.ProposalComments);
                db.AddInParameter(cd, "@in_PricingTypeId", SqlDbType.Int, ObjCreateNewOpportunity.PRICING_TYPE_ID);
                db.AddInParameter(cd, "@iv_DTValue", SqlDbType.VarChar, ObjCreateNewOpportunity.DTValue);
                db.AddInParameter(cd, "@iv_OtherDT", SqlDbType.VarChar, ObjCreateNewOpportunity.Other_DT);
                db.AddInParameter(cd, "@in_CRMTCV", SqlDbType.VarChar, ObjCreateNewOpportunity.CRM_TCV);
                db.AddInParameter(cd, "@in_CRMStage", SqlDbType.Int, ObjCreateNewOpportunity.CRM_STAGE);
                db.AddInParameter(cd, "@in_CRMBeacon", SqlDbType.VarChar, ObjCreateNewOpportunity.CRM_Beacon);
                db.AddInParameter(cd, "@in_SubSP", SqlDbType.Int, ObjCreateNewOpportunity.subSPId);
                db.AddInParameter(cd, "@iv_DigitalTCV", SqlDbType.VarChar, ObjCreateNewOpportunity.strDigitalTcv);
                db.AddInParameter(cd, "@in_TGA", SqlDbType.VarChar, ObjCreateNewOpportunity.TataGroupAccount);
                db.AddInParameter(cd, "@in_TPA", SqlDbType.VarChar, ObjCreateNewOpportunity.TPA);
                db.AddInParameter(cd, "@in_TPA_Name", SqlDbType.VarChar, ObjCreateNewOpportunity.TPA_Name);
                db.AddInParameter(cd, "@in_ItisScope", SqlDbType.VarChar, ObjCreateNewOpportunity.ItisScope);
                db.AddInParameter(cd, "@in_IsContractRenewal", SqlDbType.VarChar, ObjCreateNewOpportunity.IsContractRenewal);
                db.AddInParameter(cd, "@in_ContractRenewalValue", SqlDbType.VarChar, ObjCreateNewOpportunity.ContractRenewalValue);
                db.AddOutParameter(cd, "@on_Result", SqlDbType.Int, Int16.MaxValue);
                //changes
                db.AddInParameter(cd, "@in_ResourcingId", SqlDbType.Int, ObjCreateNewOpportunity.RESOURCING_ID);
                db.AddInParameter(cd, "@in_Seat_IdentificationId", SqlDbType.Int, ObjCreateNewOpportunity.SEAT_IDENTIFICATION_ID);
                db.AddInParameter(cd, "@DealStatus_Id", SqlDbType.Int, ObjCreateNewOpportunity.DealStatus);
                db.AddInParameter(cd, "@ServicePractice_Id", SqlDbType.Int, ObjCreateNewOpportunity.ServicePractice);
                db.AddInParameter(cd, "@CoreOffering_Id", SqlDbType.Int, ObjCreateNewOpportunity.CoreOffering);
                db.AddInParameter(cd, "@in_modernisedOfferingId", SqlDbType.Int, ObjCreateNewOpportunity.ModernisedOffering);
                db.AddInParameter(cd, "@in_cognitiveSolutionId", SqlDbType.Int, ObjCreateNewOpportunity.CognitiveSolutions);
                db.AddInParameter(cd, "@in_offerings", SqlDbType.VarChar, ObjCreateNewOpportunity.Offerings);
                db.AddInParameter(cd, "@in_Opportunity_Desc_Details", SqlDbType.VarChar, ObjCreateNewOpportunity.OpportunityDescDetails);
                
                db.AddInParameter(cd, "@in_proposalSubmissionDate", SqlDbType.VarChar, ObjCreateNewOpportunity.PROPOSAL_SUBMISSION_DATE);
                db.AddInParameter(cd, "@in_salesStageMovedOnDate", SqlDbType.VarChar, ObjCreateNewOpportunity.SALES_STAGE_MOVED_ONDATE);

                db.AddInParameter(cd, "@iv_deliveryLocationProposed", SqlDbType.VarChar, ObjCreateNewOpportunity.DELIVERY_LOCATION_PROPOSED);
                db.AddInParameter(cd, "@CoreOfferingName_Id", SqlDbType.Int, ObjCreateNewOpportunity.CofID);
                db.AddInParameter(cd, "@in_OfferingId", SqlDbType.Int, ObjCreateNewOpportunity.offeringType);
                db.AddInParameter(cd, "@iv_IgnioTMscope", SqlDbType.VarChar, ObjCreateNewOpportunity.IgnioTMScope);
                db.AddInParameter(cd, "@iv_IgnioTMscopeDetail", SqlDbType.VarChar, ObjCreateNewOpportunity.IgnioTMScopeDetails);
                db.AddInParameter(cd, "@iv_DigitalFlagging", SqlDbType.VarChar, ObjCreateNewOpportunity.DigitalFlagging);
                db.AddInParameter(cd, "@cboioffering", SqlDbType.VarChar, ObjCreateNewOpportunity.Cboi_Offering_id);
                db.AddInParameter(cd, "@dealflag", SqlDbType.VarChar, ObjCreateNewOpportunity.Deal_Flag_id);
                //End
                db.ExecuteNonQuery(cd);
                on_Result = db.GetParameterValue(cd, "@on_Result").ToString();
                strResult.Add(new CreateNewOpportunity()
                {
                    on_Result = db.GetParameterValue(cd, "@on_Result").ToString()

                });
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
            return strResult;
        }      /// <summary>
               /// Save Stage4 Details
               /// </summary>
        public List<CreateNewOpportunity> Save_Stage4Opportunity(CreateNewOpportunity ObjCreateNewOpportunity)
        {
            List<CreateNewOpportunity> result = new List<CreateNewOpportunity>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Ins_Opportunity_stage4_sp);

                db.AddInParameter(cd, "@in_OpportunityId", SqlDbType.VarChar, ObjCreateNewOpportunity.OpportunityId);
                db.AddInParameter(cd, "@iv_OpportunityDesc", SqlDbType.VarChar, ObjCreateNewOpportunity.OPPORTUNITY_DESC);
                db.AddInParameter(cd, "@iv_OldOpportunityDesc", SqlDbType.VarChar, ObjCreateNewOpportunity.OLD_OPPORTUNITY_DESC);
                db.AddInParameter(cd, "@in_GeographyId", SqlDbType.Int, ObjCreateNewOpportunity.GEOGRAPHY_ID);
                db.AddInParameter(cd, "@in_CustId", SqlDbType.Int, ObjCreateNewOpportunity.CUST_ID);
                db.AddInParameter(cd, "@in_CustTypeId", SqlDbType.Int, ObjCreateNewOpportunity.CUST_TYPE_ID);
                db.AddInParameter(cd, "@in_IndustryPracticeId", SqlDbType.Int, ObjCreateNewOpportunity.INDUSTRY_PRACTICE_ID);
                db.AddInParameter(cd, "@in_StageId", SqlDbType.Int, ObjCreateNewOpportunity.StageID);
                db.AddInParameter(cd, "@iv_GeographySalesOwner", SqlDbType.VarChar, ObjCreateNewOpportunity.GeosalesOwner);
                db.AddInParameter(cd, "@iv_OffshorePracticeOwner", SqlDbType.VarChar, ObjCreateNewOpportunity.OffPracOwner);
                db.AddInParameter(cd, "@iv_RdCrd", SqlDbType.VarChar, ObjCreateNewOpportunity.RDCrd);
                db.AddInParameter(cd, "@iv_OffshoreBDLead", SqlDbType.VarChar, ObjCreateNewOpportunity.OffShoreBDLead);
                db.AddInParameter(cd, "@iv_OnsiteOwner", SqlDbType.VarChar, ObjCreateNewOpportunity.OnsiteOwner);
                db.AddInParameter(cd, "@in_ProbabilityOfwin", SqlDbType.Int, ObjCreateNewOpportunity.PROBABILITY_OF_WIN);
                db.AddInParameter(cd, "@in_CurencyId", SqlDbType.Int, ObjCreateNewOpportunity.CURRENCY_ID);
                db.AddInParameter(cd, "@in_TCV", SqlDbType.VarChar, ObjCreateNewOpportunity.TCV);
                db.AddInParameter(cd, "@in_ContractLength", SqlDbType.Int, ObjCreateNewOpportunity.ContractLength);
                db.AddInParameter(cd, "@in_FiscalRev", SqlDbType.Float, ObjCreateNewOpportunity.FiscRev);
                db.AddInParameter(cd, "@in_FTE", SqlDbType.Int, ObjCreateNewOpportunity.FTE);
                db.AddInParameter(cd, "@iv_Remark", SqlDbType.VarChar, ObjCreateNewOpportunity.REMARK);
                db.AddInParameter(cd, "@in_OppDate", SqlDbType.Int, ObjCreateNewOpportunity.OppDate);
                db.AddInParameter(cd, "@in_RFIReceivedDt", SqlDbType.Int, ObjCreateNewOpportunity.RFIReceivedDate);
                db.AddInParameter(cd, "@in_RFIProbSubmissiondDt", SqlDbType.Int, ObjCreateNewOpportunity.RFIProbableSubmissionDate);
                db.AddInParameter(cd, "@in_RFIActSubmissiondDt", SqlDbType.Int, ObjCreateNewOpportunity.RFIActualSubmissionDate);
                db.AddInParameter(cd, "@in_RFPReceivedDt", SqlDbType.Int, ObjCreateNewOpportunity.RFPReceivedDate);
                db.AddInParameter(cd, "@in_RFPProbSubmissiondDt", SqlDbType.Int, ObjCreateNewOpportunity.RFPProbableSubmissionDate);
                // db.AddInParameter(cd, "@in_RFPActSubmissionDt", SqlDbType.Int, ObjCreateNewOpportunity.RFPActualSubmissionDate);
                //db.AddInParameter(cd, "@in_ShortListDt", SqlDbType.VarChar, objCreateNewOpportunity.SHORTLIST_DT);
                //  db.AddInParameter(cd, "@in_ShortListDt", SqlDbType.VarChar, ObjCreateNewOpportunity.SHORTLIST_DT);
                ////// Need to check
                //   db.AddInParameter(cd, "@in_BCPDRPLocation", SqlDbType.VarChar, ObjCreateNewOpportunity.BCP_DRP_LOCATION);
                db.AddInParameter(cd, "@iv_EmpNo", SqlDbType.VarChar, ObjCreateNewOpportunity.EmpNo);
                db.AddInParameter(cd, "@in_ClosureDate", SqlDbType.Int, ObjCreateNewOpportunity.ClosureDate);
                db.AddInParameter(cd, "@in_Comp1", SqlDbType.Int, ObjCreateNewOpportunity.COMPETITOR_1);
                db.AddInParameter(cd, "@in_Comp2", SqlDbType.Int, ObjCreateNewOpportunity.COMPETITOR_2);
                db.AddInParameter(cd, "@in_Comp3", SqlDbType.Int, ObjCreateNewOpportunity.COMPETITOR_3);
                db.AddInParameter(cd, "@in_Comp4", SqlDbType.Int, ObjCreateNewOpportunity.COMPETITOR_4);
                db.AddInParameter(cd, "@in_Comp5", SqlDbType.Int, ObjCreateNewOpportunity.COMPETITOR_5);
                db.AddInParameter(cd, "@in_AdvisoryId", SqlDbType.Int, ObjCreateNewOpportunity.ADVISORY_ID);
                db.AddInParameter(cd, "@iv_Platform", SqlDbType.VarChar, ObjCreateNewOpportunity.PLATFORM);
                db.AddInParameter(cd, "@iv_NextStep", SqlDbType.VarChar, ObjCreateNewOpportunity.NextStep);
                db.AddInParameter(cd, "@in_BusinessId", SqlDbType.Int, ObjCreateNewOpportunity.BUSINESS_ID);
                db.AddInParameter(cd, "@in_ProductId", SqlDbType.Int, ObjCreateNewOpportunity.PRODUCT_ID);
                db.AddInParameter(cd, "@in_CompetencyId", SqlDbType.Int, ObjCreateNewOpportunity.COMPETENCY_ID);
                db.AddInParameter(cd, "@in_SubCompetencyId", SqlDbType.Int, ObjCreateNewOpportunity.SUB_COMPETENCY_ID);
                db.AddInParameter(cd, "@in_AnnualSaleValue", SqlDbType.Decimal, ObjCreateNewOpportunity.AnnualSaleValue);
                db.AddInParameter(cd, "@iv_AccountSalesOwner", SqlDbType.VarChar, ObjCreateNewOpportunity.AccountSalesOwner);
                db.AddInParameter(cd, "@iv_StatusUpdate", SqlDbType.VarChar, ObjCreateNewOpportunity.StatusUpdate);
                db.AddInParameter(cd, "@in_CategoryId", SqlDbType.Int, ObjCreateNewOpportunity.Category_Id);
                db.AddInParameter(cd, "@in_CountryId", SqlDbType.Int, ObjCreateNewOpportunity.CountryId);
                db.AddInParameter(cd, "@in_NextStepDueDt", SqlDbType.Int, ObjCreateNewOpportunity.NextStepDueDt);
                db.AddInParameter(cd, "@in_OffFTE", SqlDbType.Int, ObjCreateNewOpportunity.FTEOff);
                db.AddInParameter(cd, "@in_OnFTE", SqlDbType.Int, ObjCreateNewOpportunity.FTEOn);
                db.AddInParameter(cd, "@in_UnitID", SqlDbType.Int, ObjCreateNewOpportunity.UnitId);
                db.AddInParameter(cd, "@iv_ISUOwner", SqlDbType.VarChar, ObjCreateNewOpportunity.ISU_OWNER_ID);
                db.AddInParameter(cd, "@iv_ISU", SqlDbType.VarChar, ObjCreateNewOpportunity.ISU_CD);
                db.AddInParameter(cd, "@iv_PIBS", SqlDbType.VarChar, ObjCreateNewOpportunity.PIBS);
                db.AddInParameter(cd, "@iv_TCS_INVESTMENT", SqlDbType.VarChar, ObjCreateNewOpportunity.TCSInvestment);
                db.AddInParameter(cd, "@in_PIBStartDate", SqlDbType.Int, ObjCreateNewOpportunity.PIBStartDate);
                db.AddInParameter(cd, "@in_PIBEndDate", SqlDbType.Int, ObjCreateNewOpportunity.PIBSEndDate);
                db.AddInParameter(cd, "@in_NoOfFTEsEngaged", SqlDbType.Int, ObjCreateNewOpportunity.FTEsEngaged);
                db.AddInParameter(cd, "@in_PIBStatus", SqlDbType.Int, ObjCreateNewOpportunity.PIBStatus);
                db.AddInParameter(cd, "@in_PIBSOutcome", SqlDbType.Int, ObjCreateNewOpportunity.PIBS_OUTCOME_ID);
                db.AddInParameter(cd, "@iv_PIBStatusRemarks", SqlDbType.VarChar, ObjCreateNewOpportunity.PIBStatusRemarks);
                // db.AddInParameter(cd, "@iv_FTEType", SqlDbType.VarChar, ObjCreateNewOpportunity.chkVariousFTEs);
                db.AddInParameter(cd, "@iv_FTEType", SqlDbType.VarChar, ObjCreateNewOpportunity.FTE_TYPE);
                db.AddInParameter(cd, "@in_FTETypeCount", SqlDbType.Int, FTE_TYPE_COUNT);
                db.AddInParameter(cd, "@in_BPODomain", SqlDbType.Int, ObjCreateNewOpportunity.BPODomain);
                db.AddInParameter(cd, "@iv_DomainPresalesLead", SqlDbType.VarChar, ObjCreateNewOpportunity.DOMAIN_PRESALES_LEAD);
                db.AddInParameter(cd, "@in_DealCategory", SqlDbType.Int, ObjCreateNewOpportunity.DealCategory);
                db.AddInParameter(cd, "@iv_DealCoachName", SqlDbType.VarChar, ObjCreateNewOpportunity.DealCoachName);
                db.AddInParameter(cd, "@in_DemandType", SqlDbType.Int, ObjCreateNewOpportunity.DemandType);
                db.AddInParameter(cd, "@iv_KeyDeal", SqlDbType.VarChar, ObjCreateNewOpportunity.KEY_DEAL);
                db.AddInParameter(cd, "@iv_ProposedSolution", SqlDbType.VarChar, ObjCreateNewOpportunity.ProposedSolution);
                db.AddInParameter(cd, "@iv_KeyRmk", SqlDbType.VarChar, ObjCreateNewOpportunity.KeyRmk);
                db.AddInParameter(cd, "@iv_WinningTeam", SqlDbType.VarChar, ObjCreateNewOpportunity.WinningTheme);
                db.AddInParameter(cd, "@iv_KeyCustExp", SqlDbType.VarChar, ObjCreateNewOpportunity.KeyCustExp);
                db.AddInParameter(cd, "@iv_OperatingModel", SqlDbType.VarChar, ObjCreateNewOpportunity.operatingModel);
                db.AddInParameter(cd, "@iv_PricingModel", SqlDbType.VarChar, ObjCreateNewOpportunity.PRICING_MODEL);
                db.AddInParameter(cd, "@iv_Differentiators", SqlDbType.VarChar, ObjCreateNewOpportunity.Differentiators);
                db.AddInParameter(cd, "@iv_Risks", SqlDbType.VarChar, ObjCreateNewOpportunity.Risks);
                db.AddInParameter(cd, "@iv_KeyCustomerConnects", SqlDbType.VarChar, ObjCreateNewOpportunity.KeyCustomerConnects);
                db.AddInParameter(cd, "@iv_BPOOfferingDescription", SqlDbType.VarChar, ObjCreateNewOpportunity.BPOOfferingDescription);
                db.AddInParameter(cd, "@iv_FirstTimeOutsource", SqlDbType.VarChar, ObjCreateNewOpportunity.chkFirstTimeOutsource);
                db.AddInParameter(cd, "@iv_Incumbents", SqlDbType.VarChar, ObjCreateNewOpportunity.INCUMBENTS);
                db.AddInParameter(cd, "@iv_NameOfIncumbents", SqlDbType.VarChar, ObjCreateNewOpportunity.NAME_OF_INCUMBENTS);
                db.AddInParameter(cd, "@iv_TCSOfferingCapability", SqlDbType.VarChar, ObjCreateNewOpportunity.TCS_OFFERING_CAPABILITY);
                db.AddInParameter(cd, "@iv_SpecifyOffering", SqlDbType.VarChar, ObjCreateNewOpportunity.SpecifyOffering);
                db.AddInParameter(cd, "@iv_CoachAvailable", SqlDbType.VarChar, ObjCreateNewOpportunity.CoachAvailable);
                db.AddInParameter(cd, "@iv_FnA", SqlDbType.VarChar, ObjCreateNewOpportunity.FnA);
                db.AddInParameter(cd, "@in_Fna_FTE", SqlDbType.Int, ObjCreateNewOpportunity.FnA_FTE);
                db.AddInParameter(cd, "@iv_HRO", SqlDbType.VarChar, ObjCreateNewOpportunity.HRO);
                db.AddInParameter(cd, "@in_HRO_FTE", SqlDbType.Int, ObjCreateNewOpportunity.HRO_FTE);
                db.AddInParameter(cd, "@iv_SCM", SqlDbType.VarChar, ObjCreateNewOpportunity.SCM);
                db.AddInParameter(cd, "@in_SCM_FTE", SqlDbType.Int, ObjCreateNewOpportunity.SCM_FTE);
                db.AddInParameter(cd, "@iv_KPO", SqlDbType.VarChar, ObjCreateNewOpportunity.KPO);
                db.AddInParameter(cd, "@in_KPO_FTE", SqlDbType.Int, ObjCreateNewOpportunity.KPO_FTE);
                db.AddInParameter(cd, "@iv_LPO", SqlDbType.VarChar, ObjCreateNewOpportunity.LPO);
                db.AddInParameter(cd, "@in_LPO_FTE", SqlDbType.Int, ObjCreateNewOpportunity.LPO_FTE);
                db.AddInParameter(cd, "@iv_Vertical", SqlDbType.VarChar, ObjCreateNewOpportunity.VERTICAL);
                db.AddInParameter(cd, "@in_Vertical_FTE", SqlDbType.Int, ObjCreateNewOpportunity.VerticalFTE);
                db.AddInParameter(cd, "@iv_Voice", SqlDbType.VarChar, ObjCreateNewOpportunity.Voice);
                db.AddInParameter(cd, "@in_Voice_FTE", SqlDbType.Int, ObjCreateNewOpportunity.VoiceFTE);
                db.AddInParameter(cd, "@iv_Bpm", SqlDbType.VarChar, ObjCreateNewOpportunity.BPM);
                db.AddInParameter(cd, "@in_Bpm_FTE", SqlDbType.Int, ObjCreateNewOpportunity.BPM_FTE);
                db.AddInParameter(cd, "@in_Seat_Requirements", SqlDbType.Int, ObjCreateNewOpportunity.SeatRequirements);
                db.AddInParameter(cd, "@iv_Entity", SqlDbType.VarChar, ObjCreateNewOpportunity.ENTITY);
                db.AddInParameter(cd, "@in_SolTM", SqlDbType.Int, ObjCreateNewOpportunity.SolTM);
                db.AddInParameter(cd, "@in_DelTM", SqlDbType.Int, ObjCreateNewOpportunity.DelTM);
                db.AddInParameter(cd, "@iv_BidManager", SqlDbType.VarChar, ObjCreateNewOpportunity.BID_MANAGER);
                db.AddInParameter(cd, "@iv_BidExec", SqlDbType.VarChar, ObjCreateNewOpportunity.BID_EXEC_OWNER);
                db.AddInParameter(cd, "@iv_PricingOwner", SqlDbType.VarChar, ObjCreateNewOpportunity.PRICING_OWNER);
                db.AddInParameter(cd, "@in_TransitionTeam", SqlDbType.Int, ObjCreateNewOpportunity.TransitionTeam);
                db.AddInParameter(cd, "@iv_ExpectedDate", SqlDbType.VarChar, ObjCreateNewOpportunity.ExpectedDate);
                db.AddInParameter(cd, "@iv_TransitionReq", SqlDbType.Int, ObjCreateNewOpportunity.TransitionReq);
                db.AddInParameter(cd, "@iv_Quarter", SqlDbType.VarChar, ObjCreateNewOpportunity.Quarter);
                db.AddInParameter(cd, "@iv_FiscalYear", SqlDbType.VarChar, ObjCreateNewOpportunity.FiscalYear);
                db.AddInParameter(cd, "@iv_CurrentlyActive", SqlDbType.VarChar, ObjCreateNewOpportunity.CURRENTLY_ACTIVE);
                db.AddInParameter(cd, "@iv_ImmediateComment", SqlDbType.VarChar, ObjCreateNewOpportunity.ImmediateComment);
                db.AddInParameter(cd, "@iv_FTEDD", SqlDbType.VarChar, ObjCreateNewOpportunity.FTEDD);
                db.AddInParameter(cd, "@iv_SolutionLeader", SqlDbType.VarChar, ObjCreateNewOpportunity.SolutionLeader);
                db.AddInParameter(cd, "@iv_RUR", SqlDbType.VarChar, ObjCreateNewOpportunity.RUR);
                db.AddInParameter(cd, "@iv_HRT_Comments", SqlDbType.VarChar, ObjCreateNewOpportunity.HRTComments);
                db.AddInParameter(cd, "@iv_CRMId", SqlDbType.VarChar, ObjCreateNewOpportunity.CRM_ID);
                db.AddInParameter(cd, "@iv_ValueBPS", SqlDbType.VarChar, ObjCreateNewOpportunity.ValueBPS);
                db.AddInParameter(cd, "@in_ValueBPSTCV", SqlDbType.Decimal, ObjCreateNewOpportunity.ValueBPSTCV);
                db.AddInParameter(cd, "@iv_OppType", SqlDbType.VarChar, ObjCreateNewOpportunity.OPP_TYPE);
                db.AddInParameter(cd, "@iv_Fna_Lead", SqlDbType.VarChar, ObjCreateNewOpportunity.FnA_Lead);
                db.AddInParameter(cd, "@iv_HRO_Lead", SqlDbType.VarChar, ObjCreateNewOpportunity.HRO_Lead);
                db.AddInParameter(cd, "@iv_SCM_Lead", SqlDbType.VarChar, ObjCreateNewOpportunity.SCM_Lead);
                db.AddInParameter(cd, "@iv_KPO_Lead", SqlDbType.VarChar, ObjCreateNewOpportunity.KPO_Lead);
                db.AddInParameter(cd, "@iv_LPO_Lead", SqlDbType.VarChar, ObjCreateNewOpportunity.LPO_Lead);
                db.AddInParameter(cd, "@iv_Vertical_Lead", SqlDbType.VarChar, ObjCreateNewOpportunity.VERTICAL_LEAD);
                db.AddInParameter(cd, "@iv_Voice_Lead", SqlDbType.VarChar, ObjCreateNewOpportunity.Voice_Lead);
                db.AddInParameter(cd, "@iv_Bpm_Lead", SqlDbType.VarChar, ObjCreateNewOpportunity.BPM_LEAD);
                db.AddInParameter(cd, "@iv_MultiTower", SqlDbType.VarChar, ObjCreateNewOpportunity.MultiTower);
                db.AddInParameter(cd, "@in_StatusFlag", SqlDbType.Int, ObjCreateNewOpportunity.StatusFlag);
                db.AddInParameter(cd, "@iv_BidManagerId", SqlDbType.VarChar, ObjCreateNewOpportunity.BID_MANAGER_EMPID);
                db.AddInParameter(cd, "@iv_BidExecId", SqlDbType.VarChar, ObjCreateNewOpportunity.BID_EXEC_OWNER_EMPID);
                db.AddInParameter(cd, "@iv_PricingOwnerId", SqlDbType.VarChar, ObjCreateNewOpportunity.PRICING_OWNER_EMPID);
                db.AddInParameter(cd, "@iv_SolutionLeaderId", SqlDbType.VarChar, ObjCreateNewOpportunity.SolutionLeaderId);
                //db.AddInParameter(cd, "@in_OperationWindow", SqlDbType.VarChar, ObjCreateNewOpportunity.OPERATION_WINDOW);
                //db.AddInParameter(cd, "@in_Area", SqlDbType.VarChar, ObjCreateNewOpportunity.AREA);
                //db.AddInParameter(cd, "@in_TypesOfSeat", SqlDbType.VarChar, ObjCreateNewOpportunity.TYPES_OF_SEAT);
                //db.AddInParameter(cd, "@in_PCsRequired", SqlDbType.VarChar, ObjCreateNewOpportunity.PCS_REQUIRED);
                //db.AddInParameter(cd, "@in_DesksRequired", SqlDbType.VarChar, ObjCreateNewOpportunity.DESKS_REQUIRED);
                //db.AddInParameter(cd, "@in_PhonesRequired", SqlDbType.VarChar, ObjCreateNewOpportunity.PHONES_REQUIRED);
                //db.AddInParameter(cd, "@in_CabinsRequired", SqlDbType.VarChar, ObjCreateNewOpportunity.CABINS_REQUIRED);
                //db.AddInParameter(cd, "@in_LaptopsRequired", SqlDbType.VarChar, ObjCreateNewOpportunity.LAPTOPS_REQUIRED);
                db.AddInParameter(cd, "@iv_FnaTCV", SqlDbType.VarChar, ObjCreateNewOpportunity.FnATCV);
                db.AddInParameter(cd, "@iv_HROTCV", SqlDbType.VarChar, ObjCreateNewOpportunity.HROTCV);
                db.AddInParameter(cd, "@iv_SCMTCV", SqlDbType.VarChar, ObjCreateNewOpportunity.SCMTCV);
                db.AddInParameter(cd, "@iv_KPOTCV", SqlDbType.VarChar, ObjCreateNewOpportunity.KPOTCV);
                db.AddInParameter(cd, "@iv_LPOTCV", SqlDbType.VarChar, ObjCreateNewOpportunity.LPOTCV);
                db.AddInParameter(cd, "@iv_VerticalTCV", SqlDbType.VarChar, ObjCreateNewOpportunity.VERTICALTCV);
                db.AddInParameter(cd, "@iv_VoiceTCV", SqlDbType.VarChar, ObjCreateNewOpportunity.VOICETCV);
                db.AddInParameter(cd, "@iv_BpmTCV", SqlDbType.VarChar, ObjCreateNewOpportunity.BPMTCV);
                db.AddInParameter(cd, "@in_RFIRwDt", SqlDbType.Int, ObjCreateNewOpportunity.RFI_REVIEW_DT);
                db.AddInParameter(cd, "@in_RFPRwDt", SqlDbType.Int, ObjCreateNewOpportunity.RFP_REVIEW_DT);
                db.AddInParameter(cd, "@iv_RFIBy", SqlDbType.VarChar, ObjCreateNewOpportunity.RFI_REVIEW_BY);
                db.AddInParameter(cd, "@iv_RFPBy", SqlDbType.VarChar, ObjCreateNewOpportunity.RFP_REVIEW_BY);
                db.AddInParameter(cd, "@iv_NGM", SqlDbType.VarChar, ObjCreateNewOpportunity.OPP_NGM);
                db.AddInParameter(cd, "@iv_CRMReason", SqlDbType.VarChar, ObjCreateNewOpportunity.CRM_REASON);
                db.AddInParameter(cd, "@iv_BidExeEmpId", SqlDbType.VarChar, ObjCreateNewOpportunity.BID_EXECUTIVE_EMPID);
                db.AddInParameter(cd, "@iv_Disqual", SqlDbType.VarChar, ObjCreateNewOpportunity.Disqual);
                db.AddInParameter(cd, "@iv_AddDeal", SqlDbType.VarChar, ObjCreateNewOpportunity.AddDeal);
                db.AddInParameter(cd, "@iv_BidExeName", SqlDbType.VarChar, ObjCreateNewOpportunity.BID_EXECUTIVE_NAME);
                db.AddInParameter(cd, "@iv_DealOwner", SqlDbType.VarChar, ObjCreateNewOpportunity.DealOwner);
                db.AddInParameter(cd, "@iv_DealOwner2", SqlDbType.VarChar, ObjCreateNewOpportunity.DealOwner2);
                db.AddInParameter(cd, "@in_PIBSTCV", SqlDbType.VarChar, ObjCreateNewOpportunity.PibsSaleValue);
                db.AddInParameter(cd, "@in_ClusterId", SqlDbType.Int, ObjCreateNewOpportunity.ClusterId);
                db.AddInParameter(cd, "@in_BPSSubSPID", SqlDbType.Int, ObjCreateNewOpportunity.BPSSubSPID);
                db.AddInParameter(cd, "@in_BPSOfferingID", SqlDbType.Int, ObjCreateNewOpportunity.BPSOfferingID);
                db.AddInParameter(cd, "@in_ServiceId", SqlDbType.Int, ObjCreateNewOpportunity.ServiceId);
                db.AddInParameter(cd, "@in_SUBIOU", SqlDbType.VarChar, ObjCreateNewOpportunity.SUBIOU);
                db.AddInParameter(cd, "@iv_ExeSponser", SqlDbType.VarChar, ObjCreateNewOpportunity.ExeSponser);
                db.AddInParameter(cd, "@iv_ValBPSCon", SqlDbType.VarChar, ObjCreateNewOpportunity.ValBPSCon);
                db.AddInParameter(cd, "@iv_ProactiveProposal", SqlDbType.VarChar, ObjCreateNewOpportunity.ProactiveProposal);
                db.AddInParameter(cd, "@iv_IsuMain", SqlDbType.VarChar, ObjCreateNewOpportunity.IsuMain);
                db.AddInParameter(cd, "@iv_PlatformNew", SqlDbType.VarChar, ObjCreateNewOpportunity.PlatformNew);
                db.AddInParameter(cd, "@in_strTransitionEmpId", SqlDbType.VarChar, ObjCreateNewOpportunity.TransitionEmpId);
                db.AddInParameter(cd, "@in_strTransitionName", SqlDbType.VarChar, ObjCreateNewOpportunity.TransitionName);
                db.AddInParameter(cd, "@in_strTransitionType", SqlDbType.VarChar, ObjCreateNewOpportunity.TransitionType);
                db.AddInParameter(cd, "@in_strTransitionApproach", SqlDbType.VarChar, ObjCreateNewOpportunity.TransitionApproach);
                db.AddInParameter(cd, "@in_strTransitionModel", SqlDbType.VarChar, ObjCreateNewOpportunity.TransitionModel);
                db.AddInParameter(cd, "@in_strProposalfactory", SqlDbType.VarChar, ObjCreateNewOpportunity.Proposalfactory);
                db.AddInParameter(cd, "@in_strProposalfactoryOptions", SqlDbType.VarChar, ObjCreateNewOpportunity.ProposalfactoryOptions);
                db.AddInParameter(cd, "@in_strProposalComments", SqlDbType.VarChar, ObjCreateNewOpportunity.ProposalComments);
                db.AddInParameter(cd, "@in_PricingTypeId", SqlDbType.Int, ObjCreateNewOpportunity.PRICING_TYPE_ID);
                db.AddInParameter(cd, "@iv_DTValue", SqlDbType.VarChar, ObjCreateNewOpportunity.DTValue);
                db.AddInParameter(cd, "@iv_OtherDT", SqlDbType.VarChar, ObjCreateNewOpportunity.Other_DT);
                db.AddInParameter(cd, "@in_CRMTCV", SqlDbType.VarChar, ObjCreateNewOpportunity.CRM_TCV);                
                db.AddInParameter(cd, "@in_CRMStage", SqlDbType.Int, ObjCreateNewOpportunity.CRM_STAGE);
                db.AddInParameter(cd, "@in_CRMBeacon", SqlDbType.VarChar, ObjCreateNewOpportunity.CRM_Beacon);
                db.AddInParameter(cd, "@iv_DigitalTCV", SqlDbType.VarChar, ObjCreateNewOpportunity.strDigitalTcv);
                db.AddInParameter(cd, "@in_SubSP", SqlDbType.Int, ObjCreateNewOpportunity.subSPId);
                db.AddInParameter(cd, "@in_TGA", SqlDbType.VarChar, ObjCreateNewOpportunity.TataGroupAccount);
                db.AddInParameter(cd, "@in_TPA", SqlDbType.VarChar, ObjCreateNewOpportunity.TPA);
                db.AddInParameter(cd, "@in_TPA_Name", SqlDbType.VarChar, ObjCreateNewOpportunity.TPA_Name);
                db.AddInParameter(cd, "@in_ItisScope", SqlDbType.VarChar, ObjCreateNewOpportunity.ItisScope);
                db.AddInParameter(cd, "@in_IsContractRenewal", SqlDbType.VarChar, ObjCreateNewOpportunity.IsContractRenewal);
                db.AddInParameter(cd, "@in_ContractRenewalValue", SqlDbType.VarChar, ObjCreateNewOpportunity.ContractRenewalValue);
                db.AddInParameter(cd, "@in_ResourcingId", SqlDbType.Int, ObjCreateNewOpportunity.RESOURCING_ID);
                db.AddInParameter(cd, "@in_Seat_IdentificationId", SqlDbType.Int, ObjCreateNewOpportunity.SEAT_IDENTIFICATION_ID);
                db.AddInParameter(cd, "@DealStatus_Id", SqlDbType.Int, ObjCreateNewOpportunity.DealStatus);
                db.AddInParameter(cd, "@ServicePractice_Id", SqlDbType.Int, ObjCreateNewOpportunity.ServicePractice);
                db.AddInParameter(cd, "@CoreOffering_Id", SqlDbType.Int, ObjCreateNewOpportunity.CoreOffering);
                db.AddInParameter(cd, "@in_modernisedOfferingId", SqlDbType.Int, ObjCreateNewOpportunity.ModernisedOffering);
                db.AddInParameter(cd, "@in_cognitiveSolutionId", SqlDbType.Int, ObjCreateNewOpportunity.CognitiveSolutions);
                db.AddInParameter(cd, "@in_offerings", SqlDbType.VarChar, ObjCreateNewOpportunity.Offerings);
                db.AddInParameter(cd, "@in_Opportunity_Desc_Details", SqlDbType.VarChar, ObjCreateNewOpportunity.OpportunityDescDetails);

                db.AddInParameter(cd, "@in_proposalSubmissionDate", SqlDbType.VarChar, ObjCreateNewOpportunity.PROPOSAL_SUBMISSION_DATE);
                db.AddInParameter(cd, "@in_salesStageMovedOnDate", SqlDbType.VarChar, ObjCreateNewOpportunity.SALES_STAGE_MOVED_ONDATE);

                db.AddInParameter(cd, "@iv_deliveryLocationProposed", SqlDbType.VarChar, ObjCreateNewOpportunity.DELIVERY_LOCATION_PROPOSED);

                db.AddInParameter(cd, "@OfferingType_Id", SqlDbType.Int, ObjCreateNewOpportunity.offeringType);
                db.AddInParameter(cd, "@CoreOfferingName_Id", SqlDbType.Int, ObjCreateNewOpportunity.CofID);
                db.AddInParameter(cd, "@iv_IgnioTMscope", SqlDbType.VarChar, ObjCreateNewOpportunity.IgnioTMScope);
                db.AddInParameter(cd, "@iv_IgnioTMscopeDetail", SqlDbType.VarChar, ObjCreateNewOpportunity.IgnioTMScopeDetails);
                db.AddInParameter(cd, "@iv_DigitalFlagging", SqlDbType.VarChar, ObjCreateNewOpportunity.DigitalFlagging);
                db.AddInParameter(cd, "@cboioffering", SqlDbType.VarChar, ObjCreateNewOpportunity.Cboi_Offering_id);
                db.AddInParameter(cd, "@dealflag", SqlDbType.VarChar, ObjCreateNewOpportunity.Deal_Flag_id);

                db.AddOutParameter(cd, "@on_Result", SqlDbType.Int, Int16.MaxValue);
                db.ExecuteNonQuery(cd);
                on_Result = db.GetParameterValue(cd, "@on_Result").ToString();
                result.Add(new CreateNewOpportunity()
                {
                    on_Result = (db.GetParameterValue(cd, "@on_Result")).ToString()
                });
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
            return result;
        }







        /// <summary>
        /// Get Stage6 Details
        /// </summary>
        public List<CreateNewOpportunity> GetOpportunityStage6(string opportunityId, int stageId)
        {
            DataSet ds = null;
            List<CreateNewOpportunity> modelList = new List<CreateNewOpportunity>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.GetOpportunityStage6);
                db.AddInParameter(cd, "@in_OpportunityId", SqlDbType.VarChar, opportunityId);
                db.AddInParameter(cd, "@in_StageId", SqlDbType.Int, stageId);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;

                        for (int i = 0; i < rowCount; i++)
                        {
                            modelList.Add(MapStage6(ds.Tables[0].Rows[i]));
                        }

                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }
            return modelList;
        }
        private static CreateNewOpportunity MapStage6(DataRow dr)
        {
            try
            {
                return new CreateNewOpportunity()
                {

                    OpportunityId = (dr.Table.Columns.Contains("OPPORTUNITY_ID")) ? (dr["OPPORTUNITY_ID"] == DBNull.Value) ? "" : Convert.ToString(dr["OPPORTUNITY_ID"]) : "",
                    OPPORTUNITY_DESC = (dr.Table.Columns.Contains("OPPORTUNITY_DESC")) ? (dr["OPPORTUNITY_DESC"] == DBNull.Value) ? "" : dr.Field<string>("OPPORTUNITY_DESC") : "",
                    OLD_OPPORTUNITY_DESC = (dr.Table.Columns.Contains("OLD_OPPORTUNITY_DESC")) ? (dr["OLD_OPPORTUNITY_DESC"] == DBNull.Value) ? "" : dr.Field<string>("OLD_OPPORTUNITY_DESC") : "",
                    GEOGRAPHY_ID = (dr.Table.Columns.Contains("GEOGRAPHY_ID")) ? (dr["GEOGRAPHY_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["GEOGRAPHY_ID"]) : 0,
                    GEOGRAPHY_NAME = (dr.Table.Columns.Contains("GEOGRAPHY_NAME")) ? (dr["GEOGRAPHY_NAME"] == DBNull.Value) ? "" : dr.Field<string>("GEOGRAPHY_NAME") : "",
                    CUST_ID = (dr.Table.Columns.Contains("CUST_ID")) ? (dr["CUST_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CUST_ID"]) : 0,
                    CUST_NAME = (dr.Table.Columns.Contains("CUST_NAME")) ? (dr["CUST_NAME"] == DBNull.Value) ? "" : dr.Field<string>("CUST_NAME") : "",
                    CUST_TYPE_ID = (dr.Table.Columns.Contains("CUST_TYPE_ID")) ? (dr["CUST_TYPE_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CUST_TYPE_ID"]) : 0,
                    CUST_TYPE_NAME = (dr.Table.Columns.Contains("CUST_TYPE_NAME")) ? (dr["CUST_TYPE_NAME"] == DBNull.Value) ? "" : dr.Field<string>("CUST_TYPE_NAME") : "",
                    INDUSTRY_PRACTICE_ID = (dr.Table.Columns.Contains("INDUSTRY_PRACTICE_ID")) ? (dr["INDUSTRY_PRACTICE_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["INDUSTRY_PRACTICE_ID"]) : 0,
                    StageID = (dr.Table.Columns.Contains("STAGE_ID")) ? (dr["STAGE_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["STAGE_ID"]) : 0,
                    INDUSTRY_PRACTICE_NAME = (dr.Table.Columns.Contains("INDUSTRY_PRACTICE_NAME")) ? (dr["INDUSTRY_PRACTICE_NAME"] == DBNull.Value) ? "" : dr.Field<string>("INDUSTRY_PRACTICE_NAME") : "",
                    STAGE_NAME = (dr.Table.Columns.Contains("STAGE_NAME")) ? (dr["STAGE_NAME"] == DBNull.Value) ? "" : dr.Field<string>("STAGE_NAME") : "",
                    ISU_CD = (dr.Table.Columns.Contains("ISU_CD")) ? (dr["ISU_CD"] == DBNull.Value) ? "" : dr.Field<string>("ISU_CD") : "",
                    ISU_NAME = (dr.Table.Columns.Contains("ISU_NAME")) ? (dr["ISU_NAME"] == DBNull.Value) ? "" : dr.Field<string>("ISU_NAME") : "",
                    GEOGRAPHY_SALES_OWNER = (dr.Table.Columns.Contains("GEOGRAPHY_SALES_OWNER_ID")) ? (dr["GEOGRAPHY_SALES_OWNER_ID"] == DBNull.Value) ? "" : dr.Field<string>("GEOGRAPHY_SALES_OWNER_ID") : "",
                    ONSITE_OWNER = (dr.Table.Columns.Contains("ONSITE_OWNER_ID")) ? (dr["ONSITE_OWNER_ID"] == DBNull.Value) ? "" : dr.Field<string>("ONSITE_OWNER_ID") : "",
                    OFFSHORE_BD_LEAD = (dr.Table.Columns.Contains("OFFSHORE_BD_LEAD_ID")) ? (dr["OFFSHORE_BD_LEAD_ID"] == DBNull.Value) ? "" : dr.Field<string>("OFFSHORE_BD_LEAD_ID") : "",
                    OPPORTUNITY_DATE = (dr.Table.Columns.Contains("OPPORTUNITY_DATE")) ? (dr["OPPORTUNITY_DATE"] == DBNull.Value) ? "" : dr.Field<string>("OPPORTUNITY_DATE") : "",
                    RFIApprovedBy = (dr.Table.Columns.Contains("RFI_APPROVED_BY")) ? (dr["RFI_APPROVED_BY"] == DBNull.Value) ? "" : Convert.ToString(dr["RFI_APPROVED_BY"]) : "",
                    RFPApprovedBy = (dr.Table.Columns.Contains("RFP_APPROVED_BY")) ? (dr["RFP_APPROVED_BY"] == DBNull.Value) ? "" : Convert.ToString(dr["RFP_APPROVED_BY"]) : "",
                    ContractLength = (dr.Table.Columns.Contains("CONTRACT_LENGTH")) ? (dr["CONTRACT_LENGTH"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CONTRACT_LENGTH"]) : 0,
                    SHORTLIST_DT = (dr.Table.Columns.Contains("SHORTLIST_DT")) ? (dr["SHORTLIST_DT"] == DBNull.Value) ? "" : Convert.ToString(dr["SHORTLIST_DT"]) : "",
                    CURRENT_FISCAL_REVENUE = (dr.Table.Columns.Contains("CURRENT_FISCAL_REVENUE")) ? (dr["CURRENT_FISCAL_REVENUE"] == DBNull.Value) ? "" : dr.Field<string>("CURRENT_FISCAL_REVENUE") : "",
                    CURRENCY_ID = (dr.Table.Columns.Contains("CURRENCY_ID")) ? (dr["CURRENCY_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CURRENCY_ID"]) : 0,
                    TOTAL_CONTRACT_VALUE = (dr.Table.Columns.Contains("TOTAL_CONTRACT_VALUE")) ? (dr["TOTAL_CONTRACT_VALUE"] == DBNull.Value) ? 0 : Convert.ToDouble(dr["TOTAL_CONTRACT_VALUE"]) : 0,
                    BCP_DRP_LOCATION = (dr.Table.Columns.Contains("BCP_DRP_LOCATION")) ? (dr["BCP_DRP_LOCATION"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["BCP_DRP_LOCATION"]) : 0,
                    DAYS_IN_THIS_STAGE = (dr.Table.Columns.Contains("DAYS_IN_THIS_STAGE")) ? (dr["DAYS_IN_THIS_STAGE"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["DAYS_IN_THIS_STAGE"]) : 0,
                    DEAL_CLOSURE_EXP_DATE = (dr.Table.Columns.Contains("DEAL_CLOSURE_EXP_DATE")) ? (dr["DEAL_CLOSURE_EXP_DATE"] == DBNull.Value) ? "" : dr.Field<string>("DEAL_CLOSURE_EXP_DATE") : "",
                    DTOTAL_CONTRACT_VALUE = (dr.Table.Columns.Contains("TOTAL_CONTRACT_VALUE")) ? (dr["TOTAL_CONTRACT_VALUE"] == DBNull.Value) ? 0 : Convert.ToDouble(dr["TOTAL_CONTRACT_VALUE"]) : 0,
                    BUSINESS_ID = (dr.Table.Columns.Contains("BUSINESS_ID")) ? (dr["BUSINESS_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["BUSINESS_ID"]) : 0,
                    COUNTRY_ID = (dr.Table.Columns.Contains("COUNTRY_ID")) ? (dr["COUNTRY_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["COUNTRY_ID"]) : 0,
                    PIBS = (dr.Table.Columns.Contains("PIBS")) ? (dr["PIBS"] == DBNull.Value) ? "" : dr.Field<string>("PIBS") : "",
                    CRM_ID = (dr.Table.Columns.Contains("CRM_ID")) ? (dr["CRM_ID"] == DBNull.Value) ? "" : dr.Field<string>("CRM_ID") : "",
                    VALUE_BPS = (dr.Table.Columns.Contains("VALUE_BPS")) ? (dr["VALUE_BPS"] == DBNull.Value) ? "" : dr.Field<string>("VALUE_BPS") : "",
                    VALUE_BPS_TCV = (dr.Table.Columns.Contains("VALUE_BPS_TCV")) ? (dr["VALUE_BPS_TCV"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["VALUE_BPS_TCV"]) : 0,
                    OPP_TYPE = (dr.Table.Columns.Contains("OPP_TYPE")) ? (dr["OPP_TYPE"] == DBNull.Value) ? "" : dr.Field<string>("OPP_TYPE") : "",
                    IESTIMATED_FTE_SIZE = (dr.Table.Columns.Contains("ESTIMATED_FTE_SIZE")) ? (dr["ESTIMATED_FTE_SIZE"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["ESTIMATED_FTE_SIZE"]) : 0,
                    ISU_OWNER_ID = (dr.Table.Columns.Contains("ISU_OWNER_ID")) ? (dr["ISU_OWNER_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["ISU_OWNER_ID"]) : 0,
                    ACCOUNT_SALES_OWNER_ID = (dr.Table.Columns.Contains("ACCOUNT_SALES_OWNER_ID")) ? (dr["ACCOUNT_SALES_OWNER_ID"] == DBNull.Value) ? "" : dr.Field<string>("ACCOUNT_SALES_OWNER_ID") : "",
                    GEOGRAPHY_SALES_OWNER_ID = (dr.Table.Columns.Contains("GEOGRAPHY_SALES_OWNER_ID")) ? (dr["GEOGRAPHY_SALES_OWNER_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["GEOGRAPHY_SALES_OWNER_ID"]) : 0,
                    OFFSHORE_BD_LEAD_ID = (dr.Table.Columns.Contains("OFFSHORE_BD_LEAD_ID")) ? (dr["OFFSHORE_BD_LEAD_ID"] == DBNull.Value) ? "" : dr.Field<string>("OFFSHORE_BD_LEAD_ID") : "",
                    LAST_UPDATE = (dr.Table.Columns.Contains("LAST_UPDATE")) ? (dr["LAST_UPDATE"] == DBNull.Value) ? "" : dr.Field<string>("LAST_UPDATE") : "",
                    DEAL_BD_LEAD_ID = (dr.Table.Columns.Contains("DEAL_BD_LEAD_ID")) ? (dr["DEAL_BD_LEAD_ID"] == DBNull.Value) ? "" : dr.Field<string>("DEAL_BD_LEAD_ID") : "",
                    DEAL_BD_LEAD_ID2 = (dr.Table.Columns.Contains("DEAL_BD_LEAD_ID2")) ? (dr["DEAL_BD_LEAD_ID2"] == DBNull.Value) ? "" : dr.Field<string>("DEAL_BD_LEAD_ID2") : "",
                    RFI_ReviewDate = (dr.Table.Columns.Contains("RFI_REVIEW_DT")) ? (dr["RFI_REVIEW_DT"] == DBNull.Value) ? "" : dr.Field<string>("RFI_REVIEW_DT") : "",
                    RFP_ReviewDate = (dr.Table.Columns.Contains("RFP_REVIEW_DT")) ? (dr["RFP_REVIEW_DT"] == DBNull.Value) ? "" : dr.Field<string>("RFP_REVIEW_DT") : "",
                    RFI_ReceivedDate = (dr.Table.Columns.Contains("RFI_RECEIVED_DT")) ? (dr["RFI_RECEIVED_DT"] == DBNull.Value) ? "" : dr.Field<string>("RFI_RECEIVED_DT") : "",
                    RFP_ReceivedDate = (dr.Table.Columns.Contains("RFP_RECEIVED_DT")) ? (dr["RFP_RECEIVED_DT"] == DBNull.Value) ? "" : dr.Field<string>("RFP_RECEIVED_DT") : "",
                    RFI_ProbableSubmissionDate = (dr.Table.Columns.Contains("RFI_PROBABLE_SUBMISSION_DT")) ? (dr["RFI_PROBABLE_SUBMISSION_DT"] == DBNull.Value) ? "" : dr.Field<string>("RFI_PROBABLE_SUBMISSION_DT") : "",
                    RFP_ProbableSubmissionDate = (dr.Table.Columns.Contains("RFP_PROBABLE_SUBMISSION_DT")) ? (dr["RFP_PROBABLE_SUBMISSION_DT"] == DBNull.Value) ? "" : dr.Field<string>("RFP_PROBABLE_SUBMISSION_DT") : "",
                    RFI_ActualSubmissionDate = (dr.Table.Columns.Contains("RFI_ACTUAL_SUBMISSION_DT")) ? (dr["RFI_ACTUAL_SUBMISSION_DT"] == DBNull.Value) ? "" : dr.Field<string>("RFI_ACTUAL_SUBMISSION_DT") : "",
                    RFP_ActualSubmissionDate = (dr.Table.Columns.Contains("RFP_ACTUAL_SUBMISSION_DT")) ? (dr["RFP_ACTUAL_SUBMISSION_DT"] == DBNull.Value) ? "" : dr.Field<string>("RFP_ACTUAL_SUBMISSION_DT") : "",
                    RFI_REVIEW_BY = (dr.Table.Columns.Contains("RFI_REVIEW_BY")) ? (dr["RFI_REVIEW_BY"] == DBNull.Value) ? "" : dr.Field<string>("RFI_REVIEW_BY") : "",
                    RFP_REVIEW_BY = (dr.Table.Columns.Contains("RFP_REVIEW_BY")) ? (dr["RFP_REVIEW_BY"] == DBNull.Value) ? "" : dr.Field<string>("RFP_REVIEW_BY") : "",
                    FTEOff = (dr.Table.Columns.Contains("FTE_OFFSHORE")) ? (dr["FTE_OFFSHORE"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["FTE_OFFSHORE"]) : 0,
                    FTEOn = (dr.Table.Columns.Contains("FTE_ONSITE")) ? (dr["FTE_ONSITE"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["FTE_ONSITE"]) : 0,
                    ClusterId = (dr.Table.Columns.Contains("CLUSTER_ID")) ? (dr["CLUSTER_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CLUSTER_ID"]) : 0,
                    DealCategory = (dr.Table.Columns.Contains("DEAL_CATEGORY")) ? (dr["DEAL_CATEGORY"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["DEAL_CATEGORY"]) : 0,
                    BPS_OFFERING_ID = (dr.Table.Columns.Contains("BPS_OFFERING_ID")) ? (dr["BPS_OFFERING_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["BPS_OFFERING_ID"]) : 0,
                    SERVICE_ID = (dr.Table.Columns.Contains("SERVICE_ID")) ? (dr["SERVICE_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["SERVICE_ID"]) : 0,
                    SUB_IOU = (dr.Table.Columns.Contains("SUB_IOU")) ? (dr["SUB_IOU"] == DBNull.Value) ? "" : dr.Field<string>("SUB_IOU") : "",
                    EXECUTIVE_SPONSOR = (dr.Table.Columns.Contains("EXECUTIVE_SPONSOR")) ? (dr["EXECUTIVE_SPONSOR"] == DBNull.Value) ? "" : dr.Field<string>("EXECUTIVE_SPONSOR") : "",
                    VALBPS_CON = (dr.Table.Columns.Contains("VALBPS_CON")) ? (dr["VALBPS_CON"] == DBNull.Value) ? "" : dr.Field<string>("VALBPS_CON") : "",
                    PROACTIVE_PROPOSAL = (dr.Table.Columns.Contains("PROACTIVE_PROPOSAL")) ? (dr["PROACTIVE_PROPOSAL"] == DBNull.Value) ? "" : dr.Field<string>("PROACTIVE_PROPOSAL") : "",
                    ISU_MAIN = (dr.Table.Columns.Contains("ISU_MAIN")) ? (dr["ISU_MAIN"] == DBNull.Value) ? "" : dr.Field<string>("ISU_MAIN") : "",
                    Quarter = (dr.Table.Columns.Contains("quarter")) ? (dr["quarter"] == DBNull.Value) ? "" : dr.Field<string>("quarter") : "",
                    FISCAL_YEAR = (dr.Table.Columns.Contains("FISCAL_YEAR")) ? (dr["FISCAL_YEAR"] == DBNull.Value) ? "" : dr.Field<string>("FISCAL_YEAR") : "",
                    PROPOSAL_FACTORY = (dr.Table.Columns.Contains("PROPOSAL_FACTORY")) ? (dr["PROPOSAL_FACTORY"] == DBNull.Value) ? "" : dr.Field<string>("PROPOSAL_FACTORY") : "",
                    PROPOSAL_FACTORY_OPTIONS = (dr.Table.Columns.Contains("PROPOSAL_FACTORY_OPTIONS")) ? (dr["PROPOSAL_FACTORY_OPTIONS"] == DBNull.Value) ? "" : dr.Field<string>("PROPOSAL_FACTORY_OPTIONS") : "",
                    PROPOSAL_FACTORY_COMMENTS = (dr.Table.Columns.Contains("PROPOSAL_FACTORY_COMMENTS")) ? (dr["PROPOSAL_FACTORY_COMMENTS"] == DBNull.Value) ? "" : dr.Field<string>("PROPOSAL_FACTORY_COMMENTS") : "",
                    DT_ID = (dr.Table.Columns.Contains("DT_ID")) ? (dr["DT_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["DT_ID"]) : 0,
                    Other_DT = (dr.Table.Columns.Contains("Other_DT")) ? (dr["Other_DT"] == DBNull.Value) ? "" : dr.Field<string>("Other_DT") : "",
                    CRM_TCV = (dr.Table.Columns.Contains("CRM_TCV")) ? (dr["CRM_TCV"] == DBNull.Value) ? "" : Convert.ToString(dr["CRM_TCV"]) : "",
                    CRM_STAGE = (dr.Table.Columns.Contains("CRM_STAGE")) ? (dr["CRM_STAGE"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CRM_STAGE"]) : 0,
                    strDigitalTcv = (dr.Table.Columns.Contains("Digital_TCV")) ? (dr["Digital_TCV"] == DBNull.Value) ? "" : dr.Field<string>("Digital_TCV") : "",
                    subSPId = (dr.Table.Columns.Contains("SubSPID")) ? (dr["SubSPID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["SubSPID"]) : 0,
                    CRM_Beacon = (dr.Table.Columns.Contains("CRM_Beacon")) ? (dr["CRM_Beacon"] == DBNull.Value) ? "" : Convert.ToString(dr["CRM_Beacon"]) : "",
                    MULTITOWER_DEAL = (dr.Table.Columns.Contains("MULTITOWER_DEAL")) ? (dr["MULTITOWER_DEAL"] == DBNull.Value) ? "" : dr.Field<string>("MULTITOWER_DEAL") : "",

                    TataGroupAccount = (dr.Table.Columns.Contains("TATA_GROUP_ACCOUNT")) ? (dr["TATA_GROUP_ACCOUNT"] == DBNull.Value) ? "" : Convert.ToString(dr["TATA_GROUP_ACCOUNT"]) : "",
                    ItisScope = (dr.Table.Columns.Contains("ItisScope")) ? (dr["ItisScope"] == DBNull.Value) ? "" : Convert.ToString(dr["ItisScope"]) : "",
                    IsContractRenewal = (dr.Table.Columns.Contains("IsContractRenewal")) ? (dr["IsContractRenewal"] == DBNull.Value) ? "" : Convert.ToString(dr["IsContractRenewal"]) : "",
                    ContractRenewalValue = (dr.Table.Columns.Contains("ContractRenewalValue")) ? (dr["ContractRenewalValue"] == DBNull.Value) ? "" : Convert.ToString(dr["ContractRenewalValue"]) : "",
                    //changess
                    RESOURCING_ID = (dr.Table.Columns.Contains("ResourcingId")) ? (dr["ResourcingId"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["ResourcingId"]) : 0,
                    SEAT_IDENTIFICATION_ID = (dr.Table.Columns.Contains("Seat_IdentificationId")) ? (dr["Seat_IdentificationId"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["Seat_IdentificationId"]) : 0,
                    //End

                    ENTITY = (dr.Table.Columns.Contains("ENTITY")) ? (dr["ENTITY"] == DBNull.Value) ? "" : dr.Field<string>("ENTITY") : "",
                    FIRST_TIME_OUTSOURCE = (dr.Table.Columns.Contains("FIRST_TIME_OUTSOURCE")) ? (dr["FIRST_TIME_OUTSOURCE"] == DBNull.Value) ? "" : dr.Field<string>("FIRST_TIME_OUTSOURCE") : "",
                    INCUMBENTS = (dr.Table.Columns.Contains("INCUMBENTS")) ? (dr["INCUMBENTS"] == DBNull.Value) ? "" : dr.Field<string>("INCUMBENTS") : "",
                    ADVISORY_ID = (dr.Table.Columns.Contains("ADVISORY_ID")) ? (dr["ADVISORY_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["ADVISORY_ID"]) : 0,
                    DealStatus = (dr.Table.Columns.Contains("DealStatus_Id")) ? (dr["DealStatus_Id"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["DealStatus_Id"]) : 0,
                    ServicePractice = (dr.Table.Columns.Contains("ServicePractice_Id")) ? (dr["ServicePractice_Id"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["ServicePractice_Id"]) : 0,
                    CoreOffering = (dr.Table.Columns.Contains("CoreOffering_Id")) ? (dr["CoreOffering_Id"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CoreOffering_Id"]) : 0,
                    OpportunityDescDetails = (dr.Table.Columns.Contains("Opportunity_Desc_Details")) ? (dr["Opportunity_Desc_Details"] == DBNull.Value) ? "" : dr.Field<string>("Opportunity_Desc_Details") : "",

                    PROPOSAL_SUBMISSION_DATE = (dr.Table.Columns.Contains("PROPOSAL_SUBMISSION_DATE")) ? (dr["PROPOSAL_SUBMISSION_DATE"] == DBNull.Value) ? "" : dr.Field<string>("PROPOSAL_SUBMISSION_DATE") : "",
                    SALES_STAGE_MOVED_ONDATE = (dr.Table.Columns.Contains("SALES_STAGE_MOVED_ON_DATE")) ? (dr["SALES_STAGE_MOVED_ON_DATE"] == DBNull.Value) ? "" : dr.Field<string>("SALES_STAGE_MOVED_ON_DATE") : "",

                    Previous_Deal_Stage = (dr.Table.Columns.Contains("Previous_Deal_Stage")) ? (dr["Previous_Deal_Stage"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["Previous_Deal_Stage"]) : 0,

                    DELIVERY_LOCATION_PROPOSED = (dr.Table.Columns.Contains("DELIVERY_LOCATION_PROPOSED")) ? (dr["DELIVERY_LOCATION_PROPOSED"] == DBNull.Value) ? "" : dr.Field<string>("DELIVERY_LOCATION_PROPOSED") : "",
                    offeringType = (dr.Table.Columns.Contains("OfferingType_Id")) ? (dr["OfferingType_Id"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["OfferingType_Id"]) : 0,
                    CofID = (dr.Table.Columns.Contains("CoreOfferingName_Id")) ? (dr["CoreOfferingName_Id"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CoreOfferingName_Id"]) : 0,

                    DigitalFlagging = (dr.Table.Columns.Contains("Digital_Flagging")) ? (dr["Digital_Flagging"] == DBNull.Value) ? "" : Convert.ToString(dr["Digital_Flagging"]) : "",
                    Cboi_Offering_id = (dr.Table.Columns.Contains("cboi_offering_id")) ? (dr["cboi_offering_id"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["cboi_offering_id"]) : 0,
                    Deal_Flag_id = (dr.Table.Columns.Contains("deal_flag")) ? (dr["deal_flag"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["deal_flag"]) : 0,
                    PLATFORM = (dr.Table.Columns.Contains("PLATFORM")) ? (dr["PLATFORM"] == DBNull.Value) ? "" : dr.Field<string>("PLATFORM") : "",
                    PLATFORM_OPTION = (dr.Table.Columns.Contains("PLATFORM_OPTION")) ? (dr["PLATFORM_OPTION"] == DBNull.Value) ? "" : dr.Field<string>("PLATFORM_OPTION") : "",




                };
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
        }

        public List<CreateNewOpportunity> Get_WinReason(string oppid)
        {
            List<CreateNewOpportunity> strResult = new List<CreateNewOpportunity>();
            try
            {

                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.InsertOpportunitystage6);

                db.AddInParameter(cd, "@in_OpportunityId", SqlDbType.VarChar, oppid);
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
            return strResult;
        }
        /// <summary>
        /// Save Stage6 Details
        /// </summary>
        public List<CreateNewOpportunity> InsertOpportunitystage6(CreateNewOpportunity objCreateNewOpportunity)
        {
            List<CreateNewOpportunity> strResult = new List<CreateNewOpportunity>();
            try
            {
                
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.InsertOpportunitystage6);

                db.AddInParameter(cd, "@in_OpportunityId", SqlDbType.VarChar, objCreateNewOpportunity.OpportunityId);
                db.AddInParameter(cd, "@iv_OpportunityDesc", SqlDbType.VarChar, objCreateNewOpportunity.OPPORTUNITY_DESC);
                db.AddInParameter(cd, "@iv_OldOpportunityDesc", SqlDbType.VarChar, objCreateNewOpportunity.OLD_OPPORTUNITY_DESC);
                db.AddInParameter(cd, "@in_GeographyId", SqlDbType.Int, objCreateNewOpportunity.GEOGRAPHY_ID);
                db.AddInParameter(cd, "@in_CustId", SqlDbType.Int, objCreateNewOpportunity.CUST_ID);
                db.AddInParameter(cd, "@in_CustTypeId", SqlDbType.Int, objCreateNewOpportunity.CUST_TYPE_ID);
                db.AddInParameter(cd, "@in_IndustryPracticeId", SqlDbType.Int, objCreateNewOpportunity.INDUSTRY_PRACTICE_ID);
                db.AddInParameter(cd, "@in_StageId", SqlDbType.Int, objCreateNewOpportunity.StageID);
                db.AddInParameter(cd, "@iv_GeographySalesOwner", SqlDbType.VarChar, objCreateNewOpportunity.GeosalesOwner);
                db.AddInParameter(cd, "@iv_OffshorePracticeOwner", SqlDbType.VarChar, objCreateNewOpportunity.OffPracOwner);
                db.AddInParameter(cd, "@iv_RdCrd", SqlDbType.VarChar, objCreateNewOpportunity.RDCrd);
                db.AddInParameter(cd, "@iv_OffshoreBDLead", SqlDbType.VarChar, objCreateNewOpportunity.OffShoreBDLead);
                db.AddInParameter(cd, "@iv_OnsiteOwner", SqlDbType.VarChar, objCreateNewOpportunity.OnsiteOwner);
                db.AddInParameter(cd, "@in_ProbabilityOfwin", SqlDbType.Int, objCreateNewOpportunity.PROBABILITY_OF_WIN);
                db.AddInParameter(cd, "@in_CurencyId", SqlDbType.Int, objCreateNewOpportunity.CURRENCY_ID);
                db.AddInParameter(cd, "@in_TCV", SqlDbType.VarChar, objCreateNewOpportunity.TCV);
                db.AddInParameter(cd, "@in_ContractLength", SqlDbType.Int, objCreateNewOpportunity.ContractLength);
                db.AddInParameter(cd, "@in_FiscalRev", SqlDbType.Float, objCreateNewOpportunity.FiscRev);
                db.AddInParameter(cd, "@in_FTE", SqlDbType.Int, objCreateNewOpportunity.FTE);
                db.AddInParameter(cd, "@iv_Remark", SqlDbType.VarChar, objCreateNewOpportunity.REMARK);
                db.AddInParameter(cd, "@in_OppDate", SqlDbType.Int, objCreateNewOpportunity.OppDate);
                db.AddInParameter(cd, "@in_RFIReceivedDt", SqlDbType.Int, objCreateNewOpportunity.RFIReceivedDate);
                db.AddInParameter(cd, "@in_RFIProbSubmissiondDt", SqlDbType.Int, objCreateNewOpportunity.RFIProbableSubmissionDate);
                db.AddInParameter(cd, "@in_RFIActSubmissiondDt", SqlDbType.Int, objCreateNewOpportunity.RFIActualSubmissionDate);
                db.AddInParameter(cd, "@in_RFPReceivedDt", SqlDbType.Int, objCreateNewOpportunity.RFPReceivedDate);
                db.AddInParameter(cd, "@in_RFPProbSubmissiondDt", SqlDbType.Int, objCreateNewOpportunity.RFPProbableSubmissionDate);
                db.AddInParameter(cd, "@in_RFPActSubmissionDt", SqlDbType.Int, objCreateNewOpportunity.RFPActualSubmissionDate);
                db.AddInParameter(cd, "@in_BCPDRPLocation", SqlDbType.Int, objCreateNewOpportunity.BCP_DRP_LOCATION);
                db.AddInParameter(cd, "@iv_EmpNo", SqlDbType.VarChar, objCreateNewOpportunity.EmpNo);
                db.AddInParameter(cd, "@in_ClosureDate", SqlDbType.Int, objCreateNewOpportunity.ClosureDate);
                db.AddInParameter(cd, "@in_RFIRwDt", SqlDbType.Int, objCreateNewOpportunity.RFI_REVIEW_DT);
                db.AddInParameter(cd, "@in_RFPRwDt", SqlDbType.Int, objCreateNewOpportunity.RFP_REVIEW_DT);
                db.AddInParameter(cd, "@iv_RFIBy", SqlDbType.VarChar, objCreateNewOpportunity.RFI_REVIEW_BY);
                db.AddInParameter(cd, "@iv_RFPBy", SqlDbType.VarChar, objCreateNewOpportunity.RFP_REVIEW_BY);
                db.AddInParameter(cd, "@iv_NGM", SqlDbType.VarChar, objCreateNewOpportunity.OPP_NGM);
                db.AddInParameter(cd, "@iv_CRMReason", SqlDbType.VarChar, objCreateNewOpportunity.CRM_REASON);
                db.AddInParameter(cd, "@iv_BidExeEmpId", SqlDbType.VarChar, objCreateNewOpportunity.BID_EXECUTIVE_EMPID);
                db.AddInParameter(cd, "@iv_Disqual", SqlDbType.VarChar, objCreateNewOpportunity.Disqual);
                db.AddInParameter(cd, "@iv_AddDeal", SqlDbType.VarChar, objCreateNewOpportunity.AddDeal);
                db.AddInParameter(cd, "@iv_BidExeName", SqlDbType.VarChar, objCreateNewOpportunity.BID_EXECUTIVE_NAME);
                db.AddInParameter(cd, "@iv_DealOwner", SqlDbType.VarChar, objCreateNewOpportunity.DealOwner);
                db.AddInParameter(cd, "@iv_DealOwner2", SqlDbType.VarChar, objCreateNewOpportunity.DealOwner2);
                db.AddInParameter(cd, "@in_OperationWindow", SqlDbType.Int, objCreateNewOpportunity.OPERATION_WINDOW);
                db.AddInParameter(cd, "@in_Area", SqlDbType.Int, objCreateNewOpportunity.AREA);
                db.AddInParameter(cd, "@in_TypesOfSeat", SqlDbType.Int, objCreateNewOpportunity.TYPES_OF_SEAT);
                db.AddInParameter(cd, "@in_PCsRequired", SqlDbType.Int, objCreateNewOpportunity.PCS_REQUIRED);
                db.AddInParameter(cd, "@in_DesksRequired", SqlDbType.Int, objCreateNewOpportunity.DESKS_REQUIRED);
                db.AddInParameter(cd, "@in_PhonesRequired", SqlDbType.Int, objCreateNewOpportunity.PHONES_REQUIRED);
                db.AddInParameter(cd, "@in_CabinsRequired", SqlDbType.Int, objCreateNewOpportunity.CABINS_REQUIRED);
                db.AddInParameter(cd, "@in_LaptopsRequired", SqlDbType.Int, objCreateNewOpportunity.LAPTOPS_REQUIRED);
                db.AddInParameter(cd, "@in_Comp1", SqlDbType.Int, objCreateNewOpportunity.COMPETITOR_1);
                db.AddInParameter(cd, "@in_Comp2", SqlDbType.Int, objCreateNewOpportunity.COMPETITOR_2);
                db.AddInParameter(cd, "@in_Comp3", SqlDbType.Int, objCreateNewOpportunity.COMPETITOR_3);
                db.AddInParameter(cd, "@in_Comp4", SqlDbType.Int, objCreateNewOpportunity.COMPETITOR_4);
                db.AddInParameter(cd, "@in_Comp5", SqlDbType.Int, objCreateNewOpportunity.COMPETITOR_5);
                db.AddInParameter(cd, "@in_AdvisoryId", SqlDbType.Int, objCreateNewOpportunity.ADVISORY_ID);
                db.AddInParameter(cd, "@iv_Platform", SqlDbType.VarChar, objCreateNewOpportunity.PLATFORM);
                db.AddInParameter(cd, "@in_PIBSTCV", SqlDbType.VarChar, objCreateNewOpportunity.PibsSaleValue);
                db.AddInParameter(cd, "@iv_NextStep", SqlDbType.VarChar, objCreateNewOpportunity.NextStep);
                db.AddInParameter(cd, "@in_BusinessId", SqlDbType.Int, objCreateNewOpportunity.BUSINESS_ID);
                db.AddInParameter(cd, "@in_ProductId", SqlDbType.Int, objCreateNewOpportunity.PRODUCT_ID);
                db.AddInParameter(cd, "@in_CompetencyId", SqlDbType.Int, objCreateNewOpportunity.COMPETENCY_ID);
                db.AddInParameter(cd, "@in_SubCompetencyId", SqlDbType.Int, objCreateNewOpportunity.SUB_COMPETENCY_ID);
                db.AddInParameter(cd, "@in_AnnualSaleValue", SqlDbType.Decimal, objCreateNewOpportunity.AnnualSaleValue);
                db.AddInParameter(cd, "@in_PricingTypeId", SqlDbType.Int, objCreateNewOpportunity.PRICING_TYPE_ID);
                db.AddInParameter(cd, "@iv_KeyRmk", SqlDbType.VarChar, objCreateNewOpportunity.KeyRmk);
                db.AddInParameter(cd, "@iv_AccountSalesOwner", SqlDbType.VarChar, objCreateNewOpportunity.AccountSalesOwner);
                db.AddInParameter(cd, "@iv_ExeSponser", SqlDbType.VarChar, objCreateNewOpportunity.ExeSponser);
                db.AddInParameter(cd, "@iv_ValBPSCon", SqlDbType.VarChar, objCreateNewOpportunity.ValBPSCon);
                db.AddInParameter(cd, "@iv_ProactiveProposal", SqlDbType.VarChar, objCreateNewOpportunity.ProactiveProposal);
                db.AddInParameter(cd, "@iv_IsuMain", SqlDbType.VarChar, objCreateNewOpportunity.IsuMain);
                db.AddInParameter(cd, "@iv_PlatformNew", SqlDbType.VarChar, objCreateNewOpportunity.PlatformNew);
                db.AddInParameter(cd, "@iv_StatusUpdate", SqlDbType.VarChar, objCreateNewOpportunity.StatusUpdate);
                db.AddInParameter(cd, "@in_CategoryId", SqlDbType.Int, objCreateNewOpportunity.Category_Id);
                db.AddInParameter(cd, "@in_CountryId", SqlDbType.Int, objCreateNewOpportunity.CountryId);
                db.AddInParameter(cd, "@in_NextStepDueDt", SqlDbType.Int, objCreateNewOpportunity.NextStepDueDt);
                db.AddInParameter(cd, "@in_OffFTE  ", SqlDbType.Int, objCreateNewOpportunity.FTEOff);
                db.AddInParameter(cd, "@in_OnFTE  ", SqlDbType.Int, objCreateNewOpportunity.FTEOn);
                db.AddInParameter(cd, "@iv_ISUOwner", SqlDbType.VarChar, objCreateNewOpportunity.ISU_OWNER_ID);
                db.AddInParameter(cd, "@in_UnitID", SqlDbType.Int, objCreateNewOpportunity.UnitId);
                db.AddInParameter(cd, "@iv_ISU", SqlDbType.VarChar, objCreateNewOpportunity.ISU_CD);
                db.AddInParameter(cd, "@iv_PIBS", SqlDbType.VarChar, objCreateNewOpportunity.PIBS);
                db.AddInParameter(cd, "@iv_TCS_INVESTMENT", SqlDbType.VarChar, objCreateNewOpportunity.TCSInvestment);
                db.AddInParameter(cd, "@in_PIBStartDate", SqlDbType.Int, objCreateNewOpportunity.PIBStartDate);
                db.AddInParameter(cd, "@in_PIBEndDate", SqlDbType.Int, objCreateNewOpportunity.PIBSEndDate);
                db.AddInParameter(cd, "@in_NoOfFTEsEngaged", SqlDbType.Int, objCreateNewOpportunity.FTEsEngaged);
                db.AddInParameter(cd, "@in_PIBStatus", SqlDbType.Int, objCreateNewOpportunity.PIBStatus);
                db.AddInParameter(cd, "@in_PIBSOutcome", SqlDbType.Int, objCreateNewOpportunity.PIBS_OUTCOME_ID);
                db.AddInParameter(cd, "@iv_PIBStatusRemarks", SqlDbType.VarChar, objCreateNewOpportunity.PIBStatusRemarks);
                db.AddInParameter(cd, "@iv_FTEType", SqlDbType.VarChar, objCreateNewOpportunity.chkVariousFTEs);
                db.AddInParameter(cd, "@in_FTETypeCount", SqlDbType.Int, objCreateNewOpportunity.FTE_TYPE_COUNT);
                db.AddInParameter(cd, "@in_BPODomain", SqlDbType.Int, objCreateNewOpportunity.BPODomain);
                db.AddInParameter(cd, "@iv_DomainPresalesLead", SqlDbType.VarChar, objCreateNewOpportunity.DOMAIN_PRESALES_LEAD);
                db.AddInParameter(cd, "@in_DealCategory", SqlDbType.Int, objCreateNewOpportunity.DealCategory);
                db.AddInParameter(cd, "@iv_DealCoachName", SqlDbType.VarChar, objCreateNewOpportunity.DealCoachName);
                db.AddInParameter(cd, "@in_DemandType", SqlDbType.Int, objCreateNewOpportunity.DemandType);
                db.AddInParameter(cd, "@iv_KeyDeal", SqlDbType.VarChar, objCreateNewOpportunity.KEY_DEAL);
                db.AddInParameter(cd, "@iv_ProposedSolution", SqlDbType.VarChar, objCreateNewOpportunity.ProposedSolution);
                db.AddInParameter(cd, "@iv_WinningTeam", SqlDbType.VarChar, objCreateNewOpportunity.WinningTheme);
                db.AddInParameter(cd, "@iv_KeyCustExp", SqlDbType.VarChar, objCreateNewOpportunity.KeyCustExp);
                db.AddInParameter(cd, "@iv_OperatingModel", SqlDbType.VarChar, objCreateNewOpportunity.operatingModel);
                db.AddInParameter(cd, "@iv_PricingModel", SqlDbType.VarChar, objCreateNewOpportunity.PRICING_MODEL);
                db.AddInParameter(cd, "@iv_Differentiators", SqlDbType.VarChar, objCreateNewOpportunity.Differentiators);
                db.AddInParameter(cd, "@iv_Risks", SqlDbType.VarChar, Risks);
                db.AddInParameter(cd, "@iv_KeyCustomerConnects", SqlDbType.VarChar, objCreateNewOpportunity.KeyCustomerConnects);
                db.AddInParameter(cd, "@iv_BPOOfferingDescription", SqlDbType.VarChar, objCreateNewOpportunity.BPOOfferingDescription);
                db.AddInParameter(cd, "@iv_FirstTimeOutsource", SqlDbType.VarChar, objCreateNewOpportunity.FIRST_TIME_OUTSOURCE);
                db.AddInParameter(cd, "@iv_Incumbents", SqlDbType.VarChar, objCreateNewOpportunity.INCUMBENTS);
                db.AddInParameter(cd, "@iv_NameOfIncumbents", SqlDbType.VarChar, objCreateNewOpportunity.NAME_OF_INCUMBENTS);
                db.AddInParameter(cd, "@iv_TCSOfferingCapability", SqlDbType.VarChar, objCreateNewOpportunity.TCS_OFFERING_CAPABILITY);
                db.AddInParameter(cd, "@iv_SpecifyOffering", SqlDbType.VarChar, objCreateNewOpportunity.SpecifyOffering);
                db.AddInParameter(cd, "@iv_CoachAvailable", SqlDbType.VarChar, objCreateNewOpportunity.CoachAvailable);
                db.AddInParameter(cd, "@iv_FnA", SqlDbType.VarChar, objCreateNewOpportunity.FnA);
                db.AddInParameter(cd, "@in_Fna_FTE", SqlDbType.Int, objCreateNewOpportunity.FnA_FTE);
                db.AddInParameter(cd, "@iv_HRO", SqlDbType.VarChar, objCreateNewOpportunity.HRO);
                db.AddInParameter(cd, "@in_HRO_FTE", SqlDbType.Int, objCreateNewOpportunity.HRO_FTE);
                db.AddInParameter(cd, "@iv_SCM", SqlDbType.VarChar, objCreateNewOpportunity.SCM);
                db.AddInParameter(cd, "@in_SCM_FTE", SqlDbType.Int, objCreateNewOpportunity.SCM_FTE);
                db.AddInParameter(cd, "@iv_KPO", SqlDbType.VarChar, objCreateNewOpportunity.KPO);
                db.AddInParameter(cd, "@in_KPO_FTE", SqlDbType.Int, objCreateNewOpportunity.KPO_FTE);
                db.AddInParameter(cd, "@iv_LPO", SqlDbType.VarChar, objCreateNewOpportunity.LPO);
                db.AddInParameter(cd, "@in_LPO_FTE", SqlDbType.Int, objCreateNewOpportunity.LPO_FTE);
                db.AddInParameter(cd, "@iv_Vertical", SqlDbType.VarChar, objCreateNewOpportunity.VERTICAL);
                db.AddInParameter(cd, "@in_Vertical_FTE", SqlDbType.Int, objCreateNewOpportunity.VerticalFTE);
                db.AddInParameter(cd, "@iv_Voice", SqlDbType.VarChar, objCreateNewOpportunity.Voice);
                db.AddInParameter(cd, "@in_Voice_FTE", SqlDbType.Int, objCreateNewOpportunity.VoiceFTE);
                db.AddInParameter(cd, "@iv_Bpm", SqlDbType.VarChar, objCreateNewOpportunity.BPM);
                db.AddInParameter(cd, "@in_Bpm_FTE", SqlDbType.Int, objCreateNewOpportunity.BPM_FTE);
                db.AddInParameter(cd, "@in_SolTM", SqlDbType.Int, objCreateNewOpportunity.SolTM);
                db.AddInParameter(cd, "@in_DelTM", SqlDbType.Int, objCreateNewOpportunity.DelTM);
                db.AddInParameter(cd, "@iv_BidManager", SqlDbType.VarChar, objCreateNewOpportunity.BID_MANAGER);
                db.AddInParameter(cd, "@iv_BidExec", SqlDbType.VarChar, objCreateNewOpportunity.BID_EXEC_OWNER);
                db.AddInParameter(cd, "@iv_PricingOwner", SqlDbType.VarChar, objCreateNewOpportunity.PRICING_OWNER);
                db.AddInParameter(cd, "@in_TransitionTeam", SqlDbType.Int, objCreateNewOpportunity.TransitionTeam);
                db.AddInParameter(cd, "@iv_ExpectedDate", SqlDbType.Int, objCreateNewOpportunity.ExpectedDate);
                db.AddInParameter(cd, "@iv_TransitionReq", SqlDbType.VarChar, objCreateNewOpportunity.TransitionReq);
                db.AddInParameter(cd, "@iv_Entity", SqlDbType.VarChar, objCreateNewOpportunity.ENTITY);
                db.AddInParameter(cd, "@iv_Quarter", SqlDbType.VarChar, objCreateNewOpportunity.Quarter);
                db.AddInParameter(cd, "@iv_FiscalYear", SqlDbType.VarChar, objCreateNewOpportunity.FiscalYear);
                db.AddInParameter(cd, "@iv_CurrentlyActive", SqlDbType.VarChar, objCreateNewOpportunity.CURRENTLY_ACTIVE);
                db.AddInParameter(cd, "@iv_FTEDD", SqlDbType.VarChar, objCreateNewOpportunity.FTEDD);
                db.AddInParameter(cd, "@iv_SolutionLeader", SqlDbType.VarChar, objCreateNewOpportunity.SolutionLeader);
                db.AddInParameter(cd, "@in_Seat_Requirements", SqlDbType.Int, objCreateNewOpportunity.SeatRequirements);
                db.AddInParameter(cd, "@iv_RUR", SqlDbType.VarChar, objCreateNewOpportunity.RUR);
                db.AddInParameter(cd, "@iv_HRT_Comments", SqlDbType.VarChar, objCreateNewOpportunity.HRTComments);
                db.AddInParameter(cd, "@iv_CRMId", SqlDbType.VarChar, objCreateNewOpportunity.CRM_ID);
                db.AddInParameter(cd, "@iv_ValueBPS", SqlDbType.VarChar, objCreateNewOpportunity.ValueBPS);
                db.AddInParameter(cd, "@in_ValueBPSTCV", SqlDbType.Decimal, objCreateNewOpportunity.ValueBPSTCV);
                db.AddInParameter(cd, "@iv_OppType", SqlDbType.VarChar, objCreateNewOpportunity.OPP_TYPE);
                db.AddInParameter(cd, "@iv_ImmediateComment", SqlDbType.VarChar, objCreateNewOpportunity.ImmediateComment);
                db.AddInParameter(cd, "@iv_MultiTower", SqlDbType.VarChar, objCreateNewOpportunity.MultiTower);
                db.AddInParameter(cd, "@in_StatusFlag", SqlDbType.Int, objCreateNewOpportunity.StatusFlag);
                db.AddInParameter(cd, "@iv_Fna_Lead", SqlDbType.VarChar, objCreateNewOpportunity.FnA_Lead);
                db.AddInParameter(cd, "@iv_HRO_Lead", SqlDbType.VarChar, objCreateNewOpportunity.HRO_Lead);
                db.AddInParameter(cd, "@iv_SCM_Lead", SqlDbType.VarChar, objCreateNewOpportunity.SCM_Lead);
                db.AddInParameter(cd, "@iv_KPO_Lead", SqlDbType.VarChar, objCreateNewOpportunity.KPO_Lead);
                db.AddInParameter(cd, "@iv_LPO_Lead", SqlDbType.VarChar, objCreateNewOpportunity.LPO_Lead);
                db.AddInParameter(cd, "@iv_Vertical_Lead", SqlDbType.VarChar, objCreateNewOpportunity.VERTICAL_LEAD);
                db.AddInParameter(cd, "@iv_Voice_Lead", SqlDbType.VarChar, objCreateNewOpportunity.Voice_Lead);
                db.AddInParameter(cd, "@iv_Bpm_Lead", SqlDbType.VarChar, objCreateNewOpportunity.BPM_LEAD);
                db.AddInParameter(cd, "@iv_BidManagerId", SqlDbType.VarChar, objCreateNewOpportunity.BID_MANAGER_EMPID);
                db.AddInParameter(cd, "@iv_BidExecId", SqlDbType.VarChar, objCreateNewOpportunity.BID_EXEC_OWNER_EMPID);
                db.AddInParameter(cd, "@iv_PricingOwnerId", SqlDbType.VarChar, objCreateNewOpportunity.PRICING_OWNER_EMPID);
                db.AddInParameter(cd, "@iv_SolutionLeaderId", SqlDbType.VarChar, objCreateNewOpportunity.SolutionLeaderId);
                db.AddInParameter(cd, "@iv_FnaTCV", SqlDbType.VarChar, objCreateNewOpportunity.FnATCV);
                db.AddInParameter(cd, "@iv_HROTCV", SqlDbType.VarChar, objCreateNewOpportunity.HROTCV);
                db.AddInParameter(cd, "@iv_SCMTCV", SqlDbType.VarChar, objCreateNewOpportunity.SCMTCV);
                db.AddInParameter(cd, "@iv_KPOTCV", SqlDbType.VarChar, objCreateNewOpportunity.KPOTCV);
                db.AddInParameter(cd, "@iv_LPOTCV", SqlDbType.VarChar, objCreateNewOpportunity.LPOTCV);
                db.AddInParameter(cd, "@iv_VerticalTCV", SqlDbType.VarChar, objCreateNewOpportunity.VERTICALTCV);
                db.AddInParameter(cd, "@iv_VoiceTCV", SqlDbType.VarChar, objCreateNewOpportunity.VOICETCV);
                db.AddInParameter(cd, "@iv_BpmTCV", SqlDbType.VarChar, objCreateNewOpportunity.BPMTCV);
                db.AddInParameter(cd, "@in_ClusterId", SqlDbType.Int, objCreateNewOpportunity.ClusterId);
                db.AddInParameter(cd, "@in_BPSSubSPID", SqlDbType.Int, objCreateNewOpportunity.BPSSubSPID);
                db.AddInParameter(cd, "@in_BPSOfferingID", SqlDbType.Int, objCreateNewOpportunity.BPSOfferingID);
                db.AddInParameter(cd, "@in_ServiceId", SqlDbType.Int, objCreateNewOpportunity.ServiceId);
                db.AddInParameter(cd, "@in_SUBIOU", SqlDbType.VarChar, objCreateNewOpportunity.SUBIOU);
                db.AddInParameter(cd, "@in_strTransitionEmpId", SqlDbType.VarChar, objCreateNewOpportunity.TransitionEmpId);
                db.AddInParameter(cd, "@in_strTransitionName", SqlDbType.VarChar, objCreateNewOpportunity.TransitionName);
                db.AddInParameter(cd, "@in_strTransitionType", SqlDbType.VarChar, objCreateNewOpportunity.TransitionType);
                db.AddInParameter(cd, "@in_strTransitionApproach", SqlDbType.VarChar, objCreateNewOpportunity.TransitionApproach);
                db.AddInParameter(cd, "@in_strTransitionModel", SqlDbType.VarChar, objCreateNewOpportunity.TransitionModel);
                db.AddInParameter(cd, "@in_strProposalfactory", SqlDbType.VarChar, objCreateNewOpportunity.Proposalfactory);
                db.AddInParameter(cd, "@in_strProposalfactoryOptions", SqlDbType.VarChar, objCreateNewOpportunity.ProposalfactoryOptions);
                db.AddInParameter(cd, "@in_strProposalComments", SqlDbType.VarChar, objCreateNewOpportunity.ProposalComments);
                db.AddInParameter(cd, "@iv_DTValue", SqlDbType.VarChar, objCreateNewOpportunity.DTValue);
                db.AddInParameter(cd, "@iv_OtherDT", SqlDbType.VarChar, objCreateNewOpportunity.Other_DT);
                db.AddInParameter(cd, "@in_CRMTCV", SqlDbType.VarChar, objCreateNewOpportunity.CRM_TCV);
                db.AddInParameter(cd, "@in_CRMStage", SqlDbType.Int, objCreateNewOpportunity.CRM_STAGE);
                db.AddInParameter(cd, "@in_TGA", SqlDbType.VarChar, objCreateNewOpportunity.TataGroupAccount);
                db.AddInParameter(cd, "@in_TPA", SqlDbType.VarChar, objCreateNewOpportunity.TPA);
                db.AddInParameter(cd, "@in_TPA_Name", SqlDbType.VarChar, objCreateNewOpportunity.TPA_Name);
                db.AddInParameter(cd, "@in_ItisScope", SqlDbType.VarChar, objCreateNewOpportunity.ItisScope);
                db.AddInParameter(cd, "@in_IsContractRenewal", SqlDbType.VarChar, objCreateNewOpportunity.IsContractRenewal);
                db.AddInParameter(cd, "@in_ContractRenewalValue", SqlDbType.VarChar, objCreateNewOpportunity.ContractRenewalValue);
                db.AddInParameter(cd, "@iv_DigitalTCV", SqlDbType.VarChar, objCreateNewOpportunity.strDigitalTcv);

                db.AddInParameter(cd, "@in_SubSP", SqlDbType.Int, objCreateNewOpportunity.subSPId);
                db.AddInParameter(cd, "@in_CRMBeacon", SqlDbType.VarChar, objCreateNewOpportunity.CRM_Beacon);
                //changess
                db.AddInParameter(cd, "@in_ResourcingId", SqlDbType.Int, objCreateNewOpportunity.RESOURCING_ID);
                db.AddInParameter(cd, "@in_Seat_IdentificationId", SqlDbType.Int, objCreateNewOpportunity.SEAT_IDENTIFICATION_ID);
                db.AddInParameter(cd, "@in_ShortListDt", SqlDbType.VarChar, objCreateNewOpportunity.SHORTLIST_DT);
                db.AddInParameter(cd, "@DealStatus_Id", SqlDbType.Int, objCreateNewOpportunity.DealStatus);
                db.AddInParameter(cd, "@ServicePractice_Id", SqlDbType.Int, objCreateNewOpportunity.ServicePractice);
                db.AddInParameter(cd, "@CoreOffering_Id", SqlDbType.Int, objCreateNewOpportunity.CoreOffering);
                db.AddInParameter(cd, "@in_modernisedOfferingId", SqlDbType.Int, objCreateNewOpportunity.ModernisedOffering);
                db.AddInParameter(cd, "@in_cognitiveSolutionId", SqlDbType.Int, objCreateNewOpportunity.CognitiveSolutions);
                db.AddInParameter(cd, "@in_offerings", SqlDbType.VarChar, objCreateNewOpportunity.Offerings);
                db.AddInParameter(cd, "@in_Opportunity_Desc_Details", SqlDbType.VarChar, objCreateNewOpportunity.OpportunityDescDetails);
                db.AddInParameter(cd, "@OfferingType_Id", SqlDbType.Int, objCreateNewOpportunity.offeringType);
                db.AddInParameter(cd, "@CoreOfferingName_Id", SqlDbType.Int, objCreateNewOpportunity.CofID);
                db.AddInParameter(cd, "@iv_IgnioTMscope", SqlDbType.VarChar, objCreateNewOpportunity.IgnioTMScope);
                db.AddInParameter(cd, "@iv_IgnioTMscopeDetail", SqlDbType.VarChar, objCreateNewOpportunity.IgnioTMScopeDetails);
                db.AddInParameter(cd, "@iv_DigitalFlagging", SqlDbType.VarChar, objCreateNewOpportunity.DigitalFlagging);
                //End
                //End

                db.AddInParameter(cd, "@in_proposalSubmissionDate", SqlDbType.VarChar, objCreateNewOpportunity.PROPOSAL_SUBMISSION_DATE);
                db.AddInParameter(cd, "@in_salesStageMovedOnDate", SqlDbType.VarChar, objCreateNewOpportunity.SALES_STAGE_MOVED_ONDATE);

                db.AddInParameter(cd, "@iv_deliveryLocationProposed", SqlDbType.VarChar, objCreateNewOpportunity.DELIVERY_LOCATION_PROPOSED);
                db.AddInParameter(cd, "@cboioffering", SqlDbType.VarChar, objCreateNewOpportunity.Cboi_Offering_id);
                db.AddInParameter(cd, "@dealflag", SqlDbType.VarChar, objCreateNewOpportunity.Deal_Flag_id);
                db.AddOutParameter(cd, "@on_Result", SqlDbType.Int, Int16.MaxValue);
                db.ExecuteNonQuery(cd);
                on_Result = db.GetParameterValue(cd, "@on_Result").ToString();
                strResult.Add(new CreateNewOpportunity()
                {
                    on_Result = db.GetParameterValue(cd, "@on_Result").ToString()
                });


            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
            return strResult;

        }

        /// <summary>
        /// Get Industry Practise HclMap Details
        /// </summary>
        public List<CreateNewOpportunity> GetIndustryPractiseHclMap(CreateNewOpportunity ObjCreateNewOpportunity)
        {
            DataSet ds = null;
            List<CreateNewOpportunity> IndustryPraciseList = new List<CreateNewOpportunity>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.GetOpportunity_Stage4_sp);
                db.AddInParameter(cd, "@in_IndPractId", SqlDbType.VarChar, ObjCreateNewOpportunity.INDUSTRY_PRACTICE_ID);
                db.AddInParameter(cd, "@iv_StakeHolderName", SqlDbType.VarChar, ObjCreateNewOpportunity.StakeHolder);
                db.AddInParameter(cd, "@in_Location_Id", SqlDbType.Int, ObjCreateNewOpportunity.LOCATION_ID);

                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;

                        for (int i = 0; i < rowCount; i++)
                        {
                            IndustryPraciseList.Add(ObjIndustryPractise(ds.Tables[0].Rows[i]));
                        }

                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }
            return IndustryPraciseList;
        }

        private static CreateNewOpportunity ObjIndustryPractise(DataRow dr)
        {
            try
            {
                return new CreateNewOpportunity()
                {

                    IPHCLMAPID = (dr.Table.Columns.Contains("IP_HCL_MAP_ID")) ? (dr["IP_HCL_MAP_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["IP_HCL_MAP_ID"]) : 0,
                    INDUSTRY_PRACTICE_ID = (dr.Table.Columns.Contains("INDUSTRY_PRACTICE_ID")) ? (dr["INDUSTRY_PRACTICE_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["INDUSTRY_PRACTICE_ID"]) : 0,
                    INDUSTRY_PRACTICE_CODE = (dr.Table.Columns.Contains("INDUSTRY_PRACTICE_CODE")) ? (dr["INDUSTRY_PRACTICE_CODE"] == DBNull.Value) ? "" : dr.Field<string>("INDUSTRY_PRACTICE_CODE") : "",
                    LOCATION_ID = (dr.Table.Columns.Contains("LOCATION_ID")) ? (dr["LOCATION_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["LOCATION_ID"]) : 0,
                    STAKEHOLDERID = (dr.Table.Columns.Contains("STAKEHOLDER_ID")) ? (dr["STAKEHOLDER_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["STAKEHOLDER_ID"]) : 0,
                    ResponsibleEmployee = (dr.Table.Columns.Contains("RESPONSIBLE_EMP")) ? (dr["RESPONSIBLE_EMP"] == DBNull.Value) ? "" : dr.Field<string>("RESPONSIBLE_EMP") : "",
                    FirstName = (dr.Table.Columns.Contains("FIRST_NAME")) ? (dr["FIRST_NAME"] == DBNull.Value) ? "" : dr.Field<string>("FIRST_NAME") : "",
                    LastName = (dr.Table.Columns.Contains("LAST_NAME")) ? (dr["LAST_NAME"] == DBNull.Value) ? "" : dr.Field<string>("LAST_NAME") : "",
                    CREATED_BY = (dr.Table.Columns.Contains("CREATED_BY")) ? (dr["CREATED_BY"] == DBNull.Value) ? "" : dr.Field<string>("CREATED_BY") : "",
                    CHANGED_DT = (dr.Table.Columns.Contains("CHANGED_DT")) ? (dr["CHANGED_DT"] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(dr.Field<DateTime>("CHANGED_DT")) : (DateTime?)null,
                    CHANGED_BY = (dr.Table.Columns.Contains("CHANGED_BY")) ? (dr["CHANGED_BY"] == DBNull.Value) ? "" : dr.Field<string>("CHANGED_BY") : "",
                    UnitId = (dr.Table.Columns.Contains("UNIT_ID")) ? (dr["UNIT_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["UNIT_ID"]) : 0,
                    Accountable = (dr.Table.Columns.Contains("ACCOUNTABLE")) ? (dr["ACCOUNTABLE"] == DBNull.Value) ? "" : dr.Field<string>("ACCOUNTABLE") : "",

                };
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
        }

        /// <summary>
        /// Get Stage9 Details
        /// </summary>
        public List<CreateNewOpportunity> Get_stage9(string opportunityId, string stageId)
        {
            DataSet ds = null;
            List<CreateNewOpportunity> modelList = new List<CreateNewOpportunity>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.GetOpportunity_Stage9_sp);
                db.AddInParameter(cd, "@in_OpportunityId", SqlDbType.VarChar, opportunityId);
                db.AddInParameter(cd, "@in_StageId", SqlDbType.Int, stageId);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;

                        for (int i = 0; i < rowCount; i++)
                        {
                            modelList.Add(MapPopulate_Get_stage9(ds.Tables[0].Rows[i]));
                        }

                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }
            return modelList;
        }
        private static CreateNewOpportunity MapPopulate_Get_stage9(DataRow dr)
        {
            try
            {
                return new CreateNewOpportunity()
                {
                    OPPORTUNITY_DESC = (dr.Table.Columns.Contains("OPPORTUNITY_DESC")) ? (dr["OPPORTUNITY_DESC"] == DBNull.Value) ? "" : dr.Field<string>("OPPORTUNITY_DESC") : "",
                    GEOGRAPHY_ID = (dr.Table.Columns.Contains("GEOGRAPHY_ID")) ? (dr["GEOGRAPHY_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["GEOGRAPHY_ID"]) : 0,
                    CUST_ID = (dr.Table.Columns.Contains("CUST_ID")) ? (dr["CUST_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CUST_ID"]) : 0,
                    CUST_TYPE_ID = (dr.Table.Columns.Contains("CUST_TYPE_ID")) ? (dr["CUST_TYPE_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CUST_TYPE_ID"]) : 0,
                    INDUSTRY_PRACTICE_ID = (dr.Table.Columns.Contains("INDUSTRY_PRACTICE_ID")) ? (dr["INDUSTRY_PRACTICE_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["INDUSTRY_PRACTICE_ID"]) : 0,
                    StageID = (dr.Table.Columns.Contains("STAGE_ID")) ? (dr["STAGE_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["STAGE_ID"]) : 0,
                    ESTIMATED_FTE_SIZE = (dr.Table.Columns.Contains("ESTIMATED_FTE_SIZE")) ? (dr["ESTIMATED_FTE_SIZE"] == DBNull.Value) ? 0 : Convert.ToDecimal(dr["ESTIMATED_FTE_SIZE"]) : 0,
                    FTE_OFFSHORE = (dr.Table.Columns.Contains("FTE_OFFSHORE")) ? (dr["FTE_OFFSHORE"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["FTE_OFFSHORE"]) : 0,
                    FTE_ONSITE = (dr.Table.Columns.Contains("FTE_ONSITE")) ? (dr["FTE_ONSITE"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["FTE_ONSITE"]) : 0,
                    GEOGRAPHY_SALES_OWNER_ID = (dr.Table.Columns.Contains("GEOGRAPHY_SALES_OWNER_ID")) ? (dr["GEOGRAPHY_SALES_OWNER_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["GEOGRAPHY_SALES_OWNER_ID"]) : 0,
                    PRACTICE_SALES_OWNER_ID = (dr.Table.Columns.Contains("PRACTICE_SALES_OWNER_ID")) ? (dr["PRACTICE_SALES_OWNER_ID"] == DBNull.Value) ? "" : Convert.ToString(dr["PRACTICE_SALES_OWNER_ID"]) : "",
                    ONSITE_OWNER_ID = (dr.Table.Columns.Contains("ONSITE_OWNER_ID")) ? (dr["ONSITE_OWNER_ID"] == DBNull.Value) ? "" : Convert.ToString(dr["ONSITE_OWNER_ID"]) : "",
                    OFFSHORE_BD_LEAD_ID = (dr.Table.Columns.Contains("OFFSHORE_BD_LEAD_ID")) ? (dr["OFFSHORE_BD_LEAD_ID"] == DBNull.Value) ? "" : Convert.ToString(dr["OFFSHORE_BD_LEAD_ID"]) : "",
                    ISU_OWNER_ID = (dr.Table.Columns.Contains("ISU_OWNER_ID")) ? (dr["ISU_OWNER_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["ISU_OWNER_ID"]) : 0,
                    ISU_CD = (dr.Table.Columns.Contains("ISU_CD")) ? (dr["ISU_CD"] == DBNull.Value) ? "" : dr.Field<string>("ISU_CD") : "",
                    PROBABILITY_OF_WIN = (dr.Table.Columns.Contains("PROBABILITY_OF_WIN")) ? (dr["PROBABILITY_OF_WIN"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["PROBABILITY_OF_WIN"]) : 0,
                    REMARK = (dr.Table.Columns.Contains("REMARK")) ? (dr["REMARK"] == DBNull.Value) ? "" : dr.Field<string>("REMARK") : "",

                    OPPORTUNITY_DATE = (dr.Table.Columns.Contains("OPPORTUNITY_DATE")) ? (dr["OPPORTUNITY_DATE"] == DBNull.Value) ? "" : dr.Field<string>("OPPORTUNITY_DATE") : "",
                    RFI_ReceivedDate = (dr.Table.Columns.Contains("RFI_RECEIVED_DT")) ? (dr["RFI_RECEIVED_DT"] == DBNull.Value) ? "" : dr.Field<string>("RFI_RECEIVED_DT") : "",
                    RFP_ReceivedDate = (dr.Table.Columns.Contains("RFP_RECEIVED_DT")) ? (dr["RFP_RECEIVED_DT"] == DBNull.Value) ? "" : dr.Field<string>("RFP_RECEIVED_DT") : "",
                    RFI_ProbableSubmissionDate = (dr.Table.Columns.Contains("RFI_PROBABLE_SUBMISSION_DT")) ? (dr["RFI_PROBABLE_SUBMISSION_DT"] == DBNull.Value) ? "" : dr.Field<string>("RFI_PROBABLE_SUBMISSION_DT") : "",
                    RFP_ProbableSubmissionDate = (dr.Table.Columns.Contains("RFP_PROBABLE_SUBMISSION_DT")) ? (dr["RFP_PROBABLE_SUBMISSION_DT"] == DBNull.Value) ? "" : dr.Field<string>("RFP_PROBABLE_SUBMISSION_DT") : "",
                    RFI_ActualSubmissionDate = (dr.Table.Columns.Contains("RFI_ACTUAL_SUBMISSION_DT")) ? (dr["RFI_ACTUAL_SUBMISSION_DT"] == DBNull.Value) ? "" : dr.Field<string>("RFI_ACTUAL_SUBMISSION_DT") : "",
                    RFP_ActualSubmissionDate = (dr.Table.Columns.Contains("RFP_ACTUAL_SUBMISSION_DT")) ? (dr["RFP_ACTUAL_SUBMISSION_DT"] == DBNull.Value) ? "" : dr.Field<string>("RFP_ACTUAL_SUBMISSION_DT") : "",
                    ContractLength = (dr.Table.Columns.Contains("CONTRACT_LENGTH")) ? (dr["CONTRACT_LENGTH"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CONTRACT_LENGTH"]) : 0,
                    SHORTLIST_DT = (dr.Table.Columns.Contains("SHORTLIST_DT")) ? (dr["SHORTLIST_DT"] == DBNull.Value) ? "" : Convert.ToString(dr["SHORTLIST_DT"]) : "",
                    SELECTION_DT = (dr.Table.Columns.Contains("SELECTION_DT")) ? (dr["SELECTION_DT"] == DBNull.Value) ? "" : Convert.ToString(dr["SELECTION_DT"]) : "",
                    WIN_DT = (dr.Table.Columns.Contains("WIN_DT")) ? (dr["WIN_DT"] == DBNull.Value) ? "" : Convert.ToString(dr["WIN_DT"]) : "",
                    CONTRACT_NEGOTIATION_DT = (dr.Table.Columns.Contains("CONTRACT_NEGOTIATION_DT")) ? (dr["CONTRACT_NEGOTIATION_DT"] == DBNull.Value) ? "" : dr.Field<string>("CONTRACT_NEGOTIATION_DT") : "",
                    CURRENCY_ID = (dr.Table.Columns.Contains("CURRENCY_ID")) ? (dr["CURRENCY_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CURRENCY_ID"]) : 0,
                    TOTAL_CONTRACT_VALUE = (dr.Table.Columns.Contains("TOTAL_CONTRACT_VALUE")) ? (dr["TOTAL_CONTRACT_VALUE"] == DBNull.Value) ? 0 : Convert.ToDouble(dr["TOTAL_CONTRACT_VALUE"]) : 0,
                    BCP_DRP_LOCATION = (dr.Table.Columns.Contains("BCP_DRP_LOCATION")) ? (dr["BCP_DRP_LOCATION"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["BCP_DRP_LOCATION"]) : 0,

                    PRICING_TYPE_ID = (dr.Table.Columns.Contains("PRICING_TYPE_ID")) ? (dr["PRICING_TYPE_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["PRICING_TYPE_ID"]) : 0,
                    ONSITE_TRAINING_NOS = (dr.Table.Columns.Contains("ONSITE_TRAINING_NOS")) ? (dr["ONSITE_TRAINING_NOS"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["ONSITE_TRAINING_NOS"]) : 0,
                    VISA_REQUIRED = (dr.Table.Columns.Contains("VISA_REQUIRED")) ? (dr["VISA_REQUIRED"] == DBNull.Value) ? "" : dr.Field<string>("VISA_REQUIRED") : "",
                    VISAS_REQUIRED = (dr.Table.Columns.Contains("VISAS_REQUIRED")) ? (dr["VISAS_REQUIRED"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["VISAS_REQUIRED"]) : 0,
                    TRAINING_DURATION = (dr.Table.Columns.Contains("TRAINING_DURATION")) ? (dr["TRAINING_DURATION"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["TRAINING_DURATION"]) : 0,
                    DAYS_IN_THIS_STAGE = (dr.Table.Columns.Contains("DAYS_IN_THIS_STAGE")) ? (dr["DAYS_IN_THIS_STAGE"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["DAYS_IN_THIS_STAGE"]) : 0,
                    DEAL_CLOSURE_EXP_DATE = (dr.Table.Columns.Contains("DEAL_CLOSURE_EXP_DATE")) ? (dr["DEAL_CLOSURE_EXP_DATE"] == DBNull.Value) ? "" : dr.Field<string>("DEAL_CLOSURE_EXP_DATE") : "",
                    OPERATION_WINDOW = (dr.Table.Columns.Contains("OPERATION_WINDOW")) ? (dr["OPERATION_WINDOW"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["OPERATION_WINDOW"]) : 0,
                    AREA = (dr.Table.Columns.Contains("AREA")) ? (dr["AREA"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["AREA"]) : 0,
                    TYPES_OF_SEAT = (dr.Table.Columns.Contains("TYPES_OF_SEAT")) ? (dr["TYPES_OF_SEAT"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["TYPES_OF_SEAT"]) : 0,
                    PCS_REQUIRED = (dr.Table.Columns.Contains("PCS_REQUIRED")) ? (dr["PCS_REQUIRED"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["PCS_REQUIRED"]) : 0,
                    DESKS_REQUIRED = (dr.Table.Columns.Contains("DESKS_REQUIRED")) ? (dr["DESKS_REQUIRED"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["DESKS_REQUIRED"]) : 0,
                    PHONES_REQUIRED = (dr.Table.Columns.Contains("PHONES_REQUIRED")) ? (dr["PHONES_REQUIRED"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["PHONES_REQUIRED"]) : 0,
                    CABINS_REQUIRED = (dr.Table.Columns.Contains("CABINS_REQUIRED")) ? (dr["CABINS_REQUIRED"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CABINS_REQUIRED"]) : 0,
                    LAPTOPS_REQUIRED = (dr.Table.Columns.Contains("LAPTOPS_REQUIRED")) ? (dr["LAPTOPS_REQUIRED"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["LAPTOPS_REQUIRED"]) : 0,
                    ADVISORY_ID = (dr.Table.Columns.Contains("ADVISORY_ID")) ? (dr["ADVISORY_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["ADVISORY_ID"]) : 0,
                    PLATFORM = (dr.Table.Columns.Contains("PLATFORM")) ? (dr["PLATFORM"] == DBNull.Value) ? "" : dr.Field<string>("PLATFORM") : "",
                    NEXT_STEP = (dr.Table.Columns.Contains("NEXT_STEP")) ? (dr["NEXT_STEP"] == DBNull.Value) ? "" : dr.Field<string>("NEXT_STEP") : "",

                    NEXT_STEP_DUE_DT = (dr.Table.Columns.Contains("NEXT_STEP_DUE_DT")) ? (dr["NEXT_STEP_DUE_DT"] == DBNull.Value) ? "" : dr.Field<string>("NEXT_STEP_DUE_DT") : "",
                    BUSINESS_ID = (dr.Table.Columns.Contains("BUSINESS_ID")) ? (dr["BUSINESS_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["BUSINESS_ID"]) : 0,
                    PRODUCT_ID = (dr.Table.Columns.Contains("PRODUCT_ID")) ? (dr["PRODUCT_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["PRODUCT_ID"]) : 0,
                    COMPETENCY_ID = (dr.Table.Columns.Contains("COMPETENCY_ID")) ? (dr["COMPETENCY_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["COMPETENCY_ID"]) : 0,
                    SUB_COMPETENCY_ID = (dr.Table.Columns.Contains("SUB_COMPETENCY_ID")) ? (dr["SUB_COMPETENCY_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["SUB_COMPETENCY_ID"]) : 0,
                    Category_Id = (dr.Table.Columns.Contains("CATEGORY_ID")) ? (dr["CATEGORY_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CATEGORY_ID"]) : 0,
                    COUNTRY_ID = (dr.Table.Columns.Contains("COUNTRY_ID")) ? (dr["COUNTRY_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["COUNTRY_ID"]) : 0,
                    ACCOUNT_SALES_OWNER_ID = (dr.Table.Columns.Contains("ACCOUNT_SALES_OWNER_ID")) ? (dr["ACCOUNT_SALES_OWNER_ID"] == DBNull.Value) ? "" : dr.Field<string>("ACCOUNT_SALES_OWNER_ID") : "",
                    STATUS_UPDATE = (dr.Table.Columns.Contains("STATUS_UPDATE")) ? (dr["STATUS_UPDATE"] == DBNull.Value) ? "" : dr.Field<string>("STATUS_UPDATE") : "",
                    DEAL_BD_LEAD_ID = (dr.Table.Columns.Contains("DEAL_BD_LEAD_ID")) ? (dr["DEAL_BD_LEAD_ID"] == DBNull.Value) ? "" : Convert.ToString(dr["DEAL_BD_LEAD_ID"]) : "",
                    DEAL_BD_LEAD_ID2 = (dr.Table.Columns.Contains("DEAL_BD_LEAD_ID2")) ? (dr["DEAL_BD_LEAD_ID2"] == DBNull.Value) ? "" : Convert.ToString(dr["DEAL_BD_LEAD_ID2"]) : "",
                    EXECUTIVE_SPONSOR = (dr.Table.Columns.Contains("EXECUTIVE_SPONSOR")) ? (dr["EXECUTIVE_SPONSOR"] == DBNull.Value) ? "" : dr.Field<string>("EXECUTIVE_SPONSOR") : "",
                    OPP_AGE = (dr.Table.Columns.Contains("OPP_AGE")) ? (dr["OPP_AGE"] == DBNull.Value) ? "" : dr.Field<string>("OPP_AGE") : "",
                    //rajat
                    Next_Step_Notes = (dr.Table.Columns.Contains("NEXT_STEP")) ? (dr["NEXT_STEP"] == DBNull.Value) ? "" : dr.Field<string>("NEXT_STEP") : "",
                    PROJECT_WON = (dr.Table.Columns.Contains("PROJECT_WON")) ? (dr["PROJECT_WON"] == DBNull.Value) ? "" : dr.Field<string>("PROJECT_WON") : "",
                    WON_FTE = (dr.Table.Columns.Contains("WON_FTE")) ? (dr["WON_FTE"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["WON_FTE"]) : 0,
                    ANTICIPATED_ACTUAL_STDT = (dr.Table.Columns.Contains("ANTICIPATED_ACTUAL_STDT")) ? (dr["ANTICIPATED_ACTUAL_STDT"] == DBNull.Value) ? "" : Convert.ToString(dr["ANTICIPATED_ACTUAL_STDT"]) : "",
                    CURRENT_FISCAL_REVENUE = (dr.Table.Columns.Contains("CURRENT_FISCAL_REVENUE")) ? (dr["CURRENT_FISCAL_REVENUE"] == DBNull.Value) ? "" : dr.Field < string > ("CURRENT_FISCAL_REVENUE") : "",
                    REVENUE_MONTHS = (dr.Table.Columns.Contains("REVENUE_MONTHS")) ? (dr["REVENUE_MONTHS"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["REVENUE_MONTHS"]) : 0,
                    Contract_Closure_Date = (dr.Table.Columns.Contains("DEAL_CLOSURE_EXP_DATE")) ? (dr["DEAL_CLOSURE_EXP_DATE"] == DBNull.Value) ? "" : Convert.ToString(dr["DEAL_CLOSURE_EXP_DATE"]) : "",
                    //DEAL_AGING= (dr.Table.Columns.Contains("WON_FTE")) ? (dr["WON_FTE"] == DBNull.Value) ? "" : dr.Field<string>("DEAL_CLOSURE_EXP_DATE") : "",
                    // WIN_REASON_ID= (dr.Table.Columns.Contains("WON_FTE")) ? (dr["WON_FTE"] == DBNull.Value) ? "" : dr.Field<string>("WON_FTE") : "",
                    WIN_VERBATIM = (dr.Table.Columns.Contains("WIN_LOSS_VERBATUM")) ? (dr["WIN_LOSS_VERBATUM"] == DBNull.Value) ? "" : dr.Field<string>("WIN_LOSS_VERBATUM") : "",
                    WON_FINAL_TCV = (dr.Table.Columns.Contains("WON_FINAL_TCV")) ? (dr["WON_FINAL_TCV"] == DBNull.Value) ? 0 : Convert.ToDouble(dr["WON_FINAL_TCV"]) : 0,
                    Category_RAG = (dr.Table.Columns.Contains("RAG_STATUS_FLAG")) ? (dr["RAG_STATUS_FLAG"] == DBNull.Value) ? "" : dr.Field<string>("RAG_STATUS_FLAG") : "",
                    DEAL_REASON1 = (dr.Table.Columns.Contains("DEAL_REASON1")) ? (dr["DEAL_REASON1"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["DEAL_REASON1"]) : 0,
                    DEAL_REASON2 = (dr.Table.Columns.Contains("DEAL_REASON2")) ? (dr["DEAL_REASON2"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["DEAL_REASON2"]) : 0,
                    DEAL_REASON3 = (dr.Table.Columns.Contains("DEAL_REASON3")) ? (dr["DEAL_REASON3"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["DEAL_REASON3"]) : 0,
                    Submitted_DT = (dr.Table.Columns.Contains("SUBMITTED_DT")) ? (dr["SUBMITTED_DT"] == DBNull.Value) ? "" : Convert.ToString(dr["SUBMITTED_DT"]) : "",
                    OpportunityId = (dr.Table.Columns.Contains("OPPORTUNITY_ID")) ? (dr["OPPORTUNITY_ID"] == DBNull.Value) ? "" : Convert.ToString(dr["OPPORTUNITY_ID"]) : "",

                    OLD_OPPORTUNITY_DESC = (dr.Table.Columns.Contains("OLD_OPPORTUNITY_DESC")) ? (dr["OLD_OPPORTUNITY_DESC"] == DBNull.Value) ? "" : dr.Field<string>("OLD_OPPORTUNITY_DESC") : "",
                    GEOGRAPHY_NAME = (dr.Table.Columns.Contains("GEOGRAPHY_NAME")) ? (dr["GEOGRAPHY_NAME"] == DBNull.Value) ? "" : dr.Field<string>("GEOGRAPHY_NAME") : "",
                    CUST_NAME = (dr.Table.Columns.Contains("CUST_NAME")) ? (dr["CUST_NAME"] == DBNull.Value) ? "" : dr.Field<string>("CUST_NAME") : "",
                    CUST_TYPE_NAME = (dr.Table.Columns.Contains("CUST_TYPE_NAME")) ? (dr["CUST_TYPE_NAME"] == DBNull.Value) ? "" : dr.Field<string>("CUST_TYPE_NAME") : "",
                    INDUSTRY_PRACTICE_NAME = (dr.Table.Columns.Contains("INDUSTRY_PRACTICE_NAME")) ? (dr["INDUSTRY_PRACTICE_NAME"] == DBNull.Value) ? "" : dr.Field<string>("INDUSTRY_PRACTICE_NAME") : "",
                    STAGE_NAME = (dr.Table.Columns.Contains("STAGE_NAME")) ? (dr["STAGE_NAME"] == DBNull.Value) ? "" : dr.Field<string>("STAGE_NAME") : "",
                    ISU_NAME = (dr.Table.Columns.Contains("ISU_NAME")) ? (dr["ISU_NAME"] == DBNull.Value) ? "" : dr.Field<string>("ISU_NAME") : "",
                    GEOGRAPHY_SALES_OWNER = (dr.Table.Columns.Contains("GEOGRAPHY_SALES_OWNER_ID")) ? (dr["GEOGRAPHY_SALES_OWNER_ID"] == DBNull.Value) ? "" : dr.Field<string>("GEOGRAPHY_SALES_OWNER_ID") : "",
                    ONSITE_OWNER = (dr.Table.Columns.Contains("ONSITE_OWNER_ID")) ? (dr["ONSITE_OWNER_ID"] == DBNull.Value) ? "" : dr.Field<string>("ONSITE_OWNER_ID") : "",
                    OFFSHORE_BD_LEAD = (dr.Table.Columns.Contains("OFFSHORE_BD_LEAD_ID")) ? (dr["OFFSHORE_BD_LEAD_ID"] == DBNull.Value) ? "" : dr.Field<string>("OFFSHORE_BD_LEAD_ID") : "",
                    offeringType = (dr.Table.Columns.Contains("OfferingType_Id")) ? (dr["OfferingType_Id"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["OfferingType_Id"]) : 0,
                    CofID = (dr.Table.Columns.Contains("CoreOfferingName_Id")) ? (dr["CoreOfferingName_Id"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CoreOfferingName_Id"]) : 0,

                    //RFIReceivedDate = dr.Table.Columns.Contains("RFI_RECEIVED_DT") ? (dr["RFI_RECEIVED_DT"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["RFI_RECEIVED_DT"]) : 0,

                    //RFIProbableSubmissionDate = dr.Table.Columns.Contains("RFI_PROBABLE_SUBMISSION_DT") ? (dr["RFI_PROBABLE_SUBMISSION_DT"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["RFI_PROBABLE_SUBMISSION_DT"]) : 0,
                    //RFIActualSubmissionDate = dr.Table.Columns.Contains("RFI_ACTUAL_SUBMISSION_DT") ? (dr["RFI_ACTUAL_SUBMISSION_DT"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["RFI_ACTUAL_SUBMISSION_DT"]) : 0,
                    //RFISubmissionDate = dr.Table.Columns.Contains("RFI_SUBMISSION_DT") ? (dr["RFI_SUBMISSION_DT"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["RFI_SUBMISSION_DT"]) : 0,
                    //RFPReceivedDate = (dr.Table.Columns.Contains("RFP_RECEIVED_DT")) ? (dr["RFP_RECEIVED_DT"] == DBNull.Value) ? 0 : Convert.ToInt32(dr.Field<DateTime>("RFP_RECEIVED_DT")) : 0,
                    //RFPProbableSubmissionDate = dr.Table.Columns.Contains("RFP_PROBABLE_SUBMISSION_DT") ? (dr["RFP_PROBABLE_SUBMISSION_DT"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["RFP_PROBABLE_SUBMISSION_DT"]) : 0,
                    //RFPActualSubmissionDate = dr.Table.Columns.Contains("RFP_ACTUAL_SUBMISSION_DT") ? (dr["RFP_ACTUAL_SUBMISSION_DT"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["RFP_ACTUAL_SUBMISSION_DT"]) : 0,
                    //RFPSubmissionDate = dr.Table.Columns.Contains("RFP_SUBMISSION_DT") ? (dr["RFP_SUBMISSION_DT"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["RFP_SUBMISSION_DT"]) : 0,
                    //RFIApprovedBy = (dr.Table.Columns.Contains("RFI_APPROVED_BY")) ? (dr["RFI_APPROVED_BY"] == DBNull.Value) ? "" : Convert.ToString(dr["RFI_APPROVED_BY"]) : "",
                    //RFPApprovedBy = (dr.Table.Columns.Contains("RFP_APPROVED_BY")) ? (dr["RFP_APPROVED_BY"] == DBNull.Value) ? "" : Convert.ToString(dr["RFP_APPROVED_BY"]) : "",
                    DTOTAL_CONTRACT_VALUE = (dr.Table.Columns.Contains("TOTAL_CONTRACT_VALUE")) ? (dr["TOTAL_CONTRACT_VALUE"] == DBNull.Value) ? 0 : Convert.ToDouble(dr["TOTAL_CONTRACT_VALUE"]) : 0,
                    PIBS = (dr.Table.Columns.Contains("PIBS")) ? (dr["PIBS"] == DBNull.Value) ? "" : dr.Field<string>("PIBS") : "",

                    CRM_ID = (dr.Table.Columns.Contains("CRM_ID")) ? (dr["CRM_ID"] == DBNull.Value) ? "" : dr.Field<string>("CRM_ID") : "",
                    VALUE_BPS = (dr.Table.Columns.Contains("VALUE_BPS")) ? (dr["VALUE_BPS"] == DBNull.Value) ? "" : dr.Field<string>("VALUE_BPS") : "",
                    VALUE_BPS_TCV = (dr.Table.Columns.Contains("VALUE_BPS_TCV")) ? (dr["VALUE_BPS_TCV"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["VALUE_BPS_TCV"]) : 0,
                    OPP_TYPE = (dr.Table.Columns.Contains("OPP_TYPE")) ? (dr["OPP_TYPE"] == DBNull.Value) ? "" : dr.Field<string>("OPP_TYPE") : "",
                    IESTIMATED_FTE_SIZE = (dr.Table.Columns.Contains("ESTIMATED_FTE_SIZE")) ? (dr["ESTIMATED_FTE_SIZE"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["ESTIMATED_FTE_SIZE"]) : 0,
                    //ContractLength = (dr.Table.Columns.Contains("CONTRACT_LENGTH")) ? (dr["CONTRACT_LENGTH"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CONTRACT_LENGTH"]) : 0,
                    LAST_UPDATE = (dr.Table.Columns.Contains("LAST_UPDATE")) ? (dr["LAST_UPDATE"] == DBNull.Value) ? "" : dr.Field<string>("LAST_UPDATE") : "",
                    RFI_ReviewDate = (dr.Table.Columns.Contains("RFI_REVIEW_DT")) ? (dr["RFI_REVIEW_DT"] == DBNull.Value) ? "" : dr.Field<string>("RFI_REVIEW_DT") : "",
                    RFP_ReviewDate = (dr.Table.Columns.Contains("RFP_REVIEW_DT")) ? (dr["RFP_REVIEW_DT"] == DBNull.Value) ? "" : dr.Field<string>("RFP_REVIEW_DT") : "",
                    //  BCP_DRP_LOCATION = (dr.Table.Columns.Contains("BCP_DRP_LOCATION")) ? (dr["BCP_DRP_LOCATION"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["BCP_DRP_LOCATION"]) : 0,
                    RFI_REVIEW_BY = (dr.Table.Columns.Contains("RFI_REVIEW_BY")) ? (dr["RFI_REVIEW_BY"] == DBNull.Value) ? "" : dr.Field<string>("RFI_REVIEW_BY") : "",
                    RFP_REVIEW_BY = (dr.Table.Columns.Contains("RFP_REVIEW_BY")) ? (dr["RFP_REVIEW_BY"] == DBNull.Value) ? "" : dr.Field<string>("RFP_REVIEW_BY") : "",
                    // CURRENCY_ID = (dr.Table.Columns.Contains("CURRENCY_ID")) ? (dr["CURRENCY_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CURRENCY_ID"]) : 0,
                    FTEOff = (dr.Table.Columns.Contains("FTE_OFFSHORE")) ? (dr["FTE_OFFSHORE"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["FTE_OFFSHORE"]) : 0,
                    FTEOn = (dr.Table.Columns.Contains("FTE_ONSITE")) ? (dr["FTE_ONSITE"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["FTE_ONSITE"]) : 0,
                    ClusterId = (dr.Table.Columns.Contains("CLUSTER_ID")) ? (dr["CLUSTER_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CLUSTER_ID"]) : 0,
                    DealCategory = (dr.Table.Columns.Contains("DEAL_CATEGORY")) ? (dr["DEAL_CATEGORY"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["DEAL_CATEGORY"]) : 0,

                    BPS_OFFERING_ID = (dr.Table.Columns.Contains("BPS_OFFERING_ID")) ? (dr["BPS_OFFERING_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["BPS_OFFERING_ID"]) : 0,
                    SERVICE_ID = (dr.Table.Columns.Contains("SERVICE_ID")) ? (dr["SERVICE_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["SERVICE_ID"]) : 0,
                    SUB_IOU = (dr.Table.Columns.Contains("SUB_IOU")) ? (dr["SUB_IOU"] == DBNull.Value) ? "" : dr.Field<string>("SUB_IOU") : "",
                    VALBPS_CON = (dr.Table.Columns.Contains("VALBPS_CON")) ? (dr["VALBPS_CON"] == DBNull.Value) ? "" : dr.Field<string>("VALBPS_CON") : "",
                    PROACTIVE_PROPOSAL = (dr.Table.Columns.Contains("PROACTIVE_PROPOSAL")) ? (dr["PROACTIVE_PROPOSAL"] == DBNull.Value) ? "" : dr.Field<string>("PROACTIVE_PROPOSAL") : "",
                    ISU_MAIN = (dr.Table.Columns.Contains("ISU_MAIN")) ? (dr["ISU_MAIN"] == DBNull.Value) ? "" : dr.Field<string>("ISU_MAIN") : "",
                    Quarter = (dr.Table.Columns.Contains("quarter")) ? (dr["quarter"] == DBNull.Value) ? "" : dr.Field<string>("quarter") : "",
                    FISCAL_YEAR = (dr.Table.Columns.Contains("FISCAL_YEAR")) ? (dr["FISCAL_YEAR"] == DBNull.Value) ? "" : dr.Field<string>("FISCAL_YEAR") : "",
                    PROPOSAL_FACTORY = (dr.Table.Columns.Contains("PROPOSAL_FACTORY")) ? (dr["PROPOSAL_FACTORY"] == DBNull.Value) ? "" : dr.Field<string>("PROPOSAL_FACTORY") : "",
                    PROPOSAL_FACTORY_OPTIONS = (dr.Table.Columns.Contains("PROPOSAL_FACTORY_OPTIONS")) ? (dr["PROPOSAL_FACTORY_OPTIONS"] == DBNull.Value) ? "" : dr.Field<string>("PROPOSAL_FACTORY_OPTIONS") : "",
                    PROPOSAL_FACTORY_COMMENTS = (dr.Table.Columns.Contains("PROPOSAL_FACTORY_COMMENTS")) ? (dr["PROPOSAL_FACTORY_COMMENTS"] == DBNull.Value) ? "" : dr.Field<string>("PROPOSAL_FACTORY_COMMENTS") : "",
                    DT_ID = (dr.Table.Columns.Contains("DT_ID")) ? (dr["DT_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["DT_ID"]) : 0,
                    Other_DT = (dr.Table.Columns.Contains("Other_DT")) ? (dr["Other_DT"] == DBNull.Value) ? "" : dr.Field<string>("Other_DT") : "",
                    CRM_TCV = (dr.Table.Columns.Contains("CRM_TCV")) ? (dr["CRM_TCV"] == DBNull.Value) ? "" : Convert.ToString(dr["CRM_TCV"]) : "",
                    CRM_STAGE = (dr.Table.Columns.Contains("CRM_STAGE")) ? (dr["CRM_STAGE"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CRM_STAGE"]) : 0,
                    strDigitalTcv = (dr.Table.Columns.Contains("Digital_TCV")) ? (dr["Digital_TCV"] == DBNull.Value) ? "" : dr.Field<string>("Digital_TCV") : "",
                    subSPId = (dr.Table.Columns.Contains("SubSPID")) ? (dr["SubSPID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["SubSPID"]) : 0,
                    CRM_Beacon = (dr.Table.Columns.Contains("CRM_Beacon")) ? (dr["CRM_Beacon"] == DBNull.Value) ? "" : Convert.ToString(dr["CRM_Beacon"]) : "",

                    MULTITOWER_DEAL = (dr.Table.Columns.Contains("MULTITOWER_DEAL")) ? (dr["MULTITOWER_DEAL"] == DBNull.Value) ? "" : dr.Field<string>("MULTITOWER_DEAL") : "",
                    TataGroupAccount = (dr.Table.Columns.Contains("TATA_GROUP_ACCOUNT")) ? (dr["TATA_GROUP_ACCOUNT"] == DBNull.Value) ? "" : Convert.ToString(dr["TATA_GROUP_ACCOUNT"]) : "",
                    ItisScope = (dr.Table.Columns.Contains("ItisScope")) ? (dr["ItisScope"] == DBNull.Value) ? "" : Convert.ToString(dr["ItisScope"]) : "",
                    IsContractRenewal = (dr.Table.Columns.Contains("IsContractRenewal")) ? (dr["IsContractRenewal"] == DBNull.Value) ? "" : Convert.ToString(dr["IsContractRenewal"]) : "",
                    ContractRenewalValue = (dr.Table.Columns.Contains("ContractRenewalValue")) ? (dr["ContractRenewalValue"] == DBNull.Value) ? "" : Convert.ToString(dr["ContractRenewalValue"]) : "",
                    RESOURCING_ID = (dr.Table.Columns.Contains("ResourcingId")) ? (dr["ResourcingId"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["ResourcingId"]) : 0,
                    SEAT_IDENTIFICATION_ID = (dr.Table.Columns.Contains("Seat_IdentificationId")) ? (dr["Seat_IdentificationId"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["Seat_IdentificationId"]) : 0,
                    ActualCloseDate= (dr.Table.Columns.Contains("Actual_Close_Date")) ? (dr["Actual_Close_Date"] == DBNull.Value) ? "" : dr.Field<string>("Actual_Close_Date") : "",
                    DealClosureReason = (dr.Table.Columns.Contains("Deal_Closure_Reason")) ? (dr["Deal_Closure_Reason"] == DBNull.Value) ? "" : dr.Field<string>("Deal_Closure_Reason") : "",
                    OpportunityDescDetails = (dr.Table.Columns.Contains("Opportunity_Desc_Details")) ? (dr["Opportunity_Desc_Details"] == DBNull.Value) ? "" : dr.Field<string>("Opportunity_Desc_Details") : "",
                    SALES_STAGE_MOVED_ONDATE = (dr.Table.Columns.Contains("SALES_STAGE_MOVED_ON_DATE")) ? (dr["SALES_STAGE_MOVED_ON_DATE"] == DBNull.Value) ? "" : dr.Field<string>("SALES_STAGE_MOVED_ON_DATE") : "",
                    Previous_Deal_Stage = (dr.Table.Columns.Contains("Previous_Deal_Stage")) ? (dr["Previous_Deal_Stage"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["Previous_Deal_Stage"]) : 0,
                    DELIVERY_LOCATION_PROPOSED = (dr.Table.Columns.Contains("DELIVERY_LOCATION_PROPOSED")) ? (dr["DELIVERY_LOCATION_PROPOSED"] == DBNull.Value) ? "" : dr.Field<string>("DELIVERY_LOCATION_PROPOSED") : "",
                    DigitalFlagging = (dr.Table.Columns.Contains("Digital_Flagging")) ? (dr["Digital_Flagging"] == DBNull.Value) ? "" : Convert.ToString(dr["Digital_Flagging"]) : "",
                    PROPOSAL_SUBMISSION_DATE = (dr.Table.Columns.Contains("PROPOSAL_SUBMISSION_DATE")) ? (dr["PROPOSAL_SUBMISSION_DATE"] == DBNull.Value) ? "" : dr.Field<string>("PROPOSAL_SUBMISSION_DATE") : "",
                    DealStatus = (dr.Table.Columns.Contains("DealStatus_Id")) ? (dr["DealStatus_Id"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["DealStatus_Id"]) : 0,
                    ServicePractice = (dr.Table.Columns.Contains("ServicePractice_Id")) ? (dr["ServicePractice_Id"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["ServicePractice_Id"]) : 0,
                    CoreOffering = (dr.Table.Columns.Contains("CoreOffering_Id")) ? (dr["CoreOffering_Id"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["CoreOffering_Id"]) : 0,

                    Cboi_Offering_id = (dr.Table.Columns.Contains("cboi_offering_id")) ? (dr["cboi_offering_id"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["cboi_offering_id"]) : 0,
                    Deal_Flag_id = (dr.Table.Columns.Contains("deal_flag")) ? (dr["deal_flag"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["deal_flag"]) : 0,
                    PLATFORM_OPTION = (dr.Table.Columns.Contains("PLATFORM_OPTION")) ? (dr["PLATFORM_OPTION"] == DBNull.Value) ? "" : dr.Field<string>("PLATFORM_OPTION") : "",








                };
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
        }


        /// <summary>
        /// Get Opportunity_Stage1_sp_INFRA Details
        /// </summary>
        public List<CreateNewOpportunity> Get_Infra_stage1(CreateNewOpportunity ObjCreateNewOpportunity)
        {
            DataSet ds = null;
            List<CreateNewOpportunity> IndustryPraciseList = new List<CreateNewOpportunity>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.GetOpportunity_Stage1_sp_INFRA);
                db.AddInParameter(cd, "@in_OpportunityId", SqlDbType.VarChar, ObjCreateNewOpportunity.OpportunityId);
                db.AddInParameter(cd, "@in_StageId", SqlDbType.Int, ObjCreateNewOpportunity.StageID);

                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;

                        for (int i = 0; i < rowCount; i++)
                        {
                            IndustryPraciseList.Add(MapGet_Infra_stage1(ds.Tables[0].Rows[i]));
                        }

                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }
            return IndustryPraciseList;
        }

        private static CreateNewOpportunity MapGet_Infra_stage1(DataRow dr)
        {
            try
            {
                return new CreateNewOpportunity()
                {

                    OPERATION_WINDOW = (dr.Table.Columns.Contains("OPERATION_WINDOW")) ? (dr["OPERATION_WINDOW"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["OPERATION_WINDOW"]) : 0,
                    TYPES_OF_SEAT = (dr.Table.Columns.Contains("TYPES_OF_SEAT")) ? (dr["TYPES_OF_SEAT"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["TYPES_OF_SEAT"]) : 0,
                    AREA = (dr.Table.Columns.Contains("AREA")) ? (dr["AREA"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["AREA"]) : 0,

                };
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
        }
        /// <summary>
        /// Save Stage9 Details
        /// </summary>
        public int Save_Stage9Opportunity(CreateNewOpportunity ObjCreateNewOpportunity)
        {
            try
            {
                int intResult;
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Ins_Opportunity_stage9_sp);
                db.AddInParameter(cd, "@in_OpportunityId", SqlDbType.VarChar, ObjCreateNewOpportunity.OpportunityId);
                db.AddInParameter(cd, "@iv_OpportunityDesc", SqlDbType.VarChar, ObjCreateNewOpportunity.OPPORTUNITY_DESC);
                db.AddInParameter(cd, "@iv_OldOpportunityDesc", SqlDbType.VarChar, ObjCreateNewOpportunity.OLD_OPPORTUNITY_DESC);
                db.AddInParameter(cd, "@in_GeographyId", SqlDbType.VarChar, ObjCreateNewOpportunity.GEOGRAPHY_ID);
                db.AddInParameter(cd, "@in_CustId", SqlDbType.VarChar, ObjCreateNewOpportunity.CUST_ID);
                db.AddInParameter(cd, "@in_CustTypeId", SqlDbType.VarChar, ObjCreateNewOpportunity.CUST_TYPE_ID);
                db.AddInParameter(cd, "@in_IndustryPracticeId", SqlDbType.VarChar, ObjCreateNewOpportunity.INDUSTRY_PRACTICE_ID);
                db.AddInParameter(cd, "@in_StageId", SqlDbType.VarChar, ObjCreateNewOpportunity.StageID);
                db.AddInParameter(cd, "@iv_GeographySalesOwner", SqlDbType.VarChar, ObjCreateNewOpportunity.GeosalesOwner);
                db.AddInParameter(cd, "@iv_OffshorePracticeOwner", SqlDbType.VarChar, ObjCreateNewOpportunity.OffPracOwner);
                db.AddInParameter(cd, "@iv_RdCrd", SqlDbType.VarChar, ObjCreateNewOpportunity.RDCrd);
                db.AddInParameter(cd, "@iv_OffshoreBDLead", SqlDbType.VarChar, ObjCreateNewOpportunity.OffShoreBDLead);
                db.AddInParameter(cd, "@iv_OnsiteOwner", SqlDbType.VarChar, ObjCreateNewOpportunity.OnsiteOwner);
                db.AddInParameter(cd, "@in_ProbabilityOfwin", SqlDbType.VarChar, ObjCreateNewOpportunity.PROBABILITY_OF_WIN);
                db.AddInParameter(cd, "@in_ContractLength", SqlDbType.VarChar, ObjCreateNewOpportunity.ContractLength);
                db.AddInParameter(cd, "@in_FTE", SqlDbType.VarChar, ObjCreateNewOpportunity.FTE);
                db.AddInParameter(cd, "@iv_Remark", SqlDbType.VarChar, ObjCreateNewOpportunity.REMARK);
                db.AddInParameter(cd, "@in_OppDate", SqlDbType.VarChar, ObjCreateNewOpportunity.OppDate);
                db.AddInParameter(cd, "@iv_EmpNo", SqlDbType.VarChar, ObjCreateNewOpportunity.EmpNo);
                db.AddInParameter(cd, "@in_ClosureDate", SqlDbType.VarChar, ObjCreateNewOpportunity.ClosureDate);
                db.AddInParameter(cd, "@in_AdvisoryId", SqlDbType.Int, ObjCreateNewOpportunity.ADVISORY_ID);
                db.AddInParameter(cd, "@iv_Platform", SqlDbType.VarChar, ObjCreateNewOpportunity.PLATFORM);
                db.AddInParameter(cd, "@in_PricingTypeId", SqlDbType.Int, ObjCreateNewOpportunity.PRICING_TYPE_ID);
                db.AddInParameter(cd, "@iv_NextStep", SqlDbType.VarChar, ObjCreateNewOpportunity.NextStep);
                db.AddInParameter(cd, "@in_BusinessId", SqlDbType.Int, ObjCreateNewOpportunity.BUSINESS_ID);
                db.AddInParameter(cd, "@in_ProductId", SqlDbType.VarChar, ObjCreateNewOpportunity.PRODUCT_ID);
                db.AddInParameter(cd, "@in_CompetencyId", SqlDbType.Int, ObjCreateNewOpportunity.COMPETENCY_ID);
                db.AddInParameter(cd, "@in_SubCompetencyId", SqlDbType.VarChar, ObjCreateNewOpportunity.SUB_COMPETENCY_ID);
                db.AddInParameter(cd, "@in_AnnualSaleValue", SqlDbType.VarChar, ObjCreateNewOpportunity.AnnualSaleValue);
                db.AddInParameter(cd, "@iv_AccountSalesOwner", SqlDbType.VarChar, ObjCreateNewOpportunity.AccountSalesOwner);
                db.AddInParameter(cd, "@iv_ExeSponser", SqlDbType.VarChar, ObjCreateNewOpportunity.ExeSponser);
                db.AddInParameter(cd, "@iv_ProactiveProposal", SqlDbType.VarChar, ObjCreateNewOpportunity.ProactiveProposal);
                db.AddInParameter(cd, "@iv_ValBPSCon", SqlDbType.VarChar, ObjCreateNewOpportunity.ValBPSCon);
                db.AddInParameter(cd, "@iv_IsuMain", SqlDbType.VarChar, ObjCreateNewOpportunity.IsuMain);
                db.AddInParameter(cd, "@iv_PlatformNew", SqlDbType.VarChar, ObjCreateNewOpportunity.PlatformNew);
                db.AddInParameter(cd, "@iv_StatusUpdate", SqlDbType.VarChar, ObjCreateNewOpportunity.StatusUpdate);
                db.AddInParameter(cd, "@in_CountryId", SqlDbType.VarChar, ObjCreateNewOpportunity.CountryId);
                db.AddInParameter(cd, "@in_NextStepDueDt", SqlDbType.VarChar, ObjCreateNewOpportunity.NextStepDueDt);
                db.AddInParameter(cd, "@in_UnitID", SqlDbType.Int, ObjCreateNewOpportunity.UnitId);
                db.AddInParameter(cd, "@iv_ISUOwner", SqlDbType.VarChar, ObjCreateNewOpportunity.ISU_OWNER_ID);
                db.AddInParameter(cd, "@iv_ISU", SqlDbType.VarChar, ObjCreateNewOpportunity.ISU_CD);
                db.AddInParameter(cd, "@iv_PIBS", SqlDbType.VarChar, ObjCreateNewOpportunity.PIBS);
                db.AddInParameter(cd, "@iv_TCS_INVESTMENT", SqlDbType.VarChar, ObjCreateNewOpportunity.TCSInvestment);
                db.AddInParameter(cd, "@in_PIBStartDate", SqlDbType.VarChar, ObjCreateNewOpportunity.PIBStartDate);
                db.AddInParameter(cd, "@in_PIBEndDate", SqlDbType.VarChar, ObjCreateNewOpportunity.PIBSEndDate);
                db.AddInParameter(cd, "@in_NoOfFTEsEngaged", SqlDbType.Int, ObjCreateNewOpportunity.FTEsEngaged);
                db.AddInParameter(cd, "@in_PIBStatus", SqlDbType.VarChar, ObjCreateNewOpportunity.PIBStatus);
                db.AddInParameter(cd, "@in_PIBSOutcome", SqlDbType.VarChar, ObjCreateNewOpportunity.PIBS_OUTCOME_ID);
                db.AddInParameter(cd, "@iv_PIBStatusRemarks", SqlDbType.VarChar, ObjCreateNewOpportunity.PIBStatusRemarks);
                db.AddInParameter(cd, "@iv_FTEType", SqlDbType.VarChar, ObjCreateNewOpportunity.FTE_TYPE);
                db.AddInParameter(cd, "@in_FTETypeCount", SqlDbType.VarChar, FTE_TYPE_COUNT);
                db.AddInParameter(cd, "@in_BPODomain", SqlDbType.VarChar, ObjCreateNewOpportunity.BPODomain);
                db.AddInParameter(cd, "@iv_DomainPresalesLead", SqlDbType.VarChar, ObjCreateNewOpportunity.DOMAIN_PRESALES_LEAD);
                db.AddInParameter(cd, "@in_DealCategory", SqlDbType.VarChar, ObjCreateNewOpportunity.DealCategory);
                db.AddInParameter(cd, "@in_BPSSubSPID", SqlDbType.Int, ObjCreateNewOpportunity.BPSSubSPID);
                db.AddInParameter(cd, "@in_BPSOfferingID", SqlDbType.Int, ObjCreateNewOpportunity.BPSOfferingID);
                db.AddInParameter(cd, "@iv_DealCoachName", SqlDbType.VarChar, ObjCreateNewOpportunity.DealCoachName);
                db.AddInParameter(cd, "@in_DemandType", SqlDbType.VarChar, ObjCreateNewOpportunity.DemandType);
                db.AddInParameter(cd, "@iv_KeyDeal", SqlDbType.VarChar, ObjCreateNewOpportunity.KEY_DEAL);
                db.AddInParameter(cd, "@iv_ProposedSolution", SqlDbType.VarChar, ObjCreateNewOpportunity.ProposedSolution);
                db.AddInParameter(cd, "@iv_KeyRmk", SqlDbType.VarChar, ObjCreateNewOpportunity.KeyRmk);
                db.AddInParameter(cd, "@iv_WinningTeam", SqlDbType.VarChar, ObjCreateNewOpportunity.WinningTheme);
                db.AddInParameter(cd, "@iv_KeyCustExp", SqlDbType.VarChar, ObjCreateNewOpportunity.KeyCustExp);
                db.AddInParameter(cd, "@iv_OperatingModel", SqlDbType.VarChar, ObjCreateNewOpportunity.operatingModel);
                db.AddInParameter(cd, "@iv_PricingModel", SqlDbType.VarChar, ObjCreateNewOpportunity.PRICING_MODEL);
                db.AddInParameter(cd, "@iv_Differentiators", SqlDbType.VarChar, ObjCreateNewOpportunity.Differentiators);
                db.AddInParameter(cd, "@iv_Risks", SqlDbType.VarChar, ObjCreateNewOpportunity.Risks);
                db.AddInParameter(cd, "@iv_KeyCustomerConnects", SqlDbType.VarChar, ObjCreateNewOpportunity.KeyCustomerConnects);
                db.AddInParameter(cd, "@iv_BPOOfferingDescription", SqlDbType.VarChar, ObjCreateNewOpportunity.BPOOfferingDescription);
                db.AddInParameter(cd, "@iv_FirstTimeOutsource", SqlDbType.VarChar, ObjCreateNewOpportunity.chkFirstTimeOutsource);
                db.AddInParameter(cd, "@iv_Incumbents", SqlDbType.VarChar, ObjCreateNewOpportunity.INCUMBENTS);
                db.AddInParameter(cd, "@iv_NameOfIncumbents", SqlDbType.VarChar, ObjCreateNewOpportunity.NAME_OF_INCUMBENTS);
                db.AddInParameter(cd, "@iv_TCSOfferingCapability", SqlDbType.VarChar, ObjCreateNewOpportunity.TCS_OFFERING_CAPABILITY);
                db.AddInParameter(cd, "@iv_SpecifyOffering", SqlDbType.VarChar, ObjCreateNewOpportunity.SpecifyOffering);
                db.AddInParameter(cd, "@iv_CoachAvailable", SqlDbType.VarChar, ObjCreateNewOpportunity.CoachAvailable);
                db.AddInParameter(cd, "@iv_FnA", SqlDbType.VarChar, ObjCreateNewOpportunity.FnA);
                db.AddInParameter(cd, "@in_Fna_FTE", SqlDbType.Int, ObjCreateNewOpportunity.FnA_FTE);
                db.AddInParameter(cd, "@iv_HRO", SqlDbType.VarChar, ObjCreateNewOpportunity.HRO);
                db.AddInParameter(cd, "@in_HRO_FTE", SqlDbType.Int, ObjCreateNewOpportunity.HRO_FTE);
                db.AddInParameter(cd, "@iv_SCM", SqlDbType.VarChar, ObjCreateNewOpportunity.SCM);
                db.AddInParameter(cd, "@in_SCM_FTE", SqlDbType.Int, ObjCreateNewOpportunity.SCM_FTE);
                db.AddInParameter(cd, "@iv_KPO", SqlDbType.VarChar, ObjCreateNewOpportunity.KPO);
                db.AddInParameter(cd, "@in_KPO_FTE", SqlDbType.Int, ObjCreateNewOpportunity.KPO_FTE);
                db.AddInParameter(cd, "@iv_LPO", SqlDbType.VarChar, ObjCreateNewOpportunity.LPO);
                db.AddInParameter(cd, "@in_LPO_FTE", SqlDbType.Int, ObjCreateNewOpportunity.LPO_FTE);
                db.AddInParameter(cd, "@iv_Vertical", SqlDbType.VarChar, ObjCreateNewOpportunity.VERTICAL);
                db.AddInParameter(cd, "@in_Vertical_FTE", SqlDbType.Int, ObjCreateNewOpportunity.VerticalFTE);
                db.AddInParameter(cd, "@iv_Voice", SqlDbType.VarChar, ObjCreateNewOpportunity.Voice);
                db.AddInParameter(cd, "@in_Voice_FTE", SqlDbType.Int, ObjCreateNewOpportunity.VoiceFTE);
                db.AddInParameter(cd, "@iv_Bpm", SqlDbType.VarChar, ObjCreateNewOpportunity.BPM);
                db.AddInParameter(cd, "@in_Bpm_FTE", SqlDbType.Int, ObjCreateNewOpportunity.BPM_FTE);
                db.AddInParameter(cd, "@in_SolTM", SqlDbType.Int, ObjCreateNewOpportunity.SolTM);
                db.AddInParameter(cd, "@in_DelTM", SqlDbType.Int, ObjCreateNewOpportunity.DelTM);
                db.AddInParameter(cd, "@iv_BidManager", SqlDbType.VarChar, ObjCreateNewOpportunity.BID_MANAGER);
                db.AddInParameter(cd, "@iv_BidExec", SqlDbType.VarChar, ObjCreateNewOpportunity.BID_EXEC_OWNER);
                db.AddInParameter(cd, "@iv_PricingOwner", SqlDbType.VarChar, ObjCreateNewOpportunity.PRICING_OWNER);
                db.AddInParameter(cd, "@in_TransitionTeam", SqlDbType.Int, ObjCreateNewOpportunity.TransitionTeam);
                db.AddInParameter(cd, "@iv_ExpectedDate", SqlDbType.VarChar, ObjCreateNewOpportunity.ExpectedDate);
                db.AddInParameter(cd, "@iv_TransitionReq", SqlDbType.VarChar, ObjCreateNewOpportunity.TransitionReq);
                db.AddInParameter(cd, "@iv_Quarter", SqlDbType.VarChar, ObjCreateNewOpportunity.Quarter);
                db.AddInParameter(cd, "@iv_FiscalYear", SqlDbType.VarChar, ObjCreateNewOpportunity.FiscalYear);
                db.AddInParameter(cd, "@in_RFIRwDt", SqlDbType.VarChar, ObjCreateNewOpportunity.RFI_REVIEW_DT);
                db.AddInParameter(cd, "@in_RFPRwDt", SqlDbType.VarChar, ObjCreateNewOpportunity.RFP_REVIEW_DT);
                db.AddInParameter(cd, "@iv_RFIBy", SqlDbType.VarChar, ObjCreateNewOpportunity.RFI_REVIEW_BY);
                db.AddInParameter(cd, "@iv_RFPBy", SqlDbType.VarChar, ObjCreateNewOpportunity.RFP_REVIEW_BY);
                db.AddInParameter(cd, "@iv_NGM", SqlDbType.VarChar, ObjCreateNewOpportunity.OPP_NGM);
                db.AddInParameter(cd, "@iv_CRMReason", SqlDbType.VarChar, ObjCreateNewOpportunity.CRM_REASON);
                db.AddInParameter(cd, "@iv_BidExeEmpId", SqlDbType.VarChar, ObjCreateNewOpportunity.BID_EXECUTIVE_EMPID);
                db.AddInParameter(cd, "@iv_Disqual", SqlDbType.VarChar, ObjCreateNewOpportunity.Disqual);
                db.AddInParameter(cd, "@iv_AddDeal", SqlDbType.VarChar, ObjCreateNewOpportunity.AddDeal);
                db.AddInParameter(cd, "@iv_BidExeName", SqlDbType.VarChar, ObjCreateNewOpportunity.BID_EXECUTIVE_NAME);
                db.AddInParameter(cd, "@iv_DealOwner", SqlDbType.VarChar, ObjCreateNewOpportunity.DealOwner);
                db.AddInParameter(cd, "@iv_DealOwner2", SqlDbType.VarChar, ObjCreateNewOpportunity.DealOwner2);
                db.AddInParameter(cd, "@iv_ImmediateComment", SqlDbType.VarChar, ObjCreateNewOpportunity.ImmediateComment);
                db.AddInParameter(cd, "@iv_FTEDD", SqlDbType.VarChar, ObjCreateNewOpportunity.FTEDD);
                db.AddInParameter(cd, "@iv_SolutionLeader", SqlDbType.VarChar, ObjCreateNewOpportunity.SolutionLeader);
                db.AddInParameter(cd, "@iv_RUR", SqlDbType.VarChar, ObjCreateNewOpportunity.RUR);
                db.AddInParameter(cd, "@iv_HRT_Comments", SqlDbType.VarChar, ObjCreateNewOpportunity.HRTComments);
                db.AddInParameter(cd, "@in_Seat_Requirements", SqlDbType.Int, ObjCreateNewOpportunity.SeatRequirements);
                db.AddInParameter(cd, "@iv_CRMId", SqlDbType.VarChar, ObjCreateNewOpportunity.CRM_ID);
                db.AddInParameter(cd, "@in_TCV", SqlDbType.VarChar, ObjCreateNewOpportunity.TCV);
                db.AddInParameter(cd, "@iv_ValueBPS", SqlDbType.VarChar, ObjCreateNewOpportunity.ValueBPS);
                db.AddInParameter(cd, "@in_ValueBPSTCV", SqlDbType.VarChar, ObjCreateNewOpportunity.ValueBPSTCV);
                db.AddInParameter(cd, "@iv_OppType", SqlDbType.VarChar, ObjCreateNewOpportunity.OPP_TYPE);
                db.AddInParameter(cd, "@iv_MultiTower", SqlDbType.VarChar, ObjCreateNewOpportunity.MultiTower);
                db.AddInParameter(cd, "@in_StatusFlag", SqlDbType.Int, ObjCreateNewOpportunity.StatusFlag);
                db.AddInParameter(cd, "@iv_Fna_Lead", SqlDbType.VarChar, ObjCreateNewOpportunity.FnA_Lead);
                db.AddInParameter(cd, "@iv_HRO_Lead", SqlDbType.VarChar, ObjCreateNewOpportunity.HRO_Lead);
                db.AddInParameter(cd, "@iv_SCM_Lead", SqlDbType.VarChar, ObjCreateNewOpportunity.SCM_Lead);
                db.AddInParameter(cd, "@iv_KPO_Lead", SqlDbType.VarChar, ObjCreateNewOpportunity.KPO_Lead);
                db.AddInParameter(cd, "@iv_LPO_Lead", SqlDbType.VarChar, ObjCreateNewOpportunity.LPO_Lead);
                db.AddInParameter(cd, "@iv_Vertical_Lead", SqlDbType.VarChar, ObjCreateNewOpportunity.VERTICAL_LEAD);
                db.AddInParameter(cd, "@iv_Voice_Lead", SqlDbType.VarChar, ObjCreateNewOpportunity.Voice_Lead);
                db.AddInParameter(cd, "@iv_Bpm_Lead", SqlDbType.VarChar, ObjCreateNewOpportunity.BPM_LEAD);
                db.AddInParameter(cd, "@iv_BidManagerId", SqlDbType.VarChar, ObjCreateNewOpportunity.BID_MANAGER_EMPID);
                db.AddInParameter(cd, "@iv_BidExecId", SqlDbType.VarChar, ObjCreateNewOpportunity.BID_EXEC_OWNER_EMPID);
                db.AddInParameter(cd, "@iv_PricingOwnerId", SqlDbType.VarChar, ObjCreateNewOpportunity.PRICING_OWNER_EMPID);
                db.AddInParameter(cd, "@iv_SolutionLeaderId", SqlDbType.VarChar, ObjCreateNewOpportunity.SolutionLeaderId);
                db.AddInParameter(cd, "@iv_FnaTCV", SqlDbType.VarChar, ObjCreateNewOpportunity.FnATCV);
                db.AddInParameter(cd, "@iv_HROTCV", SqlDbType.VarChar, ObjCreateNewOpportunity.HROTCV);
                db.AddInParameter(cd, "@iv_SCMTCV", SqlDbType.VarChar, ObjCreateNewOpportunity.SCMTCV);
                db.AddInParameter(cd, "@iv_KPOTCV", SqlDbType.VarChar, ObjCreateNewOpportunity.KPOTCV);
                db.AddInParameter(cd, "@iv_LPOTCV", SqlDbType.VarChar, ObjCreateNewOpportunity.LPOTCV);
                db.AddInParameter(cd, "@iv_VerticalTCV", SqlDbType.VarChar, ObjCreateNewOpportunity.VERTICALTCV);
                db.AddInParameter(cd, "@iv_VoiceTCV", SqlDbType.VarChar, ObjCreateNewOpportunity.VOICETCV);
                db.AddInParameter(cd, "@iv_BpmTCV", SqlDbType.VarChar, ObjCreateNewOpportunity.BPMTCV);
                db.AddInParameter(cd, "@in_PIBSTCV", SqlDbType.VarChar, ObjCreateNewOpportunity.PibsSaleValue);
                db.AddInParameter(cd, "@in_ClusterId", SqlDbType.Int, ObjCreateNewOpportunity.ClusterId);
                db.AddInParameter(cd, "@in_ServiceId", SqlDbType.Int, ObjCreateNewOpportunity.ServiceId);
                db.AddInParameter(cd, "@in_SUBIOU", SqlDbType.VarChar, ObjCreateNewOpportunity.SUBIOU);
                db.AddInParameter(cd, "@in_strTransitionEmpId", SqlDbType.VarChar, ObjCreateNewOpportunity.TransitionEmpId);
                db.AddInParameter(cd, "@in_strTransitionName", SqlDbType.VarChar, ObjCreateNewOpportunity.TransitionName);
                db.AddInParameter(cd, "@in_strTransitionType", SqlDbType.VarChar, ObjCreateNewOpportunity.TransitionType);
                db.AddInParameter(cd, "@in_strTransitionApproach", SqlDbType.VarChar, ObjCreateNewOpportunity.TransitionApproach);
                db.AddInParameter(cd, "@in_strTransitionModel", SqlDbType.VarChar, ObjCreateNewOpportunity.TransitionModel);
                db.AddInParameter(cd, "@in_strProposalfactory", SqlDbType.VarChar, ObjCreateNewOpportunity.Proposalfactory);
                db.AddInParameter(cd, "@in_strProposalfactoryOptions", SqlDbType.VarChar, ObjCreateNewOpportunity.ProposalfactoryOptions);
                db.AddInParameter(cd, "@in_strProposalComments", SqlDbType.VarChar, ObjCreateNewOpportunity.ProposalComments);
                db.AddInParameter(cd, "@iv_DTValue", SqlDbType.VarChar, ObjCreateNewOpportunity.DTValue);
                db.AddInParameter(cd, "@iv_OtherDT", SqlDbType.VarChar, ObjCreateNewOpportunity.Other_DT);
                db.AddInParameter(cd, "@in_OnsiteTrainingNos", SqlDbType.VarChar, ObjCreateNewOpportunity.ONSITE_TRAINING_NOS);
                db.AddInParameter(cd, "@in_TrainingDuration", SqlDbType.VarChar, ObjCreateNewOpportunity.TRAINING_DURATION);
                db.AddInParameter(cd, "@in_ShortListDt", SqlDbType.VarChar, ObjCreateNewOpportunity.SelectionDate);
                db.AddInParameter(cd, "@in_SelectionDt", SqlDbType.VarChar, ObjCreateNewOpportunity.ShortListDate);
                db.AddInParameter(cd, "@in_WINDate", SqlDbType.VarChar, ObjCreateNewOpportunity.WIN_DT);
                db.AddInParameter(cd, "@iv_WinReason", SqlDbType.VarChar, ObjCreateNewOpportunity.WIN_VERBATIM);
                db.AddInParameter(cd, "@in_CategoryId", SqlDbType.VarChar, ObjCreateNewOpportunity.Category_RAG);
                db.AddInParameter(cd, "@in_WonFTE", SqlDbType.Int, ObjCreateNewOpportunity.WON_FTE);
                db.AddInParameter(cd, "@iv_WonTCV", SqlDbType.Decimal, ObjCreateNewOpportunity.WON_FINAL_TCV);
                db.AddInParameter(cd, "@in_AnticipatedDate  ", SqlDbType.VarChar, ObjCreateNewOpportunity.ANTICIPATED_ACTUAL_STDT);
                db.AddInParameter(cd, "@iv_RevenueCFY", SqlDbType.Int, ObjCreateNewOpportunity.CURRENT_FISCAL_REVENUE);
                db.AddInParameter(cd, "@iv_ProjectWon", SqlDbType.VarChar, ObjCreateNewOpportunity.PROJECT_WON);
                db.AddInParameter(cd, "@in_RevenueMonth", SqlDbType.Int, ObjCreateNewOpportunity.REVENUE_MONTHS);
                db.AddInParameter(cd, "@in_CurencyId", SqlDbType.Int, ObjCreateNewOpportunity.CURRENCY_ID);
                db.AddInParameter(cd, "@in_FiscalRev", SqlDbType.Float, ObjCreateNewOpportunity.FiscRev);
                db.AddInParameter(cd, "@in_RFIReceivedDt", SqlDbType.Int, ObjCreateNewOpportunity.RFIReceivedDate);
                db.AddInParameter(cd, "@in_RFIProbSubmissiondDt", SqlDbType.Int, ObjCreateNewOpportunity.RFIProbableSubmissionDate);
                db.AddInParameter(cd, "@iv_VisaRequired", SqlDbType.Int, null);
                db.AddInParameter(cd, "@in_VisasRequired", SqlDbType.Int, null);
                db.AddInParameter(cd, "@in_RFIActSubmissiondDt", SqlDbType.Int, ObjCreateNewOpportunity.RFIActualSubmissionDate);
                db.AddInParameter(cd, "@in_RFPReceivedDt", SqlDbType.Int, ObjCreateNewOpportunity.RFPReceivedDate);
                db.AddInParameter(cd, "@in_RFPProbSubmissiondDt", SqlDbType.Int, ObjCreateNewOpportunity.RFPProbableSubmissionDate);
                db.AddInParameter(cd, "@in_RFPActSubmissiondDt", SqlDbType.Int, ObjCreateNewOpportunity.RFPActualSubmissionDate);
                db.AddInParameter(cd, "@in_BCPDRPLoc", SqlDbType.Int, ObjCreateNewOpportunity.BCP_DRP_LOCATION);
                db.AddInParameter(cd, "@in_OperationWindow", SqlDbType.Int, ObjCreateNewOpportunity.OPERATION_WINDOW);
                db.AddInParameter(cd, "@in_Area", SqlDbType.Int, ObjCreateNewOpportunity.AREA);
                db.AddInParameter(cd, "@in_TypesOfSeat", SqlDbType.Int, ObjCreateNewOpportunity.TYPES_OF_SEAT);
                db.AddInParameter(cd, "@in_PCsRequired", SqlDbType.Int, ObjCreateNewOpportunity.PCS_REQUIRED);
                db.AddInParameter(cd, "@in_DesksRequired", SqlDbType.Int, ObjCreateNewOpportunity.DESKS_REQUIRED);
                db.AddInParameter(cd, "@in_PhonesRequired", SqlDbType.Int, ObjCreateNewOpportunity.PHONES_REQUIRED);
                db.AddInParameter(cd, "@in_CabinsRequired", SqlDbType.Int, ObjCreateNewOpportunity.CABINS_REQUIRED);
                db.AddInParameter(cd, "@in_LaptopsRequired", SqlDbType.Int, ObjCreateNewOpportunity.LAPTOPS_REQUIRED);
                db.AddInParameter(cd, "@in_Comp1", SqlDbType.VarChar, ObjCreateNewOpportunity.COMPETITOR_1);
                db.AddInParameter(cd, "@in_Comp2", SqlDbType.VarChar, ObjCreateNewOpportunity.COMPETITOR_2);
                db.AddInParameter(cd, "@in_Comp3", SqlDbType.VarChar, ObjCreateNewOpportunity.COMPETITOR_3);
                db.AddInParameter(cd, "@in_Comp4", SqlDbType.VarChar, ObjCreateNewOpportunity.COMPETITOR_4);
                db.AddInParameter(cd, "@in_Comp5", SqlDbType.VarChar, ObjCreateNewOpportunity.COMPETITOR_5);
                db.AddInParameter(cd, "@in_OffFTE  ", SqlDbType.Int, ObjCreateNewOpportunity.FTEOff);
                db.AddInParameter(cd, "@in_OnFTE  ", SqlDbType.Int, ObjCreateNewOpportunity.FTEOn);
                db.AddInParameter(cd, "@iv_Entity", SqlDbType.VarChar, ObjCreateNewOpportunity.ENTITY);
                db.AddInParameter(cd, "@iv_CurrentlyActive", SqlDbType.VarChar, ObjCreateNewOpportunity.CURRENTLY_ACTIVE);
                db.AddInParameter(cd, "@in_CRMTCV", SqlDbType.VarChar, ObjCreateNewOpportunity.CRM_TCV);
                db.AddInParameter(cd, "@in_CRMStage", SqlDbType.Int, ObjCreateNewOpportunity.CRM_STAGE);
                db.AddInParameter(cd, "@in_TGA", SqlDbType.VarChar, ObjCreateNewOpportunity.TataGroupAccount);
                db.AddInParameter(cd, "@in_TPA", SqlDbType.VarChar, ObjCreateNewOpportunity.TPA);
                db.AddInParameter(cd, "@in_TPA_Name", SqlDbType.VarChar, ObjCreateNewOpportunity.TPA_Name);
                db.AddInParameter(cd, "@in_ItisScope", SqlDbType.VarChar, ObjCreateNewOpportunity.ItisScope);
                db.AddInParameter(cd, "@in_IsContractRenewal", SqlDbType.VarChar, ObjCreateNewOpportunity.IsContractRenewal);
                db.AddInParameter(cd, "@in_ContractRenewalValue", SqlDbType.VarChar, ObjCreateNewOpportunity.ContractRenewalValue);
                db.AddInParameter(cd, "@iv_DigitalTCV", SqlDbType.VarChar, ObjCreateNewOpportunity.strDigitalTcv);
                db.AddInParameter(cd, "@in_SubSP", SqlDbType.Int, ObjCreateNewOpportunity.subSPId);
                db.AddInParameter(cd, "@in_CRMBeacon", SqlDbType.VarChar, ObjCreateNewOpportunity.CRM_Beacon);
                db.AddInParameter(cd, "@in_ResourcingId", SqlDbType.Int, ObjCreateNewOpportunity.RESOURCING_ID);
                db.AddInParameter(cd, "@in_Seat_IdentificationId", SqlDbType.Int, ObjCreateNewOpportunity.SEAT_IDENTIFICATION_ID);
                db.AddInParameter(cd, "@iv_WinStatus", SqlDbType.Int, null);
                db.AddInParameter(cd, "@iv_Status", SqlDbType.Int, null);
                db.AddInParameter(cd, "@in_FirstBillingDate", SqlDbType.Int, null);
                db.AddInParameter(cd, "@iv_BPSFeedback", SqlDbType.Int, null);
                db.AddInParameter(cd, "@in_DEALREASON1", SqlDbType.Int, ObjCreateNewOpportunity.DEAL_REASON1);
                db.AddInParameter(cd, "@in_DEALREASON2", SqlDbType.Int, ObjCreateNewOpportunity.DEAL_REASON2);
                db.AddInParameter(cd, "@in_DEALREASON3", SqlDbType.Int, ObjCreateNewOpportunity.DEAL_REASON3);
                db.AddInParameter(cd, "@iv_DealRemark1", SqlDbType.Int, null);
                db.AddInParameter(cd, "@iv_DealRemark2", SqlDbType.Int, null);
                db.AddInParameter(cd, "@iv_WinComm", SqlDbType.Int, null);
                db.AddInParameter(cd, "@in_actualCloseDate", SqlDbType.Int, ObjCreateNewOpportunity.ActualCloseDate);
                db.AddInParameter(cd, "@iv_dealClosureReason", SqlDbType.VarChar, ObjCreateNewOpportunity.DealClosureReason);
                db.AddInParameter(cd, "@in_modernisedOfferingId", SqlDbType.Int, ObjCreateNewOpportunity.ModernisedOffering);
                db.AddInParameter(cd, "@in_cognitiveSolutionId", SqlDbType.Int, ObjCreateNewOpportunity.CognitiveSolutions);
                db.AddInParameter(cd, "@in_offerings", SqlDbType.VarChar, ObjCreateNewOpportunity.Offerings);
                db.AddInParameter(cd, "@in_Opportunity_Desc_Details", SqlDbType.VarChar, ObjCreateNewOpportunity.OpportunityDescDetails);
                db.AddInParameter(cd, "@in_proposalSubmissionDate", SqlDbType.VarChar, ObjCreateNewOpportunity.PROPOSAL_SUBMISSION_DATE);
                db.AddInParameter(cd, "@in_salesStageMovedOnDate", SqlDbType.VarChar, ObjCreateNewOpportunity.SALES_STAGE_MOVED_ONDATE);
                db.AddInParameter(cd, "@iv_deliveryLocationProposed", SqlDbType.VarChar, ObjCreateNewOpportunity.DELIVERY_LOCATION_PROPOSED);
                db.AddInParameter(cd, "@OfferingType_Id", SqlDbType.Int, ObjCreateNewOpportunity.offeringType);
                db.AddInParameter(cd, "@CoreOfferingName_Id", SqlDbType.Int, ObjCreateNewOpportunity.CofID);
                db.AddInParameter(cd, "@in_ContractNegoDt", SqlDbType.Int, ObjCreateNewOpportunity.ContractCloserDate);
                db.AddInParameter(cd, "@DealStatus_Id", SqlDbType.Int, ObjCreateNewOpportunity.DealStatus);
                db.AddInParameter(cd, "@ServicePractice_Id", SqlDbType.Int, ObjCreateNewOpportunity.ServicePractice);
                db.AddInParameter(cd, "@CoreOffering_Id", SqlDbType.Int, ObjCreateNewOpportunity.CoreOffering);
                db.AddInParameter(cd, "@iv_IgnioTMscope", SqlDbType.VarChar, ObjCreateNewOpportunity.IgnioTMScope);
                db.AddInParameter(cd, "@iv_IgnioTMscopeDetail", SqlDbType.VarChar, ObjCreateNewOpportunity.IgnioTMScopeDetails);
                db.AddInParameter(cd, "@iv_DigitalFlagging", SqlDbType.VarChar, ObjCreateNewOpportunity.DigitalFlagging);
                db.AddInParameter(cd, "@cboioffering", SqlDbType.VarChar, ObjCreateNewOpportunity.Cboi_Offering_id);
                db.AddInParameter(cd, "@dealflag", SqlDbType.VarChar, ObjCreateNewOpportunity.Deal_Flag_id);
                db.AddOutParameter(cd, "@on_Result", SqlDbType.Int, Int16.MaxValue);

                db.ExecuteNonQuery(cd);
                intResult = Convert.ToInt16(db.GetParameterValue(cd, "@on_Result"));
                return intResult;
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
        }
        /// <summary>
        /// Get Employee Status Details
        /// </summary>
        public int ChangeCustType(string customer, string opportunityId)
        {
            try
            {
                int intResult;
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Change_Cust_Type);
                db.AddInParameter(cd, "@Cust_id", SqlDbType.VarChar, customer);
                db.AddInParameter(cd, "@Opportunity_id", SqlDbType.VarChar, opportunityId);
                db.ExecuteNonQuery(cd);
                intResult = Convert.ToInt16(db.GetParameterValue(cd, "@on_Result"));
                return intResult;
            }

            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
        }
        /// <summary>
        /// Get Responsible_Infra_Qual Details
        /// </summary>
        public Dictionary<int, List<CreateNewOpportunity>> Get_Head_Infra_Quality_Dtls(int UnitID)
        {
            DataSet ds = null;
            Dictionary<int, List<CreateNewOpportunity>> modelList = new Dictionary<int, List<CreateNewOpportunity>>();
            List<CreateNewOpportunity> newList = new List<CreateNewOpportunity>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Get_Responsible_Infra_Qual_Dtls);
                db.AddInParameter(cd, "@in_UnitID", SqlDbType.VarChar, UnitID);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;
                        for (int i = 0; i < rowCount; i++)
                        {
                            newList.Add(MapGet_Head_Infra_Quality_Dtls(ds.Tables[0].Rows[i]));
                        }
                        modelList.Add(0, newList);
                        newList = null;
                        int rowCount1 = ds.Tables[1].Rows.Count;
                        for (int i = 0; i < rowCount1; i++)
                        {
                            if (ds.Tables[0].Rows[i] != null)
                            {
                                newList.Add(MapCheckInfraQualDLDetails2(ds.Tables[1].Rows[i]));
                            }
                        }
                        modelList.Add(1, newList);
                        newList = null;
                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }
            return modelList;
        }

        private static CreateNewOpportunity MapGet_Head_Infra_Quality_Dtls(DataRow dr)
        {
            try
            {
                return new CreateNewOpportunity()
                {

                    INFRA_HEAD_EMP_ID = (dr.Table.Columns.Contains("INFRA_HEAD_EMP_ID")) ? (dr["INFRA_HEAD_EMP_ID"] == DBNull.Value) ? "" : dr.Field<string>("INFRA_HEAD_EMP_ID") : "",
                    INFRA_HEAD_EMP_NAME = (dr.Table.Columns.Contains("INFRA_HEAD_EMP_NAME")) ? (dr["INFRA_HEAD_EMP_NAME"] == DBNull.Value) ? "" : dr.Field<string>("INFRA_HEAD_EMP_NAME") : "",
                    INFRA_HEAD_EMP_EMAIL = (dr.Table.Columns.Contains("INFRA_HEAD_EMP_EMAIL")) ? (dr["INFRA_HEAD_EMP_EMAIL"] == DBNull.Value) ? "" : dr.Field<string>("INFRA_HEAD_EMP_EMAIL") : "",

                };
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
        }
        /// <summary>
        /// Get OppDtls_HCL_New_sp Details
        /// </summary>
        public List<CreateNewOpportunity> Get_EmpDtls(string catId, string oppId, string offerId, string dCId, int unitID)
        {
            DataSet ds = null;
            List<CreateNewOpportunity> IndustryPraciseList = new List<CreateNewOpportunity>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Get_OppDtls_HCL_New_sp);
                db.AddInParameter(cd, "@in_ROLE_CAT_ID", SqlDbType.Int, catId);
                db.AddInParameter(cd, "@in_OPPORTUNITY_ID", SqlDbType.VarChar, oppId);
                db.AddInParameter(cd, "@in_Offering_Id", SqlDbType.Int, offerId);
                db.AddInParameter(cd, "@in_DeliveryCenter", SqlDbType.Int, dCId);
                db.AddInParameter(cd, "@in_UnitId", SqlDbType.Int, unitID);

                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;
                        for (int i = 0; i < rowCount; i++)
                        {
                            IndustryPraciseList.Add(MapGet_EmpDtls(ds.Tables[0].Rows[i]));
                        }
                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }
            return IndustryPraciseList;
        }

        private static CreateNewOpportunity MapGet_EmpDtls(DataRow dr)
        {
            try
            {
                return new CreateNewOpportunity()
                {


                    T_REC_ID = (dr.Table.Columns.Contains("T_REC_ID")) ? (dr["T_REC_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["T_REC_ID"]) : 0,
                    OpportunityId = (dr.Table.Columns.Contains("OPPORTUNITY_ID")) ? (dr["OPPORTUNITY_ID"] == DBNull.Value) ? "" : dr.Field<string>("OPPORTUNITY_ID") : "",
                    T_REF_ID = (dr.Table.Columns.Contains("T_REF_ID")) ? (dr["T_REF_ID"] == DBNull.Value) ? "" : dr.Field<string>("T_REF_ID") : "",
                    T_REF_CODE = (dr.Table.Columns.Contains("T_REF_CODE")) ? (dr["T_REF_CODE"] == DBNull.Value) ? "" : dr.Field<string>("T_REF_CODE") : "",
                    OPP_OFFERING_ID = (dr.Table.Columns.Contains("OPP_OFFERING_ID")) ? (dr["OPP_OFFERING_ID"] == DBNull.Value) ? "" : dr.Field<string>("OPP_OFFERING_ID") : "",
                    DELIVERY_CENTER_ID = (dr.Table.Columns.Contains("DELIVERY_CENTER_ID")) ? (dr["DELIVERY_CENTER_ID"] == DBNull.Value) ? "" : dr.Field<string>("DELIVERY_CENTER_ID") : "",
                    ROLE_CAT_ID = (dr.Table.Columns.Contains("ROLE_CAT_ID")) ? (dr["ROLE_CAT_ID"] == DBNull.Value) ? "" : dr.Field<string>("ROLE_CAT_ID") : "",
                    ROLE_ID = (dr.Table.Columns.Contains("ROLE_ID")) ? (dr["ROLE_ID"] == DBNull.Value) ? "" : dr.Field<string>("ROLE_ID") : "",
                    ROLE_NAME = (dr.Table.Columns.Contains("ROLE_NAME")) ? (dr["ROLE_NAME"] == DBNull.Value) ? "" : dr.Field<string>("ROLE_NAME") : "",
                    FTE_REQ_NUMBER = (dr.Table.Columns.Contains("FTE_REQ_NUMBER")) ? (dr["FTE_REQ_NUMBER"] == DBNull.Value) ? "" : dr.Field<string>("FTE_REQ_NUMBER") : "",
                    FTE_REQ_DATE = (dr.Table.Columns.Contains("FTE_REQ_DATE")) ? (dr["FTE_REQ_DATE"] == DBNull.Value) ? "" : dr.Field<string>("FTE_REQ_DATE") : "",
                    IDENTIFIED_TAGGED = (dr.Table.Columns.Contains("IDENTIFIED_TAGGED")) ? (dr["IDENTIFIED_TAGGED"] == DBNull.Value) ? "" : dr.Field<string>("IDENTIFIED_TAGGED") : "",
                    CLOSED_IJP = (dr.Table.Columns.Contains("CLOSED_IJP")) ? (dr["CLOSED_IJP"] == DBNull.Value) ? "" : dr.Field<string>("CLOSED_IJP") : "",
                    FromDate = (dr.Table.Columns.Contains("FROM_DT")) ? (dr["FROM_DT"] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(dr.Field<DateTime>("FROM_DT")) : (DateTime?)null,
                    ToDate = (dr.Table.Columns.Contains("TO_DT")) ? (dr["TO_DT"] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(dr.Field<DateTime>("TO_DT")) : (DateTime?)null,
                    CREATED_BY = (dr.Table.Columns.Contains("CREATED_BY")) ? (dr["CREATED_BY"] == DBNull.Value) ? "" : dr.Field<string>("CREATED_BY") : "",
                    CreatedDate = (dr.Table.Columns.Contains("CREATED_DT")) ? (dr["CREATED_DT"] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(dr.Field<DateTime>("CREATED_DT")) : (DateTime?)null,
                    CRF_RAISED_FOR = (dr.Table.Columns.Contains("CRF_RAISED_FOR")) ? (dr["CRF_RAISED_FOR"] == DBNull.Value) ? "" : dr.Field<string>("CRF_RAISED_FOR") : "",
                    CRF_RAISED = (dr.Table.Columns.Contains("CRF_RAISED")) ? (dr["CRF_RAISED"] == DBNull.Value) ? "" : dr.Field<string>("CRF_RAISED") : "",
                    Internally_Tagged = (dr.Table.Columns.Contains("Internally_Tagged")) ? (dr["Internally_Tagged"] == DBNull.Value) ? "" : dr.Field<string>("Internally_Tagged") : "",
                    Balance1 = (dr.Table.Columns.Contains("Balance1")) ? (dr["Balance1"] == DBNull.Value) ? "" : dr.Field<string>("Balance1") : "",
                    IJPCOunt = (dr.Table.Columns.Contains("IJPCOunt")) ? (dr["IJPCOunt"] == DBNull.Value) ? "" : dr.Field<string>("IJPCOunt") : "",
                    Balance2 = (dr.Table.Columns.Contains("Balance2")) ? (dr["Balance2"] == DBNull.Value) ? "" : dr.Field<string>("Balance2") : "",
                    CLUSTER = (dr.Table.Columns.Contains("CLUSTER")) ? (dr["CLUSTER"] == DBNull.Value) ? "" : dr.Field<string>("CLUSTER") : "",
                    SUB_DOMAIN = (dr.Table.Columns.Contains("SUB_DOMAIN")) ? (dr["SUB_DOMAIN"] == DBNull.Value) ? "" : dr.Field<string>("SUB_DOMAIN") : "",
                    Status = (dr.Table.Columns.Contains("STATUS")) ? (dr["STATUS"] == DBNull.Value) ? "" : dr.Field<string>("STATUS") : "",
                    CRF_TYPE = (dr.Table.Columns.Contains("CRF_TYPE")) ? (dr["CRF_TYPE"] == DBNull.Value) ? "" : dr.Field<string>("CRF_TYPE") : "",

                };
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
        }
        /// <summary>
        /// Get Opportunity_Stage1_sp_INFRA Details
        /// </summary>
        public List<CreateNewOpportunity> GetOpportunity_Stage1_sp_INFRA(string opportunityId, int stageId)
        {
            DataSet ds = null;
            List<CreateNewOpportunity> modelList = new List<CreateNewOpportunity>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.GetOpportunity_Stage1_sp_INFRA);
                db.AddInParameter(cd, "@in_OpportunityId", SqlDbType.VarChar, opportunityId);
                db.AddInParameter(cd, "@in_StageId", SqlDbType.Int, stageId);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;

                        for (int i = 0; i < rowCount; i++)
                        {
                            modelList.Add(MapGetOpportunity_Stage1_sp_INFRA(ds.Tables[0].Rows[i]));
                        }

                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }
            return modelList;
        }

        private static CreateNewOpportunity MapGetOpportunity_Stage1_sp_INFRA(DataRow dr)
        {
            try
            {
                return new CreateNewOpportunity()
                {

                    STAGESTS = (dr.Table.Columns.Contains("STAGESTS")) ? (dr["STAGESTS"] == DBNull.Value) ? "" : dr.Field<string>("STAGESTS") : "",
                    OPERATION_WINDOW = (dr.Table.Columns.Contains("OPERATION_WINDOW")) ? (dr["OPERATION_WINDOW"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["OPERATION_WINDOW"]) : 0,
                    TYPES_OF_SEAT = (dr.Table.Columns.Contains("TYPES_OF_SEAT")) ? (dr["TYPES_OF_SEAT"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["TYPES_OF_SEAT"]) : 0,
                    AREA = (dr.Table.Columns.Contains("AREA")) ? (dr["AREA"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["AREA"]) : 0,
                };
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
        }
        /// <summary>
        /// Get Stage Details
        /// </summary>
        public List<Stage> GetStage()
        {
            DataSet ds = null;
            List<Stage> modelList = new List<Stage>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.GetStage);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;
                        for (int i = 0; i < rowCount; i++)
                        {
                            modelList.Add(MapGetStage(ds.Tables[0].Rows[i]));
                        }
                    }
                }
            }

            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }

            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }
            return modelList;
        }
        
        private static Stage MapGetStage(DataRow dr)
        {
            try
            {
                return new Stage()
                {
                    StageId = (dr.Table.Columns.Contains("STAGE_ID")) ? (dr["STAGE_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["STAGE_ID"]) : 0,
                    STAGE_NAME = (dr.Table.Columns.Contains("STAGE_NAME")) ? (dr["STAGE_NAME"] == DBNull.Value) ? "" : dr.Field<string>("STAGE_NAME") : "",
                };

            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
        }


        /// <summary>
        /// Get ConfiguratorControl Details
        /// </summary>
        public List<CreateNewOpportunity> Get_ConfiguratorControl(int UnitID)
        {
            DataSet ds = null;
            List<CreateNewOpportunity> modelList = new List<CreateNewOpportunity>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Get_ConfiguratorControl);
                db.AddInParameter(cd, "@Unit", SqlDbType.Int, UnitID);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;
                        for (int i = 0; i < rowCount; i++)
                        {
                            modelList.Add(MapGet_ConfiguratorControl(ds.Tables[0].Rows[i]));
                        }
                    }
                }
            }

            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }

            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }
            return modelList;
        }
        private static CreateNewOpportunity MapGet_ConfiguratorControl(DataRow dr)
        {
            try
            {

                return new CreateNewOpportunity()
                {
                    OpportunityDescription = (dr.Table.Columns.Contains("OpportunityDescription")) ? (dr["OpportunityDescription"] == DBNull.Value) ? "" : dr.Field<string>("OpportunityDescription") : "",
                    Geography = (dr.Table.Columns.Contains("Geography")) ? (dr["Geography"] == DBNull.Value) ? "" : dr.Field<string>("Geography") : "",
                    CustomerName = (dr.Table.Columns.Contains("CustomerID")) ? (dr["CustomerID"] == DBNull.Value) ? "" : dr.Field<string>("CustomerID") : "",
                    CustomerTypeID = (dr.Table.Columns.Contains("CustomerTypeID")) ? (dr["CustomerTypeID"] == DBNull.Value) ? "" : dr.Field<string>("CustomerTypeID") : "",
                    IndustryPractice = (dr.Table.Columns.Contains("IndustryPractice")) ? (dr["IndustryPractice"] == DBNull.Value) ? "" : dr.Field<string>("IndustryPractice") : "",
                    GeographySalesOwner = (dr.Table.Columns.Contains("GeographySalesOwner")) ? (dr["GeographySalesOwner"] == DBNull.Value) ? "" : dr.Field<string>("GeographySalesOwner") : "",
                    OffShorePracticeOwner = (dr.Table.Columns.Contains("OffShorePracticeOwner")) ? (dr["OffShorePracticeOwner"] == DBNull.Value) ? "" : dr.Field<string>("OffShorePracticeOwner") : "",
                    RdCrd = (dr.Table.Columns.Contains("RdCrd")) ? (dr["RdCrd"] == DBNull.Value) ? "" : dr.Field<string>("RdCrd") : "",
                    OffShorePresalesLeadVertical = (dr.Table.Columns.Contains("OffShorePresalesLeadVertical")) ? (dr["OffShorePresalesLeadVertical"] == DBNull.Value) ? "" : dr.Field<string>("OffShorePresalesLeadVertical") : "",
                    DealOwner1 = (dr.Table.Columns.Contains("DealOwner1")) ? (dr["DealOwner1"] == DBNull.Value) ? "" : dr.Field<string>("DealOwner1") : "",
                    DealOwner2 = (dr.Table.Columns.Contains("DealOwner2")) ? (dr["DealOwner2"] == DBNull.Value) ? "" : dr.Field<string>("DealOwner2") : "",
                    StrDealCategory = (dr.Table.Columns.Contains("DealCategory")) ? (dr["DealCategory"] == DBNull.Value) ? "" : dr.Field<string>("DealCategory") : "",
                    OffshorePresalesLeadHorizontal = (dr.Table.Columns.Contains("OffshorePresalesLeadHorizontal")) ? (dr["OffshorePresalesLeadHorizontal"] == DBNull.Value) ? "" : dr.Field<string>("OffshorePresalesLeadHorizontal") : "",
                    PotentialFTE = (dr.Table.Columns.Contains("PotentialFTE")) ? (dr["PotentialFTE"] == DBNull.Value) ? "" : dr.Field<string>("PotentialFTE") : "",
                    DaysInStage = (dr.Table.Columns.Contains("DaysInStage")) ? (dr["DaysInStage"] == DBNull.Value) ? "" : dr.Field<string>("DaysInStage") : "",
                    Remark = (dr.Table.Columns.Contains("Remark")) ? (dr["Remark"] == DBNull.Value) ? "" : dr.Field<string>("Remark") : "",
                    OpportunityReceivedDate = (dr.Table.Columns.Contains("OpportunityReceivedDate")) ? (dr["OpportunityReceivedDate"] == DBNull.Value) ? "" : dr.Field<string>("OpportunityReceivedDate") : "",
                    ExpectedDealClosureDate = (dr.Table.Columns.Contains("ExpectedDealClosureDate")) ? (dr["ExpectedDealClosureDate"] == DBNull.Value) ? "" : dr.Field<string>("ExpectedDealClosureDate") : "",
                    AdvisoryID = (dr.Table.Columns.Contains("AdvisoryID")) ? (dr["AdvisoryID"] == DBNull.Value) ? "" : dr.Field<string>("AdvisoryID") : "",
                    Platform = (dr.Table.Columns.Contains("Platform")) ? (dr["Platform"] == DBNull.Value) ? "" : dr.Field<string>("Platform") : "",
                    NextStep = (dr.Table.Columns.Contains("NextStep")) ? (dr["NextStep"] == DBNull.Value) ? "" : dr.Field<string>("NextStep") : "",
                    Vertical = (dr.Table.Columns.Contains("Vertical")) ? (dr["Vertical"] == DBNull.Value) ? "" : dr.Field<string>("Vertical") : "",
                    ProductID = (dr.Table.Columns.Contains("ProductID")) ? (dr["ProductID"] == DBNull.Value) ? "" : dr.Field<string>("ProductID") : "",
                    CompetencyID = (dr.Table.Columns.Contains("CompetencyID")) ? (dr["CompetencyID"] == DBNull.Value) ? "" : dr.Field<string>("CompetencyID") : "",
                    SubCompetencyID = (dr.Table.Columns.Contains("SubCompetencyID")) ? (dr["SubCompetencyID"] == DBNull.Value) ? "" : dr.Field<string>("SubCompetencyID") : "",
                    StrAnnualSaleValue = (dr.Table.Columns.Contains("AnnualSaleValue")) ? (dr["AnnualSaleValue"] == DBNull.Value) ? "" : dr.Field<string>("AnnualSaleValue") : "",
                    AccountSalesOwner = (dr.Table.Columns.Contains("AccountSalesOwner")) ? (dr["AccountSalesOwner"] == DBNull.Value) ? "" : dr.Field<string>("AccountSalesOwner") : "",
                    StatusUpdate = (dr.Table.Columns.Contains("StatusUpdate")) ? (dr["StatusUpdate"] == DBNull.Value) ? "" : dr.Field<string>("StatusUpdate") : "",
                    CategoryID = (dr.Table.Columns.Contains("CategoryID")) ? (dr["CategoryID"] == DBNull.Value) ? "" : dr.Field<string>("CategoryID") : "",
                    Country = (dr.Table.Columns.Contains("Country")) ? (dr["Country"] == DBNull.Value) ? "" : dr.Field<string>("Country") : "",
                    ISU = (dr.Table.Columns.Contains("ISU")) ? (dr["ISU"] == DBNull.Value) ? "" : dr.Field<string>("ISU") : "",
                    StrService = (dr.Table.Columns.Contains("Service")) ? (dr["Service"] == DBNull.Value) ? "" : dr.Field<string>("Service") : "",
                    CRMID = (dr.Table.Columns.Contains("CRMID")) ? (dr["CRMID"] == DBNull.Value) ? "" : dr.Field<string>("CRMID") : "",
                    OpportunityTrackedBy = (dr.Table.Columns.Contains("OpportunityTrackedBy")) ? (dr["OpportunityTrackedBy"] == DBNull.Value) ? "" : dr.Field<string>("OpportunityTrackedBy") : "",
                    ValueBPS = (dr.Table.Columns.Contains("ValueBPS")) ? (dr["ValueBPS"] == DBNull.Value) ? "" : dr.Field<string>("ValueBPS") : "",
                    StrValueBPSTCV = (dr.Table.Columns.Contains("ValueBPSTCV")) ? (dr["ValueBPSTCV"] == DBNull.Value) ? "" : dr.Field<string>("ValueBPSTCV") : "",
                    StrBPSSubSPID = (dr.Table.Columns.Contains("BPSSubSPID")) ? (dr["BPSSubSPID"] == DBNull.Value) ? "" : dr.Field<string>("BPSSubSPID") : "",
                    BPSOffering = (dr.Table.Columns.Contains("BPSOffering")) ? (dr["BPSOffering"] == DBNull.Value) ? "" : dr.Field<string>("BPSOffering") : "",
                    ProactiveProposal = (dr.Table.Columns.Contains("ProactiveProposal")) ? (dr["ProactiveProposal"] == DBNull.Value) ? "" : dr.Field<string>("ProactiveProposal") : "",
                    StrStatusFlag = (dr.Table.Columns.Contains("StatusFlag")) ? (dr["StatusFlag"] == DBNull.Value) ? "" : dr.Field<string>("StatusFlag") : "",
                    MultiTower = (dr.Table.Columns.Contains("MultiTower")) ? (dr["MultiTower"] == DBNull.Value) ? "" : dr.Field<string>("MultiTower") : "",
                    SubIOU = (dr.Table.Columns.Contains("SubIOU")) ? (dr["SubIOU"] == DBNull.Value) ? "" : dr.Field<string>("SubIOU") : "",
                    PlatformOption = (dr.Table.Columns.Contains("PlatformOption")) ? (dr["PlatformOption"] == DBNull.Value) ? "" : dr.Field<string>("PlatformOption") : "",
                    Cluster = (dr.Table.Columns.Contains("Cluster")) ? (dr["Cluster"] == DBNull.Value) ? "" : dr.Field<string>("Cluster") : "",
                    ExecutiveSponsor = (dr.Table.Columns.Contains("ExecutiveSponsor")) ? (dr["ExecutiveSponsor"] == DBNull.Value) ? "" : dr.Field<string>("ExecutiveSponsor") : "",
                    ValueBPSConsultant = (dr.Table.Columns.Contains("ValueBPSConsultant")) ? (dr["ValueBPSConsultant"] == DBNull.Value) ? "" : dr.Field<string>("ValueBPSConsultant") : "",
                    IOU = (dr.Table.Columns.Contains("IOU")) ? (dr["IOU"] == DBNull.Value) ? "" : dr.Field<string>("IOU") : "",
                    TotalContractValue = (dr.Table.Columns.Contains("TotalContractValue")) ? (dr["TotalContractValue"] == DBNull.Value) ? "" : dr.Field<string>("TotalContractValue") : "",
                    ExpectedRevenueQuarter = (dr.Table.Columns.Contains("ExpectedRevenueQuarter")) ? (dr["ExpectedRevenueQuarter"] == DBNull.Value) ? "" : dr.Field<string>("ExpectedRevenueQuarter") : "",
                    Fiscalyear = (dr.Table.Columns.Contains("Fiscalyear")) ? (dr["Fiscalyear"] == DBNull.Value) ? "" : dr.Field<string>("Fiscalyear") : "",
                    DigitalTransformation = (dr.Table.Columns.Contains("DigitalTransformation")) ? (dr["DigitalTransformation"] == DBNull.Value) ? "" : dr.Field<string>("DigitalTransformation") : "",
                    PIBS = (dr.Table.Columns.Contains("PIBS")) ? (dr["PIBS"] == DBNull.Value) ? "" : dr.Field<string>("PIBS") : "",
                    OtherDigitalTransformationValue = (dr.Table.Columns.Contains("OtherDigitalTransformationValue")) ? (dr["OtherDigitalTransformationValue"] == DBNull.Value) ? "" : dr.Field<string>("OtherDigitalTransformationValue") : "",
                    SDealstage = (dr.Table.Columns.Contains("DealStage")) ? (dr["DealStage"] == DBNull.Value) ? "" : dr.Field<string>("DealStage") : "",

                };

            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
        }


        //changes for Stage 2
        /// <summary>
        /// Save Stage2 Opportunity Details
        /// </summary>
        public List<CreateNewOpportunity> Save_Stage2Opportunity(CreateNewOpportunity ObjCreateNewOpportunity)
        {
            List<CreateNewOpportunity> strResult = new List<CreateNewOpportunity>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Ins_Opportunity_stage2_sp);
                db.AddInParameter(cd, "@in_OpportunityId", SqlDbType.VarChar, ObjCreateNewOpportunity.OpportunityId);
                db.AddInParameter(cd, "@iv_OpportunityDesc", SqlDbType.VarChar, ObjCreateNewOpportunity.OPPORTUNITY_DESC);
                db.AddInParameter(cd, "@iv_OldOpportunityDesc", SqlDbType.VarChar, ObjCreateNewOpportunity.OLD_OPPORTUNITY_DESC);
                db.AddInParameter(cd, "@in_GeographyId", SqlDbType.Int, ObjCreateNewOpportunity.GEOGRAPHY_ID);
                db.AddInParameter(cd, "@in_CustId", SqlDbType.Int, ObjCreateNewOpportunity.CUST_ID);
                db.AddInParameter(cd, "@in_CustTypeId", SqlDbType.Int, ObjCreateNewOpportunity.CUST_TYPE_ID);
                db.AddInParameter(cd, "@in_IndustryPracticeId", SqlDbType.Int, ObjCreateNewOpportunity.INDUSTRY_PRACTICE_ID);
                db.AddInParameter(cd, "@in_StageId", SqlDbType.Int, ObjCreateNewOpportunity.StageID);
                db.AddInParameter(cd, "@iv_GeographySalesOwner", SqlDbType.VarChar, ObjCreateNewOpportunity.GeosalesOwner);
                db.AddInParameter(cd, "@iv_OffshorePracticeOwner", SqlDbType.VarChar, ObjCreateNewOpportunity.OffPracOwner);
                db.AddInParameter(cd, "@iv_RdCrd", SqlDbType.VarChar, ObjCreateNewOpportunity.RDCrd);
                db.AddInParameter(cd, "@iv_OffshoreBDLead", SqlDbType.VarChar, ObjCreateNewOpportunity.OffShoreBDLead);
                db.AddInParameter(cd, "@iv_OnsiteOwner", SqlDbType.VarChar, ObjCreateNewOpportunity.OnsiteOwner);
                db.AddInParameter(cd, "@in_ProbabilityOfwin", SqlDbType.Int, ObjCreateNewOpportunity.PROBABILITY_OF_WIN);
                db.AddInParameter(cd, "@in_ContractLength", SqlDbType.Int, ObjCreateNewOpportunity.ContractLength);
                db.AddInParameter(cd, "@in_FTE", SqlDbType.Int, ObjCreateNewOpportunity.FTE);
                db.AddInParameter(cd, "@iv_Remark", SqlDbType.VarChar, ObjCreateNewOpportunity.REMARK);
                db.AddInParameter(cd, "@in_OppDate", SqlDbType.Int, ObjCreateNewOpportunity.OppDate);
                db.AddInParameter(cd, "@iv_EmpNo", SqlDbType.VarChar, ObjCreateNewOpportunity.EmpNo);
                db.AddInParameter(cd, "@in_ClosureDate", SqlDbType.Int, ObjCreateNewOpportunity.ClosureDate);
                db.AddInParameter(cd, "@in_AdvisoryId", SqlDbType.Int, ObjCreateNewOpportunity.ADVISORY_ID);
                db.AddInParameter(cd, "@iv_Platform", SqlDbType.VarChar, ObjCreateNewOpportunity.PLATFORM);
                db.AddInParameter(cd, "@in_PricingTypeId", SqlDbType.Int, ObjCreateNewOpportunity.PRICING_TYPE_ID);
                db.AddInParameter(cd, "@iv_NextStep", SqlDbType.VarChar, ObjCreateNewOpportunity.NextStep);
                db.AddInParameter(cd, "@in_BusinessId", SqlDbType.Int, ObjCreateNewOpportunity.BUSINESS_ID);
                db.AddInParameter(cd, "@in_ProductId", SqlDbType.Int, ObjCreateNewOpportunity.PRODUCT_ID);
                db.AddInParameter(cd, "@in_CompetencyId", SqlDbType.Int, ObjCreateNewOpportunity.COMPETENCY_ID);
                db.AddInParameter(cd, "@in_SubCompetencyId", SqlDbType.Int, ObjCreateNewOpportunity.SUB_COMPETENCY_ID);
                db.AddInParameter(cd, "@in_AnnualSaleValue", SqlDbType.Decimal, ObjCreateNewOpportunity.AnnualSaleValue);
                db.AddInParameter(cd, "@iv_AccountSalesOwner", SqlDbType.VarChar, ObjCreateNewOpportunity.AccountSalesOwner);
                db.AddInParameter(cd, "@iv_ExeSponser", SqlDbType.VarChar, ObjCreateNewOpportunity.ExeSponser);
                db.AddInParameter(cd, "@iv_ProactiveProposal", SqlDbType.VarChar, ObjCreateNewOpportunity.ProactiveProposal);
                db.AddInParameter(cd, "@iv_ValBPSCon", SqlDbType.VarChar, ObjCreateNewOpportunity.ValBPSCon);
                db.AddInParameter(cd, "@iv_IsuMain", SqlDbType.VarChar, ObjCreateNewOpportunity.IsuMain);
                db.AddInParameter(cd, "@iv_PlatformNew", SqlDbType.VarChar, ObjCreateNewOpportunity.PlatformNew);
                db.AddInParameter(cd, "@iv_StatusUpdate", SqlDbType.VarChar, ObjCreateNewOpportunity.StatusUpdate);
                db.AddInParameter(cd, "@in_CategoryId", SqlDbType.Int, ObjCreateNewOpportunity.Category_Id);
                db.AddInParameter(cd, "@in_CountryId", SqlDbType.Int, ObjCreateNewOpportunity.CountryId);
                db.AddInParameter(cd, "@in_NextStepDueDt", SqlDbType.Int, ObjCreateNewOpportunity.NextStepDueDt);
                db.AddInParameter(cd, "@in_UnitID", SqlDbType.Int, ObjCreateNewOpportunity.UnitId);
                db.AddInParameter(cd, "@iv_ISUOwner", SqlDbType.VarChar, ObjCreateNewOpportunity.ISU_OWNER_ID);
                db.AddInParameter(cd, "@iv_ISU", SqlDbType.VarChar, ObjCreateNewOpportunity.ISU_CD);
                db.AddInParameter(cd, "@iv_PIBS", SqlDbType.VarChar, ObjCreateNewOpportunity.PIBS);
                db.AddInParameter(cd, "@iv_TCS_INVESTMENT", SqlDbType.VarChar, ObjCreateNewOpportunity.TCSInvestment);
                db.AddInParameter(cd, "@in_PIBStartDate", SqlDbType.Int, ObjCreateNewOpportunity.PIBStartDate);
                db.AddInParameter(cd, "@in_PIBEndDate", SqlDbType.Int, ObjCreateNewOpportunity.PIBSEndDate);
                db.AddInParameter(cd, "@in_NoOfFTEsEngaged", SqlDbType.Int, ObjCreateNewOpportunity.FTEsEngaged);
                db.AddInParameter(cd, "@in_PIBStatus", SqlDbType.Int, ObjCreateNewOpportunity.PIBStatus);
                db.AddInParameter(cd, "@in_PIBSOutcome", SqlDbType.Int, ObjCreateNewOpportunity.PIBS_OUTCOME_ID);
                db.AddInParameter(cd, "@iv_PIBStatusRemarks", SqlDbType.VarChar, ObjCreateNewOpportunity.PIBStatusRemarks);
                db.AddInParameter(cd, "@iv_FTEType", SqlDbType.VarChar, ObjCreateNewOpportunity.FTE_TYPE);
                db.AddInParameter(cd, "@in_FTETypeCount", SqlDbType.Int, ObjCreateNewOpportunity.FTE_TYPE_COUNT);
                db.AddInParameter(cd, "@in_BPODomain", SqlDbType.Int, ObjCreateNewOpportunity.BPODomain);
                db.AddInParameter(cd, "@iv_DomainPresalesLead", SqlDbType.VarChar, ObjCreateNewOpportunity.DOMAIN_PRESALES_LEAD);
                db.AddInParameter(cd, "@in_DealCategory", SqlDbType.Int, ObjCreateNewOpportunity.DealCategory);
                db.AddInParameter(cd, "@in_BPSSubSPID", SqlDbType.Int, ObjCreateNewOpportunity.BPSSubSPID);
                db.AddInParameter(cd, "@in_BPSOfferingID", SqlDbType.Int, ObjCreateNewOpportunity.BPSOfferingID);
                db.AddInParameter(cd, "@iv_DealCoachName", SqlDbType.VarChar, ObjCreateNewOpportunity.DealCoachName);
                db.AddInParameter(cd, "@in_DemandType", SqlDbType.Int, ObjCreateNewOpportunity.DemandType);
                db.AddInParameter(cd, "@iv_KeyDeal", SqlDbType.VarChar, ObjCreateNewOpportunity.KEY_DEAL);
                db.AddInParameter(cd, "@iv_ProposedSolution", SqlDbType.VarChar, ObjCreateNewOpportunity.ProposedSolution);
                db.AddInParameter(cd, "@iv_KeyRmk", SqlDbType.VarChar, ObjCreateNewOpportunity.KeyRmk);
                db.AddInParameter(cd, "@iv_WinningTeam", SqlDbType.VarChar, ObjCreateNewOpportunity.WinningTheme);
                db.AddInParameter(cd, "@iv_KeyCustExp", SqlDbType.VarChar, ObjCreateNewOpportunity.KeyCustExp);
                db.AddInParameter(cd, "@iv_OperatingModel", SqlDbType.VarChar, ObjCreateNewOpportunity.operatingModel);
                db.AddInParameter(cd, "@iv_PricingModel", SqlDbType.VarChar, ObjCreateNewOpportunity.PRICING_MODEL);
                db.AddInParameter(cd, "@iv_Differentiators", SqlDbType.VarChar, ObjCreateNewOpportunity.Differentiators);
                db.AddInParameter(cd, "@iv_Risks", SqlDbType.VarChar, ObjCreateNewOpportunity.Risks);
                db.AddInParameter(cd, "@iv_KeyCustomerConnects", SqlDbType.VarChar, ObjCreateNewOpportunity.KeyCustomerConnects);
                db.AddInParameter(cd, "@iv_BPOOfferingDescription", SqlDbType.VarChar, ObjCreateNewOpportunity.BPOOfferingDescription);
                db.AddInParameter(cd, "@iv_FirstTimeOutsource", SqlDbType.VarChar, ObjCreateNewOpportunity.FIRST_TIME_OUTSOURCE);
                db.AddInParameter(cd, "@iv_Incumbents", SqlDbType.VarChar, ObjCreateNewOpportunity.INCUMBENTS);
                db.AddInParameter(cd, "@iv_NameOfIncumbents", SqlDbType.VarChar, ObjCreateNewOpportunity.NAME_OF_INCUMBENTS);
                db.AddInParameter(cd, "@iv_TCSOfferingCapability", SqlDbType.VarChar, ObjCreateNewOpportunity.TCS_OFFERING_CAPABILITY);
                db.AddInParameter(cd, "@iv_SpecifyOffering", SqlDbType.VarChar, ObjCreateNewOpportunity.SpecifyOffering);
                db.AddInParameter(cd, "@iv_CoachAvailable", SqlDbType.VarChar, ObjCreateNewOpportunity.CoachAvailable);
                db.AddInParameter(cd, "@iv_FnA", SqlDbType.VarChar, ObjCreateNewOpportunity.FnA);
                db.AddInParameter(cd, "@in_Fna_FTE", SqlDbType.Int, ObjCreateNewOpportunity.FnA_FTE);
                db.AddInParameter(cd, "@iv_HRO", SqlDbType.VarChar, ObjCreateNewOpportunity.HRO);
                db.AddInParameter(cd, "@in_HRO_FTE", SqlDbType.Int, ObjCreateNewOpportunity.HRO_FTE);
                db.AddInParameter(cd, "@iv_SCM", SqlDbType.VarChar, ObjCreateNewOpportunity.SCM);
                db.AddInParameter(cd, "@in_SCM_FTE", SqlDbType.Int, ObjCreateNewOpportunity.SCM_FTE);
                db.AddInParameter(cd, "@iv_KPO", SqlDbType.VarChar, ObjCreateNewOpportunity.KPO);
                db.AddInParameter(cd, "@in_KPO_FTE", SqlDbType.Int, ObjCreateNewOpportunity.KPO_FTE);
                db.AddInParameter(cd, "@iv_LPO", SqlDbType.VarChar, ObjCreateNewOpportunity.LPO);
                db.AddInParameter(cd, "@in_LPO_FTE", SqlDbType.Int, ObjCreateNewOpportunity.LPO_FTE);
                db.AddInParameter(cd, "@iv_Vertical", SqlDbType.VarChar, ObjCreateNewOpportunity.VERTICAL);
                db.AddInParameter(cd, "@in_Vertical_FTE", SqlDbType.Int, ObjCreateNewOpportunity.VerticalFTE);
                db.AddInParameter(cd, "@iv_Voice", SqlDbType.VarChar, ObjCreateNewOpportunity.Voice);
                db.AddInParameter(cd, "@in_Voice_FTE", SqlDbType.Int, ObjCreateNewOpportunity.VoiceFTE);
                db.AddInParameter(cd, "@iv_Bpm", SqlDbType.VarChar, ObjCreateNewOpportunity.BPM);
                db.AddInParameter(cd, "@in_Bpm_FTE", SqlDbType.Int, ObjCreateNewOpportunity.BPM_FTE);
                db.AddInParameter(cd, "@in_SolTM", SqlDbType.Int, ObjCreateNewOpportunity.SolTM);
                db.AddInParameter(cd, "@in_DelTM", SqlDbType.Int, ObjCreateNewOpportunity.DelTM);
                db.AddInParameter(cd, "@iv_BidManager", SqlDbType.VarChar, ObjCreateNewOpportunity.BID_MANAGER);
                db.AddInParameter(cd, "@iv_BidExec", SqlDbType.VarChar, ObjCreateNewOpportunity.BID_EXEC_OWNER);
                db.AddInParameter(cd, "@iv_PricingOwner", SqlDbType.VarChar, ObjCreateNewOpportunity.PRICING_OWNER);
                db.AddInParameter(cd, "@in_TransitionTeam", SqlDbType.Int, ObjCreateNewOpportunity.TransitionTeam);
                db.AddInParameter(cd, "@iv_ExpectedDate", SqlDbType.Int, ObjCreateNewOpportunity.ExpectedDate);
                db.AddInParameter(cd, "@iv_TransitionReq", SqlDbType.VarChar, ObjCreateNewOpportunity.TransitionReq);
                db.AddInParameter(cd, "@iv_Quarter", SqlDbType.VarChar, ObjCreateNewOpportunity.Quarter);
                db.AddInParameter(cd, "@iv_FiscalYear", SqlDbType.VarChar, ObjCreateNewOpportunity.FiscalYear);
                db.AddInParameter(cd, "@in_RFIRwDt", SqlDbType.Int, ObjCreateNewOpportunity.RFI_REVIEW_DT);
                db.AddInParameter(cd, "@in_RFPRwDt", SqlDbType.Int, ObjCreateNewOpportunity.RFP_REVIEW_DT);
                db.AddInParameter(cd, "@iv_RFIBy", SqlDbType.VarChar, ObjCreateNewOpportunity.RFI_REVIEW_BY);
                db.AddInParameter(cd, "@iv_RFPBy", SqlDbType.VarChar, ObjCreateNewOpportunity.RFP_REVIEW_BY);
                db.AddInParameter(cd, "@iv_NGM", SqlDbType.VarChar, ObjCreateNewOpportunity.OPP_NGM);
                db.AddInParameter(cd, "@iv_CRMReason", SqlDbType.VarChar, ObjCreateNewOpportunity.CRM_REASON);
                db.AddInParameter(cd, "@iv_BidExeEmpId", SqlDbType.VarChar, ObjCreateNewOpportunity.BID_EXECUTIVE_EMPID);
                db.AddInParameter(cd, "@iv_Disqual", SqlDbType.VarChar, ObjCreateNewOpportunity.Disqual);
                db.AddInParameter(cd, "@iv_AddDeal", SqlDbType.VarChar, ObjCreateNewOpportunity.AddDeal);
                db.AddInParameter(cd, "@iv_BidExeName", SqlDbType.VarChar, ObjCreateNewOpportunity.BID_EXECUTIVE_NAME);
                db.AddInParameter(cd, "@iv_DealOwner", SqlDbType.VarChar, ObjCreateNewOpportunity.DealOwner);
                db.AddInParameter(cd, "@iv_DealOwner2", SqlDbType.VarChar, ObjCreateNewOpportunity.DealOwner2);
                db.AddInParameter(cd, "@iv_ImmediateComment", SqlDbType.VarChar, ObjCreateNewOpportunity.ImmediateComment);
                db.AddInParameter(cd, "@iv_FTEDD", SqlDbType.VarChar, ObjCreateNewOpportunity.FTEDD);
                db.AddInParameter(cd, "@iv_SolutionLeader", SqlDbType.VarChar, ObjCreateNewOpportunity.SolutionLeader);
                db.AddInParameter(cd, "@iv_RUR", SqlDbType.VarChar, ObjCreateNewOpportunity.RUR);
                db.AddInParameter(cd, "@iv_HRT_Comments", SqlDbType.VarChar, ObjCreateNewOpportunity.HRTComments);
                db.AddInParameter(cd, "@in_Seat_Requirements", SqlDbType.Int, ObjCreateNewOpportunity.SeatRequirements);
                db.AddInParameter(cd, "@iv_CRMId", SqlDbType.VarChar, ObjCreateNewOpportunity.CRM_ID);
                db.AddInParameter(cd, "@in_TCV", SqlDbType.VarChar, ObjCreateNewOpportunity.TCV);
                db.AddInParameter(cd, "@iv_ValueBPS", SqlDbType.VarChar, ObjCreateNewOpportunity.ValueBPS);
                db.AddInParameter(cd, "@in_ValueBPSTCV", SqlDbType.Decimal, ObjCreateNewOpportunity.ValueBPSTCV);
                db.AddInParameter(cd, "@iv_OppType", SqlDbType.VarChar, ObjCreateNewOpportunity.OPP_TYPE);
                db.AddInParameter(cd, "@iv_MultiTower", SqlDbType.VarChar, ObjCreateNewOpportunity.MultiTower);
                db.AddInParameter(cd, "@in_StatusFlag", SqlDbType.Int, ObjCreateNewOpportunity.StatusFlag);
                db.AddInParameter(cd, "@iv_Fna_Lead", SqlDbType.VarChar, ObjCreateNewOpportunity.FnA_Lead);
                db.AddInParameter(cd, "@iv_HRO_Lead", SqlDbType.VarChar, ObjCreateNewOpportunity.HRO_Lead);
                db.AddInParameter(cd, "@iv_SCM_Lead", SqlDbType.VarChar, ObjCreateNewOpportunity.SCM_Lead);
                db.AddInParameter(cd, "@iv_KPO_Lead", SqlDbType.VarChar, ObjCreateNewOpportunity.KPO_Lead);
                db.AddInParameter(cd, "@iv_LPO_Lead", SqlDbType.VarChar, ObjCreateNewOpportunity.LPO_Lead);
                db.AddInParameter(cd, "@iv_Vertical_Lead", SqlDbType.VarChar, ObjCreateNewOpportunity.VERTICAL_LEAD);
                db.AddInParameter(cd, "@iv_Voice_Lead", SqlDbType.VarChar, ObjCreateNewOpportunity.Voice_Lead);
                db.AddInParameter(cd, "@iv_Bpm_Lead", SqlDbType.VarChar, ObjCreateNewOpportunity.BPM_LEAD);
                db.AddInParameter(cd, "@iv_BidManagerId", SqlDbType.VarChar, ObjCreateNewOpportunity.BID_MANAGER_EMPID);
                db.AddInParameter(cd, "@iv_BidExecId", SqlDbType.VarChar, ObjCreateNewOpportunity.BID_EXEC_OWNER_EMPID);
                db.AddInParameter(cd, "@iv_PricingOwnerId", SqlDbType.VarChar, ObjCreateNewOpportunity.PRICING_OWNER_EMPID);
                db.AddInParameter(cd, "@iv_SolutionLeaderId", SqlDbType.VarChar, ObjCreateNewOpportunity.SolutionLeaderId);
                db.AddInParameter(cd, "@iv_FnaTCV", SqlDbType.VarChar, ObjCreateNewOpportunity.FnATCV);
                db.AddInParameter(cd, "@iv_HROTCV", SqlDbType.VarChar, ObjCreateNewOpportunity.HROTCV);
                db.AddInParameter(cd, "@iv_SCMTCV", SqlDbType.VarChar, ObjCreateNewOpportunity.SCMTCV);
                db.AddInParameter(cd, "@iv_KPOTCV", SqlDbType.VarChar, ObjCreateNewOpportunity.KPOTCV);
                db.AddInParameter(cd, "@iv_LPOTCV", SqlDbType.VarChar, ObjCreateNewOpportunity.LPOTCV);
                db.AddInParameter(cd, "@iv_VerticalTCV", SqlDbType.VarChar, ObjCreateNewOpportunity.VERTICALTCV);
                db.AddInParameter(cd, "@iv_VoiceTCV", SqlDbType.VarChar, ObjCreateNewOpportunity.VOICETCV);
                db.AddInParameter(cd, "@iv_BpmTCV", SqlDbType.VarChar, ObjCreateNewOpportunity.BPMTCV);
                db.AddInParameter(cd, "@in_PIBSTCV", SqlDbType.VarChar, ObjCreateNewOpportunity.PibsSaleValue);
                db.AddInParameter(cd, "@in_ClusterId", SqlDbType.Int, ObjCreateNewOpportunity.ClusterId);
                db.AddInParameter(cd, "@in_ServiceId", SqlDbType.Int, ObjCreateNewOpportunity.ServiceId);
                db.AddInParameter(cd, "@in_SUBIOU", SqlDbType.VarChar, ObjCreateNewOpportunity.SUBIOU);
                db.AddInParameter(cd, "@in_strTransitionEmpId", SqlDbType.VarChar, ObjCreateNewOpportunity.TransitionEmpId);
                db.AddInParameter(cd, "@in_strTransitionName", SqlDbType.VarChar, ObjCreateNewOpportunity.TransitionName);
                db.AddInParameter(cd, "@in_strTransitionType", SqlDbType.VarChar, ObjCreateNewOpportunity.TransitionType);
                db.AddInParameter(cd, "@in_strTransitionApproach", SqlDbType.VarChar, ObjCreateNewOpportunity.TransitionApproach);
                db.AddInParameter(cd, "@in_strTransitionModel", SqlDbType.VarChar, ObjCreateNewOpportunity.TransitionModel);
                db.AddInParameter(cd, "@in_strProposalfactory", SqlDbType.VarChar, ObjCreateNewOpportunity.Proposalfactory);
                db.AddInParameter(cd, "@in_strProposalfactoryOptions", SqlDbType.VarChar, ObjCreateNewOpportunity.ProposalfactoryOptions);
                db.AddInParameter(cd, "@in_strProposalComments", SqlDbType.VarChar, ObjCreateNewOpportunity.ProposalComments);
                db.AddInParameter(cd, "@iv_DTValue", SqlDbType.VarChar, ObjCreateNewOpportunity.DTValue);
                db.AddInParameter(cd, "@iv_OtherDT", SqlDbType.VarChar, ObjCreateNewOpportunity.Other_DT);
                db.AddOutParameter(cd, "@on_Result", SqlDbType.Int, Int16.MaxValue);
                //Changes for Stage 2            
                db.AddInParameter(cd, "@in_RFIReceivedDt", SqlDbType.Int, ObjCreateNewOpportunity.RFIReceivedDate);
                db.AddInParameter(cd, "@in_RFIsubmitDt", SqlDbType.Int, ObjCreateNewOpportunity.RFISubmissionDate);
                db.AddInParameter(cd, "@iv_CurrentlyActive", SqlDbType.VarChar, ObjCreateNewOpportunity.CURRENTLY_ACTIVE);

                db.AddInParameter(cd, "@in_CRMStage", SqlDbType.Int, ObjCreateNewOpportunity.CRM_STAGE);
                db.AddInParameter(cd, "@in_CRMTCV", SqlDbType.VarChar, ObjCreateNewOpportunity.CRM_TCV);
                db.AddInParameter(cd, "@iv_DigitalTCV", SqlDbType.VarChar, ObjCreateNewOpportunity.strDigitalTcv);

                db.AddInParameter(cd, "@in_SubSP", SqlDbType.Int, ObjCreateNewOpportunity.subSPId);
                db.AddInParameter(cd, "@in_CRMBeacon", SqlDbType.VarChar, ObjCreateNewOpportunity.CRM_Beacon);

                //End
                db.AddInParameter(cd, "@in_TGA", SqlDbType.VarChar, ObjCreateNewOpportunity.TataGroupAccount);
                db.AddInParameter(cd, "@in_TPA", SqlDbType.VarChar, ObjCreateNewOpportunity.TPA);
                db.AddInParameter(cd, "@in_TPA_Name", SqlDbType.VarChar, ObjCreateNewOpportunity.TPA_Name);
                db.AddInParameter(cd, "@in_ItisScope", SqlDbType.VarChar, ObjCreateNewOpportunity.ItisScope);
                db.AddInParameter(cd, "@in_IsContractRenewal", SqlDbType.VarChar, ObjCreateNewOpportunity.IsContractRenewal);
                db.AddInParameter(cd, "@in_ContractRenewalValue", SqlDbType.VarChar, ObjCreateNewOpportunity.ContractRenewalValue);
                //changess
                db.AddInParameter(cd, "@in_ResourcingId", SqlDbType.Int, ObjCreateNewOpportunity.RESOURCING_ID);
                db.AddInParameter(cd, "@in_Seat_IdentificationId", SqlDbType.Int, ObjCreateNewOpportunity.SEAT_IDENTIFICATION_ID);
                db.AddInParameter(cd, "@DealStatus_Id", SqlDbType.Int, ObjCreateNewOpportunity.DealStatus);
                db.AddInParameter(cd, "@in_Opportunity_Desc_Details", SqlDbType.VarChar, ObjCreateNewOpportunity.OpportunityDescDetails);
                //End

                db.ExecuteNonQuery(cd);
                on_Result = db.GetParameterValue(cd, "@on_Result").ToString();
                strResult.Add(new CreateNewOpportunity()
                {
                    on_Result = db.GetParameterValue(cd, "@on_Result").ToString()
                });
            }



            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
            return strResult;

        }
        //changes for Stage 2
        /// <summary>
        /// Save Stage2 Opportunity Details
        /// </summary>
        public List<CreateNewOpportunity> Stage7_Save_Stage9Details(CreateNewOpportunity ObjCreateNewOpportunity)
        {
            List<CreateNewOpportunity> strResult = new List<CreateNewOpportunity>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.SAVE_STAGE9Details);
                db.AddInParameter(cd, "@in_OpportunityId", SqlDbType.VarChar, ObjCreateNewOpportunity.OpportunityId);
                db.AddInParameter(cd, "@in_DEALREASON1", SqlDbType.VarChar, ObjCreateNewOpportunity.strReason1);
                db.AddInParameter(cd, "@in_DEALREASON2", SqlDbType.VarChar, ObjCreateNewOpportunity.strReason2);
                db.AddInParameter(cd, "@in_DEALREASON3", SqlDbType.VarChar, ObjCreateNewOpportunity.strReason3);
                db.AddInParameter(cd, "@in_WonFTE", SqlDbType.VarChar, ObjCreateNewOpportunity.intWonFTE);
                db.AddInParameter(cd, "@iv_WonTCV", SqlDbType.VarChar, ObjCreateNewOpportunity.strWINTCV);
                db.AddInParameter(cd, "@iv_WinReason", SqlDbType.VarChar, ObjCreateNewOpportunity.strWinReason);
                db.AddInParameter(cd, "@in_WINDate", SqlDbType.VarChar, ObjCreateNewOpportunity.strWinDate);
                db.AddOutParameter(cd, "@on_Result", SqlDbType.Int, Int16.MaxValue);
                db.ExecuteNonQuery(cd);
                on_Result = db.GetParameterValue(cd, "@on_Result").ToString();
                strResult.Add(new CreateNewOpportunity()
                {
                    on_Result = db.GetParameterValue(cd, "@on_Result").ToString()
                });
            }



            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
            return strResult;

        }
        public List<SubSP> GetSubSP()
        {
            DataSet ds = null;
            List<SubSP> modelList = new List<SubSP>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.GetSubSP);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;
                        for (int i = 0; i < rowCount; i++)
                        {
                            modelList.Add(MapGetSubSP(ds.Tables[0].Rows[i]));
                        }
                    }
                }
            }

            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }

            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }
            return modelList;
        }

        private static SubSP MapGetSubSP(DataRow objRow)
        {

            return new SubSP()
            {
                subSPId = (objRow.Table.Columns.Contains("subSPId")) ? (objRow["subSPId"] == DBNull.Value) ? 0 : Convert.ToInt32(objRow["subSPId"]) : 0,
                subSPName = (objRow.Table.Columns.Contains("subSPName")) ? (objRow["subSPName"] == DBNull.Value) ? "" : Convert.ToString(objRow["subSPName"]) : "",
            };
        }


        //Changess

        /// <summary>
        /// Get Resoucing Details
        /// </summary>
        public List<ResourcingSeatIdentification> Get_Resourcing()
        {
            DataSet ds = null;
            List<ResourcingSeatIdentification> modelList = new List<ResourcingSeatIdentification>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.GetResourcing);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;

                        for (int i = 0; i < rowCount; i++)
                        {
                            modelList.Add(MapResourcing(ds.Tables[0].Rows[i]));
        }

    }
                }
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }
            return modelList;
        }
        private static ResourcingSeatIdentification MapResourcing(DataRow dr)
        {
            try
            {
                return new ResourcingSeatIdentification()
                {
                    RESOURCING_ID = (dr.Table.Columns.Contains("id")) ? (dr["id"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["id"]) : 0,
                    RESOURCING_NAME = (dr.Table.Columns.Contains("name")) ? (dr["name"] == DBNull.Value) ? "" : dr.Field<string>("name") : "",
                    RESOURCING_COLOR = (dr.Table.Columns.Contains("Color")) ? (dr["Color"] == DBNull.Value) ? "" : dr.Field<string>("Color") : "",
                };
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
        }

        /// <summary>
        /// Get SubCompetency Details
        /// </summary>
        public List<DealStatus> Get_DealStatus()
        {
            DataSet ds = null;
            List<DealStatus> customerList = new List<DealStatus>();
            try
            {


                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Get_DealStatus);

                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;
                        for (int i = 0; i < rowCount; i++)
                        {
                            customerList.Add(MapGet_DealStatus(ds.Tables[0].Rows[i]));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }
            return customerList;
        }

        private static DealStatus MapGet_DealStatus(DataRow objRow)
        {

            return new DealStatus()
            {

                Deal_statusID = (objRow.Table.Columns.Contains("id")) ? (objRow["id"] == DBNull.Value) ? 0 : Convert.ToInt32(objRow["id"]) : 0,
                Deal_statusName = (objRow.Table.Columns.Contains("name")) ? (objRow["name"] == DBNull.Value) ? "" : Convert.ToString(objRow["name"]) : "",
                Deal_statusColor = (objRow.Table.Columns.Contains("Color")) ? (objRow["Color"] == DBNull.Value) ? "" : Convert.ToString(objRow["Color"]) : "",

            };
        }

        public List<Services> Get_Service_Practices()
        {
            DataSet ds = null;
            List<Services> customerList = new List<Services>();
            try
            {


                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Get_Service_Practices);

                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;
                        for (int i = 0; i < rowCount; i++)
                        {
                            customerList.Add(MapGet_Service_Practices(ds.Tables[0].Rows[i]));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }
            return customerList;
        }

        private static Services MapGet_Service_Practices(DataRow objRow)
        {

            return new Services()
            {

                Service_PracticesID = (objRow.Table.Columns.Contains("id")) ? (objRow["id"] == DBNull.Value) ? 0 : Convert.ToInt32(objRow["id"]) : 0,
                Service_PracticesName = (objRow.Table.Columns.Contains("name")) ? (objRow["name"] == DBNull.Value) ? "" : Convert.ToString(objRow["name"]) : "",

            };
        }

        public List<OfferingType> Get_Core_Offerings()
        {
            DataSet ds = null;
            List<OfferingType> customerList = new List<OfferingType>();
            try
            {


                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Get_Core_Offerings);

                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;
                        for (int i = 0; i < rowCount; i++)
                        {
                            customerList.Add(MapGet_Core_Offerings(ds.Tables[0].Rows[i]));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }
            return customerList;
        }

        private static OfferingType MapGet_Core_Offerings(DataRow objRow)
        {

            return new OfferingType()
            {

                Core_OfferingID = (objRow.Table.Columns.Contains("id")) ? (objRow["id"] == DBNull.Value) ? 0 : Convert.ToInt32(objRow["id"]) : 0,
                Core_OfferingName = (objRow.Table.Columns.Contains("name")) ? (objRow["name"] == DBNull.Value) ? "" : Convert.ToString(objRow["name"]) : "",

            };
        }

        /// <summary>
        /// Get Seat Identification Details
        /// </summary>


        public List<ResourcingSeatIdentification> Get_Seat_Identification()
        {
            DataSet ds = null;
            List<ResourcingSeatIdentification> modelList = new List<ResourcingSeatIdentification>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.GetSeatIdentification);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;

                        for (int i = 0; i < rowCount; i++)
                        {
                            modelList.Add(MapIdentification(ds.Tables[0].Rows[i]));
                        }

                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }
            return modelList;
        }
        private static ResourcingSeatIdentification MapIdentification(DataRow dr)
        {
            try
            {
                return new ResourcingSeatIdentification()
                {
                    SEAT_IDENTIFICATION_ID = (dr.Table.Columns.Contains("id")) ? (dr["id"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["id"]) : 0,
                    SEAT_IDENTIFICATION_NAME = (dr.Table.Columns.Contains("name")) ? (dr["name"] == DBNull.Value) ? "" : dr.Field<string>("name") : "",
                    SEAT_IDENTIFICATION_COLOR = (dr.Table.Columns.Contains("Color")) ? (dr["Color"] == DBNull.Value) ? "" : dr.Field<string>("Color") : "",
                };
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
        }
        public List<MultiSelectList> Get_SelectedLocation(string oppId)
        {
            DataSet ds = null;
            List<MultiSelectList> customerList = new List<MultiSelectList>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Get_SelectedLocation);
                db.AddInParameter(cd, "@iv_OppID", SqlDbType.VarChar, oppId);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;

                        for (int i = 0; i < rowCount; i++)
                        {
                            customerList.Add(MapGet_SelectedLocation(ds.Tables[0].Rows[i]));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }

            return customerList;
        }

        private static MultiSelectList MapGet_SelectedLocation(DataRow objRow)
            {
            try
            {
                return new MultiSelectList()
                {
                    itemName = objRow.Table.Columns.Contains("MAIN_DC_CENTER_NAME") ? (objRow["MAIN_DC_CENTER_NAME"] == DBNull.Value) ? "" : Convert.ToString(objRow["MAIN_DC_CENTER_NAME"]) : "",
                    id = objRow.Table.Columns.Contains("MAIN_DC_CENTER_ID") ? (objRow["MAIN_DC_CENTER_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(objRow["MAIN_DC_CENTER_ID"]) : 0,
                };
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
        }


        /// <summary>
        /// Insert T_NEXT_STEP_HISTORY Details
        /// </summary>
        public int INS_NEXT_STEP_HISTORY(CreateNewOpportunity ObjCreateNewOpportunity)
        {
            try
            {
                int intResult;
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.INS_NEXT_STEP_HISTORY);
                db.AddInParameter(cd, "@OPPORTUNITY_ID", SqlDbType.VarChar, ObjCreateNewOpportunity.OpportunityId);
                db.AddInParameter(cd, "@NEXT_STEP_NAME", SqlDbType.VarChar, ObjCreateNewOpportunity.NextStep);
                db.AddInParameter(cd, "@UNIT_ID", SqlDbType.Int, ObjCreateNewOpportunity.UnitId);
                db.AddInParameter(cd, "@STAGE_ID", SqlDbType.Int, ObjCreateNewOpportunity.StageID);
                db.AddInParameter(cd, "@iv_UserLogin", SqlDbType.VarChar, ObjCreateNewOpportunity.UserLogin);
                db.AddOutParameter(cd, "@on_Result", SqlDbType.Int, Int16.MaxValue);
                db.ExecuteNonQuery(cd);
                intResult = Convert.ToInt16(db.GetParameterValue(cd, "@on_Result"));
                return intResult;
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
        }

        public List<NextStepHistory> Get_Next_Step(string opportunityId, int stageId)
        {
            DataSet ds = null;
            List<NextStepHistory> modelList = new List<NextStepHistory>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Get_Next_Step);
                db.AddInParameter(cd, "@OPPORTUNITY_ID", SqlDbType.VarChar, opportunityId);
                db.AddInParameter(cd, "@STAGE_ID", SqlDbType.Int, stageId);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;

                        for (int i = 0; i < rowCount; i++)
                        {
                            modelList.Add(Map_Next_Step(ds.Tables[0].Rows[i]));
                        }

                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }
            return modelList;
        }
        private static NextStepHistory Map_Next_Step(DataRow dr)
        {
            try
            {
                return new NextStepHistory()
                {
                    NextStep = (dr.Table.Columns.Contains("NextStep")) ? (dr["NextStep"] == DBNull.Value) ? "" : dr.Field<string>("NextStep") : "",
                };
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
        }

        /// <summary>
        /// Insert T_STATUS_UPDATE_HISTORY Details
        /// </summary>
        public int INS_STATUS_UPDATE_HISTORY(CreateNewOpportunity ObjCreateNewOpportunity)
        {
            try
            {
                int intResult;
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.INS_STATUS_UPDATE_HISTORY);
                db.AddInParameter(cd, "@OPPORTUNITY_ID", SqlDbType.VarChar, ObjCreateNewOpportunity.OpportunityId);
                db.AddInParameter(cd, "@STATUS_UPDATE_NAME", SqlDbType.VarChar, ObjCreateNewOpportunity.StatusUpdate);
                db.AddInParameter(cd, "@UNIT_ID", SqlDbType.Int, ObjCreateNewOpportunity.UnitId);
                db.AddInParameter(cd, "@STAGE_ID", SqlDbType.Int, ObjCreateNewOpportunity.StageID);
                db.AddInParameter(cd, "@iv_UserLogin", SqlDbType.VarChar, ObjCreateNewOpportunity.UserLogin);
                db.AddOutParameter(cd, "@on_Result", SqlDbType.Int, Int16.MaxValue);
                db.ExecuteNonQuery(cd);
                intResult = Convert.ToInt16(db.GetParameterValue(cd, "@on_Result"));
                return intResult;
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
        }

        public List<NextStepHistory> Get_Status_Update(string opportunityId, int stageId)
        {
            DataSet ds = null;
            List<NextStepHistory> modelList = new List<NextStepHistory>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Get_Status_Update);
                db.AddInParameter(cd, "@OPPORTUNITY_ID", SqlDbType.VarChar, opportunityId);
                db.AddInParameter(cd, "@STAGE_ID", SqlDbType.Int, stageId);
                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;

                        for (int i = 0; i < rowCount; i++)
                        {
                            modelList.Add(Map_Status_Update(ds.Tables[0].Rows[i]));
                        }

                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }
            return modelList;
        }
        private static NextStepHistory Map_Status_Update(DataRow dr)
        {
            try
            {
                return new NextStepHistory()
                {
                    StatusUpdate = (dr.Table.Columns.Contains("StatusUpdate")) ? (dr["StatusUpdate"] == DBNull.Value) ? "" : dr.Field<string>("StatusUpdate") : "",
                };
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
        }


        public List<MultiSelectList> PopulateWinReason()
        {
            DataSet ds = null;
            List<MultiSelectList> modelList = new List<MultiSelectList>();
            try
            {
                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.PopulateWinReason);
                

                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;

                        for (int i = 0; i < rowCount; i++)
                        {
                            modelList.Add(MapWinReason(ds.Tables[0].Rows[i]));
                        }

                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseException(ex);
            }
            catch (ArgumentException ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }

            return modelList;
        }

        private static MultiSelectList MapWinReason(DataRow dr)
        {
            try
            {
                return new MultiSelectList()
                {
                    id = (dr.Table.Columns.Contains("WIN_REASON_ID")) ? (dr["WIN_REASON_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["WIN_REASON_ID"]) : 0,
                    itemName = (dr.Table.Columns.Contains("WIN_REASON_NAME")) ? (dr["WIN_REASON_NAME"] == DBNull.Value) ? "" : dr.Field<string>("WIN_REASON_NAME") : "",
                };
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
        }




        public List<OfferingType> Get_Core_Offerings_Name()
        {
            DataSet ds = null;
            List<OfferingType> customerList = new List<OfferingType>();
            try
            {


                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Get_Core_Offerings_Name);

                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;
                        for (int i = 0; i < rowCount; i++)
                        {
                            customerList.Add(MapGet_Core_Offerings_Name(ds.Tables[0].Rows[i]));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }
            return customerList;
        }

        private static OfferingType MapGet_Core_Offerings_Name(DataRow objRow)
        {

            return new OfferingType()
            {

                CofID = (objRow.Table.Columns.Contains("id")) ? (objRow["id"] == DBNull.Value) ? 0 : Convert.ToInt32(objRow["id"]) : 0,
                CofName = (objRow.Table.Columns.Contains("name")) ? (objRow["name"] == DBNull.Value) ? "" : Convert.ToString(objRow["name"]) : "",

            };
        }


        public List<DeliveryMaster> Get_Delivery_Owner_Master()
        {
            DataSet ds = null;
            List<DeliveryMaster> List = new List<DeliveryMaster>();
            try
            {


                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.Get_DeliveryOwnerMaster);

                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;
                        for (int i = 0; i < rowCount; i++)
                        {
                            List.Add(MapGet_Delivery_Owner_Master(ds.Tables[0].Rows[i]));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }
            return List;
        }

        private static DeliveryMaster MapGet_Delivery_Owner_Master(DataRow objRow)
        {

            return new DeliveryMaster()
            {

                Delivery_Owner_ID = (objRow.Table.Columns.Contains("DELIVERY_LEAD_ID")) ? (objRow["DELIVERY_LEAD_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(objRow["DELIVERY_LEAD_ID"]) : 0,
                Delivery_Owner_Name = (objRow.Table.Columns.Contains("DELIVERY_LEAD_NAME")) ? (objRow["DELIVERY_LEAD_NAME"] == DBNull.Value) ? "" : Convert.ToString(objRow["DELIVERY_LEAD_NAME"]) : "",

            };
        }

        public List<Dropdown> GetCBOIOffering()
        {
            DataSet ds = null;
            List<Dropdown> List = new List<Dropdown>();
            try
            {


                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.GetCBOIOffering);

                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;
                        for (int i = 0; i < rowCount; i++)
                        {
                            List.Add(MapGet_GetCBOIOffering(ds.Tables[0].Rows[i]));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }
            return List;
        }

        private static Dropdown MapGet_GetCBOIOffering(DataRow objRow)
        {

            return new Dropdown()
            {

                id = (objRow.Table.Columns.Contains("id")) ? (objRow["id"] == DBNull.Value) ? 0 : Convert.ToInt32(objRow["id"]) : 0,
                itemName = (objRow.Table.Columns.Contains("cboi_offeringname")) ? (objRow["cboi_offeringname"] == DBNull.Value) ? "" : Convert.ToString(objRow["cboi_offeringname"]) : "",

            };
        }

        public List<Dropdown> GetDealFlag()
        {
            DataSet ds = null;
            List<Dropdown> List = new List<Dropdown>();
            try
            {


                SqlDatabase db = RPM_Model.CommonModel.GetWebDatabase();
                DbCommand cd = db.GetStoredProcCommand(DataConstants.GetDealFlag);

                ds = db.ExecuteDataSet(cd);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        int rowCount = ds.Tables[0].Rows.Count;
                        for (int i = 0; i < rowCount; i++)
                        {
                            List.Add(MapGet_GetDealFlag(ds.Tables[0].Rows[i]));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (ds != null)
                {
                    ds.Dispose();
                }
            }
            return List;
        }

        private static Dropdown MapGet_GetDealFlag(DataRow objRow)
        {

            return new Dropdown()
            {

                id = (objRow.Table.Columns.Contains("id")) ? (objRow["id"] == DBNull.Value) ? 0 : Convert.ToInt32(objRow["id"]) : 0,
                itemName = (objRow.Table.Columns.Contains("dealflag")) ? (objRow["dealflag"] == DBNull.Value) ? "" : Convert.ToString(objRow["dealflag"]) : "",

            };
        }

        //END
    }

    public class Dropdown {

        public int id { get; set; }
        public string itemName { get; set; }

    }
    public class Entity
    {
        public string Value { get; set; }
        public string Text { get; set; }


        /// <summary>
        /// Get Entity Details
        /// </summary>
        public List<Entity> GetEntity()
        {

            List<Entity> EntityList = new List<Entity> {
                                                          new Entity(Value = "eServe", Text = "eServe"),
                                                         new Entity(Value = "Non eServe", Text = "Non eServe"),

            };
            return EntityList;
        }
        public Entity()
        {

        }
        public Entity(string value, string text)
        {
            this.Value = value;
            this.Text = text;
        }

    }
    public class ProbabilityofWIN
    {
        public string Value { get; set; }
        public string Text { get; set; }
        public string Color { get; set; }

        /// <summary>
        /// Get ProbabilityofWIN Details
        /// </summary>
        public List<ProbabilityofWIN> GetProbabilityofWIN(int unitID)
        {
            List<ProbabilityofWIN> WINList = new List<ProbabilityofWIN>();
            if (unitID==1)
            {
                    WINList = new List<ProbabilityofWIN> {
                    new ProbabilityofWIN(Value = "1", Text = "High - (75%-100%)",Color="#b3ff66"),
                    new ProbabilityofWIN(Value = "2", Text = "Moderate - (50%-74%)",Color="#ffa64d"),
                    new ProbabilityofWIN(Value = "3", Text = "Low - (Less than 50%)",Color="#ff6666"),
                   

                };
            }
            else
            {
                    WINList = new List<ProbabilityofWIN> {
                    new ProbabilityofWIN(Value = "25", Text = "25",Color=""),
                    new ProbabilityofWIN(Value = "50", Text = "50",Color=""),
                    new ProbabilityofWIN(Value = "75", Text = "75",Color=""),
                    new ProbabilityofWIN(Value = "100", Text = "100",Color=""),

                };
            }
           
            return WINList;
        }
        public ProbabilityofWIN()
        {

        }
        public ProbabilityofWIN(string value, string text,string color)
        {
            this.Value = value;
            this.Text = text;
            this.Color = color;
        }
    }

    public class MultiSelect
    {
        public int id { get; set; }
        public string itemName { get; set; }
    }


    public class UpdateOpportunityStage {

        public string OpportunityId { get; set; }
        public int CurrentStageID { get; set; }
        public int NextStageID { get; set; }
        public int EmpId { get; set; }
    }



}

