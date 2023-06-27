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
	public object C66 {
		get => this[Addresses.C66];
		set => this[Addresses.C66] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object C67 {
		get => this[Addresses.C67];
		set => this[Addresses.C67] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object C68 {
		get => this[Addresses.C68];
		set => this[Addresses.C68] = value;
	}


	/// <summary>
	/// C66+C67-C68
	/// </summary>
	public object C69 {
		get => this[Addresses.C69];
		set => this[Addresses.C69] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object F66 {
		get => this[Addresses.F66];
		set => this[Addresses.F66] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object F67 {
		get => this[Addresses.F67];
		set => this[Addresses.F67] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object F68 {
		get => this[Addresses.F68];
		set => this[Addresses.F68] = value;
	}


	/// <summary>
	/// F66+F67-F68
	/// </summary>
	public object F69 {
		get => this[Addresses.F69];
		set => this[Addresses.F69] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object C20 {
		get => this[Addresses.C20];
		set => this[Addresses.C20] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object B15 {
		get => this[Addresses.B15];
		set => this[Addresses.B15] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object D20 {
		get => this[Addresses.D20];
		set => this[Addresses.D20] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object E20 {
		get => this[Addresses.E20];
		set => this[Addresses.E20] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object F20 {
		get => this[Addresses.F20];
		set => this[Addresses.F20] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object G20 {
		get => this[Addresses.G20];
		set => this[Addresses.G20] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object H20 {
		get => this[Addresses.H20];
		set => this[Addresses.H20] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object I20 {
		get => this[Addresses.I20];
		set => this[Addresses.I20] = value;
	}


	/// <summary>
	/// variable (String)
	/// </summary>
	public object J20 {
		get => this[Addresses.J20];
		set => this[Addresses.J20] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object B16 {
		get => this[Addresses.B16];
		set => this[Addresses.B16] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object B11 {
		get => this[Addresses.B11];
		set => this[Addresses.B11] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object B12 {
		get => this[Addresses.B12];
		set => this[Addresses.B12] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object C21 {
		get => this[Addresses.C21];
		set => this[Addresses.C21] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object B13 {
		get => this[Addresses.B13];
		set => this[Addresses.B13] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object C22 {
		get => this[Addresses.C22];
		set => this[Addresses.C22] = value;
	}


	/// <summary>
	/// (((B11-C20)^2)+((B12-C21)^2)+((B13-C22)^2))^0.5
	/// </summary>
	public object C35 {
		get => this[Addresses.C35];
		set => this[Addresses.C35] = value;
	}


	/// <summary>
	/// variable (String)
	/// </summary>
	public object C23 {
		get => this[Addresses.C23];
		set => this[Addresses.C23] = value;
	}


	/// <summary>
	/// IF(C23="J",5,IF(C23="n",0,"ERROR"))
	/// </summary>
	public object C36 {
		get => this[Addresses.C36];
		set => this[Addresses.C36] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object C25 {
		get => this[Addresses.C25];
		set => this[Addresses.C25] = value;
	}


	/// <summary>
	/// 10*LOG10(2/C25)*5/6
	/// </summary>
	public object C37 {
		get => this[Addresses.C37];
		set => this[Addresses.C37] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object C26 {
		get => this[Addresses.C26];
		set => this[Addresses.C26] = value;
	}


	/// <summary>
	/// 10*LOG10(2/C26)*5/6
	/// </summary>
	public object C38 {
		get => this[Addresses.C38];
		set => this[Addresses.C38] = value;
	}


	/// <summary>
	/// variable (String)
	/// </summary>
	public object C24 {
		get => this[Addresses.C24];
		set => this[Addresses.C24] = value;
	}


	/// <summary>
	/// IF(C24="j",5,(IF(C24="n",0,"ERROR")))
	/// </summary>
	public object C39 {
		get => this[Addresses.C39];
		set => this[Addresses.C39] = value;
	}


	/// <summary>
	/// 20*LOG10(C35)+9+C36-C37-C38-C39
	/// </summary>
	public object C40 {
		get => this[Addresses.C40];
		set => this[Addresses.C40] = value;
	}


	/// <summary>
	/// IF(C20<>"nvt",ROUND(B15-C40,0),"")
	/// </summary>
	public object C41 {
		get => this[Addresses.C41];
		set => this[Addresses.C41] = value;
	}


	/// <summary>
	/// IF(C20<>"nvt",ROUND(45+C40,0),"")
	/// </summary>
	public object C44 {
		get => this[Addresses.C44];
		set => this[Addresses.C44] = value;
	}


	/// <summary>
	/// IF(C20<>"nvt",ROUND(40+C40,0),"")
	/// </summary>
	public object C45 {
		get => this[Addresses.C45];
		set => this[Addresses.C45] = value;
	}


	/// <summary>
	/// IF(C20<>"nvt",(-C44),-9999)
	/// </summary>
	public object C46 {
		get => this[Addresses.C46];
		set => this[Addresses.C46] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object D21 {
		get => this[Addresses.D21];
		set => this[Addresses.D21] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object D22 {
		get => this[Addresses.D22];
		set => this[Addresses.D22] = value;
	}


	/// <summary>
	/// (((B11-D20)^2)+((B12-D21)^2)+((B13-D22)^2))^0.5
	/// </summary>
	public object D35 {
		get => this[Addresses.D35];
		set => this[Addresses.D35] = value;
	}


	/// <summary>
	/// variable (String)
	/// </summary>
	public object D23 {
		get => this[Addresses.D23];
		set => this[Addresses.D23] = value;
	}


	/// <summary>
	/// IF(D23="J",5,IF(D23="n",0,"ERROR"))
	/// </summary>
	public object D36 {
		get => this[Addresses.D36];
		set => this[Addresses.D36] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object D25 {
		get => this[Addresses.D25];
		set => this[Addresses.D25] = value;
	}


	/// <summary>
	/// 10*LOG10(2/D25)*5/6
	/// </summary>
	public object D37 {
		get => this[Addresses.D37];
		set => this[Addresses.D37] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object D26 {
		get => this[Addresses.D26];
		set => this[Addresses.D26] = value;
	}


	/// <summary>
	/// 10*LOG10(2/D26)*5/6
	/// </summary>
	public object D38 {
		get => this[Addresses.D38];
		set => this[Addresses.D38] = value;
	}


	/// <summary>
	/// variable (String)
	/// </summary>
	public object D24 {
		get => this[Addresses.D24];
		set => this[Addresses.D24] = value;
	}


	/// <summary>
	/// IF(D24="j",5,(IF(D24="n",0,"ERROR")))
	/// </summary>
	public object D39 {
		get => this[Addresses.D39];
		set => this[Addresses.D39] = value;
	}


	/// <summary>
	/// 20*LOG10(D35)+9+D36-D37-D38-D39
	/// </summary>
	public object D40 {
		get => this[Addresses.D40];
		set => this[Addresses.D40] = value;
	}


	/// <summary>
	/// IF(D20<>"nvt",ROUND(B15-D40,0),"")
	/// </summary>
	public object D41 {
		get => this[Addresses.D41];
		set => this[Addresses.D41] = value;
	}


	/// <summary>
	/// IF(D20<>"nvt",ROUND(45+D40,0),"")
	/// </summary>
	public object D44 {
		get => this[Addresses.D44];
		set => this[Addresses.D44] = value;
	}


	/// <summary>
	/// IF(D20<>"nvt",ROUND(40+D40,0),"")
	/// </summary>
	public object D45 {
		get => this[Addresses.D45];
		set => this[Addresses.D45] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object E21 {
		get => this[Addresses.E21];
		set => this[Addresses.E21] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object E22 {
		get => this[Addresses.E22];
		set => this[Addresses.E22] = value;
	}


	/// <summary>
	/// (((B11-E20)^2)+((B12-E21)^2)+((B13-E22)^2))^0.5
	/// </summary>
	public object E35 {
		get => this[Addresses.E35];
		set => this[Addresses.E35] = value;
	}


	/// <summary>
	/// variable (String)
	/// </summary>
	public object E23 {
		get => this[Addresses.E23];
		set => this[Addresses.E23] = value;
	}


	/// <summary>
	/// IF(E23="J",5,IF(E23="n",0,"ERROR"))
	/// </summary>
	public object E36 {
		get => this[Addresses.E36];
		set => this[Addresses.E36] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object E25 {
		get => this[Addresses.E25];
		set => this[Addresses.E25] = value;
	}


	/// <summary>
	/// 10*LOG10(2/E25)*5/6
	/// </summary>
	public object E37 {
		get => this[Addresses.E37];
		set => this[Addresses.E37] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object E26 {
		get => this[Addresses.E26];
		set => this[Addresses.E26] = value;
	}


	/// <summary>
	/// 10*LOG10(2/E26)*5/6
	/// </summary>
	public object E38 {
		get => this[Addresses.E38];
		set => this[Addresses.E38] = value;
	}


	/// <summary>
	/// variable (String)
	/// </summary>
	public object E24 {
		get => this[Addresses.E24];
		set => this[Addresses.E24] = value;
	}


	/// <summary>
	/// IF(E24="j",5,(IF(E24="n",0,"ERROR")))
	/// </summary>
	public object E39 {
		get => this[Addresses.E39];
		set => this[Addresses.E39] = value;
	}


	/// <summary>
	/// 20*LOG10(E35)+9+E36-E37-E38-E39
	/// </summary>
	public object E40 {
		get => this[Addresses.E40];
		set => this[Addresses.E40] = value;
	}


	/// <summary>
	/// IF(E20<>"nvt",ROUND(B15-E40,0),"")
	/// </summary>
	public object E41 {
		get => this[Addresses.E41];
		set => this[Addresses.E41] = value;
	}


	/// <summary>
	/// IF(E20<>"nvt",ROUND(45+E40,0),"")
	/// </summary>
	public object E44 {
		get => this[Addresses.E44];
		set => this[Addresses.E44] = value;
	}


	/// <summary>
	/// IF(E20<>"nvt",ROUND(40+E40,0),"")
	/// </summary>
	public object E45 {
		get => this[Addresses.E45];
		set => this[Addresses.E45] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object F21 {
		get => this[Addresses.F21];
		set => this[Addresses.F21] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object F22 {
		get => this[Addresses.F22];
		set => this[Addresses.F22] = value;
	}


	/// <summary>
	/// (((B11-F20)^2)+((B12-F21)^2)+((B13-F22)^2))^0.5
	/// </summary>
	public object F35 {
		get => this[Addresses.F35];
		set => this[Addresses.F35] = value;
	}


	/// <summary>
	/// variable (String)
	/// </summary>
	public object F23 {
		get => this[Addresses.F23];
		set => this[Addresses.F23] = value;
	}


	/// <summary>
	/// IF(F23="J",5,IF(F23="n",0,"ERROR"))
	/// </summary>
	public object F36 {
		get => this[Addresses.F36];
		set => this[Addresses.F36] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object F25 {
		get => this[Addresses.F25];
		set => this[Addresses.F25] = value;
	}


	/// <summary>
	/// 10*LOG10(2/F25)*5/6
	/// </summary>
	public object F37 {
		get => this[Addresses.F37];
		set => this[Addresses.F37] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object F26 {
		get => this[Addresses.F26];
		set => this[Addresses.F26] = value;
	}


	/// <summary>
	/// 10*LOG10(2/F26)*5/6
	/// </summary>
	public object F38 {
		get => this[Addresses.F38];
		set => this[Addresses.F38] = value;
	}


	/// <summary>
	/// variable (String)
	/// </summary>
	public object F24 {
		get => this[Addresses.F24];
		set => this[Addresses.F24] = value;
	}


	/// <summary>
	/// IF(F24="j",5,(IF(F24="n",0,"ERROR")))
	/// </summary>
	public object F39 {
		get => this[Addresses.F39];
		set => this[Addresses.F39] = value;
	}


	/// <summary>
	/// 20*LOG10(F35)+9+F36-F37-F38-F39
	/// </summary>
	public object F40 {
		get => this[Addresses.F40];
		set => this[Addresses.F40] = value;
	}


	/// <summary>
	/// IF(F20<>"nvt",ROUND(B15-F40,0),"")
	/// </summary>
	public object F41 {
		get => this[Addresses.F41];
		set => this[Addresses.F41] = value;
	}


	/// <summary>
	/// IF(F20<>"nvt",ROUND(45+F40,0),"")
	/// </summary>
	public object F44 {
		get => this[Addresses.F44];
		set => this[Addresses.F44] = value;
	}


	/// <summary>
	/// IF(F20<>"nvt",ROUND(40+F40,0),"")
	/// </summary>
	public object F45 {
		get => this[Addresses.F45];
		set => this[Addresses.F45] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object G21 {
		get => this[Addresses.G21];
		set => this[Addresses.G21] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object G22 {
		get => this[Addresses.G22];
		set => this[Addresses.G22] = value;
	}


	/// <summary>
	/// (((B11-G20)^2)+((B12-G21)^2)+((B13-G22)^2))^0.5
	/// </summary>
	public object G35 {
		get => this[Addresses.G35];
		set => this[Addresses.G35] = value;
	}


	/// <summary>
	/// variable (String)
	/// </summary>
	public object G23 {
		get => this[Addresses.G23];
		set => this[Addresses.G23] = value;
	}


	/// <summary>
	/// IF(G23="J",5,IF(G23="n",0,"ERROR"))
	/// </summary>
	public object G36 {
		get => this[Addresses.G36];
		set => this[Addresses.G36] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object G25 {
		get => this[Addresses.G25];
		set => this[Addresses.G25] = value;
	}


	/// <summary>
	/// 10*LOG10(2/G25)*5/6
	/// </summary>
	public object G37 {
		get => this[Addresses.G37];
		set => this[Addresses.G37] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object G26 {
		get => this[Addresses.G26];
		set => this[Addresses.G26] = value;
	}


	/// <summary>
	/// 10*LOG10(2/G26)*5/6
	/// </summary>
	public object G38 {
		get => this[Addresses.G38];
		set => this[Addresses.G38] = value;
	}


	/// <summary>
	/// variable (String)
	/// </summary>
	public object G24 {
		get => this[Addresses.G24];
		set => this[Addresses.G24] = value;
	}


	/// <summary>
	/// IF(G24="j",5,(IF(G24="n",0,"ERROR")))
	/// </summary>
	public object G39 {
		get => this[Addresses.G39];
		set => this[Addresses.G39] = value;
	}


	/// <summary>
	/// 20*LOG10(G35)+9+G36-G37-G38-G39
	/// </summary>
	public object G40 {
		get => this[Addresses.G40];
		set => this[Addresses.G40] = value;
	}


	/// <summary>
	/// IF(G20<>"nvt",ROUND(B15-G40,0),"")
	/// </summary>
	public object G41 {
		get => this[Addresses.G41];
		set => this[Addresses.G41] = value;
	}


	/// <summary>
	/// IF(G20<>"nvt",ROUND(45+G40,0),"")
	/// </summary>
	public object G44 {
		get => this[Addresses.G44];
		set => this[Addresses.G44] = value;
	}


	/// <summary>
	/// IF(G20<>"nvt",ROUND(40+G40,0),"")
	/// </summary>
	public object G45 {
		get => this[Addresses.G45];
		set => this[Addresses.G45] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object H21 {
		get => this[Addresses.H21];
		set => this[Addresses.H21] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object H22 {
		get => this[Addresses.H22];
		set => this[Addresses.H22] = value;
	}


	/// <summary>
	/// (((B11-H20)^2)+((B12-H21)^2)+((B13-H22)^2))^0.5
	/// </summary>
	public object H35 {
		get => this[Addresses.H35];
		set => this[Addresses.H35] = value;
	}


	/// <summary>
	/// variable (String)
	/// </summary>
	public object H23 {
		get => this[Addresses.H23];
		set => this[Addresses.H23] = value;
	}


	/// <summary>
	/// IF(H23="J",5,IF(H23="n",0,"ERROR"))
	/// </summary>
	public object H36 {
		get => this[Addresses.H36];
		set => this[Addresses.H36] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object H25 {
		get => this[Addresses.H25];
		set => this[Addresses.H25] = value;
	}


	/// <summary>
	/// 10*LOG10(2/H25)*5/6
	/// </summary>
	public object H37 {
		get => this[Addresses.H37];
		set => this[Addresses.H37] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object H26 {
		get => this[Addresses.H26];
		set => this[Addresses.H26] = value;
	}


	/// <summary>
	/// 10*LOG10(2/H26)*5/6
	/// </summary>
	public object H38 {
		get => this[Addresses.H38];
		set => this[Addresses.H38] = value;
	}


	/// <summary>
	/// variable (String)
	/// </summary>
	public object H24 {
		get => this[Addresses.H24];
		set => this[Addresses.H24] = value;
	}


	/// <summary>
	/// IF(H24="j",5,(IF(H24="n",0,"ERROR")))
	/// </summary>
	public object H39 {
		get => this[Addresses.H39];
		set => this[Addresses.H39] = value;
	}


	/// <summary>
	/// 20*LOG10(H35)+9+H36-H37-H38-H39
	/// </summary>
	public object H40 {
		get => this[Addresses.H40];
		set => this[Addresses.H40] = value;
	}


	/// <summary>
	/// IF(H20<>"nvt",ROUND(B15-H40,0),"")
	/// </summary>
	public object H41 {
		get => this[Addresses.H41];
		set => this[Addresses.H41] = value;
	}


	/// <summary>
	/// IF(H20<>"nvt",ROUND(45+H40,0),"")
	/// </summary>
	public object H44 {
		get => this[Addresses.H44];
		set => this[Addresses.H44] = value;
	}


	/// <summary>
	/// IF(H20<>"nvt",ROUND(40+H40,0),"")
	/// </summary>
	public object H45 {
		get => this[Addresses.H45];
		set => this[Addresses.H45] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object I21 {
		get => this[Addresses.I21];
		set => this[Addresses.I21] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object I22 {
		get => this[Addresses.I22];
		set => this[Addresses.I22] = value;
	}


	/// <summary>
	/// (((B11-I20)^2)+((B12-I21)^2)+((B13-I22)^2))^0.5
	/// </summary>
	public object I35 {
		get => this[Addresses.I35];
		set => this[Addresses.I35] = value;
	}


	/// <summary>
	/// variable (String)
	/// </summary>
	public object I23 {
		get => this[Addresses.I23];
		set => this[Addresses.I23] = value;
	}


	/// <summary>
	/// IF(I23="J",5,IF(I23="n",0,"ERROR"))
	/// </summary>
	public object I36 {
		get => this[Addresses.I36];
		set => this[Addresses.I36] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object I25 {
		get => this[Addresses.I25];
		set => this[Addresses.I25] = value;
	}


	/// <summary>
	/// 10*LOG10(2/I25)*5/6
	/// </summary>
	public object I37 {
		get => this[Addresses.I37];
		set => this[Addresses.I37] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object I26 {
		get => this[Addresses.I26];
		set => this[Addresses.I26] = value;
	}


	/// <summary>
	/// 10*LOG10(2/I26)*5/6
	/// </summary>
	public object I38 {
		get => this[Addresses.I38];
		set => this[Addresses.I38] = value;
	}


	/// <summary>
	/// variable (String)
	/// </summary>
	public object I24 {
		get => this[Addresses.I24];
		set => this[Addresses.I24] = value;
	}


	/// <summary>
	/// IF(I24="j",5,(IF(I24="n",0,"ERROR")))
	/// </summary>
	public object I39 {
		get => this[Addresses.I39];
		set => this[Addresses.I39] = value;
	}


	/// <summary>
	/// 20*LOG10(I35)+9+I36-I37-I38-I39
	/// </summary>
	public object I40 {
		get => this[Addresses.I40];
		set => this[Addresses.I40] = value;
	}


	/// <summary>
	/// IF(I20<>"nvt",ROUND(B15-I40,0),"")
	/// </summary>
	public object I41 {
		get => this[Addresses.I41];
		set => this[Addresses.I41] = value;
	}


	/// <summary>
	/// IF(I20<>"nvt",ROUND(45+I40,0),"")
	/// </summary>
	public object I44 {
		get => this[Addresses.I44];
		set => this[Addresses.I44] = value;
	}


	/// <summary>
	/// IF(I20<>"nvt",ROUND(40+I40,0),"")
	/// </summary>
	public object I45 {
		get => this[Addresses.I45];
		set => this[Addresses.I45] = value;
	}


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
	public object J35 {
		get => this[Addresses.J35];
		set => this[Addresses.J35] = value;
	}


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
	public object J36 {
		get => this[Addresses.J36];
		set => this[Addresses.J36] = value;
	}


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
	public object J37 {
		get => this[Addresses.J37];
		set => this[Addresses.J37] = value;
	}


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
	public object J38 {
		get => this[Addresses.J38];
		set => this[Addresses.J38] = value;
	}


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
	public object J39 {
		get => this[Addresses.J39];
		set => this[Addresses.J39] = value;
	}


	/// <summary>
	/// 20*LOG10(J35)+9+J36-J37-J38-J39
	/// </summary>
	public object J40 {
		get => this[Addresses.J40];
		set => this[Addresses.J40] = value;
	}


	/// <summary>
	/// IF(J20<>"nvt",ROUND(B15-J40,0),"")
	/// </summary>
	public object J41 {
		get => this[Addresses.J41];
		set => this[Addresses.J41] = value;
	}


	/// <summary>
	/// IF(J20<>"nvt",ROUND(45+J40,0),"")
	/// </summary>
	public object J44 {
		get => this[Addresses.J44];
		set => this[Addresses.J44] = value;
	}


	/// <summary>
	/// IF(J20<>"nvt",ROUND(40+J40,0),"")
	/// </summary>
	public object J45 {
		get => this[Addresses.J45];
		set => this[Addresses.J45] = value;
	}


	/// <summary>
	/// IF(J20<>"nvt",(-J44),-9999)
	/// </summary>
	public object J46 {
		get => this[Addresses.J46];
		set => this[Addresses.J46] = value;
	}


	/// <summary>
	/// (-MAX(C46:J46))-B16
	/// </summary>
	public object C48 {
		get => this[Addresses.C48];
		set => this[Addresses.C48] = value;
	}


	/// <summary>
	/// ROUND(C48,0)
	/// </summary>
	public object C55 {
		get => this[Addresses.C55];
		set => this[Addresses.C55] = value;
	}


	/// <summary>
	/// IF(C69<=C55,"VOLDOET","VOLDOET NIET")
	/// </summary>
	public object B70 {
		get => this[Addresses.B70];
		set => this[Addresses.B70] = value;
	}


	/// <summary>
	/// C48-5
	/// </summary>
	public object C49 {
		get => this[Addresses.C49];
		set => this[Addresses.C49] = value;
	}


	/// <summary>
	/// ROUND(C49,0)
	/// </summary>
	public object F55 {
		get => this[Addresses.F55];
		set => this[Addresses.F55] = value;
	}


	/// <summary>
	/// IF(F69<=F55,"VOLDOET","VOLDOET NIET")
	/// </summary>
	public object E70 {
		get => this[Addresses.E70];
		set => this[Addresses.E70] = value;
	}

	
	protected override IEnumerable<KeyValuePair<string, Func<object>>> GetFormulas()
	{
		yield return new KeyValuePair<string, Func<object>>("C69", () => Subtract(Add(C66, C67), C68));
		yield return new KeyValuePair<string, Func<object>>("F69", () => Subtract(Add(F66, F67), F68));
		yield return new KeyValuePair<string, Func<object>>("C35", () => Pow((Add(Add((Pow((Subtract(B11, C20)), 2)), (Pow((Subtract(B12, C21)), 2))), (Pow((Subtract(B13, C22)), 2)))), 0.5));
		yield return new KeyValuePair<string, Func<object>>("C36", () => IF(object.Equals(C23, "J"), 5, IF(object.Equals(C23, "n"), 0, "ERROR")));
		yield return new KeyValuePair<string, Func<object>>("C37", () => Divide(Multiply(Multiply(10, LOG10(Divide(2, C25))), 5), 6));
		yield return new KeyValuePair<string, Func<object>>("C38", () => Divide(Multiply(Multiply(10, LOG10(Divide(2, C26))), 5), 6));
		yield return new KeyValuePair<string, Func<object>>("C39", () => IF(object.Equals(C24, "j"), 5, (IF(object.Equals(C24, "n"), 0, "ERROR"))));
		yield return new KeyValuePair<string, Func<object>>("C40", () => Subtract(Subtract(Subtract(Add(Add(Multiply(20, LOG10(C35)), 9), C36), C37), C38), C39));
		yield return new KeyValuePair<string, Func<object>>("C41", () => IF(!object.Equals(C20, "nvt"), ROUND(Subtract(B15, C40), 0), ""));
		yield return new KeyValuePair<string, Func<object>>("C44", () => IF(!object.Equals(C20, "nvt"), ROUND(Add(45, C40), 0), ""));
		yield return new KeyValuePair<string, Func<object>>("C45", () => IF(!object.Equals(C20, "nvt"), ROUND(Add(40, C40), 0), ""));
		yield return new KeyValuePair<string, Func<object>>("C46", () => IF(!object.Equals(C20, "nvt"), (Negate(C44)), Negate(9999)));
		yield return new KeyValuePair<string, Func<object>>("D35", () => Pow((Add(Add((Pow((Subtract(B11, D20)), 2)), (Pow((Subtract(B12, D21)), 2))), (Pow((Subtract(B13, D22)), 2)))), 0.5));
		yield return new KeyValuePair<string, Func<object>>("D36", () => IF(object.Equals(D23, "J"), 5, IF(object.Equals(D23, "n"), 0, "ERROR")));
		yield return new KeyValuePair<string, Func<object>>("D37", () => Divide(Multiply(Multiply(10, LOG10(Divide(2, D25))), 5), 6));
		yield return new KeyValuePair<string, Func<object>>("D38", () => Divide(Multiply(Multiply(10, LOG10(Divide(2, D26))), 5), 6));
		yield return new KeyValuePair<string, Func<object>>("D39", () => IF(object.Equals(D24, "j"), 5, (IF(object.Equals(D24, "n"), 0, "ERROR"))));
		yield return new KeyValuePair<string, Func<object>>("D40", () => Subtract(Subtract(Subtract(Add(Add(Multiply(20, LOG10(D35)), 9), D36), D37), D38), D39));
		yield return new KeyValuePair<string, Func<object>>("D41", () => IF(!object.Equals(D20, "nvt"), ROUND(Subtract(B15, D40), 0), ""));
		yield return new KeyValuePair<string, Func<object>>("D44", () => IF(!object.Equals(D20, "nvt"), ROUND(Add(45, D40), 0), ""));
		yield return new KeyValuePair<string, Func<object>>("D45", () => IF(!object.Equals(D20, "nvt"), ROUND(Add(40, D40), 0), ""));
		yield return new KeyValuePair<string, Func<object>>("E35", () => Pow((Add(Add((Pow((Subtract(B11, E20)), 2)), (Pow((Subtract(B12, E21)), 2))), (Pow((Subtract(B13, E22)), 2)))), 0.5));
		yield return new KeyValuePair<string, Func<object>>("E36", () => IF(object.Equals(E23, "J"), 5, IF(object.Equals(E23, "n"), 0, "ERROR")));
		yield return new KeyValuePair<string, Func<object>>("E37", () => Divide(Multiply(Multiply(10, LOG10(Divide(2, E25))), 5), 6));
		yield return new KeyValuePair<string, Func<object>>("E38", () => Divide(Multiply(Multiply(10, LOG10(Divide(2, E26))), 5), 6));
		yield return new KeyValuePair<string, Func<object>>("E39", () => IF(object.Equals(E24, "j"), 5, (IF(object.Equals(E24, "n"), 0, "ERROR"))));
		yield return new KeyValuePair<string, Func<object>>("E40", () => Subtract(Subtract(Subtract(Add(Add(Multiply(20, LOG10(E35)), 9), E36), E37), E38), E39));
		yield return new KeyValuePair<string, Func<object>>("E41", () => IF(!object.Equals(E20, "nvt"), ROUND(Subtract(B15, E40), 0), ""));
		yield return new KeyValuePair<string, Func<object>>("E44", () => IF(!object.Equals(E20, "nvt"), ROUND(Add(45, E40), 0), ""));
		yield return new KeyValuePair<string, Func<object>>("E45", () => IF(!object.Equals(E20, "nvt"), ROUND(Add(40, E40), 0), ""));
		yield return new KeyValuePair<string, Func<object>>("F35", () => Pow((Add(Add((Pow((Subtract(B11, F20)), 2)), (Pow((Subtract(B12, F21)), 2))), (Pow((Subtract(B13, F22)), 2)))), 0.5));
		yield return new KeyValuePair<string, Func<object>>("F36", () => IF(object.Equals(F23, "J"), 5, IF(object.Equals(F23, "n"), 0, "ERROR")));
		yield return new KeyValuePair<string, Func<object>>("F37", () => Divide(Multiply(Multiply(10, LOG10(Divide(2, F25))), 5), 6));
		yield return new KeyValuePair<string, Func<object>>("F38", () => Divide(Multiply(Multiply(10, LOG10(Divide(2, F26))), 5), 6));
		yield return new KeyValuePair<string, Func<object>>("F39", () => IF(object.Equals(F24, "j"), 5, (IF(object.Equals(F24, "n"), 0, "ERROR"))));
		yield return new KeyValuePair<string, Func<object>>("F40", () => Subtract(Subtract(Subtract(Add(Add(Multiply(20, LOG10(F35)), 9), F36), F37), F38), F39));
		yield return new KeyValuePair<string, Func<object>>("F41", () => IF(!object.Equals(F20, "nvt"), ROUND(Subtract(B15, F40), 0), ""));
		yield return new KeyValuePair<string, Func<object>>("F44", () => IF(!object.Equals(F20, "nvt"), ROUND(Add(45, F40), 0), ""));
		yield return new KeyValuePair<string, Func<object>>("F45", () => IF(!object.Equals(F20, "nvt"), ROUND(Add(40, F40), 0), ""));
		yield return new KeyValuePair<string, Func<object>>("G35", () => Pow((Add(Add((Pow((Subtract(B11, G20)), 2)), (Pow((Subtract(B12, G21)), 2))), (Pow((Subtract(B13, G22)), 2)))), 0.5));
		yield return new KeyValuePair<string, Func<object>>("G36", () => IF(object.Equals(G23, "J"), 5, IF(object.Equals(G23, "n"), 0, "ERROR")));
		yield return new KeyValuePair<string, Func<object>>("G37", () => Divide(Multiply(Multiply(10, LOG10(Divide(2, G25))), 5), 6));
		yield return new KeyValuePair<string, Func<object>>("G38", () => Divide(Multiply(Multiply(10, LOG10(Divide(2, G26))), 5), 6));
		yield return new KeyValuePair<string, Func<object>>("G39", () => IF(object.Equals(G24, "j"), 5, (IF(object.Equals(G24, "n"), 0, "ERROR"))));
		yield return new KeyValuePair<string, Func<object>>("G40", () => Subtract(Subtract(Subtract(Add(Add(Multiply(20, LOG10(G35)), 9), G36), G37), G38), G39));
		yield return new KeyValuePair<string, Func<object>>("G41", () => IF(!object.Equals(G20, "nvt"), ROUND(Subtract(B15, G40), 0), ""));
		yield return new KeyValuePair<string, Func<object>>("G44", () => IF(!object.Equals(G20, "nvt"), ROUND(Add(45, G40), 0), ""));
		yield return new KeyValuePair<string, Func<object>>("G45", () => IF(!object.Equals(G20, "nvt"), ROUND(Add(40, G40), 0), ""));
		yield return new KeyValuePair<string, Func<object>>("H35", () => Pow((Add(Add((Pow((Subtract(B11, H20)), 2)), (Pow((Subtract(B12, H21)), 2))), (Pow((Subtract(B13, H22)), 2)))), 0.5));
		yield return new KeyValuePair<string, Func<object>>("H36", () => IF(object.Equals(H23, "J"), 5, IF(object.Equals(H23, "n"), 0, "ERROR")));
		yield return new KeyValuePair<string, Func<object>>("H37", () => Divide(Multiply(Multiply(10, LOG10(Divide(2, H25))), 5), 6));
		yield return new KeyValuePair<string, Func<object>>("H38", () => Divide(Multiply(Multiply(10, LOG10(Divide(2, H26))), 5), 6));
		yield return new KeyValuePair<string, Func<object>>("H39", () => IF(object.Equals(H24, "j"), 5, (IF(object.Equals(H24, "n"), 0, "ERROR"))));
		yield return new KeyValuePair<string, Func<object>>("H40", () => Subtract(Subtract(Subtract(Add(Add(Multiply(20, LOG10(H35)), 9), H36), H37), H38), H39));
		yield return new KeyValuePair<string, Func<object>>("H41", () => IF(!object.Equals(H20, "nvt"), ROUND(Subtract(B15, H40), 0), ""));
		yield return new KeyValuePair<string, Func<object>>("H44", () => IF(!object.Equals(H20, "nvt"), ROUND(Add(45, H40), 0), ""));
		yield return new KeyValuePair<string, Func<object>>("H45", () => IF(!object.Equals(H20, "nvt"), ROUND(Add(40, H40), 0), ""));
		yield return new KeyValuePair<string, Func<object>>("I35", () => Pow((Add(Add((Pow((Subtract(B11, I20)), 2)), (Pow((Subtract(B12, I21)), 2))), (Pow((Subtract(B13, I22)), 2)))), 0.5));
		yield return new KeyValuePair<string, Func<object>>("I36", () => IF(object.Equals(I23, "J"), 5, IF(object.Equals(I23, "n"), 0, "ERROR")));
		yield return new KeyValuePair<string, Func<object>>("I37", () => Divide(Multiply(Multiply(10, LOG10(Divide(2, I25))), 5), 6));
		yield return new KeyValuePair<string, Func<object>>("I38", () => Divide(Multiply(Multiply(10, LOG10(Divide(2, I26))), 5), 6));
		yield return new KeyValuePair<string, Func<object>>("I39", () => IF(object.Equals(I24, "j"), 5, (IF(object.Equals(I24, "n"), 0, "ERROR"))));
		yield return new KeyValuePair<string, Func<object>>("I40", () => Subtract(Subtract(Subtract(Add(Add(Multiply(20, LOG10(I35)), 9), I36), I37), I38), I39));
		yield return new KeyValuePair<string, Func<object>>("I41", () => IF(!object.Equals(I20, "nvt"), ROUND(Subtract(B15, I40), 0), ""));
		yield return new KeyValuePair<string, Func<object>>("I44", () => IF(!object.Equals(I20, "nvt"), ROUND(Add(45, I40), 0), ""));
		yield return new KeyValuePair<string, Func<object>>("I45", () => IF(!object.Equals(I20, "nvt"), ROUND(Add(40, I40), 0), ""));
		yield return new KeyValuePair<string, Func<object>>("J35", () => Pow((Add(Add((Pow((Subtract(B11, J20)), 2)), (Pow((Subtract(B12, J21)), 2))), (Pow((Subtract(B13, J22)), 2)))), 0.5));
		yield return new KeyValuePair<string, Func<object>>("J36", () => IF(object.Equals(J23, "J"), 5, IF(object.Equals(J23, "n"), 0, "ERROR")));
		yield return new KeyValuePair<string, Func<object>>("J37", () => Divide(Multiply(Multiply(10, LOG10(Divide(2, J25))), 5), 6));
		yield return new KeyValuePair<string, Func<object>>("J38", () => Divide(Multiply(Multiply(10, LOG10(Divide(2, J26))), 5), 6));
		yield return new KeyValuePair<string, Func<object>>("J39", () => IF(object.Equals(J24, "j"), 5, (IF(object.Equals(J24, "n"), 0, "ERROR"))));
		yield return new KeyValuePair<string, Func<object>>("J40", () => Subtract(Subtract(Subtract(Add(Add(Multiply(20, LOG10(J35)), 9), J36), J37), J38), J39));
		yield return new KeyValuePair<string, Func<object>>("J41", () => IF(!object.Equals(J20, "nvt"), ROUND(Subtract(B15, J40), 0), ""));
		yield return new KeyValuePair<string, Func<object>>("J44", () => IF(!object.Equals(J20, "nvt"), ROUND(Add(45, J40), 0), ""));
		yield return new KeyValuePair<string, Func<object>>("J45", () => IF(!object.Equals(J20, "nvt"), ROUND(Add(40, J40), 0), ""));
		yield return new KeyValuePair<string, Func<object>>("J46", () => IF(!object.Equals(J20, "nvt"), (Negate(J44)), Negate(9999)));
		yield return new KeyValuePair<string, Func<object>>("C48", () => Subtract((Negate(MAX(new CellRange(Addresses.C46, Addresses.J46)))), B16));
		yield return new KeyValuePair<string, Func<object>>("C55", () => ROUND(C48, 0));
		yield return new KeyValuePair<string, Func<object>>("B70", () => IF(LessOrEqual(C69, C55), "VOLDOET", "VOLDOET NIET"));
		yield return new KeyValuePair<string, Func<object>>("C49", () => Subtract(C48, 5));
		yield return new KeyValuePair<string, Func<object>>("F55", () => ROUND(C49, 0));
		yield return new KeyValuePair<string, Func<object>>("E70", () => IF(LessOrEqual(F69, F55), "VOLDOET", "VOLDOET NIET"));
	}
	
	public static class Addresses
	{
		public static readonly CellRef B11 = CellRef.Parse("B11");
		public static readonly CellRef B12 = CellRef.Parse("B12");
		public static readonly CellRef B13 = CellRef.Parse("B13");
		public static readonly CellRef B15 = CellRef.Parse("B15");
		public static readonly CellRef B16 = CellRef.Parse("B16");
		public static readonly CellRef B70 = CellRef.Parse("B70");
		public static readonly CellRef C20 = CellRef.Parse("C20");
		public static readonly CellRef C21 = CellRef.Parse("C21");
		public static readonly CellRef C22 = CellRef.Parse("C22");
		public static readonly CellRef C23 = CellRef.Parse("C23");
		public static readonly CellRef C24 = CellRef.Parse("C24");
		public static readonly CellRef C25 = CellRef.Parse("C25");
		public static readonly CellRef C26 = CellRef.Parse("C26");
		public static readonly CellRef C35 = CellRef.Parse("C35");
		public static readonly CellRef C36 = CellRef.Parse("C36");
		public static readonly CellRef C37 = CellRef.Parse("C37");
		public static readonly CellRef C38 = CellRef.Parse("C38");
		public static readonly CellRef C39 = CellRef.Parse("C39");
		public static readonly CellRef C40 = CellRef.Parse("C40");
		public static readonly CellRef C41 = CellRef.Parse("C41");
		public static readonly CellRef C44 = CellRef.Parse("C44");
		public static readonly CellRef C45 = CellRef.Parse("C45");
		public static readonly CellRef C46 = CellRef.Parse("C46");
		public static readonly CellRef C48 = CellRef.Parse("C48");
		public static readonly CellRef C49 = CellRef.Parse("C49");
		public static readonly CellRef C55 = CellRef.Parse("C55");
		public static readonly CellRef C66 = CellRef.Parse("C66");
		public static readonly CellRef C67 = CellRef.Parse("C67");
		public static readonly CellRef C68 = CellRef.Parse("C68");
		public static readonly CellRef C69 = CellRef.Parse("C69");
		public static readonly CellRef D20 = CellRef.Parse("D20");
		public static readonly CellRef D21 = CellRef.Parse("D21");
		public static readonly CellRef D22 = CellRef.Parse("D22");
		public static readonly CellRef D23 = CellRef.Parse("D23");
		public static readonly CellRef D24 = CellRef.Parse("D24");
		public static readonly CellRef D25 = CellRef.Parse("D25");
		public static readonly CellRef D26 = CellRef.Parse("D26");
		public static readonly CellRef D35 = CellRef.Parse("D35");
		public static readonly CellRef D36 = CellRef.Parse("D36");
		public static readonly CellRef D37 = CellRef.Parse("D37");
		public static readonly CellRef D38 = CellRef.Parse("D38");
		public static readonly CellRef D39 = CellRef.Parse("D39");
		public static readonly CellRef D40 = CellRef.Parse("D40");
		public static readonly CellRef D41 = CellRef.Parse("D41");
		public static readonly CellRef D44 = CellRef.Parse("D44");
		public static readonly CellRef D45 = CellRef.Parse("D45");
		public static readonly CellRef E20 = CellRef.Parse("E20");
		public static readonly CellRef E21 = CellRef.Parse("E21");
		public static readonly CellRef E22 = CellRef.Parse("E22");
		public static readonly CellRef E23 = CellRef.Parse("E23");
		public static readonly CellRef E24 = CellRef.Parse("E24");
		public static readonly CellRef E25 = CellRef.Parse("E25");
		public static readonly CellRef E26 = CellRef.Parse("E26");
		public static readonly CellRef E35 = CellRef.Parse("E35");
		public static readonly CellRef E36 = CellRef.Parse("E36");
		public static readonly CellRef E37 = CellRef.Parse("E37");
		public static readonly CellRef E38 = CellRef.Parse("E38");
		public static readonly CellRef E39 = CellRef.Parse("E39");
		public static readonly CellRef E40 = CellRef.Parse("E40");
		public static readonly CellRef E41 = CellRef.Parse("E41");
		public static readonly CellRef E44 = CellRef.Parse("E44");
		public static readonly CellRef E45 = CellRef.Parse("E45");
		public static readonly CellRef E70 = CellRef.Parse("E70");
		public static readonly CellRef F20 = CellRef.Parse("F20");
		public static readonly CellRef F21 = CellRef.Parse("F21");
		public static readonly CellRef F22 = CellRef.Parse("F22");
		public static readonly CellRef F23 = CellRef.Parse("F23");
		public static readonly CellRef F24 = CellRef.Parse("F24");
		public static readonly CellRef F25 = CellRef.Parse("F25");
		public static readonly CellRef F26 = CellRef.Parse("F26");
		public static readonly CellRef F35 = CellRef.Parse("F35");
		public static readonly CellRef F36 = CellRef.Parse("F36");
		public static readonly CellRef F37 = CellRef.Parse("F37");
		public static readonly CellRef F38 = CellRef.Parse("F38");
		public static readonly CellRef F39 = CellRef.Parse("F39");
		public static readonly CellRef F40 = CellRef.Parse("F40");
		public static readonly CellRef F41 = CellRef.Parse("F41");
		public static readonly CellRef F44 = CellRef.Parse("F44");
		public static readonly CellRef F45 = CellRef.Parse("F45");
		public static readonly CellRef F55 = CellRef.Parse("F55");
		public static readonly CellRef F66 = CellRef.Parse("F66");
		public static readonly CellRef F67 = CellRef.Parse("F67");
		public static readonly CellRef F68 = CellRef.Parse("F68");
		public static readonly CellRef F69 = CellRef.Parse("F69");
		public static readonly CellRef G20 = CellRef.Parse("G20");
		public static readonly CellRef G21 = CellRef.Parse("G21");
		public static readonly CellRef G22 = CellRef.Parse("G22");
		public static readonly CellRef G23 = CellRef.Parse("G23");
		public static readonly CellRef G24 = CellRef.Parse("G24");
		public static readonly CellRef G25 = CellRef.Parse("G25");
		public static readonly CellRef G26 = CellRef.Parse("G26");
		public static readonly CellRef G35 = CellRef.Parse("G35");
		public static readonly CellRef G36 = CellRef.Parse("G36");
		public static readonly CellRef G37 = CellRef.Parse("G37");
		public static readonly CellRef G38 = CellRef.Parse("G38");
		public static readonly CellRef G39 = CellRef.Parse("G39");
		public static readonly CellRef G40 = CellRef.Parse("G40");
		public static readonly CellRef G41 = CellRef.Parse("G41");
		public static readonly CellRef G44 = CellRef.Parse("G44");
		public static readonly CellRef G45 = CellRef.Parse("G45");
		public static readonly CellRef H20 = CellRef.Parse("H20");
		public static readonly CellRef H21 = CellRef.Parse("H21");
		public static readonly CellRef H22 = CellRef.Parse("H22");
		public static readonly CellRef H23 = CellRef.Parse("H23");
		public static readonly CellRef H24 = CellRef.Parse("H24");
		public static readonly CellRef H25 = CellRef.Parse("H25");
		public static readonly CellRef H26 = CellRef.Parse("H26");
		public static readonly CellRef H35 = CellRef.Parse("H35");
		public static readonly CellRef H36 = CellRef.Parse("H36");
		public static readonly CellRef H37 = CellRef.Parse("H37");
		public static readonly CellRef H38 = CellRef.Parse("H38");
		public static readonly CellRef H39 = CellRef.Parse("H39");
		public static readonly CellRef H40 = CellRef.Parse("H40");
		public static readonly CellRef H41 = CellRef.Parse("H41");
		public static readonly CellRef H44 = CellRef.Parse("H44");
		public static readonly CellRef H45 = CellRef.Parse("H45");
		public static readonly CellRef I20 = CellRef.Parse("I20");
		public static readonly CellRef I21 = CellRef.Parse("I21");
		public static readonly CellRef I22 = CellRef.Parse("I22");
		public static readonly CellRef I23 = CellRef.Parse("I23");
		public static readonly CellRef I24 = CellRef.Parse("I24");
		public static readonly CellRef I25 = CellRef.Parse("I25");
		public static readonly CellRef I26 = CellRef.Parse("I26");
		public static readonly CellRef I35 = CellRef.Parse("I35");
		public static readonly CellRef I36 = CellRef.Parse("I36");
		public static readonly CellRef I37 = CellRef.Parse("I37");
		public static readonly CellRef I38 = CellRef.Parse("I38");
		public static readonly CellRef I39 = CellRef.Parse("I39");
		public static readonly CellRef I40 = CellRef.Parse("I40");
		public static readonly CellRef I41 = CellRef.Parse("I41");
		public static readonly CellRef I44 = CellRef.Parse("I44");
		public static readonly CellRef I45 = CellRef.Parse("I45");
		public static readonly CellRef J20 = CellRef.Parse("J20");
		public static readonly CellRef J21 = CellRef.Parse("J21");
		public static readonly CellRef J22 = CellRef.Parse("J22");
		public static readonly CellRef J23 = CellRef.Parse("J23");
		public static readonly CellRef J24 = CellRef.Parse("J24");
		public static readonly CellRef J25 = CellRef.Parse("J25");
		public static readonly CellRef J26 = CellRef.Parse("J26");
		public static readonly CellRef J35 = CellRef.Parse("J35");
		public static readonly CellRef J36 = CellRef.Parse("J36");
		public static readonly CellRef J37 = CellRef.Parse("J37");
		public static readonly CellRef J38 = CellRef.Parse("J38");
		public static readonly CellRef J39 = CellRef.Parse("J39");
		public static readonly CellRef J40 = CellRef.Parse("J40");
		public static readonly CellRef J41 = CellRef.Parse("J41");
		public static readonly CellRef J44 = CellRef.Parse("J44");
		public static readonly CellRef J45 = CellRef.Parse("J45");
		public static readonly CellRef J46 = CellRef.Parse("J46");
	}
}
