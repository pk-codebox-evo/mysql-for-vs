﻿// Copyright © 2014 Oracle and/or its affiliates. All rights reserved.
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
using Xunit;

namespace MySql.Debugger.Tests
{
  public class TestUtils
  {
    public static readonly string CONNECTION_STRING = "server=localhost;User Id=root;database=test;Port=3305;Allow User Variables=true;Pooling=false;Allow Zero DateTime=true;";
    public static readonly string CONNECTION_STRING_SAKILA = "server=localhost;User Id=root;database=sakila;Port=3305;Allow User Variables=true;Pooling=false;Allow Zero DateTime=true;";
    public static readonly string CONNECTION_STRING_WITHOUT_DB = "server=localhost;User Id=root;Port=3305;Allow User Variables=true;Pooling=false;Allow Zero DateTime=true;";
  }

  public class SteppingTraceInfo
  {
    public SteppingTraceInfo(string RoutineName, int Line, int Column)
    {
      this.RoutineName = RoutineName;
      this.Line = Line;
      this.Column = Column;
    }

    public string RoutineName { get; set; }
    public int Line { get; set; }
    public int Column { get; set; }
  }

  public class SteppingTraceInfoList : List<SteppingTraceInfo>
  {
    private int i = 0;

    public SteppingTraceInfoList(SteppingTraceInfo[] a)
    {
      this.AddRange(a);
    }

    public void AssertBreakpoint(Breakpoint bp)
    {
      SteppingTraceInfo sti = this[i++];
      Assert.Equal(sti.RoutineName, bp.RoutineName);
      Assert.Equal(sti.Line, bp.Line);
      Assert.Equal(sti.Column, bp.StartColumn);
    }

    public void AssertFinal()
    {
      Assert.Equal(this.Count, i);
    }
  }
}
