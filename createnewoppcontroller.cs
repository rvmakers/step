//************************************************************************
//File Name	     : CreateNewOpportunityController.cs 
//Created By     : Gnanasigamani,Vinoth,Anand
//Created Date   : 13-Dec-2017
//************************************************************************
using System;
using System.Collections.Generic;
using System.Web.Http;
using RPM_Models;
using RPM_API.common;
using RPM_API.lib;


namespace RPM_API.Controllers
{
   
    public class CreateNewOpportunityController : ApiController

    {

        public List<MultiSelectList> GetPlatform(int unitID)
        {
            try
            {
                List<MultiSelectList> ObjOpportunityUnitID = new List<MultiSelectList>();
                if (unitID != 0)
                {
                    ObjOpportunityUnitID = new CreateNewOpportunity().GetPlatform(unitID);
                }
                return ObjOpportunityUnitID;
            }

            catch (InvalidOperationException ex)
            {

                throw new ExceptionHandler(ex);
            }
        }

        [HttpGet]
        public List<CreateNewOpportunity> GetCategory(int unitID)
        {
            try
            {
                List<CreateNewOpportunity> ObjOpportunityUnitID = new List<CreateNewOpportunity>();
                ObjOpportunityUnitID = new CreateNewOpportunity().GetCategory(unitID);

                return ObjOpportunityUnitID;
            }

            catch (InvalidOperationException ex)
            {

                throw new ExceptionHandler(ex);
            }
        }

        public int Ins_DelTeamMember(CreateNewOpportunity ObjCreateNewOpportunity)
        {
            try
            {
                return new CreateNewOpportunity().Ins_DelTeamMember(ObjCreateNewOpportunity);
            }
            catch (InvalidOperationException ex)
            {

                throw new ExceptionHandler(ex);
            }
        }
        public int Ins_SolTeamMember(CreateNewOpportunity ObjCreateNewOpportunity)
        {
            try
            {
                return new CreateNewOpportunity().Ins_SolTeamMember(ObjCreateNewOpportunity);
            }
            catch (InvalidOperationException ex)
            {

                throw new ExceptionHandler(ex);
            }
        }

        [HttpGet]
        public List<MultiSelectList> GetBPSOffering(string unitId)
        {
            try
            {
                List<MultiSelectList> bpsOfferingList = new List<MultiSelectList>();
                if (!CheckForNull.IsNullOrEmpty(unitId))
                {

                    bpsOfferingList = new CreateNewOpportunity().GetBPSOffering(unitId);
                }
                return bpsOfferingList;
            }
            catch (InvalidOperationException ex)
            {

                throw new ExceptionHandler(ex);
            }

        }

        [HttpGet]
        public List<OppVertical> GetVerticalName(string unitId)
        {
            try
            {
                List<OppVertical> verticalList = new List<OppVertical>();
                if (!CheckForNull.IsNullOrEmpty(unitId))
                {

                    verticalList = new CreateNewOpportunity().GetVertical(unitId);
                }
                return verticalList;
            }
            catch (InvalidOperationException ex)
            {

                throw new ExceptionHandler(ex);
            }

        }

        [HttpGet]
        public List<OppStage> GetOpportunityChkCRM(string strOpportunityID)
        {
            try
            {
                List<OppStage> ObjOpportunityUnitID = new List<OppStage>();
                if (!CheckForNull.IsNullOrEmpty(strOpportunityID))
                {
                    ObjOpportunityUnitID = new CreateNewOpportunity().GetOpportunityChkCRM(strOpportunityID);
                }
                return ObjOpportunityUnitID;
            }

            catch (InvalidOperationException ex)
            {

                throw new ExceptionHandler(ex);
            }
        }
        [HttpPost]
        public void Opportunity_StageChangeCount_sp(CreateNewOpportunity obj)
        {
            try
            {
                new CreateNewOpportunity().Opportunity_StageChangeCount_sp(obj);
            }
            catch (InvalidOperationException ex)
            {

                throw new ExceptionHandler(ex);
            }
        }

