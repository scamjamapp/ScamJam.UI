using System;

namespace ScamJam.UI
{
    public static class Utilities
    {
        #region Nullable

        internal static Form? GetOpenFormInstance<T>() where T : Form
        {
            return Application.OpenForms.OfType<T>().FirstOrDefault();
        }

        #endregion

    }
}


