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
import time
start_time = time.time()

Savepath=r"5x5/"
#%%1
count=1
"""
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Kat2_Method(5,5,OneTurns=[[1,1]])#,[1,4],[3,4],[4,4],[5,4]])
#Sol=B.findPath()
Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("5x5, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
Filename=Savepath+str(count)+"cost="+str(Sol[1])+".txt"
B.WriteChronologicalShortestpathtoFile(Filename)


#%%2


count+=1
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Kat2_Method(5,5,OneTurns=[[1,1],[5,5]])#,[1,4],[3,4],[4,4],[5,4]])
#Sol=B.findPath()
Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("5x5, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
Filename=Savepath+str(count)+"cost="+str(Sol[1])+".txt"
B.WriteChronologicalShortestpathtoFile(Filename)

count=2
#%% 3
count+=1
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Kat2_Method(5,5,OneTurns=[[1,1],[1,5],[5,1],[5,5]])#,[1,4],[3,4],[4,4],[5,4]])
#Sol=B.findPath()
Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("5x5, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
Filename=Savepath+str(count)+"cost="+str(Sol[1])+".txt"
B.WriteChronologicalShortestpathtoFile(Filename)

#%% 4
count+=1
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Kat2_Method(5,5,OneTurns=[[1,1],[2,2],[3,3],[4,4],[5,5]])#,[1,4],[3,4],[4,4],[5,4]])
#Sol=B.findPath()
Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("5x5, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
Filename=Savepath+str(count)+"cost="+str(Sol[1])+".txt"
B.WriteChronologicalShortestpathtoFile(Filename)

count=4

#%% 5**
count+=1
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Kat2_Method(5,5,OneTurns=[[1,1],[1,5],[2,2],[2,4],[3,3],[4,2],[4,4],[5,1],[5,5]])#,[1,4],[3,4],[4,4],[5,4]])
#Sol=B.findPath()
Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("5x5, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
Filename=Savepath+str(count)+"cost="+str(Sol[1])+".txt"
B.WriteChronologicalShortestpathtoFile(Filename)

count=5
#%% 6**
count+=1
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Kat2_Method(5,5,OneTurns=[[1,1],[1,2],[1,3],[1,4],[1,5],[2,4],[3,3],[4,4],[5,1],[5,2],[5,3],[5,4],[5,5]])#,[1,4],[3,4],[4,4],[5,4]])
#Sol=B.findPath()
Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("5x5, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
Filename=Savepath+str(count)+"cost="+str(Sol[1])+".txt"
B.WriteChronologicalShortestpathtoFile(Filename)

count=6
#%% 7
count+=1
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Kat2_Method(5,5,OneTurns=[[2,2],[2,3],[2,4],[3,2],[3,4],[4,2],[4,3],[4,4]])#,[1,4],[3,4],[4,4],[5,4]])
#Sol=B.findPath()
Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("5x5, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
Filename=Savepath+str(count)+"cost="+str(Sol[1])+".txt"
B.WriteChronologicalShortestpathtoFile(Filename)

#%% 8
count+=1
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Kat2_Method(5,5,OneTurns=[[2,2],[2,4],[3,2],[3,4],[4,2],[4,4]])#,[1,4],[3,4],[4,4],[5,4]])
#Sol=B.findPath()
Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("5x5, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
Filename=Savepath+str(count)+"cost="+str(Sol[1])+".txt"
B.WriteChronologicalShortestpathtoFile(Filename)

#%% 9
count+=1
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Kat2_Method(5,5,OneTurns=[[3,3]])#,[1,4],[3,4],[4,4],[5,4]])
#Sol=B.findPath()
Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("5x5, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
Filename=Savepath+str(count)+"cost="+str(Sol[1])+".txt"
B.WriteChronologicalShortestpathtoFile(Filename)

count=9
#%% 10

count+=1
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Kat2_Method(5,5,Fixed=[[1,1]],OneTurns=[[5,5]])#,[1,4],[3,4],[4,4],[5,4]])
#Sol=B.findPath()
Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("5x5, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
Filename=Savepath+str(count)+"cost="+str(Sol[1])+".txt"
B.WriteChronologicalShortestpathtoFile(Filename)

count=10
#%% 11
count+=1
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Kat2_Method(5,5,Fixed=[[1,1]],OneTurns=[[1,2],[2,2],[2,1]])#,[1,4],[3,4],[4,4],[5,4]])
#Sol=B.findPath()
Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("5x5, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
Filename=Savepath+str(count)+"cost="+str(Sol[1])+".txt"
B.WriteChronologicalShortestpathtoFile(Filename)

#%% 12
count+=1
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Kat2_Method(5,5,Fixed=[[1,1]],OneTurns=[[1,5],[5,1],[5,5]])#,[1,4],[3,4],[4,4],[5,4]])
#Sol=B.findPath()
Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("5x5, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
Filename=Savepath+str(count)+"cost="+str(Sol[1])+".txt"
B.WriteChronologicalShortestpathtoFile(Filename)

count=12
#%% 13
count+=1
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Kat2_Method(5,5,Fixed=[[1,1]],OneTurns=[[1,2],[1,3],[1,4],[1,5],[2,1],[2,5],[3,1],[3,5],[4,1],[4,5],[5,1],[5,2],[5,3],[5,4],[5,5]])#,[1,4],[3,4],[4,4],[5,4]])
#Sol=B.findPath()
Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("5x5, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
Filename=Savepath+str(count)+"cost="+str(Sol[1])+".txt"
B.WriteChronologicalShortestpathtoFile(Filename)

count=13
#%% 14
count+=1
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Kat2_Method(5,5,Fixed=[[1,1]],OneTurns=[[2,2],[2,4],[4,2],[4,4]])#,[1,4],[3,4],[4,4],[5,4]])
#Sol=B.findPath()
Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("5x5, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
Filename=Savepath+str(count)+"cost="+str(Sol[1])+".txt"
B.WriteChronologicalShortestpathtoFile(Filename)

#%% 15
count+=1
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Kat2_Method(5,5,Fixed=[[1,1]],OneTurns=[[2,3],[3,2],[3,3],[3,4],[4,3]])#,[1,4],[3,4],[4,4],[5,4]])
#Sol=B.findPath()
Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("5x5, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
Filename=Savepath+str(count)+"cost="+str(Sol[1])+".txt"
B.WriteChronologicalShortestpathtoFile(Filename)

#%% 16
count+=1
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Kat2_Method(5,5,Fixed=[[1,1]],OneTurns=[[2,2],[2,3],[2,4],[3,2],[3,3],[3,4],[4,2],[4,3],[4,4]])#,[1,4],[3,4],[4,4],[5,4]])
#Sol=B.findPath()
Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("5x5, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
Filename=Savepath+str(count)+"cost="+str(Sol[1])+".txt"
B.WriteChronologicalShortestpathtoFile(Filename)

count=16
#%% 17
count+=1
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Kat2_Method(5,5,Fixed=[[1,1]],OneTurns=[[2,2],[2,3],[2,4],[2,5],[3,2],[3,3],[3,4],[3,5],[4,2],[4,3],[4,4],[4,5],[5,2],[5,3],[5,4],[5,5]])#,[1,4],[3,4],[4,4],[5,4]])
#Sol=B.findPath()
Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("5x5, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
Filename=Savepath+str(count)+"cost="+str(Sol[1])+".txt"
B.WriteChronologicalShortestpathtoFile(Filename)

count=17
#%% 18
count+=1
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Kat2_Method(5,5,OneTurns=[[2,2],[2,3],[2,4],[3,2],[3,3],[3,4],[4,2],[4,3],[4,4]])#,[1,4],[3,4],[4,4],[5,4]])
#Sol=B.findPath()
Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("5x5, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
Filename=Savepath+str(count)+"cost="+str(Sol[1])+".txt"
B.WriteChronologicalShortestpathtoFile(Filename)

count=18
#%% 19
count+=1
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Kat2_Method(5,5,OneTurns=[[2,2],[2,3],[2,4],[2,5],[3,2],[3,3],[3,4],[3,5],[4,2],[4,3],[4,4],[4,5],[5,2],[5,3],[5,4],[5,5]])#,[1,4],[3,4],[4,4],[5,4]])
#Sol=B.findPath()
Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("5x5, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
Filename=Savepath+str(count)+"cost="+str(Sol[1])+".txt"
B.WriteChronologicalShortestpathtoFile(Filename)

count=19
#%% 20
count+=1
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Kat2_Method(5,5,Fixed=[[1,1],[1,5],[5,1],[5,5]],OneTurns=[[2,1],[2,2],[2,3],[2,4],[2,5],[3,1],[3,2],[3,3],[3,4],[3,5],[4,1],[4,2],[4,3],[4,4],[4,5]])#,[1,4],[3,4],[4,4],[5,4]])
#Sol=B.findPath()
Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("5x5, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
Filename=Savepath+str(count)+"cost="+str(Sol[1])+".txt"
B.WriteChronologicalShortestpathtoFile(Filename)

count=20
#%% 21
count+=1
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Kat2_Method(5,5,Fixed=[[1,1],[1,5],[5,1],[5,5]],OneTurns=[[1,3],[2,3],[3,1],[3,2],[3,3],[3,4],[3,5],[4,3],[5,3]])#,[1,4],[3,4],[4,4],[5,4]])
#Sol=B.findPath()
Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("5x5, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
Filename=Savepath+str(count)+"cost="+str(Sol[1])+".txt"
B.WriteChronologicalShortestpathtoFile(Filename)
"""
count=21
#%% 22
count+=1
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Kat2_Method(5,5,Fixed=[[1,1],[1,5],[5,1],[5,5]],OneTurns=[[1,2],[1,4],[2,1],[2,2],[2,4],[2,5],[4,1],[4,2],[4,4],[4,5],[5,2],[5,4]])#,[1,4],[3,4],[4,4],[5,4]])
#Sol=B.findPath()
Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("5x5, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
Filename=Savepath+str(count)+"cost="+str(Sol[1])+".txt"
B.WriteChronologicalShortestpathtoFile(Filename)

#%% 23
count+=1
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Kat2_Method(5,5,Fixed=[[1,1],[1,5],[5,1],[5,5]],OneTurns=[[1,3],[3,1],[3,5],[5,3]])#,[1,4],[3,4],[4,4],[5,4]])
#Sol=B.findPath()
Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("5x5, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
Filename=Savepath+str(count)+"cost="+str(Sol[1])+".txt"
B.WriteChronologicalShortestpathtoFile(Filename)

#%% 24
count+=1
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Kat2_Method(5,5,Fixed=[[1,1],[1,5],[5,1],[5,5]],OneTurns=[[1,3],[3,1],[3,3],[3,5],[5,3]])#,[1,4],[3,4],[4,4],[5,4]])
#Sol=B.findPath()
Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("5x5, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
Filename=Savepath+str(count)+"cost="+str(Sol[1])+".txt"
B.WriteChronologicalShortestpathtoFile(Filename)

#%% 25
count+=1
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Kat2_Method(5,5,Fixed=[[1,1],[1,2],[1,3],[1,5],[2,1],[3,1],[3,5],[4,5],[5,1],[5,3],[5,4],[5,5]],OneTurns=[[2,2],[3,3],[4,4]])#,[1,4],[3,4],[4,4],[5,4]])
#Sol=B.findPath()
Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("5x5, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
Filename=Savepath+str(count)+"cost="+str(Sol[1])+".txt"
B.WriteChronologicalShortestpathtoFile(Filename)

#%% 26
count+=1
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Kat2_Method(5,5,Fixed=[[1,1],[1,2],[1,3],[1,5],[2,1],[3,1],[3,5],[4,5],[5,1],[5,3],[5,4],[5,5]],OneTurns=[[1,4],[2,4],[2,5],[4,1],[4,2],[5,2]])#,[1,4],[3,4],[4,4],[5,4]])
#Sol=B.findPath()
Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("5x5, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
Filename=Savepath+str(count)+"cost="+str(Sol[1])+".txt"
B.WriteChronologicalShortestpathtoFile(Filename)

#%% 27
count+=1
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Kat2_Method(5,5,Fixed=[[1,1],[1,2],[1,3],[1,5],[2,1],[3,1],[3,5],[4,5],[5,1],[5,3],[5,4],[5,5]],OneTurns=[[2,4],[3,3],[4,2]])#,[1,4],[3,4],[4,4],[5,4]])
#Sol=B.findPath()
Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("5x5, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
Filename=Savepath+str(count)+"cost="+str(Sol[1])+".txt"
B.WriteChronologicalShortestpathtoFile(Filename)

#%% 28
count+=1
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Kat2_Method(5,5,Fixed=[[1,1],[1,2],[1,3],[1,5],[2,1],[3,1],[3,5],[4,5],[5,1],[5,3],[5,4],[5,5]],OneTurns=[[2,2],[2,4],[4,4],[4,2]])#,[1,4],[3,4],[4,4],[5,4]])
#Sol=B.findPath()
Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("5x5, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
Filename=Savepath+str(count)+"cost="+str(Sol[1])+".txt"
B.WriteChronologicalShortestpathtoFile(Filename)

#%% 29
count+=1
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Kat2_Method(5,5,Fixed=[[1,1],[1,2],[2,1],[4,5],[5,4],[5,5]],OneTurns=[[1,5],[2,4],[3,3],[4,2],[5,1]])#,[1,4],[3,4],[4,4],[5,4]])
#Sol=B.findPath()
Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("5x5, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
Filename=Savepath+str(count)+"cost="+str(Sol[1])+".txt"
B.WriteChronologicalShortestpathtoFile(Filename)

#%% 30
count+=1
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Kat2_Method(5,5,Fixed=[[1,1],[1,2],[2,1],[4,5],[5,4],[5,5]],OneTurns=[[2,3],[2,4],[3,2],[3,3],[3,4],[4,2],[4,3]])#,[1,4],[3,4],[4,4],[5,4]])
#Sol=B.findPath()
Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("5x5, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
Filename=Savepath+str(count)+"cost="+str(Sol[1])+".txt"
B.WriteChronologicalShortestpathtoFile(Filename)

#%% 31
count+=1
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Kat2_Method(5,5,Fixed=[[1,1],[1,2],[2,1],[4,5],[5,4],[5,5]],OneTurns=[[1,3],[1,4],[1,5],[2,5],[3,1],[3,5],[4,1],[5,1],[5,2],[5,3]])#,[1,4],[3,4],[4,4],[5,4]])
#Sol=B.findPath()
Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("5x5, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
Filename=Savepath+str(count)+"cost="+str(Sol[1])+".txt"
B.WriteChronologicalShortestpathtoFile(Filename)

#%% 32
count+=1
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Kat2_Method(5,5,Fixed=[[1,1],[1,2],[2,1],[4,5],[5,4],[5,5]],OneTurns=[[1,3],[2,2],[3,1],[3,5],[4,4],[5,3]])#,[1,4],[3,4],[4,4],[5,4]])
#Sol=B.findPath()
Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("5x5, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
Filename=Savepath+str(count)+"cost="+str(Sol[1])+".txt"
B.WriteChronologicalShortestpathtoFile(Filename)

