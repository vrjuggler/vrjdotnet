// VRJ.NET is (C) Copyright 2004-2007 by Patrick Hartling
// Distributed under the GNU Lesser General Public License 2.1.  (See
// accompanying file COPYING.txt or http://www.gnu.org/copyleft/lesser.txt)

// Generated from Revision: 1.63 of RCSfile: class_cxx.tmpl,v



#include "sharppy.h"
#include <gmtl/Matrix.h>

extern "C"
{
   // Constructor wrapper.
   SHARPPY_API gmtl::Matrix44f* gmtl_Matrix_float_4_4__Matrix__0()
   {
      gmtl::Matrix44f* obj = new gmtl::Matrix44f();
      return obj;
   }

   // Constructor wrapper.
   SHARPPY_API gmtl::Matrix44f* gmtl_Matrix_float_4_4__Matrix__gmtl_Matrix44f1(const gmtl::Matrix44f* p0)
   {
      const gmtl::Matrix44f& marshal_p0 = *p0;
      gmtl::Matrix44f* obj = new gmtl::Matrix44f(marshal_p0);
      return obj;
   }

   SHARPPY_API void delete_gmtl_Matrix44f(gmtl::Matrix44f* self_)
   {
      delete self_;
   }


   // Wrapper for non-virtual method gmtl::Matrix<float,4,4>::set()
   SHARPPY_API void gmtl_Matrix_float_4_4__set__float_float_float_float_float_float_float_float_float_float_float_float_float_float_float_float16(gmtl::Matrix44f* self_, float p0, float p1, float p2, float p3, float p4, float p5, float p6, float p7, float p8, float p9, float p10, float p11, float p12, float p13, float p14, float p15)
   {
      self_->set(p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15);
   }


   // Wrapper for non-virtual method gmtl::Matrix<float,4,4>::set()
   SHARPPY_API void gmtl_Matrix_float_4_4__set__float1(gmtl::Matrix44f* self_, const float* p0)
   {
      self_->set(p0);
   }


   // Wrapper for non-virtual method gmtl::Matrix<float,4,4>::setTranspose()
   SHARPPY_API void gmtl_Matrix_float_4_4__setTranspose__float1(gmtl::Matrix44f* self_, const float* p0)
   {
      self_->setTranspose(p0);
   }


   // Wrapper for non-virtual method gmtl::Matrix<float,4,4>::getData()
   SHARPPY_API void gmtl_Matrix_float_4_4__getData__0(gmtl::Matrix44f* self_, float* arrayHolder)
   {
      const float* temp_array;
      temp_array = self_->getData();
      for ( int i = 0; i < 16; ++i )
      {
         arrayHolder[i] = temp_array[i];
      }
   }


   // Wrapper for non-virtual method gmtl::Matrix<float,4,4>::isError()
   SHARPPY_API bool gmtl_Matrix_float_4_4__isError__0(gmtl::Matrix44f* self_)
   {
      bool result;
      result = self_->isError();
      return result;
   }


   // Wrapper for non-virtual method gmtl::Matrix<float,4,4>::setError()
   SHARPPY_API void gmtl_Matrix_float_4_4__setError__0(gmtl::Matrix44f* self_)
   {
      self_->setError();
   }


} // extern "C" for gmtl::Matrix44f

// Nested class gmtl::Matrix44f::RowAccessor.
extern "C"
{
   SHARPPY_API void delete_gmtl_Matrix44f_RowAccessor(gmtl::Matrix44f::RowAccessor* self_)
   {
      delete self_;
   }

} // extern "C" for gmtl::Matrix44f::RowAccessor


// Nested class gmtl::Matrix44f::ConstRowAccessor.
extern "C"
{
   SHARPPY_API void delete_gmtl_Matrix44f_ConstRowAccessor(gmtl::Matrix44f::ConstRowAccessor* self_)
   {
      delete self_;
   }

} // extern "C" for gmtl::Matrix44f::ConstRowAccessor



