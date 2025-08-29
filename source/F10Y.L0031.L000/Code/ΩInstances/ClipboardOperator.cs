using System;


namespace F10Y.L0031.L000
{
    public class ClipboardOperator : IClipboardOperator
    {
        #region Infrastructure

        public static IClipboardOperator Instance { get; } = new ClipboardOperator();


        private ClipboardOperator()
        {
        }

        #endregion
    }
}
