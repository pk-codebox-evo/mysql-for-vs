﻿// Copyright © 2013, Oracle and/or its affiliates. All rights reserved.
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
using System.Diagnostics;
using System.Linq;
using System.Text;
using Antlr.Runtime;
using Antlr.Runtime.Tree;
using Xunit;


namespace MySql.Parser.Tests
{
  public class FlowControlStmts
  {
    [Fact]
    public void IfElse()
    {
      StringBuilder sb;
      string sql = @"CREATE FUNCTION VerboseCompare (n INT, m INT)
  RETURNS VARCHAR(50)

  BEGIN
    DECLARE s VARCHAR(50);

    IF ( n = m ) THEN SET s = 'equals';
    ELSE
      IF ( n > m ) THEN SET s = 'greater';
      ELSE SET s = 'less';
      END IF;

      SET s = CONCAT('is ', s, ' than');
    END IF;

    SET s = CONCAT(n, ' ', s, ' ', m, '.');

    RETURN s;
  END";
      MySQL51Parser.program_return r = Utility.ParseSql(sql, false, out sb);
    }

    [Fact]
    public void Repeat()
    {
      StringBuilder sb;
      string sql = @"CREATE PROCEDURE dorepeat(p1 INT)
     BEGIN
       SET @x = 0;
       REPEAT
         SET @x = @x + 1;
       UNTIL ( @x > p1 ) END REPEAT;
     END";
      MySQL51Parser.program_return r = Utility.ParseSql(sql, false, out sb);
    }
  }
}
