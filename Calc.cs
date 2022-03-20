using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WSUniversalLib
{
    public class Calculatoin
    {
        public int GetQuantityForProduct(int productType, int materialType, int count, float width, float height)
        {
            int result = 0;
            float defectResult = 0;
            float area = width * height; ;

            if (area < 0 || count < 0)
            {               
                return -1;
            }

            switch (productType)
            {
                case 1:
                    {
                        defectResult = (float)(count * area * 1.1);
                        switch (materialType)
                        {
                            case 1:
                                {
                                    defectResult = (float)(defectResult * 99.7);
                                    result = (int)Math.Ceiling(defectResult/100);
                                    return result;
                                }
                            case 2:
                                {
                                    defectResult = (float)(defectResult * 99.88);
                                    result = (int)Math.Ceiling(defectResult / 100);
                                    return result;
                                }
                            default:
                                {
                                    return -1;
                                }
                        }

                    }
                case 2:
                    {
                        defectResult = (float)(count * area * 2.5);
                        switch (materialType)
                        {
                            case 1:
                                {
                                    defectResult = (float)(defectResult * 99.7);
                                    result = (int)Math.Ceiling(defectResult / 100);
                                    return result;
                                }
                            case 2:
                                {
                                    defectResult = (float)(defectResult * 99.88);
                                    result = (int)Math.Ceiling(defectResult / 100);
                                    return result;
                                }
                            default:
                                {
                                    return -1;
                                }
                        }
                    }
                case 3:
                    {
                        defectResult = (float)(count * area * 8.43);
                        switch (materialType)
                        {
                            case 1:
                                {
                                    defectResult = (float)(defectResult * 99.7);
                                    result = (int)Math.Ceiling(defectResult / 100);
                                    return result;
                                }
                            case 2:
                                {
                                    defectResult = (float)(defectResult * 99.88);
                                    result = (int)Math.Ceiling(defectResult / 100);
                                    return result;
                                }
                            default:
                                {
                                    return -1;
                                }
                        }
                    }
                default:
                    {

                        return -1;
                    }
            }
        }
    }
}