        public List<CreateNewOpportunity> GetSol_TM_Dtls(string strOppID)
        {
            try
            {
                List<CreateNewOpportunity> ObjOpportunityUnitID = new List<CreateNewOpportunity>();
                if (!CheckForNull.IsNullOrEmpty(strOppID))
                {
                    ObjOpportunityUnitID = new CreateNewOpportunity().GetSol_TM_Dtls(strOppID);
                }
                return ObjOpportunityUnitID;
            }

            catch (InvalidOperationException ex)
            {

                throw new ExceptionHandler(ex);
            }
        }

        public List<CreateNewOpportunity> GetDel_TM_Dtls(string strOppID)
        {
            try
            {
                List<CreateNewOpportunity> ObjOpportunityUnitID = new List<CreateNewOpportunity>();
                if (!CheckForNull.IsNullOrEmpty(strOppID))
                {
                    ObjOpportunityUnitID = new CreateNewOpportunity().GetDel_TM_Dtls(strOppID);
                }
                return ObjOpportunityUnitID;
            }

            catch (InvalidOperationException ex)
            {

                throw new ExceptionHandler(ex);
            }
        }

        [HttpPost]
        public int Upd_Sol_TM(CreateNewOpportunity ObjCreateNewOpportunity)
        {
            try
            {
                return new CreateNewOpportunity().Upd_Sol_TM(ObjCreateNewOpportunity);
            }
            catch (InvalidOperationException ex)
            {
                throw new ExceptionHandler(ex);
            }
        }

        [HttpPost]
        public int Upd_Del_TM(CreateNewOpportunity ObjCreateNewOpportunity)
        {
            try
            {
                return new CreateNewOpportunity().Upd_Del_TM(ObjCreateNewOpportunity);
            }
            catch (InvalidOperationException ex)
            {
                throw new ExceptionHandler(ex);
            }
        }

        public int Get_MaxStage(int OpportunityId)
        {
            try

            {
                return new CreateNewOpportunity().Get_MaxStage(OpportunityId);
            }
            catch (InvalidOperationException ex)
            {

                throw new ExceptionHandler(ex);
            }
        }

        public List<OppDetails> Get_TCV_CRM(string OppID)
        {
            try
            {
                List<OppDetails> ObjOpportunityUnitID = new List<OppDetails>();
                if (!CheckForNull.IsNullOrEmpty(OppID))
                {
                    ObjOpportunityUnitID = new CreateNewOpportunity().Get_TCV_CRM(OppID);
                }
                return ObjOpportunityUnitID;
            }

            catch (InvalidOperationException ex)
            {

                throw new ExceptionHandler(ex);
            }
        }

        [HttpGet]
        public List<OpportunityUnitID> Get_Service_Opp_Date(string strOppId)
        {
            try
            {
                List<OpportunityUnitID> ObjOpportunityUnitID = new List<OpportunityUnitID>();
                if (!CheckForNull.IsNullOrEmpty(strOppId))
                {
                    ObjOpportunityUnitID = new CreateNewOpportunity().Get_Service_Opp_Date(strOppId);
                }
                return ObjOpportunityUnitID;
            }

            catch (InvalidOperationException ex)
            {

                throw new ExceptionHandler(ex);
            }
        }
        [HttpGet]
        public List<VerticalHorizontal> GetServiceName(string unitId)
        {
            try
            {
                List<VerticalHorizontal> ServiceNameList = new List<VerticalHorizontal>();
                if (!CheckForNull.IsNullOrEmpty(unitId))
                {
                    ServiceNameList = new NewOpportunity().GetServiceName(unitId);
                }
                return ServiceNameList;
            }
            catch (InvalidOperationException ex)
            {

                throw new ExceptionHandler(ex);
            }

        }

        public List<Services> Get_Level1_Services(string service)
        {
            try
            {
                List<Services> ObjOpportunityUnitID = new List<Services>();
                if (!CheckForNull.IsNullOrEmpty(service))
                {
                    ObjOpportunityUnitID = new CreateNewOpportunity().Get_Level1_Services(service);
                }
                return ObjOpportunityUnitID;
            }

            catch (InvalidOperationException ex)
            {

                throw new ExceptionHandler(ex);
            }
        }

