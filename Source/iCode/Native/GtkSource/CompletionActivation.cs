// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

using System;
using System.Runtime.InteropServices;

namespace iCode.Native.GtkSource {
	#region Autogenerated code
	[Flags]
	[GLib.GType (typeof (GtkSource.CompletionActivationGType))]
	public enum CompletionActivation {

		None = 0,
		Interactive = 1,
		UserRequested = 2,
	}

	internal class CompletionActivationGType {
		[DllImport ("gtksourceview-4", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_source_completion_activation_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gtk_source_completion_activation_get_type ());
			}
		}
	}
#endregion
}