// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class SourceUndoManagerAdapter : GLib.GInterfaceAdapter, Gtk.ISourceUndoManager {

		[StructLayout (LayoutKind.Sequential)]
		struct GtkSourceUndoManagerIface {
			public CanUndoNativeDelegate CanUndo;
			public CanRedoNativeDelegate CanRedo;
			public UndoNativeDelegate Undo;
			public RedoNativeDelegate Redo;
			public BeginNotUndoableActionNativeDelegate BeginNotUndoableAction;
			public EndNotUndoableActionNativeDelegate EndNotUndoableAction;
			public CanUndoChangedNativeDelegate CanUndoChanged;
			public CanRedoChangedNativeDelegate CanRedoChanged;
		}

		static GtkSourceUndoManagerIface iface;

		static SourceUndoManagerAdapter ()
		{
			GLib.GType.Register (_gtype, typeof (SourceUndoManagerAdapter));
			iface.CanUndo = new CanUndoNativeDelegate (CanUndo_cb);
			iface.CanRedo = new CanRedoNativeDelegate (CanRedo_cb);
			iface.Undo = new UndoNativeDelegate (Undo_cb);
			iface.Redo = new RedoNativeDelegate (Redo_cb);
			iface.BeginNotUndoableAction = new BeginNotUndoableActionNativeDelegate (BeginNotUndoableAction_cb);
			iface.EndNotUndoableAction = new EndNotUndoableActionNativeDelegate (EndNotUndoableAction_cb);
			iface.CanUndoChanged = new CanUndoChangedNativeDelegate (CanUndoChanged_cb);
			iface.CanRedoChanged = new CanRedoChangedNativeDelegate (CanRedoChanged_cb);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool CanUndoNativeDelegate (IntPtr inst);

		static bool CanUndo_cb (IntPtr inst)
		{
			try {
				ISourceUndoManagerImplementor __obj = GLib.Object.GetObject (inst, false) as ISourceUndoManagerImplementor;
				bool __result;
				__result = __obj.CanUndo ();
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool CanRedoNativeDelegate (IntPtr inst);

		static bool CanRedo_cb (IntPtr inst)
		{
			try {
				ISourceUndoManagerImplementor __obj = GLib.Object.GetObject (inst, false) as ISourceUndoManagerImplementor;
				bool __result;
				__result = __obj.CanRedo ();
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void UndoNativeDelegate (IntPtr inst);

		static void Undo_cb (IntPtr inst)
		{
			try {
				ISourceUndoManagerImplementor __obj = GLib.Object.GetObject (inst, false) as ISourceUndoManagerImplementor;
				__obj.Undo ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void RedoNativeDelegate (IntPtr inst);

		static void Redo_cb (IntPtr inst)
		{
			try {
				ISourceUndoManagerImplementor __obj = GLib.Object.GetObject (inst, false) as ISourceUndoManagerImplementor;
				__obj.Redo ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void BeginNotUndoableActionNativeDelegate (IntPtr inst);

		static void BeginNotUndoableAction_cb (IntPtr inst)
		{
			try {
				ISourceUndoManagerImplementor __obj = GLib.Object.GetObject (inst, false) as ISourceUndoManagerImplementor;
				__obj.BeginNotUndoableAction ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void EndNotUndoableActionNativeDelegate (IntPtr inst);

		static void EndNotUndoableAction_cb (IntPtr inst)
		{
			try {
				ISourceUndoManagerImplementor __obj = GLib.Object.GetObject (inst, false) as ISourceUndoManagerImplementor;
				__obj.EndNotUndoableAction ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void CanUndoChangedNativeDelegate (IntPtr inst);

		static void CanUndoChanged_cb (IntPtr inst)
		{
			try {
				ISourceUndoManagerImplementor __obj = GLib.Object.GetObject (inst, false) as ISourceUndoManagerImplementor;
				__obj.CanUndoChanged ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void CanRedoChangedNativeDelegate (IntPtr inst);

		static void CanRedoChanged_cb (IntPtr inst)
		{
			try {
				ISourceUndoManagerImplementor __obj = GLib.Object.GetObject (inst, false) as ISourceUndoManagerImplementor;
				__obj.CanRedoChanged ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		static int class_offset = 2 * IntPtr.Size;

		static void Initialize (IntPtr ptr, IntPtr data)
		{
			IntPtr ifaceptr = new IntPtr (ptr.ToInt64 () + class_offset);
			GtkSourceUndoManagerIface native_iface = (GtkSourceUndoManagerIface) Marshal.PtrToStructure (ifaceptr, typeof (GtkSourceUndoManagerIface));
			native_iface.CanUndo = iface.CanUndo;
			native_iface.CanRedo = iface.CanRedo;
			native_iface.Undo = iface.Undo;
			native_iface.Redo = iface.Redo;
			native_iface.BeginNotUndoableAction = iface.BeginNotUndoableAction;
			native_iface.EndNotUndoableAction = iface.EndNotUndoableAction;
			native_iface.CanUndoChanged = iface.CanUndoChanged;
			native_iface.CanRedoChanged = iface.CanRedoChanged;
			Marshal.StructureToPtr (native_iface, ifaceptr, false);
		}

		GLib.Object implementor;

		public SourceUndoManagerAdapter ()
		{
			InitHandler = new GLib.GInterfaceInitHandler (Initialize);
		}

		public SourceUndoManagerAdapter (ISourceUndoManagerImplementor implementor)
		{
			if (implementor == null)
				throw new ArgumentNullException ("implementor");
			else if (!(implementor is GLib.Object))
				throw new ArgumentException ("implementor must be a subclass of GLib.Object");
			this.implementor = implementor as GLib.Object;
		}

		public SourceUndoManagerAdapter (IntPtr handle)
		{
			if (!_gtype.IsInstance (handle))
				throw new ArgumentException ("The gobject doesn't implement the GInterface of this adapter", "handle");
			implementor = GLib.Object.GetObject (handle);
		}

		[DllImport("gtksourceview-4", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_source_undo_manager_get_type();

		private static GLib.GType _gtype = new GLib.GType (gtk_source_undo_manager_get_type ());

		public static GLib.GType GType {
			get {
				return _gtype;
			}
		}

		public override GLib.GType GInterfaceGType {
			get {
				return _gtype;
			}
		}

		public override IntPtr Handle {
			get {
				return implementor.Handle;
			}
		}

		public IntPtr OwnedHandle {
			get {
				return implementor.OwnedHandle;
			}
		}

		public static ISourceUndoManager GetObject (IntPtr handle, bool owned)
		{
			GLib.Object obj = GLib.Object.GetObject (handle, owned);
			return GetObject (obj);
		}

		public static ISourceUndoManager GetObject (GLib.Object obj)
		{
			if (obj == null)
				return null;
			else if (obj is ISourceUndoManagerImplementor)
				return new SourceUndoManagerAdapter (obj as ISourceUndoManagerImplementor);
			else if (obj as ISourceUndoManager == null)
				return new SourceUndoManagerAdapter (obj.Handle);
			else
				return obj as ISourceUndoManager;
		}

		public ISourceUndoManagerImplementor Implementor {
			get {
				return implementor as ISourceUndoManagerImplementor;
			}
		}

		[DllImport("gtksourceview-4", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_source_undo_manager_begin_not_undoable_action(IntPtr raw);

		public void BeginNotUndoableAction() {
			gtk_source_undo_manager_begin_not_undoable_action(Handle);
		}

		[DllImport("gtksourceview-4", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_source_undo_manager_can_redo(IntPtr raw);

		public bool CanRedo() {
			bool raw_ret = gtk_source_undo_manager_can_redo(Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gtksourceview-4", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_source_undo_manager_can_redo_changed(IntPtr raw);

		public void CanRedoChanged() {
			gtk_source_undo_manager_can_redo_changed(Handle);
		}

		[DllImport("gtksourceview-4", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_source_undo_manager_can_undo(IntPtr raw);

		public bool CanUndo() {
			bool raw_ret = gtk_source_undo_manager_can_undo(Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gtksourceview-4", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_source_undo_manager_can_undo_changed(IntPtr raw);

		public void CanUndoChanged() {
			gtk_source_undo_manager_can_undo_changed(Handle);
		}

		[DllImport("gtksourceview-4", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_source_undo_manager_end_not_undoable_action(IntPtr raw);

		public void EndNotUndoableAction() {
			gtk_source_undo_manager_end_not_undoable_action(Handle);
		}

		[DllImport("gtksourceview-4", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_source_undo_manager_redo(IntPtr raw);

		public void Redo() {
			gtk_source_undo_manager_redo(Handle);
		}

		[DllImport("gtksourceview-4", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_source_undo_manager_undo(IntPtr raw);

		public void Undo() {
			gtk_source_undo_manager_undo(Handle);
		}

#endregion
	}
}