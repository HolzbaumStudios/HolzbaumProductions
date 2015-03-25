# -*- coding: utf-8 -*-
"""
Created on Sun Dec 21 09:45:27 2014

@author: Mija
"""

import numpy as np
import matplotlib.pyplot as plt
from Maze_Class_V3 import *


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
        
class Kat2_Method(Maze):
    def __init__(self,DimX,DimY,Fixed=[],OneTurns=[]):
        self._OneTurns=OneTurns
        super(Kat2_Method,self).__init__(DimX,DimY,Fixed)
        self.pressInput=[[0,0],[0,1],[0,-1],[1,0],[1,1],[1,-1],[-1,0],[-1,1],[-1,-1]]
    
        
        
    def _compareFixedToOneTurns(self):
        """
        This Method compares the Oneturns with the fixed. if they have a Cell which is the same, fixed wins
        """
        for c,OneCell in enumerate(self._OneTurns):
            if OneCell in self._Fixed:
                self._OneTurns.pop(c);
                
    def _updateMaze(self):
        self._compareFixedToOneTurns()
        self._basic_maze.Matrix=np.zeros(shape=(self._DimX,self._DimY))
        self._mazeSize=[self._DimX,self._DimY]
        self._basic_maze.stateCost=0
        self._addToReachableStates(self._basic_maze)
        
        
        
        #update basic Maze with the fixed cells and set these values to -1
        #set the One Turns to 1
        for numrow,row in enumerate(self._basic_maze.Matrix):
            
            for numcol,element in enumerate(row):
                if [numrow+1,numcol+1] in self._Fixed:
                    self._basic_maze.Matrix[numrow,numcol]=-1
                if [numrow+1,numcol+1] in self._OneTurns:
                    self._basic_maze.Matrix[numrow,numcol]=2
        
        self._terminal_maze=self._buildTerminalMaze()
        self._addToReachableStates(self._terminal_maze)
                
class Kat3_Method(Kat2_Method):
    def __init__(self,DimX,DimY,Fixed=[],OneTurns=[],Crossers=[],Edgers=[]):
        self._crossers=Crossers
        self._edgers=Edgers
        super(Kat3_Method,self).__init__(DimX,DimY,Fixed,OneTurns)
        self.crossinput=[[0,1],[0,-1],[1,0],[-1,0]]
        self.edgeInput=[[-1,1],[1,-1],[1,1],[-1,-1]]
    
                
    def _compareFixedToCrossers(self):
        """
        This Method compares the Oneturns with the fixed. if they have a Cell which is the same, fixed wins
        """
        for c,OneCell in enumerate(self._crossers):
            if OneCell in self._Fixed:
                self._crossers.pop(c);
                
    def _compareFixedToEdgers(self):
        """
        This Method compares the Oneturns with the fixed. if they have a Cell which is the same, fixed wins
        """
        for c,OneCell in enumerate(self._edgers):
            if OneCell in self._Fixed:
                self._edgers.pop(c);
                
    def _updateMaze(self):
        self._compareFixedToOneTurns()
        self._compareFixedToCrossers()
        self._compareFixedToEdgers()
        self._basic_maze.Matrix=np.zeros(shape=(self._DimX,self._DimY))
        self._mazeSize=[self._DimX,self._DimY]
        self._basic_maze.stateCost=0
        
        
        
        
        #update basic Maze with the fixed cells and set these values to -1
        #set the One Turns to 1
        for numrow,row in enumerate(self._basic_maze.Matrix):
            
            for numcol,element in enumerate(row):
                if [numrow+1,numcol+1] in self._Fixed:
                    self._basic_maze.Matrix[numrow,numcol]=-1
                if [numrow+1,numcol+1] in self._OneTurns:
                    self._basic_maze.Matrix[numrow,numcol]=2
                if [numrow+1,numcol+1] in self._crossers:
                    self._basic_maze.Matrix[numrow,numcol]=-2
                if [numrow+1,numcol+1] in self._edgers:
                    self._basic_maze.Matrix[numrow,numcol]=-3
        self._addToReachableStates(self._basic_maze)
        self._terminal_maze=self._buildTerminalMaze()
        self._addToReachableStates(self._terminal_maze)
        
    def _isCrosser(self,CellCoordinate):  
        '''
        This method returns the cell coordinates for a given cell index.
        
        Args:
            CellCoordinates(list [1x2]): Cellcoordinates with first element reffering to x coordinate and secound to y. 
            
        Returns:
            fixed (bool): if the cell is fixed, fixed=True else fixed=False
        
        '''
        fixed=False
        for fixedCell in self._crossers:
            if fixedCell==CellCoordinate:
                fixed=True
        return fixed
    
    def _isEdger(self,CellCoordinate):  
        '''
        This method returns the cell coordinates for a given cell index.
        
        Args:
            CellCoordinates(list [1x2]): Cellcoordinates with first element reffering to x coordinate and secound to y. 
            
        Returns:
            fixed (bool): if the cell is fixed, fixed=True else fixed=False
        
        '''
        fixed=False
        for fixedCell in self._edgers:
            if fixedCell==CellCoordinate:
                fixed=True
        return fixed
    
        
    def _applyPressInputToCell(self,cellIdx):
        
        Cellcor=self._getCellCoordinate(cellIdx)
        if self._isFixed([Cellcor[0],Cellcor[1]]):
            return []
        evaluationCells=[]
        if self._isCrosser([Cellcor[0],Cellcor[1]]):
            Presser=self.crossinput
        elif self._isEdger([Cellcor[0],Cellcor[1]]):
            Presser=self.edgeInput
        else:
            Presser=self.pressInput
        for pInput in Presser:
            testCell=[Cellcor[0]+pInput[0],Cellcor[1]+pInput[1]]
            if self._isInsideMaze(testCell) and not self._isFixed(testCell):
                evaluationCells.append(testCell)
        return evaluationCells

    
        
            
        

        
    
    


    