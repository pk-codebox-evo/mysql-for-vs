﻿// Copyright © 2015, Oracle and/or its affiliates. All rights reserved.
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

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MySql.VisualStudio.Tests
{
  /// <summary>
  /// Class to setup the environment used by the TablexShellTests test class
  /// </summary>
  public class SetUpXShell : SetUp, IDisposable
  {
    /// <summary>
    /// Name for the DB used by the tests
    /// </summary>
    const string _dbName = "xshellTest";

    /// <summary>
    /// Initializes a new instance of SetUpXShell class
    /// </summary>
    public SetUpXShell()
      : base()
    {
      CreateData();
    }

    /// <summary>
    /// Setup the DB environment
    /// </summary>
    internal new void CreateData()
    {
      Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("MySql.VisualStudio.Tests.Properties.SetupXShell.sql");
      StreamReader sr = new StreamReader(stream);
      StringBuilder sql = new StringBuilder(sr.ReadToEnd());
      sr.Close();
      sql.Replace("{0}", _dbName);
      ExecuteSQLAsRoot(sql.ToString());
    }

    /// <summary>
    /// Clean Server instance before exit
    /// </summary>
    internal new void Dispose()
    {
      var sql = string.Format("DROP DATABASE IF EXISTS {0};", _dbName);
      ExecuteSQLAsRoot(sql);
    }
  }
}