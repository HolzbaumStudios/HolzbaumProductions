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
        
        self._DimX=DimX
        self._DimY=DimY
        self.Fixed=Fixed
        self._basic_maze=np.zeros(shape=(DimX,DimY))
        self.mazeSize=[DimX,DimY]
    
        
        #update basic Maze with the fixed cells and set these values to -1
        for numrow,row in enumerate(self._basic_maze):
            for numcol,element in enumerate(row):
                if [numcol+1,numrow+1] in self.Fixed:
                    self._basic_maze[numcol,numrow]=-1
        
    
        
    def _getCellID(self, CellCoordinates):
        '''
        This method creates a uniqe single index Id for every Cell in the maze.
        the numeration starts at bottom right and increases with +1 in y direction and with +DimY in x direction.
        For a 2x3 maze this would mean:\n
        [2,4,6]\n
        [1,3,5]
        
        Args:
            CellCoordinates (list [1x2]): Cellcoordinates with first element reffering to x coordinate and secound to y.
        
        Returns:
            SingleIndex (int): Index of the cell.            
        '''
        SingleIndex = (CellCoordinates[0]-1)*self.mazeSize[1]+CellCoordinates[1]
        return SingleIndex
        
    def _getCellCoordinate(self, CellIdx):
        '''
        This method returns the cell coordinates for a given cell index.
        
        Args:
            CellIdx (int): Index of the cell. 
            
        Returns:
            CellCoordinates (list [1x2]): Cellcoordinates with first element reffering to x coordinate and secound to y.
        
        '''
        CellCoordinates=np.zeros(2)
        CellCoordinates[0]=np.floor((CellIdx-1)/self.mazeSize[1])+1
        CellCoordinates[1]=np.mod(CellIdx-1,self.mazeSize[1])+1
        return CellCoordinates

    def _isFixed(self,CellIdx):  
        '''
        This method returns the cell coordinates for a given cell index.
        
        Args:
            CellIdx (int): Index of the cell. 
            
        Returns:
            fixed (bool): if the cell is fixed, fixed=True else fixed=False
        
        '''
        fixed=False
        for fixedCell in self.Fixed:
            if self._getCellID(fixedCell[0],fixedCell[1])==CellIdx:
                fixed=True
        
        return fixed
        
    def plotBasicMaze(self):
        '''
        This method plots a basic maze
        '''
        plt.figure()
        ax=plt.subplot(1,1,1)
        for numrow,row in enumerate(self._basic_maze):
            for numcol,column in enumerate(row):
                if column==1:
                    ax.plot(numrow,numcol,marker='s',color='r',markersize=30)
                elif column==0:
                    ax.plot(numrow,numcol,marker='s',color='b',markersize=30)
                elif column==-1:
                    ax.plot(numrow,numcol,marker='s',color='y',markersize=30)
                
                
        plt.xlim(-1,self._DimX)
        plt.ylim(-1,self._DimY)                
        plt.show()
        
        
        
        
        
        
        
        
if __name__=="__main__":
    #close all exsisting Plots
    plt.close('all')
    #create a maze
    M=Maze(5,5,[[1,2],[4,5]])
    #Plot the basic maze
    M.plotBasicMaze()
    Coor=[2,3]
    idx=M._getCellID(Coor)
    print("idx:"+str(idx))
    cor=M._getCellCoordinate(idx)
    print(cor)
        