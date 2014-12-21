# -*- coding: utf-8 -*-
"""
Created on Sun Dec 21 22:20:15 2014

@author: Mija
"""

from Game_Variations import *

#%%

B=Block_Method(3,4)
Sol=B.findPath()
print(Sol)

#%%

C=Circle_Method(4,2)
Sol=C.findPath()
print(Sol)

#%%

Cr=Cross_Method(6,2)
Sol=Cr.findPath()
print(Sol)
#%%

CrH=Cross_Hole_Method(2,5)
Sol=CrH.findPath()
print(Sol)