        public List<OpportunityUnitID> Get_Business_BFS1(string intUnitid)
        {
            try
            {
                List<OpportunityUnitID> ObjOpportunityUnitID = new List<OpportunityUnitID>();
                if (!CheckForNull.IsNullOrEmpty(intUnitid))
                {
                    ObjOpportunityUnitID = new CreateNewOpportunity().Get_Business_BFS1(intUnitid);
                }
                return ObjOpportunityUnitID;
            }

            catch (InvalidOperationException ex)
            {

                throw new ExceptionHandler(ex);
            }
        }

        [HttpPost]
        public int Save_VerticalOppdate(CreateNewOpportunity objvertical)
        {
            try
            {
                int result = 0;
                if (!CheckForNull.IsNull(objvertical))
                {
                    result = new CreateNewOpportunity().Save_VerticalOppdate(objvertical);
                }
                return result;

            }

            catch (InvalidOperationException ex)
            {

                throw new ExceptionHandler(ex);
            }


        }

        public List<OpportunityUnitID> Get_PresalesLead_VerticalWise(int intUnitid, int intBusinessId)
        {
            try
            {
                List<OpportunityUnitID> ObjOpportunityUnitID = new List<OpportunityUnitID>();
                if (intUnitid != 0 && intBusinessId != 0)
                {
                    ObjOpportunityUnitID = new CreateNewOpportunity().Get_PresalesLead_VerticalWise(intUnitid, intBusinessId);
                }
                return ObjOpportunityUnitID;
            }

            catch (InvalidOperationException ex)
            {

                throw new ExceptionHandler(ex);
            }
        }

        [HttpPost]
        public int Delete_VerticalOppdate(CreateNewOpportunity objvertical)
        {

            try
            {
                int result = 0;
                if (!CheckForNull.IsNull(objvertical))
                {
                    result = new CreateNewOpportunity().Delete_VerticalOppdate(objvertical);
                }
                return result;
            }

            catch (InvalidOperationException ex)
            {

                throw new ExceptionHandler(ex);
            }


        }


        [HttpGet]
        public List<MultiSelectList> Get_OppCompetitors(string OppID)
        {
            try
            {
                List<MultiSelectList> ObjOpportunityUnitID = new List<MultiSelectList>();
                if (!CheckForNull.IsNullOrEmpty(OppID))
                {
                    ObjOpportunityUnitID = new CreateNewOpportunity().Get_OppCompetitors(OppID);
                }
                return ObjOpportunityUnitID;
            }

            catch (InvalidOperationException ex)
            {

                throw new ExceptionHandler(ex);
            }
        }

        [HttpGet]
        public List<MultiSelectList> Get_OppPricingType(string OppID)
        {
            try
            {
                List<MultiSelectList> ObjOpportunityUnitID = new List<MultiSelectList>();
                if (!CheckForNull.IsNullOrEmpty(OppID))
                {
                    ObjOpportunityUnitID = new CreateNewOpportunity().Get_OppPricingType(OppID);
                }
                return ObjOpportunityUnitID;
            }

            catch (InvalidOperationException ex)
            {

                throw new ExceptionHandler(ex);
            }
        }



        [HttpGet]
        public int Upd_Competitors(string opportunityid)
        {

            try
            {
                return new CreateNewOpportunity().Upd_Competitors(opportunityid);
            }

            catch (InvalidOperationException ex)
            {

                throw new ExceptionHandler(ex);
            }


        }

        [HttpPost]
        public int Upd_PricingType(CreateNewOpportunity ObjCreateNewOpportunity)
        {
            try
            {
                return new CreateNewOpportunity().Upd_PricingType(ObjCreateNewOpportunity);
            }

            catch (InvalidOperationException ex)
            {

                throw new ExceptionHandler(ex);
            }
        }

        [HttpGet]
        public int Del_OppPricingType(string OppID)
        {
            try
            {
                return new CreateNewOpportunity().Del_OppPricingType(OppID);
            }

            catch (InvalidOperationException ex)
            {

                throw new ExceptionHandler(ex);
            }
        }


        [HttpPost]
        public int Save_OppCompetitors(CreateNewOpportunity ObjCreateNewOpportunity)
        {
           
            try
            {
                
                  return new CreateNewOpportunity().SaveOppCompetitors(ObjCreateNewOpportunity);
                

               
            }

            catch (InvalidOperationException ex)
            {

                throw new ExceptionHandler(ex);
            }


        }
        [HttpPost]
        public int Save_OppPricingType(CreateNewOpportunity ObjCreateNewOpportunity)
        {

            try
            {
                return new CreateNewOpportunity().SaveOppPricingType(ObjCreateNewOpportunity);
            }

            catch (InvalidOperationException ex)
            {

                throw new ExceptionHandler(ex);
            }
        }


