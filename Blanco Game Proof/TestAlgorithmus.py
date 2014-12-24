# -*- coding: utf-8 -*-
"""
Created on Sun Dec 21 22:20:15 2014

@author: Mija

If the last element is a number, the find path algorithm found a solution which took this amount of steps.

To find the shortest path use method find shortest Path.

If there is no solution, the calculation would endure long time, so press control c to interrupt.


"""

#import the Classes and lybrairies
import matplotlib.pyplot as plt
#import all from Game Variations
from Game_Variations import *

#%%
#initialize Object 4x4 Maze
B=Block_Method(4,4,Fixed=[])
B.plotBasicMaze()
#press a cell on basic maze
nextMaze=B.pressCell(B._basic_maze,7)
B.plotStateMaze(nextMaze)
Sol=B.findPath()
print("State Costs: "+str(Sol))

"""
#%% with fixed
#initialize Object 4x4 Maze Cell with coordinates (1,2) is fixed and can not be changed
B=Block_Method(4,4,Fixed=[[1,2]])
B.plotBasicMaze()
#press a cell on basic maze
nextMaze=B.pressCell(B._basic_maze,7)
B.plotStateMaze(nextMaze)
Sol=B.findPath()
print("State Costs: "+str(Sol))

#%%

C=Circle_Method(4,4)
C.plotBasicMaze()
nextMaze=C.pressCell(C._basic_maze,7)
C.plotStateMaze(nextMaze)
Sol=C.findPath()
print("State Costs: "+str(Sol))

#%%

Cr=Cross_Method(4,4)
Cr.plotBasicMaze()
nextMaze=Cr.pressCell(Cr._basic_maze,7)
Cr.plotStateMaze(nextMaze)
Sol=Cr.findPath()
print("State Costs: "+str(Sol))

#%%

CrH=Cross_Hole_Method(4,4)
CrH.plotBasicMaze()
nextMaze=CrH.pressCell(CrH._basic_maze,7)
CrH.plotStateMaze(nextMaze)
Sol=CrH.findPath()
print("State Costs: "+str(Sol))
"""