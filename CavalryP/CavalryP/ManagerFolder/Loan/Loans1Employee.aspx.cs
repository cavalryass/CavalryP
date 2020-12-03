using Basic.Loan;
using Forms.ClientForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CavalryP.ManagerFolder.Loan2
{
    public partial class Loans1Employee : System.Web.UI.Page
    {
        static string uid = "";
        static string status = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    uid = Session["Value"].ToString().Split('@')[0];
                    status = Session["Value"].ToString().Split('@')[1];
                }
                catch (Exception ex)
                {
                    Response.Redirect("~/GlobalForm/StartPage.aspx");
                }
                Loans1Function l = new Loans1Function();
                fill(l.pageLoad(uid));
            }
        }
        protected void fill(Loans1 l)
        {
            BusinessLegalName.Text = l.BusinessName;
            BusinessLegalNameE.Text = l.BusinessName;
            dbaName.Text = l.DBAName;
            dbaNameE.Text = l.DBAName;
            PrimaryContact.Text = l.Pcontact;
            PrimaryContactE.Text = l.Pcontact;
            taxid.Text = l.TaxID;
            taxidE.Text = l.TaxID;
            sstxt.Text = l.SS;
            sstxtE.Text = l.SS;
            telephone.Text = l.Tel;
            telephoneE.Text = l.Tel;
            emailAddress.Text = l.Mail;
            emailAddressE.Text = l.Mail;
            Address.Text = l.Street;
            AddressE.Text = l.Street;
            own.Checked = l.Own;
            ownE.Checked = l.Own;
            rent.Checked = !l.Own;
            rentE.Checked = !l.Own;
            city.Text = l.City;
            cityE.Text = l.City;
            state.Text = l.State;
            stateE.Text = l.State;
            zip.Text = l.Zip;
            zipE.Text = l.Zip;
            mailAddress.Text = l.Mstreet;
            mailAddressE.Text = l.Mstreet;
            mailCity.Text = l.Mcity;
            mailCityE.Text = l.Mcity;
            mailState.Text = l.Mstate;
            mailStateE.Text = l.Mstate;
            mailZip.Text = l.Mzip;
            mailZipE.Text = l.Mzip;
            month.Text = l.DateBE.Split('/')[0];
            year.Text = l.DateBE.Split('/')[1];
            monthE.Text = l.DateBE.Split('/')[0];
            yearE.Text = l.DateBE.Split('/')[1];
            incorporationState.Text = l.StateoOI;
            incorporationStateE.Text = l.StateoOI;
            employeesNum.Text = l.EmployeesNum;
            employeesNumE.Text = l.EmployeesNum;
            explain.Text = l.Explains;
            explainE.Text = l.Explains;
            listCompanies.Text = l.Acompanies;
            listCompaniesE.Text = l.Acompanies;
            string list1 = l.Chose1;
            string list2 = l.Chose2;
            othertxt2.Visible = false;
            othertxt.Visible = false;
            othertxt2E.Visible = false;
            othertxtE1.Visible = false;
            bool f = true;
            if (list1 == "C Corporation")
            {
                Ccorporation.Checked = true;
                Ccorporation.Checked = true;
                f = false;

            }
            if (list1 == "S Corporation")
            {
                f = false;
                SCorporation.Checked = true;
                SCorporationE.Checked = true;
            }
            if (list1 == "Limited Liability")
            {
                f = false;
                LLC.Checked = true;
                LLCE.Checked = true;
            }
            if (list1 == "Business Individual")
            {
                f = false;
                businessIndividual.Checked = true;
                businessIndividualE.Checked = true;
            }
            if (list1 == "Non-Profit")
            {
                f = false;
                NonProfit.Checked = true;
                NonProfitE.Checked = true;
            }
            if (list1 == "Sole Proprietor")
            {
                f = false;
                soleProprietor.Checked = true;
                soleProprietorE.Checked = true;
            }
            if (list1 == "Limited Partnership")
            {
                f = false;
                limitedPartnership.Checked = true;
                limitedPartnershipE.Checked = true;
            }
            if (list1 == "General Partnership")
            {
                f = false;
                generalPartnership.Checked = true;
                generalPartnershipE.Checked = true;
            }
            if (list1 == "LLP")
            {
                f = false;
                LLP.Checked = true;
                LLPE.Checked = true;
            }
            if (f) 
            {
                other.Checked = true;
                othertxt.Visible = true;
                othertxt.Text = list1;
                otherE1.Checked = true;
                othertxtE1.Visible = true;
                othertxtE1.Text = list1;
            }
            f = true;
            if (list2 == "Manufacturing")
            {
                f = false;
                manufacturing.Checked = true;
                manufacturingE.Checked = true;
            }
            if (list2 == "Wholesale")
            {
                f = false;
                wholesaleE.Checked = true;
                wholesale.Checked = true;
            }
            if (list2 == "Retail")
            {
                f = false;
                retailE.Checked = true;
                retail.Checked = true;
            }
            if (list2 == "Service")
            {
                f = false;
                service.Checked = true;
                serviceE.Checked = true;
            }
            if (list2 == "Agricultural")
            {
                f = false;
                agriculturalE.Checked = true;
                agricultural.Checked = true;
            }
            if (list2 == "Construction")
            {
                f = false;
                construction.Checked = true;
                constructionE.Checked = true;
            }
            if (f)
            {
                other2.Checked = true;
                othertxt2.Visible = true;
                othertxt2.Text = list2;
                other2E.Checked = true;
                othertxt2E.Visible = true;
                othertxt2E.Text = list2;
            }
        }
        protected void own_CheckedChanged(object sender, EventArgs e)
        {
            if (ownE.Checked)
                rentE.Checked = false;
            else
                rentE.Checked = true;
        }

        protected void rent_CheckedChanged(object sender, EventArgs e)
        {
            if (rentE.Checked)
                ownE.Checked = false;
            else
                ownE.Checked = true;
        }

        protected void Submit1_Click(object sender, EventArgs e)
        {
            try
            {
                Loans1Function function = new Loans1Function();
                string list1 = "";
                string list2 = "";

                if (CcorporationE.Checked)
                    list1 = "C Corporation";
                if (SCorporationE.Checked)
                    list1 = "S Corporation";
                if (LLCE.Checked)
                    list1 = "Limited Liability";
                if (businessIndividualE.Checked)
                    list1 = "Business Individual";
                if (NonProfitE.Checked)
                    list1 = "Non-Profit";
                if (soleProprietorE.Checked)
                    list1 = "Sole Proprietor";
                if (limitedPartnershipE.Checked)
                    list1 = "Limited Partnership";
                if (generalPartnershipE.Checked)
                    list1 = "General Partnership";
                if (LLPE.Checked)
                    list1 = "LLP";
                if (otherE1.Checked)
                    list1 = othertxtE1.Text;

                if (manufacturingE.Checked)
                    list2 = "Manufacturing";
                if (wholesaleE.Checked)
                    list2 = "Wholesale";
                if (retailE.Checked)
                    list2 = "Retail";
                if (serviceE.Checked)
                    list2 = "Service";
                if (agriculturalE.Checked)
                    list2 = "Agricultural";
                if (constructionE.Checked)
                    list2 = "Construction";
                if (other2E.Checked)
                    list2 = othertxt2E.Text;
                function.Submit(new Loans1(BusinessLegalNameE.Text, dbaNameE.Text, PrimaryContactE.Text, taxidE.Text, sstxtE.Text, telephoneE.Text, emailAddressE.Text, AddressE.Text, ownE.Checked, cityE.Text, stateE.Text, zipE.Text, mailAddressE.Text, mailCityE.Text, mailStateE.Text, mailZipE.Text, list1, monthE.Text + "/" + yearE.Text, incorporationStateE.Text, employeesNumE.Text, explainE.Text, list2, listCompaniesE.Text, uid), status,uid);
                Session["Value"] = status;
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('The Application Was Approved'); window.location = '" + Page.ResolveUrl("~/ManagerFolder/ClientManagment.aspx") + "';", true);


            }
            catch (Exception ex)
            {
                message.Text = ex.Message;
            }
        }

        protected void Back_Click(object sender, EventArgs e)
        {          
                Session["Value"] = status;
                Response.Redirect("~/ManagerFolder/ClientManagment.aspx");
            
        }

        protected void logout_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/GlobalForm/StartPage.aspx");
        }

        protected void Ccorporation_CheckedChanged(object sender, EventArgs e)
        {
            SCorporationE.Checked = false;
            LLCE.Checked = false;
            businessIndividualE.Checked = false;
            NonProfitE.Checked = false;
            soleProprietorE.Checked = false;
            limitedPartnershipE.Checked = false;
            generalPartnershipE.Checked = false;
            LLPE.Checked = false;
            otherE1.Checked = false;
            othertxtE1.Visible = false;
        }

        protected void SCorporation_CheckedChanged(object sender, EventArgs e)
        {
            CcorporationE.Checked = false;
            LLCE.Checked = false;
            businessIndividualE.Checked = false;
            NonProfitE.Checked = false;
            soleProprietorE.Checked = false;
            limitedPartnershipE.Checked = false;
            generalPartnershipE.Checked = false;
            LLPE.Checked = false;
            otherE1.Checked = false;
            othertxtE1.Visible = false;
        }

        protected void LLC_CheckedChanged(object sender, EventArgs e)
        {
            SCorporationE.Checked = false;
            CcorporationE.Checked = false;
            businessIndividualE.Checked = false;
            NonProfitE.Checked = false;
            soleProprietorE.Checked = false;
            limitedPartnershipE.Checked = false;
            generalPartnershipE.Checked = false;
            LLPE.Checked = false;
            otherE1.Checked = false;
            othertxtE1.Visible = false;
        }

        protected void businessIndividual_CheckedChanged(object sender, EventArgs e)
        {
            SCorporationE.Checked = false;
            LLCE.Checked = false;
            CcorporationE.Checked = false;
            NonProfitE.Checked = false;
            soleProprietorE.Checked = false;
            limitedPartnershipE.Checked = false;
            generalPartnershipE.Checked = false;
            LLPE.Checked = false;
            otherE1.Checked = false;
            othertxtE1.Visible = false;
        }

        protected void NonProfit_CheckedChanged(object sender, EventArgs e)
        {
            SCorporationE.Checked = false;
            LLCE.Checked = false;
            businessIndividualE.Checked = false;
            CcorporationE.Checked = false;
            soleProprietorE.Checked = false;
            limitedPartnershipE.Checked = false;
            generalPartnershipE.Checked = false;
            LLPE.Checked = false;
            otherE1.Checked = false;
            othertxtE1.Visible = false;
        }

        protected void soleProprietor_CheckedChanged(object sender, EventArgs e)
        {
            SCorporationE.Checked = false;
            LLCE.Checked = false;
            businessIndividualE.Checked = false;
            NonProfitE.Checked = false;
            CcorporationE.Checked = false;
            limitedPartnershipE.Checked = false;
            generalPartnershipE.Checked = false;
            LLPE.Checked = false;
            otherE1.Checked = false;
            othertxtE1.Visible = false;

        }

        protected void limitedPartnership_CheckedChanged(object sender, EventArgs e)
        {
            SCorporationE.Checked = false;
            LLCE.Checked = false;
            businessIndividualE.Checked = false;
            NonProfitE.Checked = false;
            soleProprietorE.Checked = false;
            CcorporationE.Checked = false;
            generalPartnershipE.Checked = false;
            LLPE.Checked = false;
            otherE1.Checked = false;
            othertxtE1.Visible = false;
        }

        protected void generalPartnership_CheckedChanged(object sender, EventArgs e)
        {
            SCorporationE.Checked = false;
            LLCE.Checked = false;
            businessIndividualE.Checked = false;
            NonProfitE.Checked = false;
            soleProprietorE.Checked = false;
            limitedPartnershipE.Checked = false;
            CcorporationE.Checked = false;
            LLPE.Checked = false;
            otherE1.Checked = false;
            othertxtE1.Visible = false;
        }

        protected void LLP_CheckedChanged(object sender, EventArgs e)
        {
            SCorporationE.Checked = false;
            LLCE.Checked = false;
            businessIndividualE.Checked = false;
            NonProfitE.Checked = false;
            soleProprietorE.Checked = false;
            limitedPartnershipE.Checked = false;
            generalPartnershipE.Checked = false;
            CcorporationE.Checked = false;
            otherE1.Checked = false;
            othertxtE1.Visible = false;
        }

        protected void other_CheckedChanged(object sender, EventArgs e)
        {
            SCorporationE.Checked = false;
            LLCE.Checked = false;
            businessIndividualE.Checked = false;
            NonProfitE.Checked = false;
            soleProprietorE.Checked = false;
            limitedPartnershipE.Checked = false;
            generalPartnershipE.Checked = false;
            LLPE.Checked = false;
            CcorporationE.Checked = false;
            othertxtE1.Visible = true;
        }

        protected void manufacturing_CheckedChanged(object sender, EventArgs e)
        {
            wholesaleE.Checked = false;
            retailE.Checked = false;
            serviceE.Checked = false;
            agriculturalE.Checked = false;
            constructionE.Checked = false;
            other2E.Checked = false;
            othertxt2E.Visible = false;
        }

        protected void wholesale_CheckedChanged(object sender, EventArgs e)
        {
            manufacturingE.Checked = false;
            retailE.Checked = false;
            serviceE.Checked = false;
            agriculturalE.Checked = false;
            constructionE.Checked = false;
            other2E.Checked = false;
            othertxt2E.Visible = false;
        }

        protected void retail_CheckedChanged(object sender, EventArgs e)
        {
            wholesaleE.Checked = false;
            manufacturingE.Checked = false;
            serviceE.Checked = false;
            agriculturalE.Checked = false;
            constructionE.Checked = false;
            other2E.Checked = false;
            othertxt2E.Visible = false;
        }

        protected void service_CheckedChanged(object sender, EventArgs e)
        {
            wholesaleE.Checked = false;
            retailE.Checked = false;
            manufacturingE.Checked = false;
            agriculturalE.Checked = false;
            constructionE.Checked = false;
            other2E.Checked = false;
            othertxt2E.Visible = false;
        }

        protected void agricultural_CheckedChanged(object sender, EventArgs e)
        {
            wholesaleE.Checked = false;
            retailE.Checked = false;
            serviceE.Checked = false;
            manufacturingE.Checked = false;
            constructionE.Checked = false;
            other2E.Checked = false;
            othertxt2E.Visible = false;
        }

        protected void construction_CheckedChanged(object sender, EventArgs e)
        {
            wholesaleE.Checked = false;
            retailE.Checked = false;
            serviceE.Checked = false;
            agriculturalE.Checked = false;
            manufacturingE.Checked = false;
            other2E.Checked = false;
            othertxt2E.Visible = false;
        }

        protected void other2_CheckedChanged(object sender, EventArgs e)
        {
            wholesaleE.Checked = false;
            retailE.Checked = false;
            serviceE.Checked = false;
            agriculturalE.Checked = false;
            constructionE.Checked = false;
            manufacturingE.Checked = false;
            othertxt2E.Visible = true;
        }

        protected void Edit_Click(object sender, EventArgs e)
        {
            ReadDetails.Visible = false;
            EditDetails.Visible = true;
            Edit.Visible = false;
        }
    }
}