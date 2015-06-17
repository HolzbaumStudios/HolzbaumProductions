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
        self._basic_maze=Maze_State(np.zeros(shape=(DimX,DimY)))
        #make a pointerarray for getting out the right way.
        self._terminal_maze=None
        self.reachableStates=dict()
        
        #print(self._terminal_maze)
        self._openbin=[]
        self._Fixed=Fixed
        self.pressInput=[]
        
       
        
        #update basic Maze
        self._updateMaze()
        
        
    def _updateMaze(self):
        self._basic_maze.Matrix=np.zeros(shape=(self._DimX,self._DimY))
        self._mazeSize=[self._DimX,self._DimY]
        self._basic_maze.stateCost=0
        self._addToReachableStates(self._basic_maze)
        
        
        
        #update basic Maze with the fixed cells and set these values to -1
        for numrow,row in enumerate(self._basic_maze.Matrix):
            
            for numcol,element in enumerate(row):
                if [numrow+1,numcol+1] in self._Fixed:
                    self._basic_maze.Matrix[numrow,numcol]=-1
        
        self._terminal_maze=self._buildTerminalMaze()
        self._addToReachableStates(self._terminal_maze)
        
                    
    def _buildTerminalMaze(self):
        self._terminal_maze=Maze_State(np.copy(self._basic_maze.Matrix))
        for numrow,row in enumerate(self._basic_maze.Matrix):
            for numcol,element in enumerate(row):
                if ((element==0) or (element==2)):
                    self._terminal_maze.ChangeMatrix(numrow,numcol,1)
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
        CellCoordinates[0]=int(np.floor((CellIdx-1)/self._mazeSize[1])+1)
        CellCoordinates[1]=int(np.mod(CellIdx-1,self._mazeSize[1])+1)
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
        if self._isFixed([Cellcor[0],Cellcor[1]]):
            return []
        evaluationCells=[]
        Presser=self.pressInput
        for pInput in Presser:
            testCell=[Cellcor[0]+pInput[0],Cellcor[1]+pInput[1]]
            if self._isInsideMaze(testCell) and not self._isFixed(testCell):
                evaluationCells.append(testCell)
        return evaluationCells
        
    def _evaluateCells(self,evaluateCells,stateMaze):
        '''
        This method changes all the values of all cells in evaluateCells form 0 to 1 ore vice versa.
                
        Args:
            stateMaze (Object Maze_State ): Current Maze State \n
            evaluateCells (list): List of coordinates o cells:
            
            
        Returns:
            newStateMaze (Object Maze_State ): Matrix of the newmazeState
        
        
        '''
        newStateMaze=Maze_State(np.copy(stateMaze.Matrix))
        for evCell in evaluateCells:
            value=newStateMaze.Matrix[evCell[0]-1,evCell[1]-1]
            if value==1:
                newStateMaze.ChangeMatrix(evCell[0]-1,evCell[1]-1,0)
            elif value==0:
                newStateMaze.ChangeMatrix(evCell[0]-1,evCell[1]-1,1)
            elif value==2:
                newStateMaze.ChangeMatrix(evCell[0]-1,evCell[1]-1,0)
        return newStateMaze
        
    def _getStateIdx(self,StateMaze):
        '''
        This method returns a unique state index for a given maze state.
        the index is generated by a binary counter system. Starts at the bottom left
        and raises in y-direction
        
        Args:
            StateMaze (Object Maze_State): Matrix of the mazeState 
            
        Returns:
            stateIndex (int): Index of Maze state
        
        '''
        return StateMaze.Index
        
    def _addToReachableStates(self,Maze):
        '''
        This method checks if a maze is yet in the reachable states, and if it is not, it adds it. 
        It returns the index of the new state
        '''
        if not Maze.Index in self.reachableStates:
            self.reachableStates[Maze.Index]=Maze
        
        
    def pressCell(self,stateMaze,cellIdx):
        '''
        This method evaluates the new stateMaze if we have a current maze and cellIdx is pressed
        
        Args:
            stateMaze (Object State_maze): Matrix of the mazeState\n
            cellIdx (int): Index of Cell
            
        Returns:
            newStateMaze (numpyArray, [DimX x DimY]): Matrix of the new maze State
        
        '''
        evaluateCells=self._applyPressInputToCell(cellIdx)
        newStateMaze=self._evaluateCells(evaluateCells,stateMaze)
        
        return newStateMaze
                
        
    def plotBasicMaze(self,Axes=None):
        '''
        This method plots a basic maze
        '''
        self.plotStateMaze(self._basic_maze,Axes=Axes)
        
        
    def plotStateMaze(self,stateMaze,Axes=None):
        '''
        This method plots the state maze
        '''
        if Axes==None:
            plt.figure()
            ax=plt.subplot(1,1,1)
        else:
            ax=Axes
        for numrow,row in enumerate(stateMaze.Matrix):
            for numcol,column in enumerate(row):
                if column==1:
                    ax.plot(numrow,numcol,marker='s',color='orange',markersize=30)
                elif column==0:
                    ax.plot(numrow,numcol,marker='s',color='b',markersize=30)
                elif column==2:
                    ax.plot(numrow,numcol,marker='s',color='y',markersize=30)
                elif column==-1:
                    ax.plot(numrow,numcol,marker='s',color='w',markersize=30)
                elif column==-2:
                    ax.plot(numrow,numcol,marker='s',color='r',markersize=30) 
                elif column==-3:
                    ax.plot(numrow,numcol,marker='s',color='g',markersize=30)                
                
        plt.xlim(-1,self._DimX)
        plt.ylim(-1,self._DimY)                