        //rajat
        [HttpGet]
        public List<MultiSelectList> Get_OppBpsOffering(string OppID)
        {
            try
            {
                List<MultiSelectList> ObjOpportunityUnitID = new List<MultiSelectList>();
                if (!CheckForNull.IsNullOrEmpty(OppID))
                {
                    ObjOpportunityUnitID = new CreateNewOpportunity().Get_OppBpsOffering(OppID);
                }
                return ObjOpportunityUnitID;
            }

            catch (InvalidOperationException ex)
            {

                throw new ExceptionHandler(ex);
            }
        }


        [HttpGet]
        public int Upd_BpsOffering(string opportunityid)
        {

            try
            {
                return new CreateNewOpportunity().Upd_BpsOffering(opportunityid);
            }

            catch (InvalidOperationException ex)
            {

                throw new ExceptionHandler(ex);
            }


        }
        [HttpPost]
        public int Save_OppBpsOffering(CreateNewOpportunity[] ObjCreateNewOpportunity)
        {
            int result= 0;
            try
            {
                foreach (CreateNewOpportunity obj in ObjCreateNewOpportunity)
                {
                   result= new CreateNewOpportunity().SaveOppBpsOffering(obj);
                }
                return result;
            }
           catch (InvalidOperationException ex)
            {

                throw new ExceptionHandler(ex);
            }


        }


        [HttpPost]
        public int Save_OppPlatform(CreateNewOpportunity[] ObjCreateNewOpportunity)
        {
            int result = 0;
            try
            {
                foreach (CreateNewOpportunity obj in ObjCreateNewOpportunity)
                {
                    result = new CreateNewOpportunity().SaveOppPlatform(obj);
                }
                return result;
            }
            catch (InvalidOperationException ex)
            {

                throw new ExceptionHandler(ex);
            }


        }

        [HttpGet]
        public int Upd_Platform(string opportunityid)
        {

            try
            {
                return new CreateNewOpportunity().Upd_Platform(opportunityid);
            }

            catch (InvalidOperationException ex)
            {

                throw new ExceptionHandler(ex);
            }


        }
        [HttpGet]
        public List<MultiSelectList> Get_OppPlatform(string OppID)
        {
            try
            {
                List<MultiSelectList> ObjOpportunityUnitID = new List<MultiSelectList>();
                if (!CheckForNull.IsNullOrEmpty(OppID))
                {
                    ObjOpportunityUnitID = new CreateNewOpportunity().Get_OppPlatform(OppID);
                }
                return ObjOpportunityUnitID;
            }

            catch (InvalidOperationException ex)
            {

                throw new ExceptionHandler(ex);
            }
        }
        //rajat

        [HttpPost]
        public int Save_ServiceOppdate(CreateNewOpportunity objVerticalDomain)
        {
            try
            {
                return new CreateNewOpportunity().Save_ServiceOppdate(objVerticalDomain);
            }
            catch (InvalidOperationException ex)
            {

                throw new ExceptionHandler(ex);
            }
        }
        [HttpPost]
        public int Delete_ServiceOppdate(CreateNewOpportunity objVerticalData)
        {

            try
            {
                return new CreateNewOpportunity().Delete_ServiceOppdate(objVerticalData);
            }

            catch (InvalidOperationException ex)
            {

                throw new ExceptionHandler(ex);
            }

        }
        public List<OpportunityUnitID> GET_VERTICAL_DOMAIN_OPP_DATA(string strOppId)
        {
            try
            {
                List<OpportunityUnitID> ObjOpportunityUnitID = new List<OpportunityUnitID>();
                if (!CheckForNull.IsNullOrEmpty(strOppId))
                {
                    ObjOpportunityUnitID = new CreateNewOpportunity().GET_VERTICAL_DOMAIN_OPP_DATA(strOppId);
                }
                return ObjOpportunityUnitID;
            }

            catch (InvalidOperationException ex)
            {

                throw new ExceptionHandler(ex);
            }
        }

