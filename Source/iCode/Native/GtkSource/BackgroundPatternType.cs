// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

using System;
using System.Runtime.InteropServices;

namespace iCode.Native.GtkSource {
	#region Autogenerated code
	[GLib.GType (typeof (GtkSource.BackgroundPatternTypeGType))]
	public enum BackgroundPatternType {

		None = 0,
		Grid = 1,
	}

	internal class BackgroundPatternTypeGType {
		[DllImport ("gtksourceview-4", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_source_background_pattern_type_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gtk_source_background_pattern_type_get_type ());
			}
		}
	}
#endregion
}