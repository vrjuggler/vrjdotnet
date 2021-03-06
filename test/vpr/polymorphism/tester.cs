using System;
using System.Runtime.InteropServices;


public class Tester
{
   [DllImport("handle_obj")]
   private static extern void handleSerializableObject(
      [MarshalAs(UnmanagedType.CustomMarshaler,
                 MarshalTypeRef = typeof(vpr.SerializableObjectMarshaler))] vpr.SerializableObject obj);

   public static void Main()
   {
      Console.WriteLine("[C#] Starting");
      vpr.GUID g = new vpr.GUID();
      Console.WriteLine("[C#] vpr.GUID g created");
      Console.WriteLine("[C#] g before vpr.GUID.generate(): " + g);
      g.generate();
      Console.WriteLine("[C#] g after vpr.GUID.generate(): " + g);

      string guid_str = "a1ede580-8186-4453-86b8-108ecd421da6";

      // Test string marshaling.
      Console.WriteLine("[C#] Constructing vpr.GUID g2 from " + guid_str);
      vpr.GUID g2 = new vpr.GUID(guid_str);
      Console.WriteLine("[C#] g2: " + g2);
      handleSerializableObject(g2);
      Console.WriteLine("[C#] After handleSerialiazableObject() call");

      vpr.GUID g3 = new vpr.GUID(guid_str);
      if ( ! g2.Equals(g3) )
      {
         throw new Exception("[C#] vpr.GUID equality test failed");
      }
   }
}
