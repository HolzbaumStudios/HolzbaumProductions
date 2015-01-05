# -*- coding: utf-8 -*-
"""
Created on Sat Dec 20 12:55:04 2014

@author: Mija
"""
import numpy as np
import matplotlib.pyplot as plt


class Maze(object):
    """
    This is a class that builds and caluculates a Maze
    
    Args:
      DimX (int): The X-Dimension of the maze.\n
      DimY (int): The Y-Dimension of the maze. \n
      Fixed (list): List of maze indexes where fields are fixed.

    """
    def __init__(self,DimX,DimY,Fixed=[]):
        #construct
        self._DimX=DimX
        self._DimY=DimY
        self._mazeSize=[DimX,DimY]
        self._basic_maze=np.zeros(shape=(DimX,DimY))
        self.stateCost=[0]
        self._terminal_maze=self._buildTerminalMaze()
        self.reachableStates=[self._basic_maze]
        self._teminalMazeIdx=self._addToReachableStates(self._terminal_maze)
        #print(self._terminal_maze)
        print("Number of current states: "+str(self._teminalMazeIdx))
        self._openbin=[]
        self._Fixed=Fixed
        self.pressInput=[]
        
        #update basic Maze
        self._updateMaze()
        
        
    def _updateMaze(self):
        self._basic_maze=np.zeros(shape=(self._DimX,self._DimY))
        self._mazeSize=[self._DimX,self._DimY]
        self.stateCost=[0]
        self.stateCost[0]=0
        self.reachableStates=[self._basic_maze]
        
        
        
        #update basic Maze with the fixed cells and set these values to -1
        for numrow,row in enumerate(self._basic_maze):
            for numcol,element in enumerate(row):
                if [numcol+1,numrow+1] in self._Fixed:
                    self._basic_maze[numcol,numrow]=-1
        
        self._terminal_maze=self._buildTerminalMaze()
        self._teminalMazeIdx=self._addToReachableStates(self._terminal_maze)
        
                    
    def _buildTerminalMaze(self):
        self._terminal_maze=np.copy(self._basic_maze)
        for numrow,row in enumerate(self._basic_maze):
            for numcol,element in enumerate(row):
                if element==0:
                    self._terminal_maze[numrow,numcol]=1
        return self._terminal_maze
        
        
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
        SingleIndex = (CellCoordinates[0]-1)*self._mazeSize[1]+CellCoordinates[1]
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
        CellCoordinates[0]=np.floor((CellIdx-1)/self._mazeSize[1])+1
        CellCoordinates[1]=np.mod(CellIdx-1,self._mazeSize[1])+1
        return CellCoordinates
        
    def _isInsideMaze(self,CellCoordinate):
        '''
        This method returns the cell coordinates for a given cell index.
        
        Args:
            CellCoordinates(list [1x2]): Cellcoordinates with first element reffering to x coordinate and secound to y. 
            
        Returns:
            inside (bool): if the cell is inside, inside=True else inside=False
        
        '''
        if (self._mazeSize[0]>=CellCoordinate[0]>0) and (self._mazeSize[1]>=CellCoordinate[1]>0):
            inside=True
        else:
            inside=False
            
        return inside
                
        

    def _isFixed(self,CellCoordinate):  
        '''
        This method returns the cell coordinates for a given cell index.
        
        Args:
            CellCoordinates(list [1x2]): Cellcoordinates with first element reffering to x coordinate and secound to y. 
            
        Returns:
            fixed (bool): if the cell is fixed, fixed=True else fixed=False
        
        '''
        fixed=False
        for fixedCell in self._Fixed:
            if fixedCell==CellCoordinate:
                fixed=True
        return fixed
        
    def _applyPressInputToCell(self,cellIdx):
        
        Cellcor=self._getCellCoordinate(cellIdx)
        evaluationCells=[]
        for pInput in self.pressInput:
            testCell=[Cellcor[0]+pInput[0],Cellcor[1]+pInput[1]]
            if self._isInsideMaze(testCell) and not self._isFixed(testCell):
                evaluationCells.append(testCell)
        return evaluationCells
        
    def _evaluateCells(self,evaluateCells,stateMaze):
        '''
        This method changes all the values of all cells in evaluateCells form 0 to 1 ore vice versa.
                
        Args:
            stateMaze (numpyArray, [DimX x DimY]): Matrix of the mazeState \n
            evaluateCells (list): List of coordinates o cells:
            
            
        Returns:
            newStateMaze (numpyArray, [DimX x DimY]): Matrix of the newmazeState
        
        
        '''
        newStateMaze=np.copy(stateMaze)
        for evCell in evaluateCells:
            value=newStateMaze[evCell[0]-1,evCell[1]-1]
            if value==1:
                newStateMaze[evCell[0]-1,evCell[1]-1]=0
            elif value==0:
                newStateMaze[evCell[0]-1,evCell[1]-1]=1
        return newStateMaze
        
    def _getStateIdx(self,StateMaze):
        '''
        This method returns a unique state index for a given maze state.
        the index is generated by a binary counter system. Starts at the bottom left
        and raises in y-direction
        
        Args:
            StateMaze (numpyArray, [DimX x DimY]): Matrix of the mazeState 
            
        Returns:
            stateIndex (int): Index of Maze state
        
        '''
        for Index,reachableState in enumerate(self.reachableStates):
            K=reachableState==StateMaze
            if False not in K:
                return Index
        return None
        
    def _addToReachableStates(self,Maze):
        '''
        This method checks if a maze is yet in the reachable states, and if it is not, it adds it. 
        It returns the index of the new state
        '''
        for idx,reachedMaze in enumerate(self.reachableStates):
            K=Maze==reachedMaze
            if False not in K:
                return idx
        self.reachableStates.append(Maze)
        self.stateCost.append(np.inf)
        return len(self.reachableStates)-1
        
        
    def pressCell(self,stateMaze,cellIdx):
        '''
        This method evaluates the new stateMaze if we have a current maze and cellIdx is pressed
        
        Args:
            stateMaze (numpyArray, [DimX x DimY]): Matrix of the mazeState\n
            cellIdx (int): Index of Cell
            
        Returns:
            newStateMaze (numpyArray, [DimX x DimY]): Matrix of the new maze State
        
        '''
        evaluateCells=self._applyPressInputToCell(cellIdx)
        newStateMaze=self._evaluateCells(evaluateCells,stateMaze)
        
        return newStateMaze
                
        
    def plotBasicMaze(self):
        '''
        This method plots a basic maze
        '''
        self.plotStateMaze(self._basic_maze)
        
        
    def plotStateMaze(self,stateMaze):
        '''
        This method plots the state maze
        '''
        plt.figure()
        ax=plt.subplot(1,1,1)
        for numrow,row in enumerate(stateMaze):
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
        
    def findShortestPath(self):
        openBin=[]
        openBinIdx=[]
        #Add start state to openBin
        openBin.append(self._basic_maze)
        openBinIdx.append(0)
        
        while openBin!=[]:
            for c,M in enumerate(openBin):
                if c==0:
                    Maxidx=c
                    maxSum=np.sum(M)
                if np.sum(M)>maxSum:
                    Maxidx=c
                    maxSum=np.sum(M)
                    
                
            RemovedMaze=openBin.pop(Maxidx)
            openBinIdx.pop(Maxidx)
            removedIdx=self._getStateIdx(RemovedMaze)
            for cell in range(1,self._DimX*self._DimY+1):
                newMaze=self.pressCell(RemovedMaze,cell)
                if False in (newMaze==self._terminal_maze):
                    newMazeidx=self._addToReachableStates(newMaze)
                    if self.stateCost[removedIdx]+1<self.stateCost[newMazeidx]:
                        if self.stateCost[removedIdx]+1<self.stateCost[self._teminalMazeIdx]:
                            
                            self.stateCost[newMazeidx]=self.stateCost[removedIdx]+1
                            if newMazeidx not in openBinIdx:
                                openBin.append(newMaze)
                                openBinIdx.append(newMazeidx)                           
                elif self.stateCost[removedIdx]+1<self.stateCost[self._teminalMazeIdx]:
                    self.stateCost[self._teminalMazeIdx]=self.stateCost[removedIdx]+1
                            
                    
        return self.stateCost
        
    def findPath(self):
        openBin=[]
        openBinIdx=[]
        #Add start state to openBin
        openBin.append(self._basic_maze)
        openBinIdx.append(0)
        
        while openBin!=[]:
            for c,M in enumerate(openBin):
                if c==0:
                    Maxidx=c
                    maxSum=np.sum(M)
                if np.sum(M)>maxSum:
                    Maxidx=c
                    maxSum=np.sum(M)
                    
                
            RemovedMaze=openBin.pop(Maxidx)
            openBinIdx.pop(Maxidx)
            removedIdx=self._getStateIdx(RemovedMaze)
            for cell in range(1,self._DimX*self._DimY+1):
                newMaze=self.pressCell(RemovedMaze,cell)
                if False in (newMaze==self._terminal_maze):
                    newMazeidx=self._addToReachableStates(newMaze)
                    if self.stateCost[removedIdx]+1<self.stateCost[newMazeidx]:
                        if self.stateCost[removedIdx]+1<self.stateCost[self._teminalMazeIdx]:
                            
                            self.stateCost[newMazeidx]=self.stateCost[removedIdx]+1
                            if newMazeidx not in openBinIdx:
                                openBin.append(newMaze)
                                openBinIdx.append(newMazeidx)                           
                else:
                    self.stateCost[self._teminalMazeIdx]=self.stateCost[removedIdx]+1
                    return self.stateCost
                            
                    
        return self.stateCost

        
        
        
        
if __name__=="__main__":
    #close all exsisting Plots
    plt.close('all')
    #create a maze
    M=Maze(3,3,[[1,2],[2,2]])
    #Plot the basic maze
#    M.plotBasicMaze()
#    #test the Cell coordinate functions
#    Coor=[2,3]
#    idx=M._getCellID(Coor)
#    print("idx:"+str(idx))
#    cor=M._getCellCoordinate(idx)
#    print(cor)
#    Sidx=M._getStateIdx(M._basic_maze)
#    State1=M._basic_maze
#    State1[0,0]=1
#    State1[1,0]=1
#    print(Sidx)
#    M.plotStateMaze(State1)
#    Sidx1=M._getStateIdx(State1)
#    print("")
#    print(State1)
#    print(Sidx1)
    print(M._isInsideMaze([2,4]))