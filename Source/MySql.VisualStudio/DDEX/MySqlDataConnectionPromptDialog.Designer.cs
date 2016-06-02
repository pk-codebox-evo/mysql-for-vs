// Copyright � 2008, 2016, Oracle and/or its affiliates. All rights reserved.
//
// MySQL for Visual Studio is licensed under the terms of the GPLv2
// <http://www.gnu.org/licenses/old-licenses/gpl-2.0.html>, like most 
// MySQL Connectors. There are special exceptions to the terms and 
// conditions of the GPLv2 as it is applied to this software, see the 
// FLOSS License Exception
// <http://www.mysql.com/about/legal/licensing/foss-exception.html>.
//
// This program is free software; you can redistribute it and/or modify 
// it under the terms of the GNU General Public License as published 
// by the Free Software Foundation; version 2 of the License.
//
// This program is distributed in the hope that it will be useful, but 
// WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY 
// or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License 
// for more details.
//
// You should have received a copy of the GNU General Public License along 
// with this program; if not, write to the Free Software Foundation, Inc., 
// 51 Franklin St, Fifth Floor, Boston, MA 02110-1301  USA

namespace MySql.Data.VisualStudio.DDEX
{
  partial class MySqlDataConnectionPromptDialog
  {
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
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.Windows.Forms.Button buttonOK;
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MySqlDataConnectionPromptDialog));
      System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
      System.Windows.Forms.Label label1;
      System.Windows.Forms.Label label3;
      System.Windows.Forms.Button buttonCancel;
      this.savePassword = new System.Windows.Forms.CheckBox();
      this.login = new System.Windows.Forms.TextBox();
      this.password = new System.Windows.Forms.TextBox();
      buttonOK = new System.Windows.Forms.Button();
      tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      label1 = new System.Windows.Forms.Label();
      label3 = new System.Windows.Forms.Label();
      buttonCancel = new System.Windows.Forms.Button();
      tableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // buttonOK
      // 
      buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      resources.ApplyResources(buttonOK, "buttonOK");
      buttonOK.Name = "buttonOK";
      buttonOK.UseVisualStyleBackColor = true;
      buttonOK.Click += new System.EventHandler(this.OkClick);
      // 
      // tableLayoutPanel1
      // 
      resources.ApplyResources(tableLayoutPanel1, "tableLayoutPanel1");
      tableLayoutPanel1.Controls.Add(label1, 0, 1);
      tableLayoutPanel1.Controls.Add(this.savePassword, 1, 2);
      tableLayoutPanel1.Controls.Add(label3, 0, 0);
      tableLayoutPanel1.Controls.Add(this.login, 1, 0);
      tableLayoutPanel1.Controls.Add(this.password, 1, 1);
      tableLayoutPanel1.Name = "tableLayoutPanel1";
      // 
      // label1
      // 
      resources.ApplyResources(label1, "label1");
      label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
      label1.Name = "label1";
      // 
      // savePassword
      // 
      resources.ApplyResources(this.savePassword, "savePassword");
      this.savePassword.Name = "savePassword";
      // 
      // label3
      // 
      resources.ApplyResources(label3, "label3");
      label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
      label3.Name = "label3";
      // 
      // login
      // 
      resources.ApplyResources(this.login, "login");
      this.login.Name = "login";
      this.login.Tag = "User id";
      // 
      // password
      // 
      resources.ApplyResources(this.password, "password");
      this.password.Name = "password";
      this.password.Tag = "Password";
      this.password.UseSystemPasswordChar = true;
      // 
      // buttonCancel
      // 
      buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      resources.ApplyResources(buttonCancel, "buttonCancel");
      buttonCancel.Name = "buttonCancel";
      buttonCancel.UseVisualStyleBackColor = true;
      // 
      // MySqlDataConnectionPromptDialog
      // 
      this.AcceptButton = buttonOK;
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = buttonCancel;
      this.Controls.Add(buttonCancel);
      this.Controls.Add(tableLayoutPanel1);
      this.Controls.Add(buttonOK);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "MySqlDataConnectionPromptDialog";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      tableLayoutPanel1.ResumeLayout(false);
      tableLayoutPanel1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.CheckBox savePassword;
    private System.Windows.Forms.TextBox login;
    private System.Windows.Forms.TextBox password;
  }
}
