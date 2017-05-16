// <copyright file="FindCoachForm.Designer.cs" company="PABT at NWTC">
//     Copyright 2017 PABT (Pao Xiong, Adam Smith, Brian Lueskow, Tim Durkee)
// </copyright>
namespace CoachConnect
{
    /// <summary>
    /// A form that allows student users to search for coaching sessions and enroll in them.
    /// </summary>
    public partial class FindCoachForm
    {
        /// <summary>
        /// Tab control for different search and user options
        /// </summary>
        private System.Windows.Forms.TabControl tabControl1;

        /// <summary>
        /// Tab page for Home
        /// </summary>
        private System.Windows.Forms.TabPage tabPage1;

        /// <summary>
        /// Tab page for Find Coach by Name
        /// </summary>
        private System.Windows.Forms.TabPage tabPage2;

        /// <summary>
        /// Tab page for Find Coach by Interest
        /// </summary>
        private System.Windows.Forms.TabPage tabPage3;

        /// <summary>
        /// Tab page for Find Coach by Time
        /// </summary>
        private System.Windows.Forms.TabPage tabPage4;

        /// <summary>
        /// Button for Agri interest
        /// </summary>
        private System.Windows.Forms.Button btnAgri;

        /// <summary>
        /// A label for Energy interest
        /// </summary>
        private System.Windows.Forms.Label lblEnergy;

        /// <summary>
        /// Button for Energy interest
        /// </summary>
        private System.Windows.Forms.Button btnEnergy;

        /// <summary>
        /// A label for Digital interest
        /// </summary>
        private System.Windows.Forms.Label lblDigital;

        /// <summary>
        /// Button for Digital interest
        /// </summary>
        private System.Windows.Forms.Button btnDigital;

        /// <summary>
        /// A label for Business interest
        /// </summary>
        private System.Windows.Forms.Label lblBusiness;

        /// <summary>
        /// Button for Business interest
        /// </summary>
        private System.Windows.Forms.Button btnBusiness;

        /// <summary>
        /// A label for Arch interest
        /// </summary>
        private System.Windows.Forms.Label lblArch;

        /// <summary>
        /// Button for Arch interest
        /// </summary>
        private System.Windows.Forms.Button btnArch;

        /// <summary>
        /// A label for Agri interest
        /// </summary>
        private System.Windows.Forms.Label lblAgri;

        /// <summary>
        /// Button for Law interest
        /// </summary>
        private System.Windows.Forms.Label lblLaw;

        /// <summary>
        /// A label for Manu interest
        /// </summary>
        private System.Windows.Forms.Button btnLaw;

        /// <summary>
        /// A label for IT interest
        /// </summary>
        private System.Windows.Forms.Label lblIT;

        /// <summary>
        /// A button for IT interest
        /// </summary>
        private System.Windows.Forms.Button btnIT;

        /// <summary>
        /// A label for Human interest
        /// </summary>
        private System.Windows.Forms.Label lblHuman;

        /// <summary>
        /// Button for Human interest
        /// </summary>
        private System.Windows.Forms.Button btnHuman;

        /// <summary>
        /// A label for Health interest
        /// </summary>
        private System.Windows.Forms.Label lblHealth;

        /// <summary>
        /// Button for Health interest
        /// </summary>
        private System.Windows.Forms.Button btnHealth;

        /// <summary>
        /// A label for General interest
        /// </summary>
        private System.Windows.Forms.Label lblGeneral;

        /// <summary>
        /// Button for General interest
        /// </summary>
        private System.Windows.Forms.Button btnGeneral;

        /// <summary>
        /// A label for Transport interest
        /// </summary>
        private System.Windows.Forms.Label lblTransport;

        /// <summary>
        /// Button for Transport interest
        /// </summary>
        private System.Windows.Forms.Button btnTransport;

        /// <summary>
        /// A label for Science interest
        /// </summary>
        private System.Windows.Forms.Label lblScience;

        /// <summary>
        /// Button for Science interest
        /// </summary>
        private System.Windows.Forms.Button btnScience;

        /// <summary>
        /// A label for Manu interest
        /// </summary>
        private System.Windows.Forms.Label lblManu;

        /// <summary>
        /// Button for Manu interest
        /// </summary>
        private System.Windows.Forms.Button btnManu;

        /// <summary>
        /// A panel
        /// </summary>
        private System.Windows.Forms.Panel panel1;

        /// <summary>
        /// Button allowing user to edit his/her profile
        /// </summary>
        private System.Windows.Forms.Button btnEditProfile;

        /// <summary>
        /// A group box
        /// </summary>
        private System.Windows.Forms.GroupBox groupBox5;

        /// <summary>
        /// A label for the user's phone number
        /// </summary>
        private System.Windows.Forms.Label lblStdPhone;

        /// <summary>
        /// A lable for the user's email address
        /// </summary>
        private System.Windows.Forms.Label lblStdEmail;

        /// <summary>
        /// A lable for the user's name
        /// </summary>
        private System.Windows.Forms.Label lblStdName;

        /// <summary>
        /// A label
        /// </summary>
        private System.Windows.Forms.Label label37;

        /// <summary>
        /// A label
        /// </summary>
        private System.Windows.Forms.Label label36;

        /// <summary>
        /// A label
        /// </summary>
        private System.Windows.Forms.Label label35;

        /// <summary>
        /// A picture box for the user's profile pic
        /// </summary>
        private System.Windows.Forms.PictureBox pictureBoxStdProfile;

        /// <summary>
        /// A group box
        /// </summary>
        private System.Windows.Forms.GroupBox groupBox6;

        /// <summary>
        /// A data grid view to show the student's current appointments
        /// </summary>
        private System.Windows.Forms.DataGridView dgrShowAppointments;

        /// <summary>
        /// A button to remove the selected session from the student's list
        /// </summary>
        private System.Windows.Forms.Button btnCancelSession;

        /// <summary>
        /// A panel
        /// </summary>
        private System.Windows.Forms.Panel panelCoach;

        /// <summary>
        /// A group box
        /// </summary>
        private System.Windows.Forms.GroupBox groupBox7;

        /// <summary>
        /// A label for the coach's name
        /// </summary>
        private System.Windows.Forms.Label lblCoachName;

        /// <summary>
        /// A label
        /// </summary>
        private System.Windows.Forms.Label label27;

        /// <summary>
        /// A label
        /// </summary>
        private System.Windows.Forms.Label label26;

        /// <summary>
        /// A label for the active coach
        /// </summary>
        private System.Windows.Forms.Label lblActiveCoach;

        /// <summary>
        /// A label
        /// </summary>
        private System.Windows.Forms.Label label20;

        /// <summary>
        /// A picture box for the coach's profile pic
        /// </summary>
        private System.Windows.Forms.PictureBox pictureBoxCoachProfile;

        /// <summary>
        /// A button to clear choices in the Find Coach by Name tab
        /// </summary>
        private System.Windows.Forms.Button btnClear;

        /// <summary>
        /// A button to join a session in the Find Session by Time tab
        /// </summary>
        private System.Windows.Forms.Button btnScheduleApptName;

        /// <summary>
        /// A message in the Find Session by Coach tab
        /// </summary>
        private System.Windows.Forms.Label lblMessage;

        /// <summary>
        /// A group box for sunday time periods in Find Session by Time
        /// </summary>
        private System.Windows.Forms.GroupBox sunday;

        /// <summary>
        /// A check box for Sunday evening
        /// </summary>
        private System.Windows.Forms.CheckBox chkSunEvening;

        /// <summary>
        /// A check box for Sunday afternoon
        /// </summary>
        private System.Windows.Forms.CheckBox chkSunAfternoon;

        /// <summary>
        /// A check box for Sunday midday
        /// </summary>
        private System.Windows.Forms.CheckBox chkSunMidday;

        /// <summary>
        /// A check box for Sunday morning
        /// </summary>
        private System.Windows.Forms.CheckBox chkSunMorning;

        /// <summary>
        /// A group box for saturday time periods in Find Session by Time
        /// </summary>
        private System.Windows.Forms.GroupBox saturday;

        /// <summary>
        /// A check box for saturday evening
        /// </summary>
        private System.Windows.Forms.CheckBox chkSatEvening;

        /// <summary>
        /// A check box for saturday afternoon
        /// </summary>
        private System.Windows.Forms.CheckBox chkSatAfternoon;

        /// <summary>
        /// A check box for saturday midday
        /// </summary>
        private System.Windows.Forms.CheckBox chkSatMidday;

        /// <summary>
        /// A check box for saturday morning
        /// </summary>
        private System.Windows.Forms.CheckBox chkSatMorning;

        /// <summary>
        /// A group box for friday time periods in Find Session by Time
        /// </summary>
        private System.Windows.Forms.GroupBox friday;

        /// <summary>
        /// A check box for friday evening
        /// </summary>
        private System.Windows.Forms.CheckBox chkFriEvening;

        /// <summary>
        /// A check box for friday afternoon
        /// </summary>
        private System.Windows.Forms.CheckBox chkFriAfternoon;

        /// <summary>
        /// A check box for friday midday
        /// </summary>
        private System.Windows.Forms.CheckBox chkFriMidday;

        /// <summary>
        /// A check box for friday morning
        /// </summary>
        private System.Windows.Forms.CheckBox chkFriMorning;

        /// <summary>
        /// A group box for thursday time periods in Find Session by Time
        /// </summary>
        private System.Windows.Forms.GroupBox thursday;

        /// <summary>
        /// A check box for thursday evening
        /// </summary>
        private System.Windows.Forms.CheckBox chkThuEvening;

        /// <summary>
        /// A check box for thursday afternoon
        /// </summary>
        private System.Windows.Forms.CheckBox chkThuAfternoon;

        /// <summary>
        /// A check box for thursday midday
        /// </summary>
        private System.Windows.Forms.CheckBox chkThuMidday;

        /// <summary>
        /// A check box for thursday morning
        /// </summary>
        private System.Windows.Forms.CheckBox chkThuMorning;

        /// <summary>
        /// A group box for wednesday time periods in Find Session by Time
        /// </summary>
        private System.Windows.Forms.GroupBox wednesday;

        /// <summary>
        /// A check box for wednesday evening
        /// </summary>
        private System.Windows.Forms.CheckBox chkWedEvening;

