using System;
namespace Lab04
{

    public class ComplexData
    {
	    private Double realNum;
	    private Double imagNum;

	    public ComplexData()
	    {

	    }

        public void setRealNumber(Double realNum)
        {
            this.realNum = realNum;
        }

        public void setImagNumber(Double imagNum)
        {
            this.imagNum = imagNum;
        }

        public Double getRealNumber()
        {
            return realNum;
        }

        public Double getImagNumber()
        {
            return imagNum;
        }
    }
}
