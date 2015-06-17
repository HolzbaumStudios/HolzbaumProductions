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
import sys
sys.path.append("C:\Users\Mija\Documents\HolzBaumStudios\HolzbaumProductions\Blanco Game Proof")
#import all from Game Variations
from Game_Variations import *

Savepath=r"4x4/"
#%%1
"""
count=1
print("Calculating Nr.: "+str(count))
#initialize Object 3x3 Maze
B=Kat3_Method(4,4,Edgers=[[1,1]])#Fixed=[[1,1]],OneTurns=[[1,2]],Crossers=[[2,2]],Edgers=[[1,3]])#,[1,4],[3,4],[4,4],[5,4]])
#Sol=B.findPath()
Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("4x4, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
B.PrintChronologicalShortestpath()
Filename=Savepath+str(count)+"cost="+str(Sol[1])+".txt"
B.WriteChronologicalShortestpathtoFile(Filename)

#%%2

count+=1
print("Calculating Nr.: "+str(count))
#initialize Object 3x3 Maze
B=Kat3_Method(4,4,Fixed=[[1,1],[4,4]],Crossers=[[2,2],[3,3]])#Fixed=[[1,1]],OneTurns=[[1,2]],Crossers=[[2,2]],Edgers=[[1,3]])#,[1,4],[3,4],[4,4],[5,4]])
#Sol=B.findPath()
Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("4x4, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
B.PrintChronologicalShortestpath()
Filename=Savepath+str(count)+"cost="+str(Sol[1])+".txt"
B.WriteChronologicalShortestpathtoFile(Filename)


count=2
#%%3

count+=1
print("Calculating Nr.: "+str(count))
#initialize Object 3x3 Maze
B=Kat3_Method(4,4,Fixed=[[1,1],[4,4]],Edgers=[[3,3]])#Fixed=[[1,1]],OneTurns=[[1,2]],Crossers=[[2,2]],Edgers=[[1,3]])#,[1,4],[3,4],[4,4],[5,4]])
#Sol=B.findPath()
Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("4x4, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
B.PrintChronologicalShortestpath()
Filename=Savepath+str(count)+"cost="+str(Sol[1])+".txt"
B.WriteChronologicalShortestpathtoFile(Filename)

count=3
#%%4

count+=1

print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Kat3_Method(4,4,Fixed=[[1,1],[4,4]],Edgers=[[2,2],[3,3]])#,[1,4],[3,4],[4,4],[5,4]])
#Sol=B.findPath()
Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("4x4, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
Filename=Savepath+str(count)+"cost="+str(Sol[1])+".txt"
B.WriteChronologicalShortestpathtoFile(Filename)

#%%5

count+=1
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Kat3_Method(4,4,Fixed=[[1,1],[4,4],[1,4],[4,1]],Edgers=[[2,2],[3,3]])#,[1,4],[3,4],[4,4],[5,4]])
#Sol=B.findPath()
Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("4x4, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
Filename=Savepath+str(count)+"cost="+str(Sol[1])+".txt"
B.WriteChronologicalShortestpathtoFile(Filename)

count=5
#%%6

count+=1
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Kat3_Method(4,4,Fixed=[[2,4],[3,4],[1,4],[4,4]],Crossers=[[1,2]])#,[1,4],[3,4],[4,4],[5,4]])
#Sol=B.findPath()
Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("4x4, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
Filename=Savepath+str(count)+"cost="+str(Sol[1])+".txt"
B.WriteChronologicalShortestpathtoFile(Filename)

#%%7

count+=1
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Kat3_Method(4,4,Fixed=[[2,4],[3,4],[1,4],[4,4]],Edgers=[[1,2],[4,2]])#,[1,4],[3,4],[4,4],[5,4]])
#Sol=B.findPath()
Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("4x4, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
Filename=Savepath+str(count)+"cost="+str(Sol[1])+".txt"
B.WriteChronologicalShortestpathtoFile(Filename)

count=7
#%%8

count+=1

print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Kat3_Method(4,4,Fixed=[[2,4],[3,4],[1,4],[4,4]],Crossers=[[1,2]])#,[1,4],[3,4],[4,4],[5,4]])
#Sol=B.findPath()
Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("4x4, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
Filename=Savepath+str(count)+"cost="+str(Sol[1])+".txt"
B.WriteChronologicalShortestpathtoFile(Filename)

count=8
#%%9

count+=1

print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Kat3_Method(4,4,Fixed=[[1,4],[4,4]],Edgers=[[1,2],[4,2]])#,[1,4],[3,4],[4,4],[5,4]])
#Sol=B.findPath()
Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("4x4, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
Filename=Savepath+str(count)+"cost="+str(Sol[1])+".txt"
B.WriteChronologicalShortestpathtoFile(Filename)
"""
count=9

#%%10
"""
count+=1

print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Kat3_Method(4,4,Fixed=[[1,1],[1,4],[1,3],[2,4],[2,3]],Crossers=[[3,2]])#,[1,4],[3,4],[4,4],[5,4]])
#Sol=B.findPath()
Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("4x4, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
Filename=Savepath+str(count)+"cost="+str(Sol[1])+".txt"
B.WriteChronologicalShortestpathtoFile(Filename)
"""