        public List<OpportunityUnitID> Get_Business_Domain(string unitId)
        {
            try
            {
                List<OpportunityUnitID> ObjOpportunityUnitID = new List<OpportunityUnitID>();
                if (!CheckForNull.IsNullOrEmpty(unitId))
                {
                    ObjOpportunityUnitID = new CreateNewOpportunity().Get_Business_Domain(unitId);
                }
                return ObjOpportunityUnitID;
            }

            catch (InvalidOperationException ex)
            {

                throw new ExceptionHandler(ex);
            }
        }


        public List<OpportunityUnitID> Get_Level1_Vertical(string vertical)
        {
            try
            {
                List<OpportunityUnitID> ObjOpportunityUnitID = new List<OpportunityUnitID>();
                if (!CheckForNull.IsNullOrEmpty(vertical))
                {
                    ObjOpportunityUnitID = new CreateNewOpportunity().Get_Level1_Vertical(vertical);
                }
                return ObjOpportunityUnitID;
            }

            catch (InvalidOperationException ex)
            {

                throw new ExceptionHandler(ex);
            }
        }


        [HttpPost]
        public int Save_VerticalDomainOppdata(CreateNewOpportunity objVerticalDomain)
        {
            try
            {
                return new CreateNewOpportunity().Save_VerticalDomainOppdata(objVerticalDomain);
            }
            catch (InvalidOperationException ex)
            {

                throw new ExceptionHandler(ex);
            }
        }
        [HttpPost]
        public int Delete_VerticalDomainOppdate(CreateNewOpportunity objVerticalData)
        {

            try
            {
                return new CreateNewOpportunity().Delete_VerticalDomainOppdate(objVerticalData);
            }

            catch (InvalidOperationException ex)
            {

                throw new ExceptionHandler(ex);
            }

        }


        [HttpGet]
        public List<DealReason> Get_Deal_Reason()
        {
            try
            {
                List<DealReason> ObjOpportunityUnitID = new List<DealReason>();
                ObjOpportunityUnitID = new CreateNewOpportunity().Get_Deal_Reason();

                return ObjOpportunityUnitID;
            }

            catch (InvalidOperationException ex)
            {

                throw new ExceptionHandler(ex);
            }
        }


        [HttpGet]
        public List<CreateNewOpportunity> Get_Sub_Competency()
        {
            try
            {
                List<CreateNewOpportunity> ObjOpportunityUnitID = new List<CreateNewOpportunity>();
                ObjOpportunityUnitID = new CreateNewOpportunity().Get_Sub_Competency();

                return ObjOpportunityUnitID;
            }

            catch (InvalidOperationException ex)
            {

                throw new ExceptionHandler(ex);
            }
        }


        [HttpGet]
        public List<PricingType> Get_Pricing_Type()
        {
            try
            {
                List<PricingType> ObjOpportunityUnitID = new List<PricingType>();
                ObjOpportunityUnitID = new CreateNewOpportunity().GetPricingType();

                return ObjOpportunityUnitID;
            }

            catch (InvalidOperationException ex)
            {

                throw new ExceptionHandler(ex);
            }
        }

        [HttpGet]
        public List<MultiSelectList> Get_Opp_Win_Loss_Reason(string OppID)
        {
            try
            {
                List<MultiSelectList> ObjOpportunityUnitID = new List<MultiSelectList>();
                if (!CheckForNull.IsNullOrEmpty(OppID))
                {
                    ObjOpportunityUnitID = new CreateNewOpportunity().Get_Opp_Win_Loss_Reason(OppID);
                }
                return ObjOpportunityUnitID;
            }

            catch (InvalidOperationException ex)
            {

                throw new ExceptionHandler(ex);
            }
        }



        public List<OpportunityUnitID> GET_VERTICAL_OPP_DATA(string strOppId)
        {
            try
            {
                List<OpportunityUnitID> ObjOpportunityUnitID = new List<OpportunityUnitID>();
                if (!CheckForNull.IsNullOrEmpty(strOppId))
                {
                    ObjOpportunityUnitID = new CreateNewOpportunity().Get_Vertical_Opp_Data(strOppId);
                }
                return ObjOpportunityUnitID;
            }

            catch (InvalidOperationException ex)
            {

                throw new ExceptionHandler(ex);
            }
        }


