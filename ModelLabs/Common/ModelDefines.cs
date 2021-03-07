using System;
using System.Collections.Generic;
using System.Text;

namespace FTN.Common
{
	
	public enum DMSType : short
	{		
		MASK_TYPE							= unchecked((short)0xFFFF),

        GEOGRAPHICALREGION                  = 0x0001,
        SUBSTATION                          = 0x0002,
        DISCRETE                            = 0x0003,
        ANALOG                              = 0x0004,
        ENERGYCONSUMER                      = 0x0005,
        GENERATOR                           = 0x0006,
    }

    [Flags]
	public enum ModelCode : long
	{
		IDOBJ								= 0x1000000000000000,
		IDOBJ_GID							= 0x1000000000000104,
		IDOBJ_ALIASNAME					    = 0x1000000000000207,
		IDOBJ_MRID							= 0x1000000000000307,
		IDOBJ_NAME							= 0x1000000000000407,	

		PWRSYSRS                            = 0x1100000000000000,
        PWRSYSRS_MEASUREMENTS               = 0x1100000000000119,

        MEASUREMENT                         = 0x1200000000000000,
        MEASUREMENT_DIRECTIONMETHOD         = 0x120000000000010a,
        MEASUREMENT_MEASUREMENTTYPE         = 0x120000000000020a,
        MEASUREMENT_SAVEADRESS              = 0x1200000000000307,
        MEASUREMENT_POWERSYSRES             = 0x1200000000000409,

        GEOGRAPHICALREGION                  = 0x1300000000010000,
        GEOGRAPHICALREGION_ROTATINGMACHINES = 0x1300000000010119,

        CONNECTIVITYNODECONT                = 0x1110000000000000,
        
        EQUIPMENT                           = 0x1120000000000000,
        EQUIPMENT_EQUIPMENTCONT             = 0x1120000000000109,

        EQUIPMENTCONT                       = 0x1111000000000000,
        EQUIPMENTCONT_EQUIPMENTS            = 0x1111000000000119,

        SUBSTATION                          = 0x1111100000020000,

        CONDUCTEQUIP                        = 0x1121000000000000,

        ENERGYCONSUMER                      = 0x1121100000050000,
        ENERGYCONSUMER_PFIXED               = 0x1121100000050105,
        ENERGYCONSUMER_CURRENTPOWER         = 0x1121100000050205,
        //ENERGYCONSUMER_QFIXED               = 0x1121100000050205,

        REGULATINGCONDEQUIP                 = 0x1121200000000000,

        ROTATINGMACHINE                     = 0x1121210000000000,
        ROTATINGMACHINE_RATEDS              = 0x1121210000000105,
        ROTATINGMACHINE_GEOGRAPHICALREGION  = 0x1121210000000209,

        GENERATOR                           = 0x1121211000060000,
        GENERATOR_GENERATORTYPE             = 0x112121100006010a,
        GENERATOR_MAXQ                      = 0x1121211000060205,
        GENERATOR_MINQ                      = 0x1121211000060305,

        ANALOG                              = 0x1210000000040000,
        ANALOG_MAXVALUE                     = 0x1210000000040105,
        ANALOG_MINVALUE                     = 0x1210000000040205,
        ANALOG_NORMALVALUE                  = 0x1210000000040305,

        DISCRETE                            = 0x1220000000030000,
        DISCRETE_MAXVALUE                   = 0x1220000000030103,
        DISCRETE_MINVALUE                   = 0x1220000000030203,
        DISCRETE_NORMALVALUE                = 0x1220000000030303,
    }

    [Flags]
	public enum ModelCodeMask : long
	{
		MASK_TYPE			 = 0x00000000ffff0000,
		MASK_ATTRIBUTE_INDEX = 0x000000000000ff00,
		MASK_ATTRIBUTE_TYPE	 = 0x00000000000000ff,

		MASK_INHERITANCE_ONLY = unchecked((long)0xffffffff00000000),
		MASK_FIRSTNBL		  = unchecked((long)0xf000000000000000),
		MASK_DELFROMNBL8	  = unchecked((long)0xfffffff000000000),		
	}																		
}


