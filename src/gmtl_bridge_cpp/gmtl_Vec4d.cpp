/*************** <auto-copyright.pl BEGIN do not edit this line> **************
 *
 * VRJ.NET is (C) Copyright 2004 by Patrick Hartling
 *
 * This library is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Library General Public
 * License as published by the Free Software Foundation; either
 * version 2 of the License, or (at your option) any later version.
 *
 * This library is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
 * Library General Public License for more details.
 *
 * You should have received a copy of the GNU Library General Public
 * License along with this library; if not, write to the
 * Free Software Foundation, Inc., 59 Temple Place - Suite 330,
 * Boston, MA 02111-1307, USA.
 *
 * -----------------------------------------------------------------
 * File:          $RCSfile$
 * Date modified: $Date$
 * Version:       $Revision$
 * -----------------------------------------------------------------
 *
 *************** <auto-copyright.pl END do not edit this line> ***************/

// Generated from Revision: 1.58 of RCSfile: class_cxx.tmpl,v



#include "sharppy.h"
#include <gmtl/Matrix.h>
#include <gmtl/VecBase.h>
#include <gmtl/Vec.h>

extern "C"
{
   // Constructor wrapper.
   SHARPPY_API gmtl::Vec4d* gmtl_Vec_double_4__Vec__()
   {
      gmtl::Vec4d* obj = new gmtl::Vec4d();
      return obj;
   }

   // Constructor wrapper.
   SHARPPY_API gmtl::Vec4d* gmtl_Vec_double_4__Vec__gmtl_Vec4d(const gmtl::Vec4d* p0)
   {
      const gmtl::Vec4d& marshal_p0 = *p0; // Pre-call marshaling for p0
      gmtl::Vec4d* obj = new gmtl::Vec4d(marshal_p0);
      ; // Post-call marshaling for p0
      return obj;
   }

   // Constructor wrapper.
   SHARPPY_API gmtl::Vec4d* gmtl_Vec_double_4__Vec__gmtl_VecBase_double_4(const gmtl::VecBase<double,4>* p0)
   {
      const gmtl::VecBase<double,4>& marshal_p0 = *p0; // Pre-call marshaling for p0
      gmtl::Vec4d* obj = new gmtl::Vec4d(marshal_p0);
      ; // Post-call marshaling for p0
      return obj;
   }

   // Constructor wrapper.
   SHARPPY_API gmtl::Vec4d* gmtl_Vec_double_4__Vec__double_double(const double& p0, const double& p1)
   {
      gmtl::Vec4d* obj = new gmtl::Vec4d(p0, p1);
      return obj;
   }

   // Constructor wrapper.
   SHARPPY_API gmtl::Vec4d* gmtl_Vec_double_4__Vec__double_double_double(const double& p0, const double& p1, const double& p2)
   {
      gmtl::Vec4d* obj = new gmtl::Vec4d(p0, p1, p2);
      return obj;
   }

   // Constructor wrapper.
   SHARPPY_API gmtl::Vec4d* gmtl_Vec_double_4__Vec__double_double_double_double(const double& p0, const double& p1, const double& p2, const double& p3)
   {
      gmtl::Vec4d* obj = new gmtl::Vec4d(p0, p1, p2, p3);
      return obj;
   }

   SHARPPY_API void delete_gmtl_Vec4d(gmtl::Vec4d* self_)
   {
      delete self_;
   }






} // extern "C" for gmtl::Vec4d

