﻿using System;
using System.Windows.Forms;
using UAS_DB_PamerYuk.F3_Chat;

namespace UAS_DB_PamerYuk.F1_UserManager
{
    public partial class LoginUC : UserControl
    {
        private readonly UserManagerService service;
        private readonly MainForm mainForm;

        public LoginUC(UserManagerService service, MainForm mainForm)
        {
            InitializeComponent();
            this.service = service;
            this.mainForm = mainForm;
        }

        private void LoginUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