#        plt.show()
        
        
    def findShortestPath(self):
        openBin=[]
        openBinIdx=[]
        #Add start state to openBin
        openBin.append(self._basic_maze)
        openBinIdx.append(self._basic_maze.Index)
        
        maxopenbin=len(openBinIdx)
        Maxold=0
        
        while openBin!=[]:
            for c,M in enumerate(openBin):
                if c==0:
                    Maxidx=c
                    maxSum=M.getSum()
                if M.getSum()>maxSum:
                    Maxidx=c
                    maxSum=M.getSum()
            
            if len(openBinIdx)>maxopenbin:
                
                maxopenbin=len(openBinIdx)
                if maxopenbin>Maxold+1000:
                    Maxold=maxopenbin
                    print(str(Maxold))
                    print("Current final cost: "+str(self._terminal_maze.stateCost))
            
                    
                
            RemovedMaze=openBin.pop(Maxidx)
            openBinIdx.pop(Maxidx)
        
            for cell in range(1,self._DimX*self._DimY+1):
                newMaze=self.pressCell(RemovedMaze,cell)
                if newMaze.Index!=self._terminal_maze.Index:
                    self._addToReachableStates(newMaze)
                    if RemovedMaze.stateCost+1<self.reachableStates.get(newMaze.Index).stateCost:
                        if RemovedMaze.stateCost+1<self._terminal_maze.stateCost:
                            
                            self.reachableStates.get(newMaze.Index).stateCost=RemovedMaze.stateCost+1
                            self.reachableStates.get(newMaze.Index).reachedFromIndex=RemovedMaze.Index
                            self.reachableStates.get(newMaze.Index).reachedByPressingCell=cell
                            if newMaze.Index not in openBinIdx:
                                openBin.append(self.reachableStates.get(newMaze.Index))
                                openBinIdx.append(newMaze.Index)                           
                elif RemovedMaze.stateCost+1<self._terminal_maze.stateCost:
                    self._terminal_maze.stateCost=RemovedMaze.stateCost+1
                    self._terminal_maze.reachedFromIndex=RemovedMaze.Index
                    self._terminal_maze.reachedByPressingCell=cell
                    print("Current final cost: "+str(self._terminal_maze.stateCost))
                            
                    
        return [self._basic_maze.stateCost, self._terminal_maze.stateCost]
        
        
    def findPath(self):
        openBin=[]
        openBinIdx=[]
        #Add start state to openBin
        openBin.append(self._basic_maze)
        openBinIdx.append(self._basic_maze.Index)
        
        maxopenbin=len(openBinIdx)
        
        while openBin!=[]:
            for c,M in enumerate(openBin):
                if c==0:
                    Maxidx=c
                    maxSum=M.getSum()
                if M.getSum()>maxSum:
                    Maxidx=c
                    maxSum=M.getSum()
            
            if len(openBinIdx)>maxopenbin:
                maxopenbin=len(openBinIdx)
                print(str(maxopenbin))
            
                    
                
            RemovedMaze=openBin.pop(Maxidx)
            openBinIdx.pop(Maxidx)
        
            for cell in range(1,self._DimX*self._DimY+1):
                newMaze=self.pressCell(RemovedMaze,cell)
                if newMaze.Index!=self._terminal_maze.Index:
                    self._addToReachableStates(newMaze)
                    if RemovedMaze.stateCost+1<self.reachableStates.get(newMaze.Index).stateCost:
                        if RemovedMaze.stateCost+1<self._terminal_maze.stateCost:
                            
                            self.reachableStates.get(newMaze.Index).stateCost=RemovedMaze.stateCost+1
                            self.reachableStates.get(newMaze.Index).reachedFromIndex=RemovedMaze.Index
                            if newMaze.Index not in openBinIdx:
                                openBin.append(self.reachableStates.get(newMaze.Index))
                                openBinIdx.append(newMaze.Index)                           
                else: 
                    self._terminal_maze.stateCost=RemovedMaze.stateCost+1
                    self._terminal_maze.reachedFromIndex=RemovedMaze.Index
                    print("Current final cost: "+str(self._terminal_maze.stateCost))
                    return [self._basic_maze.stateCost, self._terminal_maze.stateCost]
                            
                    
        return [self._basic_maze.stateCost, self._terminal_maze.stateCost]
        
    def getChronologicalShortestpath(self):
        Currentidx=self._terminal_maze.Index
        SolutionWaymazes=[]
        SolutionWaymazes.append(self.reachableStates[Currentidx])
        if self._terminal_maze.stateCost==np.inf:
            print("Has no solution yet, please execute findShortestPath if you have not done so yet")
            return SolutionWaymazes
        else:
            while (Currentidx!=0):
                Currentidx=self.reachableStates[Currentidx].reachedFromIndex
                SolutionWaymazes.append(self.reachableStates[Currentidx])
        return SolutionWaymazes
    
    def PlotChronologicalShortestpath(self):
        SolWaymaze=self.getChronologicalShortestpath()
        for maze in SolWaymaze:
            self.plotStateMaze(maze)
    
    def PrintChronologicalShortestpath(self):
        SolWaymaze=self.getChronologicalShortestpath()
        for maze in SolWaymaze:
            print(str(maze.Matrix))
            
    def WriteChronologicalShortestpathtoFile(self,filepath):
        txtfile=open(filepath,'w')
        SolWaymaze=self.getChronologicalShortestpath()
        txtfile.write("Shortest Path in "+str(self._terminal_maze.stateCost)+" Steps \n")
        for maze in SolWaymaze:
            txtfile.write(str(maze.Matrix)+"\n")
            if maze.reachedByPressingCell != None:
                cellcoord=self._getCellCoordinate(maze.reachedByPressingCell)
                txtfile.write("Press Cell: "+str(cellcoord))
                if maze.Matrix[cellcoord[0]-1,cellcoord[1]-1] in [-2,-3]:
                    txtfile.write(" Special Cell")
                txtfile.write("\n")
            
class Maze_State():
    def __init__(self,Maze_Matrix):
        self.Matrix=Maze_Matrix
        self.reachedFromIndex=None
        self.reachedByPressingCell=None
        self.Index=None
        self.stateCost=np.inf
        self._Sum=None
        self.update()
        
    
    def _calculateIndex(self):
        BuilderString=''
        for i in self.Matrix:
            for j in i:              
                if int(j) in [0,1,2]:
                    BuilderString+=str(int(j))
        self.Index=int(BuilderString,3)
    
    def ChangeMatrix(self,numrow,numcol,value):
        self.Matrix[numrow,numcol]=value
        self.update()
    
    def update(self):
        self._calculateIndex()
        self.stateCost=np.inf
        self._calculateSum()
    
    def _calculateSum(self):
        self.Sum=np.sum(self.Matrix)
    
    def getSum(self):
        return self.Sum
        
                
        

        
        
        
        
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
    
    