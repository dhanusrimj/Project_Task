using Data_logic;
using Utility_object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using static Utility_object.configuration;

namespace Business_logic
{
    public class BL_otherReport
    {
        DA_otherReport obTA_DataLogic = new DA_otherReport();


        public DataSet bldaInboundInformationalCall(searchList objPCI)
        {
            try
            {
                return obTA_DataLogic.daInboundInformationalCall(objPCI);
            }
            catch (Exception )
            {
            }
            return null;
        }

        public DataSet blInboundTransactionalCalls(searchList objPCI)
        {
            try
            {
                return obTA_DataLogic.daInboundTransactionalCalls(objPCI);
            }
            catch (Exception )
            {
            }
            return null;
        }

        public DataSet blInformationalIvrCalls(searchList objPCI)
        {
            try
            {
                return obTA_DataLogic.daInformationalIvrCalls(objPCI);
            }
            catch (Exception )
            {
            }
            return null;
        }

        public DataSet blTransactionalIvrCalls(searchList objPCI)
        {
            try
            {
                return obTA_DataLogic.daTransactionalIvrCalls(objPCI);
            }
            catch (Exception )
            {
            }
            return null;
        }

        public DataSet blGetCategoryAgentDetails()
        {
            try
            {
                return obTA_DataLogic.daGetCategoryAgentDetails();
            }
            catch (Exception)
            {
            }
            return null;
        }

        public DataSet bldaCategorySummary(searchList objPCI)
        {
            try
            {
                return obTA_DataLogic.daCategorySummary(objPCI);
            }
            catch (Exception)
            {
            }
            return null;
        }

        public DataSet bldaSubCategorySummary(searchList objPCI)
        {
            try
            {
                return obTA_DataLogic.daSubCategorySummary(objPCI);
            }
            catch (Exception)
            {
            }
            return null;
        }

        public DataSet bldaWrapupAgentSummary(searchList objPCI)
        {
            try
            {
                return obTA_DataLogic.daWrapupAgentSummary(objPCI);
            }
            catch (Exception)
            {
            }
            return null;
        }
        public DataSet bldaWrapupDetailedReport(searchList objPCI)
        {
            try
            {
                return obTA_DataLogic.daWrapupDetailedReport(objPCI);
            }
            catch (Exception)
            {
            }
            return null;
        }
        public DataSet blGetHelplineServicegroupDetails()
        {
            try
            {
                return obTA_DataLogic.daGetHelplineServicegroupDetails();
            }
            catch (Exception)
            {
            }
            return null;
        }

        public DataSet blServiceGroupSummary(searchList objPCI)
        {
            try
            {
                return obTA_DataLogic.daServiceGroupSummary(objPCI);
            }
            catch (Exception)
            {
            }
            return null;
        }

        public DataSet blGetAgentServicegroupDetails()
        {
            try
            {
                return obTA_DataLogic.daGetAgentServicegroupDetails();
            }
            catch (Exception)
            {
            }
            return null;
        }

        public DataSet blstaffSummary(searchList objPCI)
        {
            try
            {
                return obTA_DataLogic.daStaffSummary(objPCI);
            }
            catch (Exception)
            {
            }
            return null;
        }
        public DataSet blstaffSummaryInterval(searchList objPCI)
        {
            try
            {
                return obTA_DataLogic.daStaffSummaryInterval(objPCI);
            }
            catch (Exception)
            {
            }
            return null;
        }
        public DataSet bldaCallsDetailsReport(searchList objPCI)
        {
            try
            {
                return obTA_DataLogic.daCallsDetailsReport(objPCI);
            }
            catch (Exception)
            {
            }
            return null;
        }
        public DataSet bldaAgentDetailsReport(searchList objPCI)
        {
            try
            {
                return obTA_DataLogic.daAgentDetailedReport(objPCI);
            }
            catch (Exception)
            {
            }
            return null;
        }
        public DataSet bldaAgentLoginLogoffReport(searchList objPCI)
        {
            try
            {
                return obTA_DataLogic.daAgentLoginLogoffReport(objPCI);
            }
            catch (Exception)
            {
            }
            return null;
        }

        public DataSet blRepeatedCallerReport(searchList objPCI)
        {
            try
            {
                return obTA_DataLogic.daRepeatedCallerReport(objPCI);
            }
            catch (Exception)
            {
            }
            return null;
        }

        public DataSet blcqbyservicegroup(searchList objPCI)
        {
            try
            {
                return obTA_DataLogic.dacqbyservicegroup(objPCI);
            }
            catch (Exception)
            {
            }
            return null;
        }
        public DataSet blcqbyagent(searchList objPCI)
        {
            try
            {
                return obTA_DataLogic.dacqbyagent(objPCI);
            }
            catch (Exception)
            {
            }
            return null;
        }

