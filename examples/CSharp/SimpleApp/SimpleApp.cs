/*************** <auto-copyright.pl BEGIN do not edit this line> **************
 *
 * VR Juggler is (C) Copyright 1998-2002 by Iowa State University
 *
 * Original Authors:
 *   Allen Bierbaum, Christopher Just,
 *   Patrick Hartling, Kevin Meinert,
 *   Carolina Cruz-Neira, Albert Baker
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

using System;
using Tao.OpenGl;


/// <summary>
/// Summary description for SimpleApp.
/// </summary>
public class SimpleApp : vrj.GlApp
{
   public static void Main(String[] args)
   {
      vrj.Kernel kernel = vrj.Kernel.instance();

      foreach (String arg in args)
      {
         kernel.loadConfigFile(arg);
      }

      kernel.start();
      kernel.setApplication(new SimpleApp());
      kernel.waitForKernelStop();
   }

   public SimpleApp() : base()
   {
   }

   public override void init()
   {
      Console.WriteLine("SimpleApp.init()");
      mButton0.init("VJButton0");
      mButton1.init("VJButton1");
   }

   public override void contextInit()
   {
      Console.WriteLine("SimpleApp.contextInit()");
      initGLState();
   }

   public override void preFrame()
   {
      Console.WriteLine("SimpleApp.preFrame()");

      if ( mButton0.getProxy().getData() != (int) gadget.Digital.State.OFF )
      {
         Console.WriteLine("Button 0 pressed");
      }

      if ( mButton1.getProxy().getData() != (int) gadget.Digital.State.OFF )
      {
         Console.WriteLine("Button 1 pressed");
      }
   }

   public override void bufferPreDraw()
   {
      Console.WriteLine("SimpleApp.bufferPreDraw()");
      Gl.glClearColor(0.0f, 0.0f, 0.0f, 0.0f);
      Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
   }

   public override void draw()
   {
      Console.WriteLine("SimpleApp.draw()");
      Gl.glClear(Gl.GL_DEPTH_BUFFER_BIT);

      // --- Setup for drawing --- //
      Gl.glMatrixMode(Gl.GL_MODELVIEW);

      // -- Get Wand matrix --- //
      //         Matrix44f wand_matrix;
      //         wand_matrix = *(mWand->getData());

      // -- Create box offset matrix -- //
/*
      Matrix44f box_offset;
      const EulerAngleXYZf euler_ang(Math::deg2Rad(-90.0f),
                                     Math::deg2Rad(0.0f),
                                     Math::deg2Rad(0.0f));
      box_offset = makeRot<Matrix44f>(euler_ang);
      setTrans(box_offset, Vec3f(0.0f, 1.0f, 0.0f));
*/

      // --- Create a color for the wand --- //
      float[] wand_color = { 0.7f, 0.7f, 0.7f };

      Gl.glPushMatrix();

      // --- Draw the box --- //
      Gl.glPushMatrix();
