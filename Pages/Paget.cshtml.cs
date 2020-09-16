using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections;
using System.Linq;

namespace razortest.Pages
{
    public class PagetModel : PageModel
    {
        public int i = 3;

        public bool[] boolArray = new bool[5];

        public void OnGet()
        {
            BitArray b = new BitArray(new byte[] { (byte)i });
            int[] bits = b.Cast<bool>().Select(bit => bit ? 1 : 0).ToArray();
            for (int j = 0; j < 5; j++)
            {
                if (bits[j] == 0)
                {
                    boolArray[j] = false;
                }
                else
                {
                    boolArray[j] = true;
                }
            }
        }
    }
}