        /// <summary>
        /// A check box for wednesday afternoon
        /// </summary>
        private System.Windows.Forms.CheckBox chkWedAfternoon;

        /// <summary>
        /// A check box for wednesday midday
        /// </summary>
        private System.Windows.Forms.CheckBox chkWedMidday;

        /// <summary>
        /// A check box for wednesday morning
        /// </summary>
        private System.Windows.Forms.CheckBox chkWedMorning;

        /// <summary>
        /// A group box for tuesday time periods in Find Session by Time
        /// </summary>
        private System.Windows.Forms.GroupBox tuesday;

        /// <summary>
        /// A check box for tuesday evening
        /// </summary>
        private System.Windows.Forms.CheckBox chkTueEvening;

        /// <summary>
        /// A check box for tuesday afternoon
        /// </summary>
        private System.Windows.Forms.CheckBox chkTueAfternoon;

        /// <summary>
        /// A check box for tuesday midday
        /// </summary>
        private System.Windows.Forms.CheckBox chkTueMidday;

        /// <summary>
        /// A check box for tuesday morning
        /// </summary>
        private System.Windows.Forms.CheckBox chkTueMorning;

        /// <summary>
        /// A group box for monday time periods in Find Session by Time
        /// </summary>
        private System.Windows.Forms.GroupBox monday;

        /// <summary>
        /// A check box for monday evening
        /// </summary>
        private System.Windows.Forms.CheckBox chkMonEvening;

        /// <summary>
        /// A check box for monday afternoon
        /// </summary>
        private System.Windows.Forms.CheckBox chkMonAfternoon;

        /// <summary>
        /// A check box for monday midday
        /// </summary>
        private System.Windows.Forms.CheckBox chkMonMidday;

        /// <summary>
        /// A check box for monday morning
        /// </summary>
        private System.Windows.Forms.CheckBox chkMonMorning;

        /// <summary>
        /// Button to search for sessions based on selected times
        /// </summary>
        private System.Windows.Forms.Button btnSearchByTime;

        /// <summary>
        /// A label
        /// </summary>
        private System.Windows.Forms.Label label49;

        /// <summary>
        /// A group box
        /// </summary>
        private System.Windows.Forms.GroupBox groupBox4;

        /// <summary>
        /// A group box
        /// </summary>
        private System.Windows.Forms.GroupBox groupBox3;

        /// <summary>
        /// A check box to select Evening
        /// </summary>
        private System.Windows.Forms.CheckBox chkEvening;

        /// <summary>
        /// A check box to select Midday
        /// </summary>
        private System.Windows.Forms.CheckBox chkMidday;

        /// <summary>
        /// A check box to select Afternoon
        /// </summary>
        private System.Windows.Forms.CheckBox chkAfternoon;

        /// <summary>
        /// A check box to select Morning
        /// </summary>
        private System.Windows.Forms.CheckBox chkMorning;

        /// <summary>
        /// A group box
        /// </summary>
        private System.Windows.Forms.GroupBox groupBox1;

        /// <summary>
        /// A check box to select sunday
        /// </summary>
        private System.Windows.Forms.CheckBox chkSun;

        /// <summary>
        /// A check box to select saturday
        /// </summary>
        private System.Windows.Forms.CheckBox chkSat;

        /// <summary>
        /// A check box to select friday
        /// </summary>
        private System.Windows.Forms.CheckBox chkFri;

        /// <summary>
        /// A check box to select thursday
        /// </summary>
        private System.Windows.Forms.CheckBox chkThu;

        /// <summary>
        /// A check box to select wednesday
        /// </summary>
        private System.Windows.Forms.CheckBox chkWed;

        /// <summary>
        /// A check box to select tuesday
        /// </summary>
        private System.Windows.Forms.CheckBox chkTue;

        /// <summary>
        /// A check box to select monday
        /// </summary>
        private System.Windows.Forms.CheckBox chkMon;

        /// <summary>
        /// A label
        /// </summary>
        private System.Windows.Forms.Label label34;

        /// <summary>
        /// A label
        /// </summary>
        private System.Windows.Forms.Label label33;

        /// <summary>
        /// A label
        /// </summary>
        private System.Windows.Forms.Label label32;

        /// <summary>
        /// A label
        /// </summary>
        private System.Windows.Forms.Label label31;

        /// <summary>
        /// A label
        /// </summary>
        private System.Windows.Forms.Label label30;

        /// <summary>
        /// A label
        /// </summary>
        private System.Windows.Forms.Label label29;

        /// <summary>
        /// A label
        /// </summary>
        private System.Windows.Forms.Label label14;

        /// <summary>
        /// A button to schedule the selected appointment
        /// </summary>
        private System.Windows.Forms.Button btnScheduleAppointment;

        /// <summary>
        /// A button for a user to reset his/her password
        /// </summary>
        private System.Windows.Forms.Button btnResetPassword;

        /// <summary>
        /// A label for the student ID field
        /// </summary>
        private System.Windows.Forms.Label lblStdID;

        /// <summary>
        /// A label
        /// </summary>
        private System.Windows.Forms.Label label2;

        /// <summary>
        /// A button to search by name
        /// </summary>
        private System.Windows.Forms.Button btnSearchByName;

        /// <summary>
        /// Button to clear the Find Session by Time area
        /// </summary>
        private System.Windows.Forms.Button btnClearByTime;

        /// <summary>
        /// Combo box containing a list of active coaches
        /// </summary>
        private System.Windows.Forms.ComboBox comboBoxCoaches;

        /// <summary>
        /// Message to display when an appointment is being made
        /// </summary>
        private System.Windows.Forms.Label appointmentMessage;

        /// <summary>
        /// A label for the email address text box.
        /// </summary>
        private System.Windows.Forms.Label lblEmail;

        /// <summary>
        /// A label
        /// </summary>
        private System.Windows.Forms.Label label3;

        /// <summary>
        /// A label for the user's phone number
        /// </summary>
        private System.Windows.Forms.Label lblPhone;

        /// <summary>
        /// A label
        /// </summary>
        private System.Windows.Forms.Label label4;

        /// <summary>
        /// A data grid to show found coaches by time
        /// </summary>
        private System.Windows.Forms.DataGridView dataGridSessionsByTime;

        /// <summary>
        /// A button for users to logout of the form
        /// </summary>
        private System.Windows.Forms.Button btnStdLogout;

        /// <summary>
        /// A status message
        /// </summary>
        private System.Windows.Forms.Label lblRegisterStatusMessage;

        /// <summary>
        /// A list box showing active courses
        /// </summary>
        private System.Windows.Forms.ListBox listBoxCourse;

        /// <summary>
        /// A list box to show subjects for the current coach
        /// </summary>
        private System.Windows.Forms.ListBox listBoxDisplayCoachSubject;

        /// <summary>
        /// A label
        /// </summary>
        private System.Windows.Forms.Label label1;

