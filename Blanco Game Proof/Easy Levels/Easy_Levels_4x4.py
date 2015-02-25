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

Savepath=r"4x4/"
#%%1
count=1
"""
#initialize Object 4x4 Maze
B=Block_Method(4,4)#,Fixed=[[1,1]])#,[1,4],[3,4],[4,4],[5,4]])
Sol=B.findPath()
#Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("4x4, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
"""

#%%2

count+=1

"""
#initialize Object 4x4 Maze
B=Block_Method(4,4,Fixed=[[1,2]])#,[1,4],[3,4],[4,4],[5,4]])
Sol=B.findPath()
#Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("4x4, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
"""
#%%3

count+=1

"""
#initialize Object 4x4 Maze
B=Block_Method(4,4,Fixed=[[1,1]])#,[1,4],[3,4],[4,4],[5,4]])
Sol=B.findPath()
#Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("4x4, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
"""
#%%4

count+=1

"""
#initialize Object 4x4 Maze
B=Block_Method(4,4,Fixed=[[2,2]])#,[1,4],[3,4],[4,4],[5,4]])
Sol=B.findPath()
#Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("4x4, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
"""
#%%5

count+=1
"""
#initialize Object 4x4 Maze
B=Block_Method(4,4,Fixed=[[1,2],[1,1]])#,[1,4],[3,4],[4,4],[5,4]])
Sol=B.findPath()
#Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("4x4, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
"""
#%%6

count+=1
"""
#initialize Object 4x4 Maze
B=Block_Method(4,4,Fixed=[[1,2],[1,3]])#,[1,4],[3,4],[4,4],[5,4]])
Sol=B.findPath()
#Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("4x4, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
"""
#%%7

count+=1
"""
#initialize Object 4x4 Maze
B=Block_Method(4,4,Fixed=[[2,2],[1,1]])#,[1,4],[3,4],[4,4],[5,4]])
Sol=B.findPath()
#Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("4x4, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
"""
#%%8

count+=1
""" Achtung schon shortest
#initialize Object 4x4 Maze
B=Block_Method(4,4,Fixed=[[2,2],[2,1]])#,[1,4],[3,4],[4,4],[5,4]])
#Sol=B.findPath()
Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("4x4, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
"""
#%%9

count+=1
"""Achtung schon shortest
#initialize Object 4x4 Maze
B=Block_Method(4,4,Fixed=[[2,2],[2,3]])#,[1,4],[3,4],[4,4],[5,4]])
Sol=B.findPath()
#Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("4x4, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
"""

#%%10

count+=1
"""Achtung schon shortest
#initialize Object 4x4 Maze
B=Block_Method(4,4,Fixed=[[2,2],[3,3]])#,[1,4],[3,4],[4,4],[5,4]])
Sol=B.findPath()
#Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("4x4, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
"""

#%%11

count+=1
"""Achtung schon shortest
#initialize Object 4x4 Maze
B=Block_Method(4,4,Fixed=[[3,2],[2,1]])#,[1,4],[3,4],[4,4],[5,4]])
Sol=B.findPath()
#Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("4x4, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
"""

#%%12

count+=1
"""Achtung schon shortest
#initialize Object 4x4 Maze
B=Block_Method(4,4,Fixed=[[1,2],[2,1]])#,[1,4],[3,4],[4,4],[5,4]])
Sol=B.findPath()
#Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("4x4, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
"""

#%%13

count+=1
"""Achtung schon shortest
#initialize Object 4x4 Maze
B=Block_Method(4,4,Fixed=[[1,1],[3,3]])#,[1,4],[3,4],[4,4],[5,4]])
#Sol=B.findPath()
Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("4x4, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
"""

#%%14

count+=1
"""
#initialize Object 4x4 Maze
B=Block_Method(4,4,Fixed=[[1,1],[4,4]])#,[1,4],[3,4],[4,4],[5,4]])
Sol=B.findPath()
#Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("4x4, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
"""

count+=1
"""
#initialize Object 4x4 Maze
B=Block_Method(4,4,Fixed=[[1,1],[1,4]])#,[1,4],[3,4],[4,4],[5,4]])
Sol=B.findPath()
#Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("4x4, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
"""

count+=1
"""
#initialize Object 4x4 Maze
B=Block_Method(4,4,Fixed=[[1,1],[1,4],[4,4]])#,[1,4],[3,4],[4,4],[5,4]])
Sol=B.findPath()
#Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("4x4, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
"""

count+=1
"""
#initialize Object 4x4 Maze
B=Block_Method(4,4,Fixed=[[1,1],[1,4],[4,1],[4,4]])#,[1,4],[3,4],[4,4],[5,4]])
Sol=B.findPath()
#Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("4x4, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
"""

count+=1
"""
#initialize Object 4x4 Maze
B=Block_Method(4,4,Fixed=[[1,1],[1,2],[4,4]])#,[1,4],[3,4],[4,4],[5,4]])
Sol=B.findPath()
#Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("4x4, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
"""

count+=1
"""
#initialize Object 4x4 Maze
B=Block_Method(4,4,Fixed=[[1,1],[1,2],[4,3],[4,4]])#,[1,4],[3,4],[4,4],[5,4]])
Sol=B.findPath()
#Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("4x4, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
"""

count+=1
"""
#initialize Object 4x4 Maze
B=Block_Method(4,4,Fixed=[[1,1],[1,2],[4,3],[1,4],[2,4],[4,1],[3,1],[4,4]])#,[1,4],[3,4],[4,4],[5,4]])
Sol=B.findPath()
#Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("4x4, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
"""

count+=1
"""
#initialize Object 4x4 Maze
B=Block_Method(4,4,Fixed=[[1,1],[1,2],[3,4],[4,4]])#,[1,4],[3,4],[4,4],[5,4]])
Sol=B.findPath()
#Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("4x4, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
"""

count+=1
"""
#initialize Object 4x4 Maze
B=Block_Method(4,4,Fixed=[[1,1],[1,2],[3,4],[4,3],[4,4]])#,[1,4],[3,4],[4,4],[5,4]])
Sol=B.findPath()
#Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("4x4, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
"""

count+=1
"""
#initialize Object 4x4 Maze
B=Block_Method(4,4,Fixed=[[1,1],[1,2],[3,4],[4,4],[1,4]])
Sol=B.findPath()
#Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("4x4, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
"""