using Lab04;
using System;

public class ComplexArithmetic
{

	public ComplexArithmetic()
	{
	}

	public void add(ComplexData comp1, ComplexData comp2, ComplexData compAns)
    {
		compAns.setRealNumber(comp1.getRealNumber() + comp2.getRealNumber());
		compAns.setImagNumber(comp1.getImagNumber() + comp2.getImagNumber());
    }

	public void sub(ComplexData comp1, ComplexData comp2, ComplexData compAns)
    {
		compAns.setRealNumber(comp1.getRealNumber() - comp2.getRealNumber());
		compAns.setImagNumber(comp1.getImagNumber() - comp2.getImagNumber());
	}

	public void mult(ComplexData comp1, ComplexData comp2, ComplexData compAns)
    {
		Double firstReal = comp1.getRealNumber() * comp2.getRealNumber();
		Double outerImag = comp1.getRealNumber() * comp2.getImagNumber();
		Double innerImag = comp1.getImagNumber() * comp2.getRealNumber();
		Double lastReal = comp1.getImagNumber() * comp2.getImagNumber() * -1;
		Double realAns = firstReal + lastReal;
		Double imagAns = outerImag + innerImag;
		compAns.setRealNumber(realAns);
		compAns.setImagNumber(imagAns);
    }

	public void div(ComplexData comp1, ComplexData comp2, ComplexData compAns)
    {
		Double numerFirstReal = comp1.getRealNumber() * comp2.getRealNumber();
		Double numerOuterConjImag = comp1.getRealNumber() * (comp2.getImagNumber() * -1);
		Double numerInnerImag = comp1.getImagNumber() * comp2.getRealNumber();
		Double numerLastConjReal = comp1.getImagNumber() * (comp2.getImagNumber() * -1) * -1;
		Double denomFirstReal = comp2.getRealNumber() * comp2.getRealNumber();
		Double denomOuterConjImag = comp2.getRealNumber() * (comp2.getImagNumber() * -1);
		Double denomInnerImag = comp2.getImagNumber() * comp2.getRealNumber();
		Double denomLastConjReal = comp2.getImagNumber() * (comp2.getImagNumber() * -1) * -1;

		Double realAns;
		Double imagAns;

		if (denomFirstReal + denomLastConjReal != 0)
        {
			realAns = (numerFirstReal + numerLastConjReal) / (denomFirstReal + denomLastConjReal);
			imagAns = (numerOuterConjImag + numerInnerImag) / (denomFirstReal + denomLastConjReal);

		}
		else
        {
			realAns = (numerFirstReal + numerLastConjReal);
			imagAns = (numerOuterConjImag + numerInnerImag);
        }

		compAns.setRealNumber(realAns);
		compAns.setImagNumber(imagAns);

	}
}