        /// <summary>
        /// A button allowing users to exit the program
        /// </summary>
        private System.Windows.Forms.Button btnExit;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label28;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindCoachForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnCancelSession = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.appointmentMessage = new System.Windows.Forms.Label();
            this.dgrShowAppointments = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxCourse = new System.Windows.Forms.ListBox();
            this.lblRegisterStatusMessage = new System.Windows.Forms.Label();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.lblStdID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStdPhone = new System.Windows.Forms.Label();
            this.lblStdEmail = new System.Windows.Forms.Label();
            this.lblStdName = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.pictureBoxStdProfile = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboBoxCoaches = new System.Windows.Forms.ComboBox();
            this.btnSearchByName = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnScheduleApptName = new System.Windows.Forms.Button();
            this.panelCoach = new System.Windows.Forms.Panel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.listBoxDisplayCoachSubject = new System.Windows.Forms.ListBox();
            this.label20 = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCoachName = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.lblActiveCoach = new System.Windows.Forms.Label();
            this.pictureBoxCoachProfile = new System.Windows.Forms.PictureBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.monday = new System.Windows.Forms.GroupBox();
            this.chkMonEvening = new System.Windows.Forms.CheckBox();
            this.chkMonAfternoon = new System.Windows.Forms.CheckBox();
            this.chkMonMidday = new System.Windows.Forms.CheckBox();
            this.chkMonMorning = new System.Windows.Forms.CheckBox();
            this.sunday = new System.Windows.Forms.GroupBox();
            this.chkSunEvening = new System.Windows.Forms.CheckBox();
            this.chkSunAfternoon = new System.Windows.Forms.CheckBox();
            this.chkSunMidday = new System.Windows.Forms.CheckBox();
            this.chkSunMorning = new System.Windows.Forms.CheckBox();
            this.tuesday = new System.Windows.Forms.GroupBox();
            this.chkTueEvening = new System.Windows.Forms.CheckBox();
            this.chkTueAfternoon = new System.Windows.Forms.CheckBox();
            this.chkTueMidday = new System.Windows.Forms.CheckBox();
            this.chkTueMorning = new System.Windows.Forms.CheckBox();
            this.saturday = new System.Windows.Forms.GroupBox();
            this.chkSatEvening = new System.Windows.Forms.CheckBox();
            this.chkSatAfternoon = new System.Windows.Forms.CheckBox();
            this.chkSatMidday = new System.Windows.Forms.CheckBox();
            this.chkSatMorning = new System.Windows.Forms.CheckBox();
            this.wednesday = new System.Windows.Forms.GroupBox();
            this.chkWedEvening = new System.Windows.Forms.CheckBox();
            this.chkWedAfternoon = new System.Windows.Forms.CheckBox();
            this.chkWedMidday = new System.Windows.Forms.CheckBox();
            this.chkWedMorning = new System.Windows.Forms.CheckBox();
            this.friday = new System.Windows.Forms.GroupBox();
            this.chkFriEvening = new System.Windows.Forms.CheckBox();
            this.chkFriAfternoon = new System.Windows.Forms.CheckBox();
            this.chkFriMidday = new System.Windows.Forms.CheckBox();
            this.chkFriMorning = new System.Windows.Forms.CheckBox();
            this.thursday = new System.Windows.Forms.GroupBox();
            this.chkThuEvening = new System.Windows.Forms.CheckBox();
            this.chkThuAfternoon = new System.Windows.Forms.CheckBox();
            this.chkThuMidday = new System.Windows.Forms.CheckBox();
            this.chkThuMorning = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblTransport = new System.Windows.Forms.Label();
            this.lblScience = new System.Windows.Forms.Label();
            this.lblManu = new System.Windows.Forms.Label();
            this.lblLaw = new System.Windows.Forms.Label();
            this.lblIT = new System.Windows.Forms.Label();
            this.lblHuman = new System.Windows.Forms.Label();
            this.lblHealth = new System.Windows.Forms.Label();
            this.lblGeneral = new System.Windows.Forms.Label();
            this.lblEnergy = new System.Windows.Forms.Label();
            this.lblDigital = new System.Windows.Forms.Label();
            this.lblBusiness = new System.Windows.Forms.Label();
            this.lblArch = new System.Windows.Forms.Label();
            this.lblAgri = new System.Windows.Forms.Label();
            this.btnTransport = new System.Windows.Forms.Button();
            this.btnScience = new System.Windows.Forms.Button();
            this.btnManu = new System.Windows.Forms.Button();
            this.btnLaw = new System.Windows.Forms.Button();
            this.btnIT = new System.Windows.Forms.Button();
            this.btnHuman = new System.Windows.Forms.Button();
            this.btnHealth = new System.Windows.Forms.Button();
            this.btnGeneral = new System.Windows.Forms.Button();
            this.btnEnergy = new System.Windows.Forms.Button();
            this.btnDigital = new System.Windows.Forms.Button();
            this.btnBusiness = new System.Windows.Forms.Button();
            this.btnArch = new System.Windows.Forms.Button();
            this.btnAgri = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnClearByTime = new System.Windows.Forms.Button();
            this.btnScheduleAppointment = new System.Windows.Forms.Button();
            this.btnSearchByTime = new System.Windows.Forms.Button();
            this.label49 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridSessionsByTime = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkEvening = new System.Windows.Forms.CheckBox();
            this.chkMidday = new System.Windows.Forms.CheckBox();
            this.chkAfternoon = new System.Windows.Forms.CheckBox();
            this.chkMorning = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkSun = new System.Windows.Forms.CheckBox();
            this.chkSat = new System.Windows.Forms.CheckBox();
            this.chkFri = new System.Windows.Forms.CheckBox();
            this.chkThu = new System.Windows.Forms.CheckBox();
            this.chkWed = new System.Windows.Forms.CheckBox();
            this.chkTue = new System.Windows.Forms.CheckBox();
            this.chkMon = new System.Windows.Forms.CheckBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnStdLogout = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            label28 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrShowAppointments)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStdProfile)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panelCoach.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoachProfile)).BeginInit();
            this.monday.SuspendLayout();
            this.sunday.SuspendLayout();
            this.tuesday.SuspendLayout();
            this.saturday.SuspendLayout();
            this.wednesday.SuspendLayout();
            this.friday.SuspendLayout();
            this.thursday.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSessionsByTime)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label28.Location = new System.Drawing.Point(308, 25);
            label28.Name = "label28";
            label28.Size = new System.Drawing.Size(99, 13);
            label28.TabIndex = 7;
            label28.Text = "Select Your Coach:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 32);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(876, 538);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(868, 512);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            // 
            // btnCancelSession
            // 
            this.btnCancelSession.Enabled = false;
            this.btnCancelSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelSession.Location = new System.Drawing.Point(749, 226);
            this.btnCancelSession.Name = "btnCancelSession";
            this.btnCancelSession.Padding = new System.Windows.Forms.Padding(1);
            this.btnCancelSession.Size = new System.Drawing.Size(99, 28);
            this.btnCancelSession.TabIndex = 5;
            this.btnCancelSession.Text = "Leave Session";
            this.btnCancelSession.UseVisualStyleBackColor = true;
            this.btnCancelSession.Click += new System.EventHandler(this.BtnCancelCoachClick);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnCancelSession);
            this.groupBox6.Controls.Add(this.appointmentMessage);
            this.groupBox6.Controls.Add(this.dgrShowAppointments);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(6, 233);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(856, 259);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Your Enrolled Sessions";
            // 
            // appointmentMessage
            // 
            this.appointmentMessage.AutoSize = true;
            this.appointmentMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentMessage.Location = new System.Drawing.Point(283, 62);
            this.appointmentMessage.Name = "appointmentMessage";
            this.appointmentMessage.Size = new System.Drawing.Size(307, 25);
            this.appointmentMessage.TabIndex = 6;
            this.appointmentMessage.Text = "You haven\'t assigned a coach.";
            this.appointmentMessage.Visible = false;
            // 
            // dgrShowAppointments
            // 
            this.dgrShowAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrShowAppointments.Location = new System.Drawing.Point(6, 50);
            this.dgrShowAppointments.Name = "dgrShowAppointments";
            this.dgrShowAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrShowAppointments.Size = new System.Drawing.Size(842, 170);
            this.dgrShowAppointments.TabIndex = 0;
            this.dgrShowAppointments.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.pictureBoxStdProfile);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(1);
            this.panel1.Size = new System.Drawing.Size(856, 213);
            this.panel1.TabIndex = 3;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.listBoxCourse);
            this.groupBox5.Controls.Add(this.lblRegisterStatusMessage);
            this.groupBox5.Controls.Add(this.btnResetPassword);
            this.groupBox5.Controls.Add(this.btnEditProfile);
            this.groupBox5.Controls.Add(this.lblStdID);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.lblStdPhone);
            this.groupBox5.Controls.Add(this.lblStdEmail);
            this.groupBox5.Controls.Add(this.lblStdName);
            this.groupBox5.Controls.Add(this.label37);
            this.groupBox5.Controls.Add(this.label36);
            this.groupBox5.Controls.Add(this.label35);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(148, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(700, 163);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Profile";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(366, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Registered Courses";
            // 
            // listBoxCourse
            // 
            this.listBoxCourse.FormattingEnabled = true;
            this.listBoxCourse.Location = new System.Drawing.Point(369, 78);
            this.listBoxCourse.Name = "listBoxCourse";
            this.listBoxCourse.Size = new System.Drawing.Size(307, 69);
            this.listBoxCourse.TabIndex = 12;
            this.listBoxCourse.Visible = false;
            // 
            // lblRegisterStatusMessage
            // 
            this.lblRegisterStatusMessage.AutoSize = true;
            this.lblRegisterStatusMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterStatusMessage.Location = new System.Drawing.Point(458, 100);
            this.lblRegisterStatusMessage.Name = "lblRegisterStatusMessage";
            this.lblRegisterStatusMessage.Size = new System.Drawing.Size(108, 13);
            this.lblRegisterStatusMessage.TabIndex = 11;
            this.lblRegisterStatusMessage.Text = "No course register.ed";
            this.lblRegisterStatusMessage.Visible = false;
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetPassword.Location = new System.Drawing.Point(474, 20);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Padding = new System.Windows.Forms.Padding(1);
            this.btnResetPassword.Size = new System.Drawing.Size(112, 28);
            this.btnResetPassword.TabIndex = 6;
            this.btnResetPassword.Text = "Reset Password";
            this.btnResetPassword.UseVisualStyleBackColor = true;
            this.btnResetPassword.Click += new System.EventHandler(this.BtnResetPasswordClick);
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProfile.Location = new System.Drawing.Point(369, 20);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Padding = new System.Windows.Forms.Padding(1);
            this.btnEditProfile.Size = new System.Drawing.Size(87, 28);
            this.btnEditProfile.TabIndex = 3;
            this.btnEditProfile.Text = "Edit Profile";
            this.btnEditProfile.UseVisualStyleBackColor = true;
            this.btnEditProfile.Click += new System.EventHandler(this.BtnEditProfileClick);
            // 
            // lblStdID
            // 
            this.lblStdID.BackColor = System.Drawing.Color.Transparent;
            this.lblStdID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStdID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStdID.Location = new System.Drawing.Point(118, 22);
            this.lblStdID.Name = "lblStdID";
            this.lblStdID.Padding = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.lblStdID.Size = new System.Drawing.Size(205, 26);
            this.lblStdID.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Student ID:";
            // 
            // lblStdPhone
            // 
            this.lblStdPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblStdPhone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStdPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStdPhone.Location = new System.Drawing.Point(118, 121);
            this.lblStdPhone.Name = "lblStdPhone";
            this.lblStdPhone.Padding = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.lblStdPhone.Size = new System.Drawing.Size(205, 26);
            this.lblStdPhone.TabIndex = 6;
            // 
            // lblStdEmail
            // 
            this.lblStdEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblStdEmail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStdEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStdEmail.Location = new System.Drawing.Point(118, 87);
            this.lblStdEmail.Name = "lblStdEmail";
            this.lblStdEmail.Padding = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.lblStdEmail.Size = new System.Drawing.Size(205, 26);
            this.lblStdEmail.TabIndex = 5;
            // 
            // lblStdName
            // 
            this.lblStdName.BackColor = System.Drawing.Color.Transparent;
            this.lblStdName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStdName.Location = new System.Drawing.Point(118, 54);
            this.lblStdName.Name = "lblStdName";
            this.lblStdName.Padding = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.lblStdName.Size = new System.Drawing.Size(205, 26);
            this.lblStdName.TabIndex = 4;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(87, 127);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(25, 13);
            this.label37.TabIndex = 2;
            this.label37.Text = "Tel:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(74, 93);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(38, 13);
            this.label36.TabIndex = 1;
            this.label36.Text = "E-mail:";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(34, 60);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(78, 13);
            this.label35.TabIndex = 0;
            this.label35.Text = "Student Name:";
            // 
            // pictureBoxStdProfile
            // 
            this.pictureBoxStdProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxStdProfile.Location = new System.Drawing.Point(14, 15);
            this.pictureBoxStdProfile.Name = "pictureBoxStdProfile";
            this.pictureBoxStdProfile.Size = new System.Drawing.Size(119, 130);
            this.pictureBoxStdProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxStdProfile.TabIndex = 1;
            this.pictureBoxStdProfile.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.comboBoxCoaches);
            this.tabPage2.Controls.Add(this.btnSearchByName);
            this.tabPage2.Controls.Add(this.btnClear);
            this.tabPage2.Controls.Add(this.btnScheduleApptName);
            this.tabPage2.Controls.Add(this.panelCoach);
            this.tabPage2.Controls.Add(label28);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(868, 512);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Find Session by Coach";
            this.tabPage2.Click += new System.EventHandler(this.TabPage2Click);
            // 
            // comboBoxCoaches
            // 
            this.comboBoxCoaches.FormattingEnabled = true;
            this.comboBoxCoaches.Items.AddRange(new object[] {
            "Choose a coach"});
            this.comboBoxCoaches.Location = new System.Drawing.Point(425, 22);
            this.comboBoxCoaches.Name = "comboBoxCoaches";
            this.comboBoxCoaches.Size = new System.Drawing.Size(232, 21);
            this.comboBoxCoaches.TabIndex = 30;
            this.comboBoxCoaches.Text = "Choose a coach";
            // 
            // btnSearchByName
            // 
            this.btnSearchByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchByName.Location = new System.Drawing.Point(663, 17);
            this.btnSearchByName.Name = "btnSearchByName";
            this.btnSearchByName.Size = new System.Drawing.Size(72, 28);
            this.btnSearchByName.TabIndex = 26;
            this.btnSearchByName.Text = "Search";
            this.btnSearchByName.UseVisualStyleBackColor = true;
            this.btnSearchByName.Click += new System.EventHandler(this.BtnSearchByNameClick);
            // 
            // btnClear
            // 
            this.btnClear.Enabled = false;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(769, 472);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(73, 28);
            this.btnClear.TabIndex = 25;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClearClick);
            // 
            // btnScheduleApptName
            // 
            this.btnScheduleApptName.Enabled = false;
            this.btnScheduleApptName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScheduleApptName.Location = new System.Drawing.Point(663, 472);
            this.btnScheduleApptName.Name = "btnScheduleApptName";
            this.btnScheduleApptName.Size = new System.Drawing.Size(100, 28);
            this.btnScheduleApptName.TabIndex = 24;
            this.btnScheduleApptName.Text = "Join Session";
            this.btnScheduleApptName.UseVisualStyleBackColor = true;
            this.btnScheduleApptName.Click += new System.EventHandler(this.BtnScheduleApptNameClick);
            // 
            // panelCoach
            // 
            this.panelCoach.Controls.Add(this.groupBox7);
            this.panelCoach.Controls.Add(this.pictureBoxCoachProfile);
            this.panelCoach.Controls.Add(this.lblMessage);
            this.panelCoach.Controls.Add(this.monday);
            this.panelCoach.Controls.Add(this.sunday);
            this.panelCoach.Controls.Add(this.tuesday);
            this.panelCoach.Controls.Add(this.saturday);
            this.panelCoach.Controls.Add(this.wednesday);
            this.panelCoach.Controls.Add(this.friday);
            this.panelCoach.Controls.Add(this.thursday);
            this.panelCoach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCoach.Location = new System.Drawing.Point(21, 55);
            this.panelCoach.Name = "panelCoach";
            this.panelCoach.Size = new System.Drawing.Size(828, 411);
            this.panelCoach.TabIndex = 8;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.listBoxDisplayCoachSubject);
            this.groupBox7.Controls.Add(this.label20);
            this.groupBox7.Controls.Add(this.lblPhone);
            this.groupBox7.Controls.Add(this.label4);
            this.groupBox7.Controls.Add(this.lblEmail);
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Controls.Add(this.lblCoachName);
            this.groupBox7.Controls.Add(this.label27);
            this.groupBox7.Controls.Add(this.label26);
            this.groupBox7.Controls.Add(this.lblActiveCoach);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(135, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(674, 174);
            this.groupBox7.TabIndex = 9;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Coach Profile";
            // 
            // listBoxDisplayCoachSubject
            // 
            this.listBoxDisplayCoachSubject.FormattingEnabled = true;
            this.listBoxDisplayCoachSubject.Location = new System.Drawing.Point(457, 44);
            this.listBoxDisplayCoachSubject.Name = "listBoxDisplayCoachSubject";
            this.listBoxDisplayCoachSubject.Size = new System.Drawing.Size(210, 108);
            this.listBoxDisplayCoachSubject.TabIndex = 1;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(346, 69);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(102, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Responsible subject";
            // 
            // lblPhone
            // 
            this.lblPhone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(140, 134);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Padding = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.lblPhone.Size = new System.Drawing.Size(175, 25);
            this.lblPhone.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(109, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tel:";
            // 
            // lblEmail
            // 
            this.lblEmail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(140, 103);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Padding = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.lblEmail.Size = new System.Drawing.Size(175, 25);
            this.lblEmail.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(99, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Email:";
            // 
            // lblCoachName
            // 
            this.lblCoachName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCoachName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoachName.Location = new System.Drawing.Point(140, 44);
            this.lblCoachName.Name = "lblCoachName";
            this.lblCoachName.Padding = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.lblCoachName.Size = new System.Drawing.Size(175, 24);
            this.lblCoachName.TabIndex = 5;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(61, 49);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(72, 13);
            this.label27.TabIndex = 1;
            this.label27.Text = "Coach Name:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(30, 78);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(104, 13);
            this.label26.TabIndex = 2;
            this.label26.Text = "Active Coach Since:";
            // 
            // lblActiveCoach
            // 
            this.lblActiveCoach.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblActiveCoach.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveCoach.Location = new System.Drawing.Point(140, 73);
            this.lblActiveCoach.Name = "lblActiveCoach";
            this.lblActiveCoach.Padding = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.lblActiveCoach.Size = new System.Drawing.Size(175, 25);
            this.lblActiveCoach.TabIndex = 6;
            // 
            // pictureBoxCoachProfile
            // 
            this.pictureBoxCoachProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxCoachProfile.Image = global::CoachConnect.Properties.Resources.scottie;
            this.pictureBoxCoachProfile.Location = new System.Drawing.Point(7, 11);
            this.pictureBoxCoachProfile.Name = "pictureBoxCoachProfile";
            this.pictureBoxCoachProfile.Size = new System.Drawing.Size(121, 130);
            this.pictureBoxCoachProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoachProfile.TabIndex = 0;
            this.pictureBoxCoachProfile.TabStop = false;
            // 
            // lblMessage
            // 
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(142, 236);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(540, 25);
            this.lblMessage.TabIndex = 23;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // monday
            // 
            this.monday.Controls.Add(this.chkMonEvening);
            this.monday.Controls.Add(this.chkMonAfternoon);
            this.monday.Controls.Add(this.chkMonMidday);
            this.monday.Controls.Add(this.chkMonMorning);
            this.monday.Enabled = false;
            this.monday.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monday.Location = new System.Drawing.Point(8, 270);
            this.monday.Name = "monday";
            this.monday.Size = new System.Drawing.Size(111, 135);
            this.monday.TabIndex = 16;
            this.monday.TabStop = false;
            this.monday.Text = "Monday";
            // 
            // chkMonEvening
            // 
            this.chkMonEvening.AutoSize = true;
            this.chkMonEvening.Enabled = false;
            this.chkMonEvening.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMonEvening.Location = new System.Drawing.Point(17, 106);
            this.chkMonEvening.Name = "chkMonEvening";
            this.chkMonEvening.Size = new System.Drawing.Size(65, 17);
            this.chkMonEvening.TabIndex = 10;
            this.chkMonEvening.Text = "Evening";
            this.chkMonEvening.UseVisualStyleBackColor = true;
            this.chkMonEvening.Click += new System.EventHandler(this.TabPage2Click);
            // 
            // chkMonAfternoon
            // 
            this.chkMonAfternoon.AutoSize = true;
            this.chkMonAfternoon.Enabled = false;
            this.chkMonAfternoon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMonAfternoon.Location = new System.Drawing.Point(17, 80);
            this.chkMonAfternoon.Name = "chkMonAfternoon";
            this.chkMonAfternoon.Size = new System.Drawing.Size(72, 17);
            this.chkMonAfternoon.TabIndex = 9;
            this.chkMonAfternoon.Text = "Afternoon";
            this.chkMonAfternoon.UseVisualStyleBackColor = true;
            this.chkMonAfternoon.Click += new System.EventHandler(this.TabPage2Click);
            // 
            // chkMonMidday
            // 
            this.chkMonMidday.AutoSize = true;
            this.chkMonMidday.Enabled = false;
            this.chkMonMidday.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMonMidday.Location = new System.Drawing.Point(17, 54);
            this.chkMonMidday.Name = "chkMonMidday";
            this.chkMonMidday.Size = new System.Drawing.Size(60, 17);
            this.chkMonMidday.TabIndex = 8;
            this.chkMonMidday.Text = "Midday";
            this.chkMonMidday.UseVisualStyleBackColor = true;
            this.chkMonMidday.Click += new System.EventHandler(this.TabPage2Click);
            // 
            // chkMonMorning
            // 
            this.chkMonMorning.AutoSize = true;
            this.chkMonMorning.Enabled = false;
            this.chkMonMorning.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMonMorning.Location = new System.Drawing.Point(17, 28);
            this.chkMonMorning.Name = "chkMonMorning";
            this.chkMonMorning.Size = new System.Drawing.Size(64, 17);
            this.chkMonMorning.TabIndex = 7;
            this.chkMonMorning.Text = "Morning";
            this.chkMonMorning.UseVisualStyleBackColor = true;
            this.chkMonMorning.Click += new System.EventHandler(this.TabPage2Click);
            // 
            // sunday
            // 
            this.sunday.Controls.Add(this.chkSunEvening);
            this.sunday.Controls.Add(this.chkSunAfternoon);
            this.sunday.Controls.Add(this.chkSunMidday);
            this.sunday.Controls.Add(this.chkSunMorning);
            this.sunday.Enabled = false;
            this.sunday.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunday.Location = new System.Drawing.Point(710, 270);
            this.sunday.Name = "sunday";
            this.sunday.Size = new System.Drawing.Size(111, 135);
            this.sunday.TabIndex = 22;
            this.sunday.TabStop = false;
            this.sunday.Text = "Sunday";
            // 
            // chkSunEvening
            // 
            this.chkSunEvening.AutoSize = true;
            this.chkSunEvening.Enabled = false;
            this.chkSunEvening.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSunEvening.Location = new System.Drawing.Point(17, 106);
            this.chkSunEvening.Name = "chkSunEvening";
            this.chkSunEvening.Size = new System.Drawing.Size(65, 17);
            this.chkSunEvening.TabIndex = 10;
            this.chkSunEvening.Text = "Evening";
            this.chkSunEvening.UseVisualStyleBackColor = true;
            this.chkSunEvening.Click += new System.EventHandler(this.TabPage2Click);
            // 
            // chkSunAfternoon
            // 
            this.chkSunAfternoon.AutoSize = true;
            this.chkSunAfternoon.Enabled = false;
            this.chkSunAfternoon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSunAfternoon.Location = new System.Drawing.Point(17, 80);
            this.chkSunAfternoon.Name = "chkSunAfternoon";
            this.chkSunAfternoon.Size = new System.Drawing.Size(72, 17);
            this.chkSunAfternoon.TabIndex = 9;
            this.chkSunAfternoon.Text = "Afternoon";
            this.chkSunAfternoon.UseVisualStyleBackColor = true;
            this.chkSunAfternoon.Click += new System.EventHandler(this.TabPage2Click);
            // 
            // chkSunMidday
            // 
            this.chkSunMidday.AutoSize = true;
            this.chkSunMidday.Enabled = false;
            this.chkSunMidday.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSunMidday.Location = new System.Drawing.Point(17, 54);
            this.chkSunMidday.Name = "chkSunMidday";
            this.chkSunMidday.Size = new System.Drawing.Size(60, 17);
            this.chkSunMidday.TabIndex = 8;
            this.chkSunMidday.Text = "Midday";
            this.chkSunMidday.UseVisualStyleBackColor = true;
            this.chkSunMidday.Click += new System.EventHandler(this.TabPage2Click);
            // 
            // chkSunMorning
            // 
            this.chkSunMorning.AutoSize = true;
            this.chkSunMorning.Enabled = false;
            this.chkSunMorning.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSunMorning.Location = new System.Drawing.Point(17, 28);
            this.chkSunMorning.Name = "chkSunMorning";
            this.chkSunMorning.Size = new System.Drawing.Size(64, 17);
            this.chkSunMorning.TabIndex = 7;
            this.chkSunMorning.Text = "Morning";
            this.chkSunMorning.UseVisualStyleBackColor = true;
            this.chkSunMorning.Click += new System.EventHandler(this.TabPage2Click);
            // 
            // tuesday
            // 
            this.tuesday.Controls.Add(this.chkTueEvening);
            this.tuesday.Controls.Add(this.chkTueAfternoon);
            this.tuesday.Controls.Add(this.chkTueMidday);
            this.tuesday.Controls.Add(this.chkTueMorning);
            this.tuesday.Enabled = false;
            this.tuesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tuesday.Location = new System.Drawing.Point(125, 270);
            this.tuesday.Name = "tuesday";
            this.tuesday.Size = new System.Drawing.Size(111, 135);
            this.tuesday.TabIndex = 17;
            this.tuesday.TabStop = false;
            this.tuesday.Text = "Tuesday";
            // 
            // chkTueEvening
            // 
            this.chkTueEvening.AutoSize = true;
            this.chkTueEvening.Enabled = false;
            this.chkTueEvening.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTueEvening.Location = new System.Drawing.Point(17, 106);
            this.chkTueEvening.Name = "chkTueEvening";
            this.chkTueEvening.Size = new System.Drawing.Size(65, 17);
            this.chkTueEvening.TabIndex = 10;
            this.chkTueEvening.Text = "Evening";
            this.chkTueEvening.UseVisualStyleBackColor = true;
            this.chkTueEvening.Click += new System.EventHandler(this.TabPage2Click);
            // 
            // chkTueAfternoon
            // 
            this.chkTueAfternoon.AutoSize = true;
            this.chkTueAfternoon.Enabled = false;
            this.chkTueAfternoon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTueAfternoon.Location = new System.Drawing.Point(17, 80);
            this.chkTueAfternoon.Name = "chkTueAfternoon";
            this.chkTueAfternoon.Size = new System.Drawing.Size(72, 17);
            this.chkTueAfternoon.TabIndex = 9;
            this.chkTueAfternoon.Text = "Afternoon";
            this.chkTueAfternoon.UseVisualStyleBackColor = true;
            this.chkTueAfternoon.Click += new System.EventHandler(this.TabPage2Click);
            // 
            // chkTueMidday
            // 
            this.chkTueMidday.AutoSize = true;
            this.chkTueMidday.Enabled = false;
            this.chkTueMidday.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTueMidday.Location = new System.Drawing.Point(17, 54);
            this.chkTueMidday.Name = "chkTueMidday";
            this.chkTueMidday.Size = new System.Drawing.Size(60, 17);
            this.chkTueMidday.TabIndex = 8;
            this.chkTueMidday.Text = "Midday";
            this.chkTueMidday.UseVisualStyleBackColor = true;
            this.chkTueMidday.Click += new System.EventHandler(this.TabPage2Click);
            // 
            // chkTueMorning
            // 
            this.chkTueMorning.AutoSize = true;
            this.chkTueMorning.Enabled = false;
            this.chkTueMorning.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTueMorning.Location = new System.Drawing.Point(17, 28);
            this.chkTueMorning.Name = "chkTueMorning";
            this.chkTueMorning.Size = new System.Drawing.Size(64, 17);
            this.chkTueMorning.TabIndex = 7;
            this.chkTueMorning.Text = "Morning";
            this.chkTueMorning.UseVisualStyleBackColor = true;
            this.chkTueMorning.Click += new System.EventHandler(this.TabPage2Click);
            // 
            // saturday
            // 
            this.saturday.Controls.Add(this.chkSatEvening);
            this.saturday.Controls.Add(this.chkSatAfternoon);
            this.saturday.Controls.Add(this.chkSatMidday);
            this.saturday.Controls.Add(this.chkSatMorning);
            this.saturday.Enabled = false;
            this.saturday.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saturday.Location = new System.Drawing.Point(593, 270);
            this.saturday.Name = "saturday";
            this.saturday.Size = new System.Drawing.Size(111, 135);
            this.saturday.TabIndex = 21;
            this.saturday.TabStop = false;
            this.saturday.Text = "Saturday";
            // 
            // chkSatEvening
            // 
            this.chkSatEvening.AutoSize = true;
            this.chkSatEvening.Enabled = false;
            this.chkSatEvening.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSatEvening.Location = new System.Drawing.Point(17, 106);
            this.chkSatEvening.Name = "chkSatEvening";
            this.chkSatEvening.Size = new System.Drawing.Size(65, 17);
            this.chkSatEvening.TabIndex = 10;
            this.chkSatEvening.Text = "Evening";
            this.chkSatEvening.UseVisualStyleBackColor = true;
            this.chkSatEvening.Click += new System.EventHandler(this.TabPage2Click);
            // 
            // chkSatAfternoon
            // 
            this.chkSatAfternoon.AutoSize = true;
            this.chkSatAfternoon.Enabled = false;
            this.chkSatAfternoon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSatAfternoon.Location = new System.Drawing.Point(17, 80);
            this.chkSatAfternoon.Name = "chkSatAfternoon";
            this.chkSatAfternoon.Size = new System.Drawing.Size(72, 17);
            this.chkSatAfternoon.TabIndex = 9;
            this.chkSatAfternoon.Text = "Afternoon";
            this.chkSatAfternoon.UseVisualStyleBackColor = true;
            this.chkSatAfternoon.Click += new System.EventHandler(this.TabPage2Click);
            // 
            // chkSatMidday
            // 
            this.chkSatMidday.AutoSize = true;
            this.chkSatMidday.Enabled = false;
            this.chkSatMidday.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSatMidday.Location = new System.Drawing.Point(17, 54);
            this.chkSatMidday.Name = "chkSatMidday";
            this.chkSatMidday.Size = new System.Drawing.Size(60, 17);
            this.chkSatMidday.TabIndex = 8;
            this.chkSatMidday.Text = "Midday";
            this.chkSatMidday.UseVisualStyleBackColor = true;
            this.chkSatMidday.Click += new System.EventHandler(this.TabPage2Click);
            // 
            // chkSatMorning
            // 
            this.chkSatMorning.AutoSize = true;
            this.chkSatMorning.Enabled = false;
            this.chkSatMorning.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSatMorning.Location = new System.Drawing.Point(17, 28);
            this.chkSatMorning.Name = "chkSatMorning";
            this.chkSatMorning.Size = new System.Drawing.Size(64, 17);
            this.chkSatMorning.TabIndex = 7;
            this.chkSatMorning.Text = "Morning";
            this.chkSatMorning.UseVisualStyleBackColor = true;
            this.chkSatMorning.Click += new System.EventHandler(this.TabPage2Click);
            // 
            // wednesday
            // 
            this.wednesday.Controls.Add(this.chkWedEvening);
            this.wednesday.Controls.Add(this.chkWedAfternoon);
            this.wednesday.Controls.Add(this.chkWedMidday);
            this.wednesday.Controls.Add(this.chkWedMorning);
            this.wednesday.Enabled = false;
            this.wednesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wednesday.Location = new System.Drawing.Point(242, 270);
            this.wednesday.Name = "wednesday";
            this.wednesday.Size = new System.Drawing.Size(111, 135);
            this.wednesday.TabIndex = 18;
            this.wednesday.TabStop = false;
            this.wednesday.Text = "Wednesday";
            // 
            // chkWedEvening
            // 
            this.chkWedEvening.AutoSize = true;
            this.chkWedEvening.Enabled = false;
            this.chkWedEvening.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkWedEvening.Location = new System.Drawing.Point(17, 106);
            this.chkWedEvening.Name = "chkWedEvening";
            this.chkWedEvening.Size = new System.Drawing.Size(65, 17);
            this.chkWedEvening.TabIndex = 10;
            this.chkWedEvening.Text = "Evening";
            this.chkWedEvening.UseVisualStyleBackColor = true;
            this.chkWedEvening.Click += new System.EventHandler(this.TabPage2Click);
            // 
            // chkWedAfternoon
            // 
            this.chkWedAfternoon.AutoSize = true;
            this.chkWedAfternoon.Enabled = false;
            this.chkWedAfternoon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkWedAfternoon.Location = new System.Drawing.Point(17, 80);
            this.chkWedAfternoon.Name = "chkWedAfternoon";
            this.chkWedAfternoon.Size = new System.Drawing.Size(72, 17);
            this.chkWedAfternoon.TabIndex = 9;
            this.chkWedAfternoon.Text = "Afternoon";
            this.chkWedAfternoon.UseVisualStyleBackColor = true;
            this.chkWedAfternoon.Click += new System.EventHandler(this.TabPage2Click);
            // 
            // chkWedMidday
            // 
            this.chkWedMidday.AutoSize = true;
            this.chkWedMidday.Enabled = false;
            this.chkWedMidday.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkWedMidday.Location = new System.Drawing.Point(17, 54);
            this.chkWedMidday.Name = "chkWedMidday";
            this.chkWedMidday.Size = new System.Drawing.Size(60, 17);
            this.chkWedMidday.TabIndex = 8;
            this.chkWedMidday.Text = "Midday";
            this.chkWedMidday.UseVisualStyleBackColor = true;
            this.chkWedMidday.Click += new System.EventHandler(this.TabPage2Click);
            // 
            // chkWedMorning
            // 
            this.chkWedMorning.AutoSize = true;
            this.chkWedMorning.Enabled = false;
            this.chkWedMorning.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkWedMorning.Location = new System.Drawing.Point(17, 28);
            this.chkWedMorning.Name = "chkWedMorning";
            this.chkWedMorning.Size = new System.Drawing.Size(64, 17);
            this.chkWedMorning.TabIndex = 7;
            this.chkWedMorning.Text = "Morning";
            this.chkWedMorning.UseVisualStyleBackColor = true;
            this.chkWedMorning.Click += new System.EventHandler(this.TabPage2Click);
            // 
            // friday
            // 
            this.friday.Controls.Add(this.chkFriEvening);
            this.friday.Controls.Add(this.chkFriAfternoon);
            this.friday.Controls.Add(this.chkFriMidday);
            this.friday.Controls.Add(this.chkFriMorning);
            this.friday.Enabled = false;
            this.friday.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friday.Location = new System.Drawing.Point(476, 270);
            this.friday.Name = "friday";
            this.friday.Size = new System.Drawing.Size(111, 135);
            this.friday.TabIndex = 20;
            this.friday.TabStop = false;
            this.friday.Text = "Friday";
            // 
            // chkFriEvening
            // 
            this.chkFriEvening.AutoSize = true;
            this.chkFriEvening.Enabled = false;
            this.chkFriEvening.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFriEvening.Location = new System.Drawing.Point(17, 106);
            this.chkFriEvening.Name = "chkFriEvening";
            this.chkFriEvening.Size = new System.Drawing.Size(65, 17);
            this.chkFriEvening.TabIndex = 10;
            this.chkFriEvening.Text = "Evening";
            this.chkFriEvening.UseVisualStyleBackColor = true;
            this.chkFriEvening.Click += new System.EventHandler(this.TabPage2Click);
            // 
            // chkFriAfternoon
            // 
            this.chkFriAfternoon.AutoSize = true;
            this.chkFriAfternoon.Enabled = false;
            this.chkFriAfternoon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFriAfternoon.Location = new System.Drawing.Point(17, 80);
            this.chkFriAfternoon.Name = "chkFriAfternoon";
            this.chkFriAfternoon.Size = new System.Drawing.Size(72, 17);
            this.chkFriAfternoon.TabIndex = 9;
            this.chkFriAfternoon.Text = "Afternoon";
            this.chkFriAfternoon.UseVisualStyleBackColor = true;
            this.chkFriAfternoon.Click += new System.EventHandler(this.TabPage2Click);
            // 
            // chkFriMidday
            // 
            this.chkFriMidday.AutoSize = true;
            this.chkFriMidday.Enabled = false;
            this.chkFriMidday.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFriMidday.Location = new System.Drawing.Point(17, 54);
            this.chkFriMidday.Name = "chkFriMidday";
            this.chkFriMidday.Size = new System.Drawing.Size(60, 17);
            this.chkFriMidday.TabIndex = 8;
            this.chkFriMidday.Text = "Midday";
            this.chkFriMidday.UseVisualStyleBackColor = true;
            this.chkFriMidday.Click += new System.EventHandler(this.TabPage2Click);
            // 
            // chkFriMorning
            // 
            this.chkFriMorning.AutoSize = true;
            this.chkFriMorning.Enabled = false;
            this.chkFriMorning.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFriMorning.Location = new System.Drawing.Point(17, 28);
            this.chkFriMorning.Name = "chkFriMorning";
            this.chkFriMorning.Size = new System.Drawing.Size(64, 17);
            this.chkFriMorning.TabIndex = 7;
            this.chkFriMorning.Text = "Morning";
            this.chkFriMorning.UseVisualStyleBackColor = true;
            this.chkFriMorning.Click += new System.EventHandler(this.TabPage2Click);
            // 
            // thursday
            // 
            this.thursday.Controls.Add(this.chkThuEvening);
            this.thursday.Controls.Add(this.chkThuAfternoon);
            this.thursday.Controls.Add(this.chkThuMidday);
            this.thursday.Controls.Add(this.chkThuMorning);
            this.thursday.Enabled = false;
            this.thursday.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thursday.Location = new System.Drawing.Point(359, 270);
            this.thursday.Name = "thursday";
            this.thursday.Size = new System.Drawing.Size(111, 135);
            this.thursday.TabIndex = 19;
            this.thursday.TabStop = false;
            this.thursday.Text = "Thursday";
            // 
            // chkThuEvening
            // 
            this.chkThuEvening.AutoSize = true;
            this.chkThuEvening.Enabled = false;
            this.chkThuEvening.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkThuEvening.Location = new System.Drawing.Point(17, 106);
            this.chkThuEvening.Name = "chkThuEvening";
            this.chkThuEvening.Size = new System.Drawing.Size(65, 17);
            this.chkThuEvening.TabIndex = 10;
            this.chkThuEvening.Text = "Evening";
            this.chkThuEvening.UseVisualStyleBackColor = true;
            this.chkThuEvening.Click += new System.EventHandler(this.TabPage2Click);
            // 
            // chkThuAfternoon
            // 
            this.chkThuAfternoon.AutoSize = true;
            this.chkThuAfternoon.Enabled = false;
            this.chkThuAfternoon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkThuAfternoon.Location = new System.Drawing.Point(17, 80);
            this.chkThuAfternoon.Name = "chkThuAfternoon";
            this.chkThuAfternoon.Size = new System.Drawing.Size(72, 17);
            this.chkThuAfternoon.TabIndex = 9;
            this.chkThuAfternoon.Text = "Afternoon";
            this.chkThuAfternoon.UseVisualStyleBackColor = true;
            this.chkThuAfternoon.Click += new System.EventHandler(this.TabPage2Click);
            // 
            // chkThuMidday
            // 
            this.chkThuMidday.AutoSize = true;
            this.chkThuMidday.Enabled = false;
            this.chkThuMidday.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkThuMidday.Location = new System.Drawing.Point(17, 54);
            this.chkThuMidday.Name = "chkThuMidday";
            this.chkThuMidday.Size = new System.Drawing.Size(60, 17);
            this.chkThuMidday.TabIndex = 8;
            this.chkThuMidday.Text = "Midday";
            this.chkThuMidday.UseVisualStyleBackColor = true;
            this.chkThuMidday.Click += new System.EventHandler(this.TabPage2Click);
            // 
            // chkThuMorning
            // 
            this.chkThuMorning.AutoSize = true;
            this.chkThuMorning.Enabled = false;
            this.chkThuMorning.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkThuMorning.Location = new System.Drawing.Point(17, 28);
            this.chkThuMorning.Name = "chkThuMorning";
            this.chkThuMorning.Size = new System.Drawing.Size(64, 17);
            this.chkThuMorning.TabIndex = 7;
            this.chkThuMorning.Text = "Morning";
            this.chkThuMorning.UseVisualStyleBackColor = true;
            this.chkThuMorning.Click += new System.EventHandler(this.TabPage2Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage3.Controls.Add(this.lblTransport);
            this.tabPage3.Controls.Add(this.lblScience);
            this.tabPage3.Controls.Add(this.lblManu);
            this.tabPage3.Controls.Add(this.lblLaw);
            this.tabPage3.Controls.Add(this.lblIT);
            this.tabPage3.Controls.Add(this.lblHuman);
            this.tabPage3.Controls.Add(this.lblHealth);
            this.tabPage3.Controls.Add(this.lblGeneral);
            this.tabPage3.Controls.Add(this.lblEnergy);
            this.tabPage3.Controls.Add(this.lblDigital);
            this.tabPage3.Controls.Add(this.lblBusiness);
            this.tabPage3.Controls.Add(this.lblArch);
            this.tabPage3.Controls.Add(this.lblAgri);
            this.tabPage3.Controls.Add(this.btnTransport);
            this.tabPage3.Controls.Add(this.btnScience);
            this.tabPage3.Controls.Add(this.btnManu);
            this.tabPage3.Controls.Add(this.btnLaw);
            this.tabPage3.Controls.Add(this.btnIT);
            this.tabPage3.Controls.Add(this.btnHuman);
            this.tabPage3.Controls.Add(this.btnHealth);
            this.tabPage3.Controls.Add(this.btnGeneral);
            this.tabPage3.Controls.Add(this.btnEnergy);
            this.tabPage3.Controls.Add(this.btnDigital);
            this.tabPage3.Controls.Add(this.btnBusiness);
            this.tabPage3.Controls.Add(this.btnArch);
            this.tabPage3.Controls.Add(this.btnAgri);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(868, 512);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Find Session By Interest";
            // 
            // lblTransport
            // 
            this.lblTransport.Location = new System.Drawing.Point(491, 379);
            this.lblTransport.Name = "lblTransport";
            this.lblTransport.Size = new System.Drawing.Size(76, 49);
            this.lblTransport.TabIndex = 25;
            this.lblTransport.Text = "Transportation";
            this.lblTransport.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblScience
            // 
            this.lblScience.Location = new System.Drawing.Point(389, 379);
            this.lblScience.Name = "lblScience";
            this.lblScience.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblScience.Size = new System.Drawing.Size(76, 49);
            this.lblScience.TabIndex = 23;
            this.lblScience.Text = "Science Engineering && Math";
            this.lblScience.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblManu
            // 
            this.lblManu.Location = new System.Drawing.Point(287, 379);
            this.lblManu.Name = "lblManu";
            this.lblManu.Size = new System.Drawing.Size(76, 49);
            this.lblManu.TabIndex = 21;
            this.lblManu.Text = "Manufacturing";
            this.lblManu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblLaw
            // 
            this.lblLaw.Location = new System.Drawing.Point(593, 246);
            this.lblLaw.Name = "lblLaw";
            this.lblLaw.Size = new System.Drawing.Size(76, 49);
            this.lblLaw.TabIndex = 19;
            this.lblLaw.Text = "Law, Public Safety && Security";
            this.lblLaw.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblIT
            // 
            this.lblIT.Location = new System.Drawing.Point(491, 246);
            this.lblIT.Name = "lblIT";
            this.lblIT.Size = new System.Drawing.Size(76, 49);
            this.lblIT.TabIndex = 17;
            this.lblIT.Text = "Information Technology";
            this.lblIT.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblHuman
            // 
            this.lblHuman.Location = new System.Drawing.Point(389, 246);
            this.lblHuman.Name = "lblHuman";
            this.lblHuman.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblHuman.Size = new System.Drawing.Size(76, 49);
            this.lblHuman.TabIndex = 15;
            this.lblHuman.Text = "Human Services && Education";
            this.lblHuman.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblHealth
            // 
            this.lblHealth.Location = new System.Drawing.Point(287, 246);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(76, 49);
            this.lblHealth.TabIndex = 13;
            this.lblHealth.Text = "Health Sciences";
            this.lblHealth.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblGeneral
            // 
            this.lblGeneral.Location = new System.Drawing.Point(185, 246);
            this.lblGeneral.Name = "lblGeneral";
            this.lblGeneral.Size = new System.Drawing.Size(76, 49);
            this.lblGeneral.TabIndex = 11;
            this.lblGeneral.Text = "General Studies && Transfer";
            this.lblGeneral.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblEnergy
            // 
            this.lblEnergy.Location = new System.Drawing.Point(594, 116);
            this.lblEnergy.Name = "lblEnergy";
            this.lblEnergy.Size = new System.Drawing.Size(76, 49);
            this.lblEnergy.TabIndex = 9;
            this.lblEnergy.Text = "Energy";
            this.lblEnergy.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDigital
            // 
            this.lblDigital.Location = new System.Drawing.Point(492, 116);
            this.lblDigital.Name = "lblDigital";
            this.lblDigital.Size = new System.Drawing.Size(76, 49);
            this.lblDigital.TabIndex = 7;
            this.lblDigital.Text = "Digital Arts";
            this.lblDigital.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblBusiness
            // 
            this.lblBusiness.Location = new System.Drawing.Point(390, 116);
            this.lblBusiness.Name = "lblBusiness";
            this.lblBusiness.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblBusiness.Size = new System.Drawing.Size(76, 49);
            this.lblBusiness.TabIndex = 5;
            this.lblBusiness.Text = "Business";
            this.lblBusiness.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblArch
            // 
            this.lblArch.Location = new System.Drawing.Point(288, 116);
            this.lblArch.Name = "lblArch";
            this.lblArch.Size = new System.Drawing.Size(76, 49);
            this.lblArch.TabIndex = 3;
            this.lblArch.Text = "Architecture & Construction";
            this.lblArch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAgri
            // 
            this.lblAgri.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgri.Location = new System.Drawing.Point(186, 116);
            this.lblAgri.Name = "lblAgri";
            this.lblAgri.Size = new System.Drawing.Size(76, 49);
            this.lblAgri.TabIndex = 1;
            this.lblAgri.Text = "Agriculture Food && Natural Resources";
            this.lblAgri.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnTransport
            // 
            this.btnTransport.BackgroundImage = global::CoachConnect.Properties.Resources.transportation_icon;
            this.btnTransport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTransport.Location = new System.Drawing.Point(488, 295);
            this.btnTransport.Name = "btnTransport";
            this.btnTransport.Size = new System.Drawing.Size(80, 80);
            this.btnTransport.TabIndex = 24;
            this.btnTransport.UseVisualStyleBackColor = true;
            this.btnTransport.Click += new System.EventHandler(this.BtnTransportClick);
            // 
            // btnScience
            // 
            this.btnScience.BackgroundImage = global::CoachConnect.Properties.Resources.stem_icon;
            this.btnScience.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnScience.Location = new System.Drawing.Point(386, 295);
            this.btnScience.Name = "btnScience";
            this.btnScience.Size = new System.Drawing.Size(80, 80);
            this.btnScience.TabIndex = 22;
            this.btnScience.UseVisualStyleBackColor = true;
            this.btnScience.Click += new System.EventHandler(this.BtnScienceClick);
            // 
            // btnManu
            // 
            this.btnManu.BackgroundImage = global::CoachConnect.Properties.Resources.manufacturing_icon;
            this.btnManu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnManu.Location = new System.Drawing.Point(284, 295);
            this.btnManu.Name = "btnManu";
            this.btnManu.Size = new System.Drawing.Size(80, 80);
            this.btnManu.TabIndex = 20;
            this.btnManu.UseVisualStyleBackColor = true;
            this.btnManu.Click += new System.EventHandler(this.BtnManuClick);
            // 
            // btnLaw
            // 
            this.btnLaw.BackgroundImage = global::CoachConnect.Properties.Resources.public_safety_icon;
            this.btnLaw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLaw.Location = new System.Drawing.Point(590, 162);
            this.btnLaw.Name = "btnLaw";
            this.btnLaw.Size = new System.Drawing.Size(80, 80);
            this.btnLaw.TabIndex = 18;
            this.btnLaw.UseVisualStyleBackColor = true;
            this.btnLaw.Click += new System.EventHandler(this.BtnLawClick);
            // 
            // btnIT
            // 
            this.btnIT.BackgroundImage = global::CoachConnect.Properties.Resources.it_icon;
            this.btnIT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIT.Location = new System.Drawing.Point(488, 162);
            this.btnIT.Name = "btnIT";
            this.btnIT.Size = new System.Drawing.Size(80, 80);
            this.btnIT.TabIndex = 16;
            this.btnIT.UseVisualStyleBackColor = true;
            this.btnIT.Click += new System.EventHandler(this.BtnITClick);
            // 
            // btnHuman
            // 
            this.btnHuman.BackgroundImage = global::CoachConnect.Properties.Resources.education_icon;
            this.btnHuman.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHuman.Location = new System.Drawing.Point(386, 162);
            this.btnHuman.Name = "btnHuman";
            this.btnHuman.Size = new System.Drawing.Size(80, 80);
            this.btnHuman.TabIndex = 14;
            this.btnHuman.UseVisualStyleBackColor = true;
            this.btnHuman.Click += new System.EventHandler(this.BtnHumanClick);
            // 
            // btnHealth
            // 
            this.btnHealth.BackgroundImage = global::CoachConnect.Properties.Resources.health_science_icon;
            this.btnHealth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHealth.Location = new System.Drawing.Point(284, 162);
            this.btnHealth.Name = "btnHealth";
            this.btnHealth.Size = new System.Drawing.Size(80, 80);
            this.btnHealth.TabIndex = 12;
            this.btnHealth.UseVisualStyleBackColor = true;
            this.btnHealth.Click += new System.EventHandler(this.BthHealthClick);
            // 
            // btnGeneral
            // 
            this.btnGeneral.BackgroundImage = global::CoachConnect.Properties.Resources.general_studies_icon;
            this.btnGeneral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGeneral.Location = new System.Drawing.Point(182, 162);
            this.btnGeneral.Name = "btnGeneral";
            this.btnGeneral.Size = new System.Drawing.Size(80, 80);
            this.btnGeneral.TabIndex = 10;
            this.btnGeneral.UseVisualStyleBackColor = true;
            this.btnGeneral.Click += new System.EventHandler(this.BtnGeneralClick);
            // 
            // btnEnergy
            // 
            this.btnEnergy.BackgroundImage = global::CoachConnect.Properties.Resources.energy_icon;
            this.btnEnergy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEnergy.Location = new System.Drawing.Point(591, 32);
            this.btnEnergy.Name = "btnEnergy";
            this.btnEnergy.Size = new System.Drawing.Size(80, 80);
            this.btnEnergy.TabIndex = 8;
            this.btnEnergy.UseVisualStyleBackColor = true;
            this.btnEnergy.Click += new System.EventHandler(this.BtnEnergyClick);
            // 
            // btnDigital
            // 
            this.btnDigital.BackgroundImage = global::CoachConnect.Properties.Resources.digital_arts_icon;
            this.btnDigital.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDigital.Location = new System.Drawing.Point(489, 32);
            this.btnDigital.Name = "btnDigital";
            this.btnDigital.Size = new System.Drawing.Size(80, 80);
            this.btnDigital.TabIndex = 6;
            this.btnDigital.UseVisualStyleBackColor = true;
            this.btnDigital.Click += new System.EventHandler(this.BtnDigitalClick);
            // 
            // btnBusiness
            // 
            this.btnBusiness.BackgroundImage = global::CoachConnect.Properties.Resources.business_icon;
            this.btnBusiness.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBusiness.Location = new System.Drawing.Point(387, 32);
            this.btnBusiness.Name = "btnBusiness";
            this.btnBusiness.Size = new System.Drawing.Size(80, 80);
            this.btnBusiness.TabIndex = 4;
            this.btnBusiness.UseVisualStyleBackColor = true;
            this.btnBusiness.Click += new System.EventHandler(this.BtnBusinessClick);
            // 
            // btnArch
            // 
            this.btnArch.BackgroundImage = global::CoachConnect.Properties.Resources.archi_icon;
            this.btnArch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnArch.Location = new System.Drawing.Point(285, 32);
            this.btnArch.Name = "btnArch";
            this.btnArch.Size = new System.Drawing.Size(80, 80);
            this.btnArch.TabIndex = 2;
            this.btnArch.UseVisualStyleBackColor = true;
            this.btnArch.Click += new System.EventHandler(this.BtnArchClick);
            // 
            // btnAgri
            // 
            this.btnAgri.BackgroundImage = global::CoachConnect.Properties.Resources.agri_icon;
            this.btnAgri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgri.Location = new System.Drawing.Point(183, 32);
            this.btnAgri.Name = "btnAgri";
            this.btnAgri.Size = new System.Drawing.Size(80, 80);
            this.btnAgri.TabIndex = 0;
            this.btnAgri.UseVisualStyleBackColor = true;
            this.btnAgri.Click += new System.EventHandler(this.BtnAgriClick);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage4.Controls.Add(this.btnClearByTime);
            this.tabPage4.Controls.Add(this.btnScheduleAppointment);
            this.tabPage4.Controls.Add(this.btnSearchByTime);
            this.tabPage4.Controls.Add(this.label49);
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Controls.Add(this.groupBox3);
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(868, 512);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Find Session By Time";
            // 
            // btnClearByTime
            // 
            this.btnClearByTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearByTime.Location = new System.Drawing.Point(770, 167);
            this.btnClearByTime.Name = "btnClearByTime";
            this.btnClearByTime.Size = new System.Drawing.Size(73, 28);
            this.btnClearByTime.TabIndex = 30;
            this.btnClearByTime.Text = "Clear";
            this.btnClearByTime.UseVisualStyleBackColor = true;
            this.btnClearByTime.Click += new System.EventHandler(this.BtnClearByTimeClick);
            // 
            // btnScheduleAppointment
            // 
            this.btnScheduleAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScheduleAppointment.Location = new System.Drawing.Point(742, 458);
            this.btnScheduleAppointment.Name = "btnScheduleAppointment";
            this.btnScheduleAppointment.Size = new System.Drawing.Size(101, 28);
            this.btnScheduleAppointment.TabIndex = 22;
            this.btnScheduleAppointment.Text = "Join Session";
            this.btnScheduleAppointment.UseVisualStyleBackColor = true;
            this.btnScheduleAppointment.Click += new System.EventHandler(this.BtnScheduleAppointmentClick);
            // 
            // btnSearchByTime
            // 
            this.btnSearchByTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchByTime.Location = new System.Drawing.Point(682, 167);
            this.btnSearchByTime.Name = "btnSearchByTime";
            this.btnSearchByTime.Size = new System.Drawing.Size(73, 28);
            this.btnSearchByTime.TabIndex = 21;
            this.btnSearchByTime.Text = "Search";
            this.btnSearchByTime.UseVisualStyleBackColor = true;
            this.btnSearchByTime.Click += new System.EventHandler(this.BtnSearchByTimeClick);
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.Location = new System.Drawing.Point(200, 21);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(445, 16);
            this.label49.TabIndex = 20;
            this.label49.Text = "To find a session, please select the day and day period, then click Search";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridSessionsByTime);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(22, 214);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(821, 216);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Available Sessions";
            // 
            // dataGridSessionsByTime
            // 
            this.dataGridSessionsByTime.AllowUserToAddRows = false;
            this.dataGridSessionsByTime.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridSessionsByTime.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridSessionsByTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridSessionsByTime.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridSessionsByTime.Location = new System.Drawing.Point(6, 19);
            this.dataGridSessionsByTime.Name = "dataGridSessionsByTime";
            this.dataGridSessionsByTime.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridSessionsByTime.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridSessionsByTime.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSessionsByTime.Size = new System.Drawing.Size(809, 191);
            this.dataGridSessionsByTime.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkEvening);
            this.groupBox3.Controls.Add(this.chkMidday);
            this.groupBox3.Controls.Add(this.chkAfternoon);
            this.groupBox3.Controls.Add(this.chkMorning);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(426, 61);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(417, 100);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Day Periods";
            // 
            // chkEvening
            // 
            this.chkEvening.AutoSize = true;
            this.chkEvening.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEvening.Location = new System.Drawing.Point(305, 57);
            this.chkEvening.Name = "chkEvening";
            this.chkEvening.Size = new System.Drawing.Size(51, 17);
            this.chkEvening.TabIndex = 3;
            this.chkEvening.Text = "Night";
            this.chkEvening.UseVisualStyleBackColor = true;
            // 
            // chkMidday
            // 
            this.chkMidday.AutoSize = true;
            this.chkMidday.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMidday.Location = new System.Drawing.Point(137, 57);
            this.chkMidday.Name = "chkMidday";
            this.chkMidday.Size = new System.Drawing.Size(60, 17);
            this.chkMidday.TabIndex = 2;
            this.chkMidday.Text = "Midday";
            this.chkMidday.UseVisualStyleBackColor = true;
            // 
            // chkAfternoon
            // 
            this.chkAfternoon.AutoSize = true;
            this.chkAfternoon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAfternoon.Location = new System.Drawing.Point(215, 57);
            this.chkAfternoon.Name = "chkAfternoon";
            this.chkAfternoon.Size = new System.Drawing.Size(72, 17);
            this.chkAfternoon.TabIndex = 1;
            this.chkAfternoon.Text = "Afternoon";
            this.chkAfternoon.UseVisualStyleBackColor = true;
            // 
            // chkMorning
            // 
            this.chkMorning.AutoSize = true;
            this.chkMorning.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMorning.Location = new System.Drawing.Point(22, 57);
            this.chkMorning.Name = "chkMorning";
            this.chkMorning.Size = new System.Drawing.Size(90, 17);
            this.chkMorning.TabIndex = 0;
            this.chkMorning.Text = "Early Morning";
            this.chkMorning.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkSun);
            this.groupBox1.Controls.Add(this.chkSat);
            this.groupBox1.Controls.Add(this.chkFri);
            this.groupBox1.Controls.Add(this.chkThu);
            this.groupBox1.Controls.Add(this.chkWed);
            this.groupBox1.Controls.Add(this.chkTue);
            this.groupBox1.Controls.Add(this.chkMon);
            this.groupBox1.Controls.Add(this.label34);
            this.groupBox1.Controls.Add(this.label33);
            this.groupBox1.Controls.Add(this.label32);
            this.groupBox1.Controls.Add(this.label31);
            this.groupBox1.Controls.Add(this.label30);
            this.groupBox1.Controls.Add(this.label29);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 100);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Days";
            // 
            // chkSun
            // 
            this.chkSun.AutoSize = true;
            this.chkSun.Location = new System.Drawing.Point(275, 63);
            this.chkSun.Name = "chkSun";
            this.chkSun.Size = new System.Drawing.Size(15, 14);
            this.chkSun.TabIndex = 13;
            this.chkSun.UseVisualStyleBackColor = true;
            // 
            // chkSat
            // 
            this.chkSat.AutoSize = true;
            this.chkSat.Location = new System.Drawing.Point(237, 63);
            this.chkSat.Name = "chkSat";
            this.chkSat.Size = new System.Drawing.Size(15, 14);
            this.chkSat.TabIndex = 12;
            this.chkSat.UseVisualStyleBackColor = true;
            // 
            // chkFri
            // 
            this.chkFri.AutoSize = true;
            this.chkFri.Location = new System.Drawing.Point(198, 63);
            this.chkFri.Name = "chkFri";
            this.chkFri.Size = new System.Drawing.Size(15, 14);
            this.chkFri.TabIndex = 11;
            this.chkFri.UseVisualStyleBackColor = true;
            // 
            // chkThu
            // 
            this.chkThu.AutoSize = true;
            this.chkThu.Location = new System.Drawing.Point(162, 63);
            this.chkThu.Name = "chkThu";
            this.chkThu.Size = new System.Drawing.Size(15, 14);
            this.chkThu.TabIndex = 10;
            this.chkThu.UseVisualStyleBackColor = true;
            // 
            // chkWed
            // 
            this.chkWed.AutoSize = true;
            this.chkWed.Location = new System.Drawing.Point(121, 63);
            this.chkWed.Name = "chkWed";
            this.chkWed.Size = new System.Drawing.Size(15, 14);
            this.chkWed.TabIndex = 9;
            this.chkWed.UseVisualStyleBackColor = true;
            // 
            // chkTue
            // 
            this.chkTue.AutoSize = true;
            this.chkTue.Location = new System.Drawing.Point(79, 63);
            this.chkTue.Name = "chkTue";
            this.chkTue.Size = new System.Drawing.Size(15, 14);
            this.chkTue.TabIndex = 8;
            this.chkTue.UseVisualStyleBackColor = true;
            // 
            // chkMon
            // 
            this.chkMon.AutoSize = true;
            this.chkMon.Location = new System.Drawing.Point(37, 63);
            this.chkMon.Name = "chkMon";
            this.chkMon.Size = new System.Drawing.Size(15, 14);
            this.chkMon.TabIndex = 7;
            this.chkMon.UseVisualStyleBackColor = true;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(267, 28);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(26, 13);
            this.label34.TabIndex = 6;
            this.label34.Text = "Sun";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(74, 28);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(26, 13);
            this.label33.TabIndex = 5;
            this.label33.Text = "Tue";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(195, 28);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(18, 13);
            this.label32.TabIndex = 4;
            this.label32.Text = "Fri";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(231, 28);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(23, 13);
            this.label31.TabIndex = 3;
            this.label31.Text = "Sat";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(113, 28);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(30, 13);
            this.label30.TabIndex = 2;
            this.label30.Text = "Wed";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(156, 28);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(26, 13);
            this.label29.TabIndex = 1;
            this.label29.Text = "Thu";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(31, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Mon";
            // 
            // btnStdLogout
            // 
            this.btnStdLogout.Location = new System.Drawing.Point(710, 576);
            this.btnStdLogout.Name = "btnStdLogout";
            this.btnStdLogout.Size = new System.Drawing.Size(75, 23);
            this.btnStdLogout.TabIndex = 10;
            this.btnStdLogout.Text = "Logout";
            this.btnStdLogout.UseVisualStyleBackColor = true;
            this.btnStdLogout.Click += new System.EventHandler(this.BtnStdLogoutClick);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(791, 576);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(93, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit Program";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExitClick);
            // 
            // FindCoachForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 611);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnStdLogout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindCoachForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Main Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FindCoachFormFormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrShowAppointments)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStdProfile)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panelCoach.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoachProfile)).EndInit();
            this.monday.ResumeLayout(false);
            this.monday.PerformLayout();
            this.sunday.ResumeLayout(false);
            this.sunday.PerformLayout();
            this.tuesday.ResumeLayout(false);
            this.tuesday.PerformLayout();
            this.saturday.ResumeLayout(false);
            this.saturday.PerformLayout();
            this.wednesday.ResumeLayout(false);
            this.wednesday.PerformLayout();
            this.friday.ResumeLayout(false);
            this.friday.PerformLayout();
            this.thursday.ResumeLayout(false);
            this.thursday.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSessionsByTime)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}