        public DataSet blivrreport(searchList objPCI)
        {
            try
            {
                return obTA_DataLogic.daivrreport(objPCI);
            }
            catch (Exception)
            {
            }
            return null;
        }

        public DataSet bldaChatSurveyReport(searchList objPCI)
        {
            try
            {
                return obTA_DataLogic.dachatsurveyReport(objPCI);
            }
            catch (Exception)
            {
            }
            return null;
        }

        public DataSet bldaVoiceSurveyReport(searchList objPCI)
        {
            try
            {
                return obTA_DataLogic.davoicesurveyReport(objPCI);
            }
            catch (Exception)
            {
            }
            return null;
        }

        // Email Black List
        public List<Email_black_list> bl_get_dropdown_mailbox_details(Email_black_list bo_obj)
        {
            return obTA_DataLogic.dl_get_dropdown_mailbox_details(bo_obj);
        }

        public List<Email_black_list> bl_get_email_black_list(Email_black_list bo_obj)
        {
            return obTA_DataLogic.dl_get_email_black_list(bo_obj);
        }
        public string bl_create_email_black_details(Email_black_list bo_obj)
        {
            return obTA_DataLogic.dl_create_email_black_details(bo_obj);
        }

        public string bl_delete_email_black_details(Email_black_list bo_obj)
        {
            return obTA_DataLogic.dl_delete_email_black_details(bo_obj);
        }

        public List<keyword_configuration_details> bl_get_keyword_config_list(keyword_configuration_details bo_obj)
        {
            return obTA_DataLogic.dl_get_keyword_config_list(bo_obj);
        }
        public string bl_update_keyword_config_details(keyword_configuration_details bo_obj)
        {
            return obTA_DataLogic.dl_update_keyword_config_details(bo_obj);
        }

        public DataSet blemailreport(searchList objPCI)
        {
            try
            {
                return obTA_DataLogic.daEmailReport(objPCI);
            }
            catch (Exception)
            {
            }
            return null;
        }

        public DataSet blchatreport(searchList objPCI)
        {
            try
            {
                return obTA_DataLogic.daChatReport(objPCI);
            }
            catch (Exception)
            {
            }
            return null;
        }

        public DataSet blGetemailchatHelplineServicegroupDetails(searchList objPCI)
        {
            try
            {
                return obTA_DataLogic.daGetemailchatHelplineServicegroupDetails(objPCI);
            }
            catch (Exception)
            {
            }
            return null;
        }

        public DataSet blGetOutboundCampaignDetails()
        {
            try
            {
                return obTA_DataLogic.daGetOutboundCampaignDetails();
            }
            catch (Exception)
            {
            }
            return null;
        }

        public DataSet blGetOutboundCalls(searchList objPCI)
        {
            try
            {
                return obTA_DataLogic.daGetOutboundCalls(objPCI);
            }
            catch (Exception)
            {
            }
            return null;
        }

        public list_ratio_report_master_list GetReportmasterList()
        {
            try
            {
                return obTA_DataLogic.daGetReportmasterList();
            }
            catch (Exception)
            {
            }
            return null;
        }

        public List<report_temp_column_config> GetReportmasterTempList()
        {
            try
            {
                return obTA_DataLogic.daGetReportmasterTempList();
            }
            catch (Exception)
            {
            }
            return null;
        }

        public List<report_column_config> getReportColumnConfigs(string option, string report_id, string intervalId, string agentId)
        {
            try
            {
                return obTA_DataLogic.daGetReportColumnConfigs(option, report_id, intervalId, agentId);
            }
            catch (Exception)
            {
            }
            return null;
        }
        public List<report_interval_config> getReportIntervalConfigs(string type, string reportID, string intervalId, string agentId)
        {
            try
            {
                return obTA_DataLogic.daGetReportIntervalConfigs( type, reportID, intervalId, agentId);
            }
            catch (Exception)
            {
            }
            return null;
        }

        public DataSet updateColumnConfigXml(string option, string report_id, string xmlString)
        {
            try
            {
                return obTA_DataLogic.daUpdateColumnConfigs(option, report_id, xmlString);
            }
            catch (Exception)
            {
            }
            return null;
        }

        public DataSet blDeleteIntervalConfig(string report_id, string interval_id)
        {
            try
            {
                return obTA_DataLogic.daDeleteIntervalConfig(report_id, interval_id);
            }
            catch (Exception)
            {
            }
            return null;
        }

        public DataSet blSetReportStatus(string report_id, string report_status)
        {
            try
            {
                return obTA_DataLogic.daSetReportStatus(report_id, report_status);
            }
            catch (Exception)
            {
            }
            return null;
        }


        public DataSet baGetAgentSupervisorDetails(string option)
        {
            try
            {
                return obTA_DataLogic.daGetAgentSupervisorDetails(option);
            }
            catch (Exception)
            {
            }
            return null;
        }

