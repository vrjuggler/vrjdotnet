dnl ************* <auto-copyright.pl BEGIN do not edit this line> *************
dnl Doozer++ is (C) Copyright 2000-2004 by Iowa State University
dnl
dnl Original Author:
dnl   Patrick Hartling
dnl
dnl This library is free software; you can redistribute it and/or
dnl modify it under the terms of the GNU Library General Public
dnl License as published by the Free Software Foundation; either
dnl version 2 of the License, or (at your option) any later version.
dnl
dnl This library is distributed in the hope that it will be useful,
dnl but WITHOUT ANY WARRANTY; without even the implied warranty of
dnl MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
dnl Library General Public License for more details.
dnl
dnl You should have received a copy of the GNU Library General Public
dnl License along with this library; if not, write to the
dnl Free Software Foundation, Inc., 59 Temple Place - Suite 330,
dnl Boston, MA 02111-1307, USA.
dnl
dnl -----------------------------------------------------------------
dnl File:          audiere.m4,v
dnl Date modified: 2004/07/02 11:35:55
dnl Version:       1.4
dnl -----------------------------------------------------------------
dnl ************** <auto-copyright.pl END do not edit this line> **************

dnl ===========================================================================
dnl Find the target host's Audiere installation if one exists.
dnl ---------------------------------------------------------------------------
dnl Macros:
dnl     DPP_HAVE_AUDIERE - Determine if the target system has Audiere
dnl                        installed.
dnl
dnl Command-line options added:
dnl     --with-audiere - Give the root directory of the Audiere implementation
dnl                      installation.
dnl
dnl Variables defined:
dnl     AUDIERE          - Do we have audiere on the system?
dnl     AUDIERE_ROOT     - The Audiere installation directory.
dnl     LIBAUDIERE       - The list of libraries to link for Audiere
dnl                        appliations.
dnl     AUDIERE_INCLUDES - Extra include path for the Audiere header directory.
dnl     AUDIERE_LDFLAGS  - Extra linker flags for the Audiere library directory.
dnl ===========================================================================

dnl audiere.m4,v 1.4 2004/07/02 11:35:55 patrickh Exp

dnl ---------------------------------------------------------------------------
dnl Determine if the target system has Audiere installed.  This adds the
dnl command-line argument --with-audiere.
dnl
dnl Usage:
dnl     DPP_HAVE_AUDIERE(audiere-path [, action-if-found [, action-if-not-found]])
dnl
dnl Arguments:
dnl     audiere-path        - The default directory where the Audiere
dnl                           installation is rooted.  This directory should
dnl                           contain an include directory with the Audiere
dnl                           headers and a lib (with appropriate bit suffix)
dnl                           directory with the Audiere libraries.  The value
dnl                           given is used as the default value of the
dnl                           --with-audiere command-line argument.
dnl     action-if-found     - The action to take if Audiere is found.  This
dnl                           argument is optional.
dnl     action-if-not-found - The action to take if Audiere is not found.
dnl                           This argument is optional.
dnl ---------------------------------------------------------------------------
AC_DEFUN([DPP_HAVE_AUDIERE],
[
   AC_REQUIRE([DPP_SYSTEM_SETUP])

   dnl initialize returned data...
   AUDIERE='no'
   LIBAUDIERE=''
   AUDIERE_INCLUDES=''
   AUDIERE_LDFLAGS=''
   dpp_have_audiere='no'

   AC_ARG_WITH(audiere,
               [  --with-audiere=<PATH>   Audiere installation directory  [default=$1]],
               [AUDIERE_ROOT="$withval"], [AUDIERE_ROOT=$1])

   dnl Save these values in case they need to be restored later.
   dpp_save_CXXFLAGS="$CXXFLAGS"
   dpp_save_CPPFLAGS="$CPPFLAGS"
   dpp_save_LDFLAGS="$LDFLAGS"

   dnl Add the user-specified Audiere installation directory to these
   dnl paths.  Ensure that the /usr dir is not included multiple times
   dnl if $AUDIERE_ROOT is "/usr"
   if test "x$AUDIERE_ROOT" != "x/usr" ; then
      CPPFLAGS="$CPPFLAGS -I$AUDIERE_ROOT/include"
      LDFLAGS="-L$AUDIERE_ROOT/lib $LDFLAGS $ABI_FLAGS"
   fi

   CXXFLAGS="$CXXFLAGS $ABI_FLAGS"

   dpp_save_LIBS="$LIBS"

   if test "x$PLATFORM" = "xIRIX" ; then
      LIB_AUDIO="-laudio"
   fi

   DPP_LANG_SAVE
   DPP_LANG_CPLUSPLUS

   AC_CHECK_LIB([audiere], [AdrOpenDevice],
      [AC_CHECK_HEADER([audiere.h], [dpp_have_audiere='yes'],
                       [dpp_have_audiere='no'])],
      [dpp_have_audiere='no'], [$LIB_AUDIO])

   DPP_LANG_RESTORE

   dnl this is necessary because AC_CHECK_LIB() adds -lauidere to
   dnl $LIBS.  We want to do that ourselves later.
   LIBS="$dpp_save_LIBS"

   if test "x$dpp_have_audiere" = "xyes" ; then
      ifelse([$2], , :, [$2])
   else
      ifelse([$3], , :, [$3])
   fi

   dnl If Audiere API files were found, define this extra stuff that may be
   dnl helpful in some Makefiles
   if test "x$dpp_have_audiere" = "xyes" ; then
      LIBAUDIERE="-laudiere $LIB_AUDIO -lm"
      AUDIERE_INCLUDES="-I$AUDIERE_ROOT/include"
      AUDIERE_LDFLAGS="-L$AUDIERE_ROOT/lib"
      AUDIERE='yes'
   fi

   CXXFLAGS="$dpp_save_CXXFLAGS"
   CPPFLAGS="$dpp_save_CPPFLAGS"
   LDFLAGS="$dpp_save_LDFLAGS"

   AC_SUBST(AUDIERE)
   AC_SUBST(AUDIERE_ROOT)
   AC_SUBST(LIBAUDIERE)
   AC_SUBST(AUDIERE_INCLUDES)
   AC_SUBST(AUDIERE_LDFLAGS)
])