        [HttpGet]
        public List<MultiSelect> Get_Competitor(int unitID)
        {
            try
            {
                List<MultiSelect> ObjOpportunityUnitID = new List<MultiSelect>();
                ObjOpportunityUnitID = new CreateNewOpportunity().Get_Competitor(unitID);

                return ObjOpportunityUnitID;
            }

            catch (InvalidOperationException ex)
            {

                throw new ExceptionHandler(ex);
            }
        }

        [HttpGet]
        public List<MultiSelect> Get_PricingType(int unitID)
        {
            try
            {
                List<MultiSelect> ObjOpportunityUnitID = new List<MultiSelect>();
                ObjOpportunityUnitID = new CreateNewOpportunity().Get_PricingType(unitID);

                return ObjOpportunityUnitID;
            }

            catch (InvalidOperationException ex)
            {

                throw new ExceptionHandler(ex);
            }
        }

        [HttpGet]
        public List<CreateNewOpportunity> Get_OperationWindow()
        {
            try
            {
                List<CreateNewOpportunity> ObjOpportunityUnitID = new List<CreateNewOpportunity>();
                ObjOpportunityUnitID = new CreateNewOpportunity().Get_OperationWindow();

                return ObjOpportunityUnitID;
            }

            catch (InvalidOperationException ex)
            {

                throw new ExceptionHandler(ex);
            }
        }

        [HttpGet]
        public List<Seat> Get_TypesOfSeat()
        {
            try
            {
                List<Seat> ObjOpportunityUnitID = new List<Seat>();
                ObjOpportunityUnitID = new CreateNewOpportunity().Get_TypesOfSeat();

                return ObjOpportunityUnitID;
            }

            catch (InvalidOperationException ex)
            {

                throw new ExceptionHandler(ex);
            }
        }


        //Changess
        public List<ResourcingSeatIdentification> Get_Resourcing()
        {
            try
            {
                List<ResourcingSeatIdentification> objResourcing = new List<ResourcingSeatIdentification>();
                objResourcing = new CreateNewOpportunity().Get_Resourcing();

                return objResourcing;
            }

            catch (InvalidOperationException ex)
            {

                throw new ExceptionHandler(ex);
            }
        }


        public List<ResourcingSeatIdentification> Get_Seat_Identification()
        {
            try
            {
                List<ResourcingSeatIdentification> objIdentification = new List<ResourcingSeatIdentification>();
                objIdentification = new CreateNewOpportunity().Get_Seat_Identification();

                return objIdentification;
            }

            catch (InvalidOperationException ex)
            {

                throw new ExceptionHandler(ex);
            }
        }


        [HttpGet]
        public List<SubSP> GetSubSP()
        {
            try
            {
                List<SubSP> list = new List<SubSP>();
                list = new CreateNewOpportunity().GetSubSP();

                return list;
            }

            catch (InvalidOperationException ex)
            {

                throw new ExceptionHandler(ex);
            }
        }

        [HttpGet]
        public List<DealStatus> Get_DealStatus()
        {
            try
            {
                List<DealStatus> ObjOpportunityUnitID = new List<DealStatus>();
                ObjOpportunityUnitID = new CreateNewOpportunity().Get_DealStatus();

                return ObjOpportunityUnitID;
            }

            catch (InvalidOperationException ex)
            {

                throw new ExceptionHandler(ex);
            }
        }

        [HttpGet]
        public List<Services> Get_Service_Practices()
        {
            try
            {
                List<Services> ObjOpportunityUnitID = new List<Services>();
                ObjOpportunityUnitID = new CreateNewOpportunity().Get_Service_Practices();

                return ObjOpportunityUnitID;
            }

            catch (InvalidOperationException ex)
            {

                throw new ExceptionHandler(ex);
            }
        }


        [HttpGet]
        public List<OfferingType> Get_Core_Offerings()
        {
            try
            {
                List<OfferingType> ObjOpportunityUnitID = new List<OfferingType>();
                ObjOpportunityUnitID = new CreateNewOpportunity().Get_Core_Offerings();

                return ObjOpportunityUnitID;
            }

            catch (InvalidOperationException ex)
            {

                throw new ExceptionHandler(ex);
            }
        }
        [HttpPost]
        public int INS_NEXT_STEP_HISTORY(CreateNewOpportunity obj)
        {

            try
            {
                return new CreateNewOpportunity().INS_NEXT_STEP_HISTORY(obj);
            }

            catch (InvalidOperationException ex)
            {

                throw new ExceptionHandler(ex);
            }

        }

