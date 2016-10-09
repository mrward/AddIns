using MonoDevelop.Components.Commands;
using MonoDevelop.Ide;
using MonoDevelop.Ide.Editor;
using MonoDevelop.Ide.Gui;
using System;

namespace DateInserter
{
	class InsertDateHandler : CommandHandler
	{
		protected override void Run ()
		{
			Document doc = IdeApp.Workbench.ActiveDocument;
			string date = DateTime.Now.ToString ();
			doc.Editor.InsertAtCaret (date);
		}

		protected override void Update (CommandInfo info)
		{
			Document doc = IdeApp.Workbench.ActiveDocument;
			info.Enabled = doc != null && doc.Editor != null;
		}
	}
}