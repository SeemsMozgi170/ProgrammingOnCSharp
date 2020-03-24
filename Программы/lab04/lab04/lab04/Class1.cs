using System;
using System.Collections.Generic;
using System.Text;

namespace lab04 {
	class Class1 {


		public static void Ex2() {
			//
			// TODO: Add code to start application here
			DblOp operations = new DblOp(MathOprt.Mul2);
			operations += new DblOp(MathOprt.Sqr);

			Prc(operations, 4.0);
			Prc(operations, 9.94);
			Prc(operations, 3.143);
		}

		static void Prc(DblOp act, double val) {

			Console.WriteLine("\n*********\n");
			act(val);
		}

		class MathOprt {
			public static void Mul2(double val) {
				double rslt = val * 2;
				Console.WriteLine("Mul2 bсходное значение {0},результат  {1}",
						val, rslt);
			}
			public static void Sqr(double val) {
				double rslt = val * val;
				Console.WriteLine("Sqr исходное значение {0}, результат  {1}",
						val, rslt);

			}
		}
		delegate void DblOp(double x);//объявление делегата
	}
}
