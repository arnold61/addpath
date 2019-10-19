/*
** ----------------------------------------------------------------------------
** Filename: addpath.cs
** Version:  1
** Revision: 0
** Release:  2019-10-19
** Author:   Arnold Sebr <arnold@sebr.name>
** ----------------------------------------------------------------------------
** (C) Copyright 2019 by Arnold Sebr. All rights reserved.
** ----------------------------------------------------------------------------
*/
/*
** includes
*/
using System ;
using System.Collections.Generic ;
using System.Text ;
using System.Text.RegularExpressions ;
using Microsoft.Win32 ;
/*
** AddPath Program Main
*/
namespace AddPath {
 class Program {
  static void Main( string[ ] args ) {
   string RegKey = Registry.LocalMachine + @"\SYSTEM\CurrentControlSet\Control\Session Manager\Environment" ;
   Console.WriteLine( "AddPath, version 1.0, (C) Copyright 2019 by Arnold Sebr. All rights reserved.\n" ) ;
   if( args.Length == 0 ) {
    Console.WriteLine( "usage: AddPath <directory>\n" ) ;
    Console.WriteLine( "Appends <directory> to the environment path variable." ) ;
    Console.WriteLine( "f.e.: AddPath D:\\my\\new\\path" ) ;
    Environment.Exit( 0 ) ;
    }
   string newPath = args[ 0 ] ;
   if( !Regex.IsMatch( newPath , "^(([a-zA-Z]\\:)|(\\\\))(\\\\{1}|((\\\\{1})[^\\\\]([^/:*?<>\"|]*))+)$" , RegexOptions.IgnoreCase ) ) {
    Console.WriteLine( "error: invalid directory: " + newPath ) ;
    Environment.Exit( 0 ) ;
    }
   try {
    string oldPath = (string) Registry.GetValue( RegKey , "Path" , string.Empty ) ;
    Registry.SetValue( RegKey , "Path" , string.IsNullOrEmpty( oldPath) ? newPath : oldPath + ';' + newPath , RegistryValueKind.ExpandString ) ;
    }
   catch( Exception ex ) {
    Console.WriteLine( "error: " + ex.Message ) ;
    }
   }
  }
 }
/*
** EOF
*/
 