        public DataSet blAgentPerformanceReport(searchList objPCI)
        {
            try
            {
                return obTA_DataLogic.daAgentperformanceReport(objPCI);
            }
            catch (Exception)
            {
            }
            return null;
        }
        public DataSet blSupervisorPerformanceReport(searchList objPCI)
        {
            try
            {
                return obTA_DataLogic.daSupervisorPerformanceReport(objPCI);
            }
            catch (Exception)
            {
            }
            return null;
        }

        public DataSet blSurveyDetailsReport(searchList objPCI)
        {
            try
            {
                return obTA_DataLogic.daSurveyDetailsReport(objPCI);
            }
            catch (Exception)
            {
            }
            return null;
        }


        public DataSet baGetIVRMenuListDetails()
        {
            try
            {
                return obTA_DataLogic.daGetIVRMenuListDetails();
            }
            catch (Exception)
            {
            }
            return null;
        }

        public DataSet blIVRMenuDetailsReport(searchList objPCI)
        {
            try
            {
                return obTA_DataLogic.daIVRMenuDetailsReport(objPCI);
            }
            catch (Exception)
            {
            }
            return null;
        }

        public DataSet blGetIvrOperationalReport(searchList objPCI)
        {
            try
            {
                return obTA_DataLogic.daGetIvrOperationalReport(objPCI);
            }
            catch (Exception)
            {
            }
            return null;
        }

        public List<auto_ans_configuration_list> bl_get_auto_ans_list(auto_ans_configuration_list bo_obj)
        {
            try
            {
                return obTA_DataLogic.dl_get_auto_ans_list(bo_obj);
            }
            catch (Exception)
            {
            }
            return null;
        }

        public string bl_update_auto_ans_details(auto_ans_configuration_list bo_obj)
        {
            try
            {
                return obTA_DataLogic.dl_update_auto_ans_list(bo_obj);
            }
            catch (Exception)
            {
            }
            return null;
        }

        public string bl_insert_auto_ans_details(auto_ans_configuration_list bo_obj)
        {
            try
            {
                return obTA_DataLogic.dl_insert_auto_ans_details(bo_obj);
            }
            catch (Exception)
            {
            }
            return null;
        }

        public string bl_delete_auto_ans_details(auto_ans_configuration_list bo_obj)
        {
            try
            {
                return obTA_DataLogic.dl_delete_auto_ans_details(bo_obj);
            }
            catch (Exception)
            {
            }
            return null;
        }

        public List<service_list> bl_get_service_list(service_list bo_obj)
        {
            try
            {
                return obTA_DataLogic.dl_get_service_list(bo_obj);
            }
            catch (Exception)
            {
            }
            return null;
        }

        public DataSet blcallabandonedreport(searchList objPCI)
        {
            try
            {
                return obTA_DataLogic.dacallabandonedreport(objPCI);
            }
            catch (Exception)
            {
            }
            return null;
        }

        public DataSet blsummaryivrreport(searchList objPCI)
        {
            try
            {
                return obTA_DataLogic.dasummaryivrreport(objPCI);
            }
            catch (Exception)
            {
            }
            return null;
        }

        public DataSet blivrmenupathreport(searchList objPCI)
        {
            try
            {
                return obTA_DataLogic.daivrmenupathreport(objPCI);
            }
            catch (Exception)
            {
            }
            return null;
        }

        public DataSet bltransferbackonivrdisconnectreport(searchList objPCI)
        {
            try
            {
                return obTA_DataLogic.datransferbackonivrdisconnectreport(objPCI);
            }
            catch (Exception)
            {
            }
            return null;
        }

        public DataSet blsummaryivrreportbasedonlang(searchList objPCI)
        {
            try
            {
                return obTA_DataLogic.dasummaryivrreportbasedonlang(objPCI);
            }
            catch (Exception)
            {
            }
            return null;
        }

        public DataSet blGetHelplineLanguageDetails()
        {
            try
            {
                return obTA_DataLogic.daGetHelplineLanguageDetails();
            }
            catch (Exception)
            {
            }
            return null;
        }

        public List<menu_details> blivrmenudetails(string menu_id)
        {
            try
            {
                return obTA_DataLogic.daivrmenudetails(menu_id);
            }
            catch (Exception)
            {
            }
            return null;
        }

        public DataSet blannouncementpereventreport(searchList objPCI)
        {
            try
            {
                return obTA_DataLogic.daannouncementpereventreport(objPCI);
            }
            catch (Exception)
            {
            }
            return null;
        }

        public DataSet blslareport(searchList objPCI)
        {
            try
            {
                return obTA_DataLogic.daslareport(objPCI);
            }
            catch (Exception)
            {
            }
            return null;
        }

    }


}

