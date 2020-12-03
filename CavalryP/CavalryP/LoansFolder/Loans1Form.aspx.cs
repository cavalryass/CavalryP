using Basic.Loan;
using Basic.SoftwareUsers;
using Forms.ClientForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CavalryP.LoansFolder
{
    public partial class Loans1Form : System.Web.UI.Page
    {
       static string uid = "";
        static string status="";
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
            bool f = true;
            BusinessLegalName.Text = l.BusinessName;
            dbaName.Text = l.DBAName;
            PrimaryContact.Text = l.Pcontact;
            taxid.Text = l.TaxID;
            sstxt.Text = l.SS;
            telephone.Text = l.Tel;
            emailAddress.Text = l.Mail;
            Address.Text = l.Street;
            own.Checked = l.Own;
            rent.Checked = !l.Own;
            city.Text = l.City;
            state.Text = l.State;
            zip.Text = l.Zip;
            mailAddress.Text = l.Mstreet;
            mailCity.Text = l.Mcity;
            mailState.Text = l.Mstate;
            mailZip.Text = l.Mzip;
            month.Text = l.DateBE.Split('/')[0];
            year.Text = l.DateBE.Split('/')[1];
            incorporationState.Text = l.StateoOI;
            employeesNum.Text = l.EmployeesNum;
            explain.Text = l.Explains;
            listCompanies.Text = l.Acompanies;
            string list1 = l.Chose1;
            string list2 = l.Chose2;
            othertxt2.Visible = false;
            othertxt.Visible = false;
            if (list1 == "C Corporation")
            {
                f = false;
                Ccorporation.Checked = true;
            }
            if (list1 == "S Corporation")
            {
                f = false;
                SCorporation.Checked = true;
            }
            if (list1 == "Limited Liability")
            {
                f = false;
                LLC.Checked = true;
            }
            if (list1 == "Business Individual")
            {
                f = false;
                businessIndividual.Checked = true;
            }
            if (list1 == "Non-Profit")
            {
                f = false;
                NonProfit.Checked = true;
            }
            if (list1 == "Sole Proprietor")
            {
                f = false;
                soleProprietor.Checked = true;
            }
            if (list1 == "Limited Partnership")
            {
                f = false;
                limitedPartnership.Checked = true;
            }
            if (list1 == "General Partnership")
            {
                f = false;
                generalPartnership.Checked = true;
            }
            if (list1 == "LLP")
            {
                f = false;
                LLP.Checked = true;
            }
            if (f)
            {
                other.Checked = true;
                othertxt.Visible = true;
                othertxt.Text=list1;
            }
            f = true;
            if (list2 == "Manufacturing")
            {
                f = false;
                manufacturing.Checked = true;
            }
            if (list2 == "Wholesale")
            {
                f = false;
                wholesale.Checked = true;
            }
            if (list2 == "Retail")
            {
                f = false;
                retail.Checked = true;
            }
            if (list2 == "Service")
            {
                f = false;
                service.Checked = true;
            }
            if (list2 == "Agricultural")
            {
                f = false;
                agricultural.Checked = true;
            }
            if (list2 == "Construction")
            {
                f = false;
                construction.Checked = true;
            }
            if (f) {
                other2.Checked = true;
                othertxt2.Visible = true;
                othertxt2.Text=list2;

            }
        }
        protected void own_CheckedChanged(object sender, EventArgs e)
        {
            if (own.Checked)
                rent.Checked = false;
            else
                rent.Checked = true;
        }

        protected void rent_CheckedChanged(object sender, EventArgs e)
        {
            if (rent.Checked)
                own.Checked = false;
            else
                own.Checked = true;
        }

        protected void Submit1_Click(object sender, EventArgs e)
        {
            try
            {
                Loans1Function function = new Loans1Function();
                string list1 = "";
                string list2 = "";

                if (Ccorporation.Checked)
                    list1 = "C Corporation";
                if (SCorporation.Checked)
                    list1 = "S Corporation";
                if (LLC.Checked)
                    list1 = "Limited Liability";
                if (businessIndividual.Checked)
                    list1 = "Business Individual";
                if (NonProfit.Checked)
                    list1 = "Non-Profit";
                if (soleProprietor.Checked)
                    list1 = "Sole Proprietor";
                if (limitedPartnership.Checked)
                    list1 = "Limited Partnership";
                if (generalPartnership.Checked)
                    list1 = "General Partnership";
                if (LLP.Checked)
                    list1 = "LLP";
                if (other.Checked)
                    list1 = othertxt.Text;

                if (manufacturing.Checked)
                    list2 = "Manufacturing";
                if (wholesale.Checked)
                    list2 = "Wholesale";
                if (retail.Checked)
                    list2 = "Retail";
                if (service.Checked)
                    list2 = "Service";
                if (agricultural.Checked)
                    list2 = "Agricultural";
                if (construction.Checked)
                    list2 = "Construction";
                if (other2.Checked)
                    list2 = othertxt2.Text;
                function.Submit(new Loans1(BusinessLegalName.Text, dbaName.Text, PrimaryContact.Text, taxid.Text, sstxt.Text, telephone.Text, emailAddress.Text, Address.Text, own.Checked, city.Text, state.Text, zip.Text, mailAddress.Text, mailCity.Text, mailState.Text, mailZip.Text, list1, month.Text + "/" + year.Text, incorporationState.Text, employeesNum.Text, explain.Text, list2, listCompanies.Text,uid),status,uid);
            }
            catch(Exception ex)
            {
                message.Text = ex.Message;
            }
        }

        protected void Back_Click(object sender, EventArgs e)
        {
            if (status == "Client")
            {
                Session["Value"] = uid;
                Response.Redirect("~/LoansFolder/Steps.aspx");
            }
            else
            {
                Session["Value"] = status;
                Response.Redirect("~/ClientFolder/ClientP.aspx");
            }
        }

        protected void logout_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/GlobalForm/StartPage.aspx");
        }

        protected void Ccorporation_CheckedChanged(object sender, EventArgs e)
        {
            SCorporation.Checked = false;
            LLC.Checked = false;
            businessIndividual.Checked = false;
            NonProfit.Checked = false;
            soleProprietor.Checked = false;
            limitedPartnership.Checked = false;
            generalPartnership.Checked = false;
            LLP.Checked = false;
            other.Checked = false;
            othertxt.Visible = false;
        }

        protected void SCorporation_CheckedChanged(object sender, EventArgs e)
        {
            Ccorporation.Checked = false;
            LLC.Checked = false;
            businessIndividual.Checked = false;
            NonProfit.Checked = false;
            soleProprietor.Checked = false;
            limitedPartnership.Checked = false;
            generalPartnership.Checked = false;
            LLP.Checked = false;
            other.Checked = false;
            othertxt.Visible = false;
        }

        protected void LLC_CheckedChanged(object sender, EventArgs e)
        {
            SCorporation.Checked = false;
            Ccorporation.Checked = false;
            businessIndividual.Checked = false;
            NonProfit.Checked = false;
            soleProprietor.Checked = false;
            limitedPartnership.Checked = false;
            generalPartnership.Checked = false;
            LLP.Checked = false;
            other.Checked = false;
            othertxt.Visible = false;
        }

        protected void businessIndividual_CheckedChanged(object sender, EventArgs e)
        {
            SCorporation.Checked = false;
            LLC.Checked = false;
            Ccorporation.Checked = false;
            NonProfit.Checked = false;
            soleProprietor.Checked = false;
            limitedPartnership.Checked = false;
            generalPartnership.Checked = false;
            LLP.Checked = false;
            other.Checked = false;
            othertxt.Visible = false;
        }

        protected void NonProfit_CheckedChanged(object sender, EventArgs e)
        {
            SCorporation.Checked = false;
            LLC.Checked = false;
            businessIndividual.Checked = false;
            Ccorporation.Checked = false;
            soleProprietor.Checked = false;
            limitedPartnership.Checked = false;
            generalPartnership.Checked = false;
            LLP.Checked = false;
            other.Checked = false;
            othertxt.Visible = false;
        }

        protected void soleProprietor_CheckedChanged(object sender, EventArgs e)
        {
            SCorporation.Checked = false;
            LLC.Checked = false;
            businessIndividual.Checked = false;
            NonProfit.Checked = false;
            Ccorporation.Checked = false;
            limitedPartnership.Checked = false;
            generalPartnership.Checked = false;
            LLP.Checked = false;
            other.Checked = false;
            othertxt.Visible = false;

        }

        protected void limitedPartnership_CheckedChanged(object sender, EventArgs e)
        {
            SCorporation.Checked = false;
            LLC.Checked = false;
            businessIndividual.Checked = false;
            NonProfit.Checked = false;
            soleProprietor.Checked = false;
            Ccorporation.Checked = false;
            generalPartnership.Checked = false;
            LLP.Checked = false;
            other.Checked = false;
            othertxt.Visible = false;
        }

        protected void generalPartnership_CheckedChanged(object sender, EventArgs e)
        {
            SCorporation.Checked = false;
            LLC.Checked = false;
            businessIndividual.Checked = false;
            NonProfit.Checked = false;
            soleProprietor.Checked = false;
            limitedPartnership.Checked = false;
            Ccorporation.Checked = false;
            LLP.Checked = false;
            other.Checked = false;
            othertxt.Visible = false;
        }

        protected void LLP_CheckedChanged(object sender, EventArgs e)
        {
            SCorporation.Checked = false;
            LLC.Checked = false;
            businessIndividual.Checked = false;
            NonProfit.Checked = false;
            soleProprietor.Checked = false;
            limitedPartnership.Checked = false;
            generalPartnership.Checked = false;
            Ccorporation.Checked = false;
            other.Checked = false;
            othertxt.Visible = false;
        }

        protected void other_CheckedChanged(object sender, EventArgs e)
        {
            SCorporation.Checked = false;
            LLC.Checked = false;
            businessIndividual.Checked = false;
            NonProfit.Checked = false;
            soleProprietor.Checked = false;
            limitedPartnership.Checked = false;
            generalPartnership.Checked = false;
            LLP.Checked = false;
            Ccorporation.Checked = false;
            othertxt.Visible = true;
        }

        protected void manufacturing_CheckedChanged(object sender, EventArgs e)
        {
            wholesale.Checked = false;
            retail.Checked = false;
            service.Checked = false;
            agricultural.Checked = false;
            construction.Checked = false;
            other2.Checked = false;
            othertxt2.Visible = false;
        }

        protected void wholesale_CheckedChanged(object sender, EventArgs e)
        {
            manufacturing.Checked = false;
            retail.Checked = false;
            service.Checked = false;
            agricultural.Checked = false;
            construction.Checked = false;
            other2.Checked = false;
            othertxt2.Visible = false;
        }

        protected void retail_CheckedChanged(object sender, EventArgs e)
        {
            wholesale.Checked = false;
            manufacturing.Checked = false;
            service.Checked = false;
            agricultural.Checked = false;
            construction.Checked = false;
            other2.Checked = false;
            othertxt2.Visible = false;
        }

        protected void service_CheckedChanged(object sender, EventArgs e)
        {
            wholesale.Checked = false;
            retail.Checked = false;
            manufacturing.Checked = false;
            agricultural.Checked = false;
            construction.Checked = false;
            other2.Checked = false;
            othertxt2.Visible = false;
        }

        protected void agricultural_CheckedChanged(object sender, EventArgs e)
        {
            wholesale.Checked = false;
            retail.Checked = false;
            service.Checked = false;
            manufacturing.Checked = false;
            construction.Checked = false;
            other2.Checked = false;
            othertxt2.Visible = false;
        }

        protected void construction_CheckedChanged(object sender, EventArgs e)
        {
            wholesale.Checked = false;
            retail.Checked = false;
            service.Checked = false;
            agricultural.Checked = false;
            manufacturing.Checked = false;
            other2.Checked = false;
            othertxt2.Visible = false;
        }

        protected void other2_CheckedChanged(object sender, EventArgs e)
        {
            wholesale.Checked = false;
            retail.Checked = false;
            service.Checked = false;
            agricultural.Checked = false;
            construction.Checked = false;
            manufacturing.Checked = false;
            othertxt2.Visible = true;
        }
    }
}