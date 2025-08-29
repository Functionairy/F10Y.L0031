using System;
using System.Threading.Tasks;

using TextCopy;

using F10Y.T0002;


namespace F10Y.L0031.L000
{
    [FunctionsMarker]
    public partial interface IClipboardOperator
    {
        public async Task Copy_ToClipboard(string text)
        {
            await ClipboardService.SetTextAsync(text);
        }

        public void Copy_ToClipboard_Synchronous(string text)
        {
            ClipboardService.SetText(text);
        }
    }
}
