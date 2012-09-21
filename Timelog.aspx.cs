using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Timelog : System.Web.UI.Page
{

#region Variables

#endregion

#region Properties
#endregion

#region Functions

   /// <summary>
   /// Populate the list of classes in a drop down list
   /// </summary>
   private void PopulateClasses(int UserId)
   {
      // variables

      try
      {
         // Connect and pull

         //Bind data
         ddlClasses.DataSource     = null;
         ddlClasses.DataTextField  = "value";
         ddlClasses.DataValueField = "value";
         ddlClasses.DataBind();

      }
      catch (Exception ex)
      {
         throw (ex);
      }

      return;
   }

   /// <summary>
   /// Populate the list of projects
   /// </summary>
   private void PopulateProjects(int Class_ID, int User_ID)
   {
      // variables

      try
      {



      }
      catch (Exception ex)
      {
         throw (ex);
      }

      return;
   }

   /// <summary>
   /// Populate the list of students in a class
   /// </summary>
   private void PopulateStudents(int IncomingClass_ID)
   {
      // variables here
      try
      {
         // Connect and pull data

         // Bind data
         ddlStudents.DataSource = null;
         ddlStudents.DataTextField = "Bla";
         ddlStudents.DataValueField = "Bla2";

      }
      catch (Exception ex)
      {
         throw (ex);
      }

      return;
   }

   /// <summary>
   /// Populate the week drop down list
   /// </summary>
   private void PopulateWeek()
   {
      // variables

      try
      {

         ddlWeek.DataSource     = null;
         ddlWeek.DataTextField  = "value";
         ddlWeek.DataValueField = "value";
         ddlWeek.DataBind();

      }
      catch(Exception ex)
      {
         throw (ex);
      }

      return;
   }

   /// <summary>
   /// Add time to the time log
   /// </summary>
   private void AddTimelog()
   {
      // variables

      try
      {



      }
      catch (Exception ex)
      {
         throw (ex);
      }

      return;
   }

   /// <summary>
   /// Delete time from the time log
   /// </summary>
   private void DeleteTimelog()
   {
      // variables

      try
      {



      }
      catch (Exception ex)
      {
         throw (ex);
      }

      return;
   }

   /// <summary>
   /// Modify a time log
   /// </summary>
   private void ModifyTimeLog()
   {
      try
      {

      }

      catch (Exception ex)
      {
         throw (ex);
      }
   }

   /// <summary>
   /// Populate the list of timelogs
   /// </summary>
   private void PopulateTimeLog(int Class_ID, int Project_ID, int User_ID, int Week_ID, int UserType)
   {
      try
      {

      }

      catch(Exception ex)
      {
         throw (ex);
      }

      return;
   }


#endregion

#region Events

   /// <summary>
   /// Constructor, create a new web page
   /// </summary>
   /// <param name="sender"></param>
   /// <param name="e"></param>
   protected void Page_Load(object sender, EventArgs e)
   {
      try
      {
         // Set the visibility of the page depending on which user it is
         switch (!(Master.isAdmin || Master.isTeacher))
         {
            case true:
               ddlStudents.Visible = false;
               break;
         }

         // Fill the drop down list
         //PopulateClasses();
        // PopulateStudents();
        
      }
      catch
      {
         // display the message
      }
   }

#endregion
   
}