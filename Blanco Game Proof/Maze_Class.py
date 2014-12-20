# -*- coding: utf-8 -*-
"""
Created on Sat Dec 20 12:55:04 2014

@author: Mija
"""
import numpy as np
import matplotlib.pyplot as plt

class Maze():
    """This is a class that builds and caluculates a Maze
    
    Args:
      DimX (int): The X-Dimension of the maze.\n
      DimY (int): The Y-Dimension of the maze. \n
      Fixed (list): List of maze indexes where fields are fixed.

    """
    def __init__(self,DimX,DimY,Fixed=[]):
        
        self.DimX=DimX
        self.DimY=DimY
        self.Fixed=Fixed
        self.basic_maze=np.zeros(shape=(DimX,DimY))
        
        print(self.basic_maze)
        
    def plotBasicMaze(self):
        plt.figure()
        ax=plt.subplot(1,1,1)
        for numrow,row in enumerate(self.basic_maze):
            for numcol,column in enumerate(row):
                ax.plot(numrow,numcol,marker='s',color='b',markersize=30)
                
        plt.xlim(-1,self.DimX)
        plt.ylim(-1,self.DimY)                
        plt.show()
        
            
        
        
        
        
        
        
if __name__=="__main__":
    M=Maze(8,8)
    M.plotBasicMaze()
        