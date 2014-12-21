# -*- coding: utf-8 -*-
"""
Created on Sun Dec 21 09:45:27 2014

@author: Mija
"""

import numpy as np
import matplotlib.pyplot as plt
from Maze_Class import *


class Block_Method(Maze):
    def __init__(self,DimX,DimY,Fixed=[]):
        super(Block_Method,self).__init__(DimX,DimY,Fixed)
        self.pressInput=[[0,0],[0,1],[0,-1],[1,0],[1,1],[1,-1],[-1,0],[-1,1],[-1,-1]]#all the fields around the cell which change color
        
class Circle_Method(Maze):
    def __init__(self,DimX,DimY,Fixed=[]):
        super(Circle_Method,self).__init__(DimX,DimY,Fixed)
        self.pressInput=[[0,1],[0,-1],[1,0],[1,1],[1,-1],[-1,0],[-1,1],[-1,-1]]#all the fields around the cell which change color
        
class Cross_Method(Maze):
    def __init__(self,DimX,DimY,Fixed=[]):
        super(Cross_Method,self).__init__(DimX,DimY,Fixed)
        self.pressInput=[[0,0],[0,1],[0,-1],[1,0],[-1,0]]#all the fields around the cell which change color
        
class Cross_Hole_Method(Maze):
    def __init__(self,DimX,DimY,Fixed=[]):
        super(Cross_Hole_Method,self).__init__(DimX,DimY,Fixed)
        self.pressInput=[[0,1],[0,-1],[1,0],[-1,0]]#all the fields around the cell which change color
        
                    
                            
#
                
            
    
    
        
            
        

        
    
    


    