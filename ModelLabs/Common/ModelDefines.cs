using System;
using System.Collections.Generic;
using System.Text;

namespace FTN.Common
{
	
	public enum DMSType : short
	{		
		MASK_TYPE							= unchecked((short)0xFFFF),

        CONNECTIVITYNODE                    = 0x0001,
        SERIESCOMPENSATOR                   = 0x0002,
        DCLINESEGMENT                       = 0x0003,
        ACLINESEGMENT                       = 0x0004,
        PERLENGTHSEQUENCEIMPEDANCE          = 0x0005,
        TERMINAL                            = 0x0006,
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

        PLENIM                              = 0x1200000000000000,

        PLENSIM                             = 0x1210000000050000,
        PLENSIM_B0CH                        = 0x1210000000050105,
        PLENSIM_BCH                         = 0x1210000000050205,
        PLENSIM_G0CH                        = 0x1210000000050305,
        PLENSIM_GCH                         = 0x1210000000050405,
        PLENSIM_R                           = 0x1210000000050505,
        PLENSIM_R0                          = 0x1210000000050605,
        PLENSIM_X                           = 0x1210000000050705,
        PLENSIM_X0                          = 0x1210000000050805,

        CONNODE                             = 0x1300000000010000,
        CONNODE_DESCRIPTION                 = 0x1300000000010107,
        CONNODE_TERMINALS                   = 0x1300000000010219,

        TERMINAL                            = 0x1400000000060000,
        TERMINAL_CONNODE                    = 0x1400000000060109,
        TERMINAL_CONEQ                      = 0x1400000000060209,

        EQUIPMENT                           = 0x1110000000000000,

        CONEQUIPMENT                        = 0x1111000000000000,
        CONEQUIPMENT_TERMINALS              = 0x1111000000000119,

        SERCOMPENSATOR                      = 0x1111100000020000,
        SERCOMPENSATOR_R                    = 0x1111100000020105,
        SERCOMPENSATOR_R0                   = 0x1111100000020205,
        SERCOMPENSATOR_X                    = 0x1111100000020305,
        SERCOMPENSATOR_X0                   = 0x1111100000020405,

        CONDUCTOR                           = 0x1111200000000000,
        CONDUCTOR_LENGTH                    = 0x1111200000000105,

        DCLINESEG                           = 0x1111210000030000,

        ACLINESEG                           = 0x1111220000040000,
        ACLINESEG_B0CH                      = 0x1111220000040105,
        ACLINESEG_BCH                       = 0x1111220000040205,
        ACLINESEG_G0CH                      = 0x1111220000040305,
        ACLINESEG_GCH                       = 0x1111220000040405,
        ACLINESEG_R                         = 0x1111220000040505,
        ACLINESEG_R0                        = 0x1111220000040605,
        ACLINESEG_X                         = 0x1111220000040705,
        ACLINESEG_X0                        = 0x1111220000040805,
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