        [HttpGet]
        public List<NextStepHistory> Get_Next_Step(string opportunityId, int stageId)
        {
            try
            {
                List<NextStepHistory> ObjOpportunityUnitID = new List<NextStepHistory>();
                if (!CheckForNull.IsNullOrEmpty(opportunityId) && stageId != 0)
                {
                    ObjOpportunityUnitID = new CreateNewOpportunity().Get_Next_Step(opportunityId, stageId);
                }
                return ObjOpportunityUnitID;
            }

            catch (InvalidOperationException ex)
            {

                throw new ExceptionHandler(ex);
            }
        }
        [HttpPost]
        public int INS_STATUS_UPDATE_HISTORY(CreateNewOpportunity obj)
        {

            try
            {
                return new CreateNewOpportunity().INS_STATUS_UPDATE_HISTORY(obj);
            }

            catch (InvalidOperationException ex)
            {

                throw new ExceptionHandler(ex);
            }

        }

        [HttpGet]
        public List<NextStepHistory> Get_Status_Update(string opportunityId, int stageId)
        {
            try
            {
                List<NextStepHistory> ObjOpportunityUnitID = new List<NextStepHistory>();
                if (!CheckForNull.IsNullOrEmpty(opportunityId) && stageId != 0)
                {
                    ObjOpportunityUnitID = new CreateNewOpportunity().Get_Status_Update(opportunityId, stageId);
                }
                return ObjOpportunityUnitID;
            }

            catch (InvalidOperationException ex)
            {

                throw new ExceptionHandler(ex);
            }
        }


        [HttpGet]
        public List<OfferingType> GetOfferingType()
        {
            try
            {
                List<OfferingType> ObjOpportunityUnitID = new List<OfferingType>();
                ObjOpportunityUnitID = new CreateNewOpportunity().GetOfferingType();
                return ObjOpportunityUnitID;
            }

            catch (InvalidOperationException ex)
            {

                throw new ExceptionHandler(ex);
            }
        }

       [HttpGet]
        public List<OfferingType> Get_Core_Offerings_Name()
        {
            try
            {
                List<OfferingType> ObjOpportunityUnitID = new List<OfferingType>();
                ObjOpportunityUnitID = new CreateNewOpportunity().Get_Core_Offerings_Name();
                return ObjOpportunityUnitID;
            }

            catch (InvalidOperationException ex)
            {

                throw new ExceptionHandler(ex);
            }
        }

        [HttpGet]
        public List<MultiSelectList> Get_SelectedLocation(string OppID)
        {
            try
            {
                List<MultiSelectList> ObjOpportunityUnitID = new List<MultiSelectList>();
                if (!CheckForNull.IsNullOrEmpty(OppID))
                {
                    ObjOpportunityUnitID = new CreateNewOpportunity().Get_SelectedLocation(OppID);
                }
                return ObjOpportunityUnitID;
            }

            catch (InvalidOperationException ex)
            {

                throw new ExceptionHandler(ex);
            }
        }

        [HttpGet]
        public List<Dropdown> GetCBOIOffering()
        {
            try
            {
                List<Dropdown> ObjOpportunityUnitID = new List<Dropdown>();
                
                    ObjOpportunityUnitID = new CreateNewOpportunity().GetCBOIOffering();
                
                return ObjOpportunityUnitID;
            }

            catch (InvalidOperationException ex)
            {

                throw new ExceptionHandler(ex);
            }
        }

        [HttpGet]
        public List<Dropdown> GetDealFlag()
        {
            try
            {
                List<Dropdown> ObjOpportunityUnitID = new List<Dropdown>();

                ObjOpportunityUnitID = new CreateNewOpportunity().GetDealFlag();

                return ObjOpportunityUnitID;
            }

            catch (InvalidOperationException ex)
            {

                throw new ExceptionHandler(ex);
            }
        }
        //End




    }
}




