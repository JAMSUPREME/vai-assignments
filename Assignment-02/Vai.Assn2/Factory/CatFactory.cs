using Vai.Assn2.Models;

namespace Vai.Assn2.Factory
{
    /// <summary>
    /// Generates cats
    /// </summary>
    public static class CatFactory
    {
        private static int _counter = 0;

        /// <summary>
        /// Returns a cat that implements ICat
        /// </summary>
        /// <returns></returns>
        public static ICat GetCat()
        {
            _counter++;
            if (_counter % 2 == 0)
            {
                return new FatCat();
            }
            return new ShortCat();
        }
    }
}
