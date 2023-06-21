using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Ambacht.Common.Excel;

namespace WarmtePompGeluid.Model.Generated;

public class Calculator_AP : ExcelCalculatorBase {

	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? C20 {
		get => (double?)this[Addresses.C20];
		set => this[Addresses.C20] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? D20 {
		get => (double?)this[Addresses.D20];
		set => this[Addresses.D20] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? E20 {
		get => (double?)this[Addresses.E20];
		set => this[Addresses.E20] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? F20 {
		get => (double?)this[Addresses.F20];
		set => this[Addresses.F20] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? G20 {
		get => (double?)this[Addresses.G20];
		set => this[Addresses.G20] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? H20 {
		get => (double?)this[Addresses.H20];
		set => this[Addresses.H20] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? I20 {
		get => (double?)this[Addresses.I20];
		set => this[Addresses.I20] = value;
	}


	/// <summary>
	/// variable (String)
	/// </summary>
	public string J20 {
		get => (string)this[Addresses.J20];
		set => this[Addresses.J20] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? C66 {
		get => (double?)this[Addresses.C66];
		set => this[Addresses.C66] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? C67 {
		get => (double?)this[Addresses.C67];
		set => this[Addresses.C67] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? C68 {
		get => (double?)this[Addresses.C68];
		set => this[Addresses.C68] = value;
	}


	/// <summary>
	/// C66+C67-C68
	/// </summary>
	public object C69 => Subtract(Add(C66, C67), C68);


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? F66 {
		get => (double?)this[Addresses.F66];
		set => this[Addresses.F66] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? F67 {
		get => (double?)this[Addresses.F67];
		set => this[Addresses.F67] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? F68 {
		get => (double?)this[Addresses.F68];
		set => this[Addresses.F68] = value;
	}


	/// <summary>
	/// F66+F67-F68
	/// </summary>
	public object F69 => Subtract(Add(F66, F67), F68);


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? B16 {
		get => (double?)this[Addresses.B16];
		set => this[Addresses.B16] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? B11 {
		get => (double?)this[Addresses.B11];
		set => this[Addresses.B11] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? B12 {
		get => (double?)this[Addresses.B12];
		set => this[Addresses.B12] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? C21 {
		get => (double?)this[Addresses.C21];
		set => this[Addresses.C21] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? B13 {
		get => (double?)this[Addresses.B13];
		set => this[Addresses.B13] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? C22 {
		get => (double?)this[Addresses.C22];
		set => this[Addresses.C22] = value;
	}


	/// <summary>
	/// (((B11-C20)^2)+((B12-C21)^2)+((B13-C22)^2))^0.5
	/// </summary>
	public object C35 => Pow((Add(Add((Pow((Subtract(B11, C20)), 2)), (Pow((Subtract(B12, C21)), 2))), (Pow((Subtract(B13, C22)), 2)))), 5);


	/// <summary>
	/// variable (String)
	/// </summary>
	public string C23 {
		get => (string)this[Addresses.C23];
		set => this[Addresses.C23] = value;
	}


	/// <summary>
	/// IF(C23="J",5,IF(C23="n",0,"ERROR"))
	/// </summary>
	public object C36 => IF(object.Equals(C23, "J"), 5, IF(object.Equals(C23, "n"), 0, "ERROR"));


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? C25 {
		get => (double?)this[Addresses.C25];
		set => this[Addresses.C25] = value;
	}


	/// <summary>
	/// 10*LOG10(2/C25)*5/6
	/// </summary>
	public object C37 => Divide(Multiply(Multiply(10, LOG10(Divide(2, C25))), 5), 6);


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? C26 {
		get => (double?)this[Addresses.C26];
		set => this[Addresses.C26] = value;
	}


	/// <summary>
	/// 10*LOG10(2/C26)*5/6
	/// </summary>
	public object C38 => Divide(Multiply(Multiply(10, LOG10(Divide(2, C26))), 5), 6);


	/// <summary>
	/// variable (String)
	/// </summary>
	public string C24 {
		get => (string)this[Addresses.C24];
		set => this[Addresses.C24] = value;
	}


	/// <summary>
	/// IF(C24="j",5,(IF(C24="n",0,"ERROR")))
	/// </summary>
	public object C39 => IF(object.Equals(C24, "j"), 5, (IF(object.Equals(C24, "n"), 0, "ERROR")));


	/// <summary>
	/// 20*LOG10(C35)+9+C36-C37-C38-C39
	/// </summary>
	public object C40 => Subtract(Subtract(Subtract(Add(Add(Multiply(20, LOG10(C35)), 9), C36), C37), C38), C39);


	/// <summary>
	/// IF(C20<>"nvt",ROUND(45+C40,0),"")
	/// </summary>
	public object C44 => IF(!object.Equals(C20, "nvt"), ROUND(Add(45, C40), 0), "");


	/// <summary>
	/// IF(C20<>"nvt",ROUND(40+C40,0),"")
	/// </summary>
	public object C45 => IF(!object.Equals(C20, "nvt"), ROUND(Add(40, C40), 0), "");


	/// <summary>
	/// IF(C20<>"nvt",(-C44),-9999)
	/// </summary>
	public object C46 => IF(!object.Equals(C20, "nvt"), (Negate(C44)), Negate(9999));


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? D21 {
		get => (double?)this[Addresses.D21];
		set => this[Addresses.D21] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? D22 {
		get => (double?)this[Addresses.D22];
		set => this[Addresses.D22] = value;
	}


	/// <summary>
	/// (((B11-D20)^2)+((B12-D21)^2)+((B13-D22)^2))^0.5
	/// </summary>
	public object D35 => Pow((Add(Add((Pow((Subtract(B11, D20)), 2)), (Pow((Subtract(B12, D21)), 2))), (Pow((Subtract(B13, D22)), 2)))), 5);


	/// <summary>
	/// variable (String)
	/// </summary>
	public string D23 {
		get => (string)this[Addresses.D23];
		set => this[Addresses.D23] = value;
	}


	/// <summary>
	/// IF(D23="J",5,IF(D23="n",0,"ERROR"))
	/// </summary>
	public object D36 => IF(object.Equals(D23, "J"), 5, IF(object.Equals(D23, "n"), 0, "ERROR"));


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? D25 {
		get => (double?)this[Addresses.D25];
		set => this[Addresses.D25] = value;
	}


	/// <summary>
	/// 10*LOG10(2/D25)*5/6
	/// </summary>
	public object D37 => Divide(Multiply(Multiply(10, LOG10(Divide(2, D25))), 5), 6);


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? D26 {
		get => (double?)this[Addresses.D26];
		set => this[Addresses.D26] = value;
	}


	/// <summary>
	/// 10*LOG10(2/D26)*5/6
	/// </summary>
	public object D38 => Divide(Multiply(Multiply(10, LOG10(Divide(2, D26))), 5), 6);


	/// <summary>
	/// variable (String)
	/// </summary>
	public string D24 {
		get => (string)this[Addresses.D24];
		set => this[Addresses.D24] = value;
	}


	/// <summary>
	/// IF(D24="j",5,(IF(D24="n",0,"ERROR")))
	/// </summary>
	public object D39 => IF(object.Equals(D24, "j"), 5, (IF(object.Equals(D24, "n"), 0, "ERROR")));


	/// <summary>
	/// 20*LOG10(D35)+9+D36-D37-D38-D39
	/// </summary>
	public object D40 => Subtract(Subtract(Subtract(Add(Add(Multiply(20, LOG10(D35)), 9), D36), D37), D38), D39);


	/// <summary>
	/// IF(D20<>"nvt",ROUND(45+D40,0),"")
	/// </summary>
	public object D44 => IF(!object.Equals(D20, "nvt"), ROUND(Add(45, D40), 0), "");


	/// <summary>
	/// IF(D20<>"nvt",ROUND(40+D40,0),"")
	/// </summary>
	public object D45 => IF(!object.Equals(D20, "nvt"), ROUND(Add(40, D40), 0), "");


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? E21 {
		get => (double?)this[Addresses.E21];
		set => this[Addresses.E21] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? E22 {
		get => (double?)this[Addresses.E22];
		set => this[Addresses.E22] = value;
	}


	/// <summary>
	/// (((B11-E20)^2)+((B12-E21)^2)+((B13-E22)^2))^0.5
	/// </summary>
	public object E35 => Pow((Add(Add((Pow((Subtract(B11, E20)), 2)), (Pow((Subtract(B12, E21)), 2))), (Pow((Subtract(B13, E22)), 2)))), 5);


	/// <summary>
	/// variable (String)
	/// </summary>
	public string E23 {
		get => (string)this[Addresses.E23];
		set => this[Addresses.E23] = value;
	}


	/// <summary>
	/// IF(E23="J",5,IF(E23="n",0,"ERROR"))
	/// </summary>
	public object E36 => IF(object.Equals(E23, "J"), 5, IF(object.Equals(E23, "n"), 0, "ERROR"));


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? E25 {
		get => (double?)this[Addresses.E25];
		set => this[Addresses.E25] = value;
	}


	/// <summary>
	/// 10*LOG10(2/E25)*5/6
	/// </summary>
	public object E37 => Divide(Multiply(Multiply(10, LOG10(Divide(2, E25))), 5), 6);


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? E26 {
		get => (double?)this[Addresses.E26];
		set => this[Addresses.E26] = value;
	}


	/// <summary>
	/// 10*LOG10(2/E26)*5/6
	/// </summary>
	public object E38 => Divide(Multiply(Multiply(10, LOG10(Divide(2, E26))), 5), 6);


	/// <summary>
	/// variable (String)
	/// </summary>
	public string E24 {
		get => (string)this[Addresses.E24];
		set => this[Addresses.E24] = value;
	}


	/// <summary>
	/// IF(E24="j",5,(IF(E24="n",0,"ERROR")))
	/// </summary>
	public object E39 => IF(object.Equals(E24, "j"), 5, (IF(object.Equals(E24, "n"), 0, "ERROR")));


	/// <summary>
	/// 20*LOG10(E35)+9+E36-E37-E38-E39
	/// </summary>
	public object E40 => Subtract(Subtract(Subtract(Add(Add(Multiply(20, LOG10(E35)), 9), E36), E37), E38), E39);


	/// <summary>
	/// IF(E20<>"nvt",ROUND(45+E40,0),"")
	/// </summary>
	public object E44 => IF(!object.Equals(E20, "nvt"), ROUND(Add(45, E40), 0), "");


	/// <summary>
	/// IF(E20<>"nvt",ROUND(40+E40,0),"")
	/// </summary>
	public object E45 => IF(!object.Equals(E20, "nvt"), ROUND(Add(40, E40), 0), "");


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? F21 {
		get => (double?)this[Addresses.F21];
		set => this[Addresses.F21] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? F22 {
		get => (double?)this[Addresses.F22];
		set => this[Addresses.F22] = value;
	}


	/// <summary>
	/// (((B11-F20)^2)+((B12-F21)^2)+((B13-F22)^2))^0.5
	/// </summary>
	public object F35 => Pow((Add(Add((Pow((Subtract(B11, F20)), 2)), (Pow((Subtract(B12, F21)), 2))), (Pow((Subtract(B13, F22)), 2)))), 5);


	/// <summary>
	/// variable (String)
	/// </summary>
	public string F23 {
		get => (string)this[Addresses.F23];
		set => this[Addresses.F23] = value;
	}


	/// <summary>
	/// IF(F23="J",5,IF(F23="n",0,"ERROR"))
	/// </summary>
	public object F36 => IF(object.Equals(F23, "J"), 5, IF(object.Equals(F23, "n"), 0, "ERROR"));


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? F25 {
		get => (double?)this[Addresses.F25];
		set => this[Addresses.F25] = value;
	}


	/// <summary>
	/// 10*LOG10(2/F25)*5/6
	/// </summary>
	public object F37 => Divide(Multiply(Multiply(10, LOG10(Divide(2, F25))), 5), 6);


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? F26 {
		get => (double?)this[Addresses.F26];
		set => this[Addresses.F26] = value;
	}


	/// <summary>
	/// 10*LOG10(2/F26)*5/6
	/// </summary>
	public object F38 => Divide(Multiply(Multiply(10, LOG10(Divide(2, F26))), 5), 6);


	/// <summary>
	/// variable (String)
	/// </summary>
	public string F24 {
		get => (string)this[Addresses.F24];
		set => this[Addresses.F24] = value;
	}


	/// <summary>
	/// IF(F24="j",5,(IF(F24="n",0,"ERROR")))
	/// </summary>
	public object F39 => IF(object.Equals(F24, "j"), 5, (IF(object.Equals(F24, "n"), 0, "ERROR")));


	/// <summary>
	/// 20*LOG10(F35)+9+F36-F37-F38-F39
	/// </summary>
	public object F40 => Subtract(Subtract(Subtract(Add(Add(Multiply(20, LOG10(F35)), 9), F36), F37), F38), F39);


	/// <summary>
	/// IF(F20<>"nvt",ROUND(45+F40,0),"")
	/// </summary>
	public object F44 => IF(!object.Equals(F20, "nvt"), ROUND(Add(45, F40), 0), "");


	/// <summary>
	/// IF(F20<>"nvt",ROUND(40+F40,0),"")
	/// </summary>
	public object F45 => IF(!object.Equals(F20, "nvt"), ROUND(Add(40, F40), 0), "");


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? G21 {
		get => (double?)this[Addresses.G21];
		set => this[Addresses.G21] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? G22 {
		get => (double?)this[Addresses.G22];
		set => this[Addresses.G22] = value;
	}


	/// <summary>
	/// (((B11-G20)^2)+((B12-G21)^2)+((B13-G22)^2))^0.5
	/// </summary>
	public object G35 => Pow((Add(Add((Pow((Subtract(B11, G20)), 2)), (Pow((Subtract(B12, G21)), 2))), (Pow((Subtract(B13, G22)), 2)))), 5);


	/// <summary>
	/// variable (String)
	/// </summary>
	public string G23 {
		get => (string)this[Addresses.G23];
		set => this[Addresses.G23] = value;
	}


	/// <summary>
	/// IF(G23="J",5,IF(G23="n",0,"ERROR"))
	/// </summary>
	public object G36 => IF(object.Equals(G23, "J"), 5, IF(object.Equals(G23, "n"), 0, "ERROR"));


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? G25 {
		get => (double?)this[Addresses.G25];
		set => this[Addresses.G25] = value;
	}


	/// <summary>
	/// 10*LOG10(2/G25)*5/6
	/// </summary>
	public object G37 => Divide(Multiply(Multiply(10, LOG10(Divide(2, G25))), 5), 6);


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? G26 {
		get => (double?)this[Addresses.G26];
		set => this[Addresses.G26] = value;
	}


	/// <summary>
	/// 10*LOG10(2/G26)*5/6
	/// </summary>
	public object G38 => Divide(Multiply(Multiply(10, LOG10(Divide(2, G26))), 5), 6);


	/// <summary>
	/// variable (String)
	/// </summary>
	public string G24 {
		get => (string)this[Addresses.G24];
		set => this[Addresses.G24] = value;
	}


	/// <summary>
	/// IF(G24="j",5,(IF(G24="n",0,"ERROR")))
	/// </summary>
	public object G39 => IF(object.Equals(G24, "j"), 5, (IF(object.Equals(G24, "n"), 0, "ERROR")));


	/// <summary>
	/// 20*LOG10(G35)+9+G36-G37-G38-G39
	/// </summary>
	public object G40 => Subtract(Subtract(Subtract(Add(Add(Multiply(20, LOG10(G35)), 9), G36), G37), G38), G39);


	/// <summary>
	/// IF(G20<>"nvt",ROUND(45+G40,0),"")
	/// </summary>
	public object G44 => IF(!object.Equals(G20, "nvt"), ROUND(Add(45, G40), 0), "");


	/// <summary>
	/// IF(G20<>"nvt",ROUND(40+G40,0),"")
	/// </summary>
	public object G45 => IF(!object.Equals(G20, "nvt"), ROUND(Add(40, G40), 0), "");


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? H21 {
		get => (double?)this[Addresses.H21];
		set => this[Addresses.H21] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? H22 {
		get => (double?)this[Addresses.H22];
		set => this[Addresses.H22] = value;
	}


	/// <summary>
	/// (((B11-H20)^2)+((B12-H21)^2)+((B13-H22)^2))^0.5
	/// </summary>
	public object H35 => Pow((Add(Add((Pow((Subtract(B11, H20)), 2)), (Pow((Subtract(B12, H21)), 2))), (Pow((Subtract(B13, H22)), 2)))), 5);


	/// <summary>
	/// variable (String)
	/// </summary>
	public string H23 {
		get => (string)this[Addresses.H23];
		set => this[Addresses.H23] = value;
	}


	/// <summary>
	/// IF(H23="J",5,IF(H23="n",0,"ERROR"))
	/// </summary>
	public object H36 => IF(object.Equals(H23, "J"), 5, IF(object.Equals(H23, "n"), 0, "ERROR"));


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? H25 {
		get => (double?)this[Addresses.H25];
		set => this[Addresses.H25] = value;
	}


	/// <summary>
	/// 10*LOG10(2/H25)*5/6
	/// </summary>
	public object H37 => Divide(Multiply(Multiply(10, LOG10(Divide(2, H25))), 5), 6);


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? H26 {
		get => (double?)this[Addresses.H26];
		set => this[Addresses.H26] = value;
	}


	/// <summary>
	/// 10*LOG10(2/H26)*5/6
	/// </summary>
	public object H38 => Divide(Multiply(Multiply(10, LOG10(Divide(2, H26))), 5), 6);


	/// <summary>
	/// variable (String)
	/// </summary>
	public string H24 {
		get => (string)this[Addresses.H24];
		set => this[Addresses.H24] = value;
	}


	/// <summary>
	/// IF(H24="j",5,(IF(H24="n",0,"ERROR")))
	/// </summary>
	public object H39 => IF(object.Equals(H24, "j"), 5, (IF(object.Equals(H24, "n"), 0, "ERROR")));


	/// <summary>
	/// 20*LOG10(H35)+9+H36-H37-H38-H39
	/// </summary>
	public object H40 => Subtract(Subtract(Subtract(Add(Add(Multiply(20, LOG10(H35)), 9), H36), H37), H38), H39);


	/// <summary>
	/// IF(H20<>"nvt",ROUND(45+H40,0),"")
	/// </summary>
	public object H44 => IF(!object.Equals(H20, "nvt"), ROUND(Add(45, H40), 0), "");


	/// <summary>
	/// IF(H20<>"nvt",ROUND(40+H40,0),"")
	/// </summary>
	public object H45 => IF(!object.Equals(H20, "nvt"), ROUND(Add(40, H40), 0), "");


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? I21 {
		get => (double?)this[Addresses.I21];
		set => this[Addresses.I21] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? I22 {
		get => (double?)this[Addresses.I22];
		set => this[Addresses.I22] = value;
	}


	/// <summary>
	/// (((B11-I20)^2)+((B12-I21)^2)+((B13-I22)^2))^0.5
	/// </summary>
	public object I35 => Pow((Add(Add((Pow((Subtract(B11, I20)), 2)), (Pow((Subtract(B12, I21)), 2))), (Pow((Subtract(B13, I22)), 2)))), 5);


	/// <summary>
	/// variable (String)
	/// </summary>
	public string I23 {
		get => (string)this[Addresses.I23];
		set => this[Addresses.I23] = value;
	}


	/// <summary>
	/// IF(I23="J",5,IF(I23="n",0,"ERROR"))
	/// </summary>
	public object I36 => IF(object.Equals(I23, "J"), 5, IF(object.Equals(I23, "n"), 0, "ERROR"));


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? I25 {
		get => (double?)this[Addresses.I25];
		set => this[Addresses.I25] = value;
	}


	/// <summary>
	/// 10*LOG10(2/I25)*5/6
	/// </summary>
	public object I37 => Divide(Multiply(Multiply(10, LOG10(Divide(2, I25))), 5), 6);


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? I26 {
		get => (double?)this[Addresses.I26];
		set => this[Addresses.I26] = value;
	}


	/// <summary>
	/// 10*LOG10(2/I26)*5/6
	/// </summary>
	public object I38 => Divide(Multiply(Multiply(10, LOG10(Divide(2, I26))), 5), 6);


	/// <summary>
	/// variable (String)
	/// </summary>
	public string I24 {
		get => (string)this[Addresses.I24];
		set => this[Addresses.I24] = value;
	}


	/// <summary>
	/// IF(I24="j",5,(IF(I24="n",0,"ERROR")))
	/// </summary>
	public object I39 => IF(object.Equals(I24, "j"), 5, (IF(object.Equals(I24, "n"), 0, "ERROR")));


	/// <summary>
	/// 20*LOG10(I35)+9+I36-I37-I38-I39
	/// </summary>
	public object I40 => Subtract(Subtract(Subtract(Add(Add(Multiply(20, LOG10(I35)), 9), I36), I37), I38), I39);


	/// <summary>
	/// IF(I20<>"nvt",ROUND(45+I40,0),"")
	/// </summary>
	public object I44 => IF(!object.Equals(I20, "nvt"), ROUND(Add(45, I40), 0), "");


	/// <summary>
	/// IF(I20<>"nvt",ROUND(40+I40,0),"")
	/// </summary>
	public object I45 => IF(!object.Equals(I20, "nvt"), ROUND(Add(40, I40), 0), "");


	/// <summary>
	/// variable (Blank)
	/// </summary>
	public object J21 {
		get => this[Addresses.J21];
		set => this[Addresses.J21] = value;
	}


	/// <summary>
	/// variable (Blank)
	/// </summary>
	public object J22 {
		get => this[Addresses.J22];
		set => this[Addresses.J22] = value;
	}


	/// <summary>
	/// (((B11-J20)^2)+((B12-J21)^2)+((B13-J22)^2))^0.5
	/// </summary>
	public object J35 => Pow((Add(Add((Pow((Subtract(B11, J20)), 2)), (Pow((Subtract(B12, J21)), 2))), (Pow((Subtract(B13, J22)), 2)))), 5);


	/// <summary>
	/// variable (Blank)
	/// </summary>
	public object J23 {
		get => this[Addresses.J23];
		set => this[Addresses.J23] = value;
	}


	/// <summary>
	/// IF(J23="J",5,IF(J23="n",0,"ERROR"))
	/// </summary>
	public object J36 => IF(object.Equals(J23, "J"), 5, IF(object.Equals(J23, "n"), 0, "ERROR"));


	/// <summary>
	/// variable (Blank)
	/// </summary>
	public object J25 {
		get => this[Addresses.J25];
		set => this[Addresses.J25] = value;
	}


	/// <summary>
	/// 10*LOG10(2/J25)*5/6
	/// </summary>
	public object J37 => Divide(Multiply(Multiply(10, LOG10(Divide(2, J25))), 5), 6);


	/// <summary>
	/// variable (Blank)
	/// </summary>
	public object J26 {
		get => this[Addresses.J26];
		set => this[Addresses.J26] = value;
	}


	/// <summary>
	/// 10*LOG10(2/J26)*5/6
	/// </summary>
	public object J38 => Divide(Multiply(Multiply(10, LOG10(Divide(2, J26))), 5), 6);


	/// <summary>
	/// variable (Blank)
	/// </summary>
	public object J24 {
		get => this[Addresses.J24];
		set => this[Addresses.J24] = value;
	}


	/// <summary>
	/// IF(J24="j",5,(IF(J24="n",0,"ERROR")))
	/// </summary>
	public object J39 => IF(object.Equals(J24, "j"), 5, (IF(object.Equals(J24, "n"), 0, "ERROR")));


	/// <summary>
	/// 20*LOG10(J35)+9+J36-J37-J38-J39
	/// </summary>
	public object J40 => Subtract(Subtract(Subtract(Add(Add(Multiply(20, LOG10(J35)), 9), J36), J37), J38), J39);


	/// <summary>
	/// IF(J20<>"nvt",ROUND(45+J40,0),"")
	/// </summary>
	public object J44 => IF(!object.Equals(J20, "nvt"), ROUND(Add(45, J40), 0), "");


	/// <summary>
	/// IF(J20<>"nvt",ROUND(40+J40,0),"")
	/// </summary>
	public object J45 => IF(!object.Equals(J20, "nvt"), ROUND(Add(40, J40), 0), "");


	/// <summary>
	/// IF(J20<>"nvt",(-J44),-9999)
	/// </summary>
	public object J46 => IF(!object.Equals(J20, "nvt"), (Negate(J44)), Negate(9999));


	/// <summary>
	/// (-MAX(C46:J46))-B16
	/// </summary>
	public object C48 => Subtract((Negate(MAX((Addresses.C46, Addresses.J46)))), B16);


	/// <summary>
	/// ROUND(C48,0)
	/// </summary>
	public object C55 => ROUND(C48, 0);


	/// <summary>
	/// IF(C69<=C55,"VOLDOET","VOLDOET NIET")
	/// </summary>
	public object B70 => IF(LessOrEqual(C69, C55), "VOLDOET", "VOLDOET NIET");


	/// <summary>
	/// C48-5
	/// </summary>
	public object C49 => Subtract(C48, 5);


	/// <summary>
	/// ROUND(C49,0)
	/// </summary>
	public object F55 => ROUND(C49, 0);


	/// <summary>
	/// IF(F69<=F55,"VOLDOET","VOLDOET NIET")
	/// </summary>
	public object E70 => IF(LessOrEqual(F69, F55), "VOLDOET", "VOLDOET NIET");

	public static class Addresses
	{
		public static readonly (int, int) B11 = new(10, 1);
		public static readonly (int, int) B12 = new(11, 1);
		public static readonly (int, int) B13 = new(12, 1);
		public static readonly (int, int) B16 = new(15, 1);
		public static readonly (int, int) C20 = new(19, 2);
		public static readonly (int, int) C21 = new(20, 2);
		public static readonly (int, int) C22 = new(21, 2);
		public static readonly (int, int) C23 = new(22, 2);
		public static readonly (int, int) C24 = new(23, 2);
		public static readonly (int, int) C25 = new(24, 2);
		public static readonly (int, int) C26 = new(25, 2);
		public static readonly (int, int) C35 = new(34, 2);
		public static readonly (int, int) C36 = new(35, 2);
		public static readonly (int, int) C37 = new(36, 2);
		public static readonly (int, int) C38 = new(37, 2);
		public static readonly (int, int) C39 = new(38, 2);
		public static readonly (int, int) C40 = new(39, 2);
		public static readonly (int, int) C44 = new(43, 2);
		public static readonly (int, int) C46 = new(45, 2);
		public static readonly (int, int) C48 = new(47, 2);
		public static readonly (int, int) C49 = new(48, 2);
		public static readonly (int, int) C55 = new(54, 2);
		public static readonly (int, int) C66 = new(65, 2);
		public static readonly (int, int) C67 = new(66, 2);
		public static readonly (int, int) C68 = new(67, 2);
		public static readonly (int, int) C69 = new(68, 2);
		public static readonly (int, int) D20 = new(19, 3);
		public static readonly (int, int) D21 = new(20, 3);
		public static readonly (int, int) D22 = new(21, 3);
		public static readonly (int, int) D23 = new(22, 3);
		public static readonly (int, int) D24 = new(23, 3);
		public static readonly (int, int) D25 = new(24, 3);
		public static readonly (int, int) D26 = new(25, 3);
		public static readonly (int, int) D35 = new(34, 3);
		public static readonly (int, int) D36 = new(35, 3);
		public static readonly (int, int) D37 = new(36, 3);
		public static readonly (int, int) D38 = new(37, 3);
		public static readonly (int, int) D39 = new(38, 3);
		public static readonly (int, int) D40 = new(39, 3);
		public static readonly (int, int) E20 = new(19, 4);
		public static readonly (int, int) E21 = new(20, 4);
		public static readonly (int, int) E22 = new(21, 4);
		public static readonly (int, int) E23 = new(22, 4);
		public static readonly (int, int) E24 = new(23, 4);
		public static readonly (int, int) E25 = new(24, 4);
		public static readonly (int, int) E26 = new(25, 4);
		public static readonly (int, int) E35 = new(34, 4);
		public static readonly (int, int) E36 = new(35, 4);
		public static readonly (int, int) E37 = new(36, 4);
		public static readonly (int, int) E38 = new(37, 4);
		public static readonly (int, int) E39 = new(38, 4);
		public static readonly (int, int) E40 = new(39, 4);
		public static readonly (int, int) F20 = new(19, 5);
		public static readonly (int, int) F21 = new(20, 5);
		public static readonly (int, int) F22 = new(21, 5);
		public static readonly (int, int) F23 = new(22, 5);
		public static readonly (int, int) F24 = new(23, 5);
		public static readonly (int, int) F25 = new(24, 5);
		public static readonly (int, int) F26 = new(25, 5);
		public static readonly (int, int) F35 = new(34, 5);
		public static readonly (int, int) F36 = new(35, 5);
		public static readonly (int, int) F37 = new(36, 5);
		public static readonly (int, int) F38 = new(37, 5);
		public static readonly (int, int) F39 = new(38, 5);
		public static readonly (int, int) F40 = new(39, 5);
		public static readonly (int, int) F55 = new(54, 5);
		public static readonly (int, int) F66 = new(65, 5);
		public static readonly (int, int) F67 = new(66, 5);
		public static readonly (int, int) F68 = new(67, 5);
		public static readonly (int, int) F69 = new(68, 5);
		public static readonly (int, int) G20 = new(19, 6);
		public static readonly (int, int) G21 = new(20, 6);
		public static readonly (int, int) G22 = new(21, 6);
		public static readonly (int, int) G23 = new(22, 6);
		public static readonly (int, int) G24 = new(23, 6);
		public static readonly (int, int) G25 = new(24, 6);
		public static readonly (int, int) G26 = new(25, 6);
		public static readonly (int, int) G35 = new(34, 6);
		public static readonly (int, int) G36 = new(35, 6);
		public static readonly (int, int) G37 = new(36, 6);
		public static readonly (int, int) G38 = new(37, 6);
		public static readonly (int, int) G39 = new(38, 6);
		public static readonly (int, int) G40 = new(39, 6);
		public static readonly (int, int) H20 = new(19, 7);
		public static readonly (int, int) H21 = new(20, 7);
		public static readonly (int, int) H22 = new(21, 7);
		public static readonly (int, int) H23 = new(22, 7);
		public static readonly (int, int) H24 = new(23, 7);
		public static readonly (int, int) H25 = new(24, 7);
		public static readonly (int, int) H26 = new(25, 7);
		public static readonly (int, int) H35 = new(34, 7);
		public static readonly (int, int) H36 = new(35, 7);
		public static readonly (int, int) H37 = new(36, 7);
		public static readonly (int, int) H38 = new(37, 7);
		public static readonly (int, int) H39 = new(38, 7);
		public static readonly (int, int) H40 = new(39, 7);
		public static readonly (int, int) I20 = new(19, 8);
		public static readonly (int, int) I21 = new(20, 8);
		public static readonly (int, int) I22 = new(21, 8);
		public static readonly (int, int) I23 = new(22, 8);
		public static readonly (int, int) I24 = new(23, 8);
		public static readonly (int, int) I25 = new(24, 8);
		public static readonly (int, int) I26 = new(25, 8);
		public static readonly (int, int) I35 = new(34, 8);
		public static readonly (int, int) I36 = new(35, 8);
		public static readonly (int, int) I37 = new(36, 8);
		public static readonly (int, int) I38 = new(37, 8);
		public static readonly (int, int) I39 = new(38, 8);
		public static readonly (int, int) I40 = new(39, 8);
		public static readonly (int, int) J20 = new(19, 9);
		public static readonly (int, int) J21 = new(20, 9);
		public static readonly (int, int) J22 = new(21, 9);
		public static readonly (int, int) J23 = new(22, 9);
		public static readonly (int, int) J24 = new(23, 9);
		public static readonly (int, int) J25 = new(24, 9);
		public static readonly (int, int) J26 = new(25, 9);
		public static readonly (int, int) J35 = new(34, 9);
		public static readonly (int, int) J36 = new(35, 9);
		public static readonly (int, int) J37 = new(36, 9);
		public static readonly (int, int) J38 = new(37, 9);
		public static readonly (int, int) J39 = new(38, 9);
		public static readonly (int, int) J40 = new(39, 9);
		public static readonly (int, int) J44 = new(43, 9);
		public static readonly (int, int) J46 = new(45, 9);
	}
}