//      Gl.glMultMatrixf(box_offset.mData);    // Push the wand offset matrix on the stack
      Gl.glColor3fv(wand_color);
      Gl.glScalef(0.5f, 0.5f, 0.5f);
      drawCube();
      Gl.glPopMatrix();

      // Draw a coordinate axis "on" the box
      Gl.glLineWidth(5.0f);
      Gl.glDisable(Gl.GL_LIGHTING);
      Gl.glPushMatrix();
      /*
         Gl.glMultMatrixf(box_offset.mData);    // Goto wand position
         Vec3f x_axis(7.0f,0.0f,0.0f);
         Vec3f y_axis(0.0f, 7.0f, 0.0f);
         Vec3f z_axis(0.0f, 0.0f, 7.0f);
         Vec3f origin(0.0f, 0.0f, 0.0f);

         Gl.glBegin(Gl.GL_LINES);
            Gl.glColor3f(1.0f, 0.0f, 0.0f);
            Gl.glVertex3fv(origin.mData);
            Gl.glVertex3fv(x_axis.mData);

            Gl.glColor3f(0.0f, 1.0f, 0.0f);
            Gl.glVertex3fv(origin.mData);
            Gl.glVertex3fv(y_axis.mData);

            Gl.glColor3f(0.0f, 0.0f, 1.0f);
            Gl.glVertex3fv(origin.mData);
            Gl.glVertex3fv(z_axis.mData);
         Gl.glEnd();
      */
      Gl.glPopMatrix();
      Gl.glEnable(Gl.GL_LIGHTING);
      Gl.glPopMatrix();
   }

   private void initGLState()
   {
      float[] light0_ambient  = { 0.1f, 0.1f,  0.1f,  1.0f };
      float[] light0_diffuse  = { 0.8f, 0.8f,  0.8f,  1.0f };
      float[] light0_specular = { 1.0f, 1.0f,  1.0f,  1.0f };
      float[] light0_position = { 0.0f, 0.75f, 0.75f, 0.0f };

      float[] mat_ambient   = { 0.7f, 0.7f, 0.7f, 1.0f };
      float[] mat_diffuse   = { 1.0f, 0.5f, 0.8f, 1.0f };
      float[] mat_specular  = { 1.0f, 1.0f, 1.0f, 1.0f };
      float[] mat_shininess = { 50.0f };
      float[] mat_emission  = { 1.0f, 1.0f, 1.0f, 1.0f };
      float[] no_mat        = { 0.0f, 0.0f, 0.0f, 1.0f };

      Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_AMBIENT, light0_ambient);
      Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_DIFFUSE, light0_diffuse);
      Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_SPECULAR, light0_specular);
      Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_POSITION, light0_position);

      Gl.glMaterialfv(Gl.GL_FRONT, Gl.GL_AMBIENT, mat_ambient);
      Gl.glMaterialfv(Gl.GL_FRONT, Gl.GL_DIFFUSE, mat_diffuse);
      Gl.glMaterialfv(Gl.GL_FRONT, Gl.GL_SPECULAR, mat_specular);
      Gl.glMaterialfv(Gl.GL_FRONT, Gl.GL_SHININESS, mat_shininess);
      Gl.glMaterialfv(Gl.GL_FRONT, Gl.GL_EMISSION, no_mat);

      Gl.glEnable(Gl.GL_DEPTH_TEST);
      Gl.glEnable(Gl.GL_NORMALIZE);
      Gl.glEnable(Gl.GL_LIGHTING);
      Gl.glEnable(Gl.GL_LIGHT0);
      Gl.glEnable(Gl.GL_COLOR_MATERIAL);
      Gl.glShadeModel(Gl.GL_SMOOTH);
   }

   private void drawCube()
   {
      drawBox(-0.5f, 0.5f, -0.5f, 0.5f, -0.5f, 0.5f, Gl.GL_QUADS);
   }

   private void drawBox(double x0, double x1, double y0, double y1, double z0,
                        double z1, int type)
   {
      double[,] n =
         { {-1.0, 0.0, 0.0}, {0.0, 1.0, 0.0}, {1.0, 0.0, 0.0},
           {0.0, -1.0, 0.0}, {0.0, 0.0, 1.0}, {0.0, 0.0, -1.0} };
      int[,] faces =
         { {0, 1, 2, 3}, {3, 2, 6, 7}, {7, 6, 5, 4},
           {4, 5, 1, 0}, {5, 6, 2, 1}, {7, 4, 0, 3} };
      double[,] v = new double[8,3];
      double tmp;

      if (x0 > x1)
      {
         tmp = x0; x0 = x1; x1 = tmp;
      }
      if (y0 > y1)
      {
         tmp = y0; y0 = y1; y1 = tmp;
      }
      if (z0 > z1)
      {
         tmp = z0; z0 = z1; z1 = tmp;
      }

      v[0, 0] = v[1, 0] = v[2, 0] = v[3, 0] = x0;
      v[4, 0] = v[5, 0] = v[6, 0] = v[7, 0] = x1;
      v[0, 1] = v[1, 1] = v[4, 1] = v[5, 1] = y0;
      v[2, 1] = v[3, 1] = v[6, 1] = v[7, 1] = y1;
      v[0, 2] = v[3, 2] = v[4, 2] = v[7, 2] = z0;
      v[1, 2] = v[2, 2] = v[5, 2] = v[6, 2] = z1;
 
      for ( int i = 0; i < 6; ++i )
      {
         Gl.glBegin(type);
            Gl.glNormal3d(n[i, 0], n[i, 1], n[i, 2]);
            Gl.glVertex3d(v[faces[i, 0], 0], v[faces[i, 0], 1],
                          v[faces[i, 0], 2]);
            Gl.glNormal3d(n[i, 0], n[i, 1], n[i, 2]);
            Gl.glVertex3d(v[faces[i, 1], 0], v[faces[i, 1], 1],
                          v[faces[i, 1], 2]);
            Gl.glNormal3d(n[i, 0], n[i, 1], n[i, 2]);
            Gl.glVertex3d(v[faces[i, 2], 0], v[faces[i, 2], 1],
                          v[faces[i, 2], 2]);
            Gl.glNormal3d(n[i, 0], n[i, 1], n[i, 2]);
            Gl.glVertex3d(v[faces[i, 3], 0], v[faces[i, 3], 1],
                          v[faces[i, 3], 2]);
         Gl.glEnd();
      }
   }

   private gadget.DigitalInterface mButton0 = new gadget.DigitalInterface();
   private gadget.DigitalInterface mButton1 = new gadget.DigitalInterface();
}