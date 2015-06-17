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
count=1
"""
#%% 1
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Kat2_Method(4,4,OneTurns=[[1,1]])#,[1,4],[3,4],[4,4],[5,4]])
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
#

#%% 2
count+=1
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Kat2_Method(4,4,OneTurns=[[1,1],[4,4]])#,[1,4],[3,4],[4,4],[5,4]])
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
#

#%% 3
count+=1
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Kat2_Method(4,4,OneTurns=[[1,1],[2,2],[3,3],[4,4]])#,[1,4],[3,4],[4,4],[5,4]])
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

#%% 4
count+=1
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Kat2_Method(4,4,OneTurns=[[1,1],[1,2],[1,3],[1,4]])#,[1,4],[3,4],[4,4],[5,4]])
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

#%% 5
count=5
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Kat2_Method(4,4,OneTurns=[[1,1],[1,2],[1,3],[1,4],[2,1],[2,2],[2,3],[2,4]])#,[1,4],[3,4],[4,4],[5,4]])
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

#%% 6
count=6
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Kat2_Method(4,4,OneTurns=[[1,1],[1,2],[1,3],[1,4],[3,1],[3,2],[3,3],[3,4]])#,[1,4],[3,4],[4,4],[5,4]])
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

#%% 7
count+=1
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Kat2_Method(4,4,OneTurns=[[1,1],[1,4],[4,1],[4,4]])#,[1,4],[3,4],[4,4],[5,4]])
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

"""

count=7
#%% 8
count+=1
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Kat2_Method(4,4,Fixed=[[1,1]],OneTurns=[[1,2],[2,2],[2,1]])#,[1,4],[3,4],[4,4],[5,4]])
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

#%% 9
count+=1
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Kat2_Method(4,4,Fixed=[[1,1]],OneTurns=[[1,3],[2,3],[3,3],[3,2],[3,1]])#,[1,4],[3,4],[4,4],[5,4]])
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

#%% 10
count+=1
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Kat2_Method(4,4,Fixed=[[1,1]],OneTurns=[[1,3],[2,3],[3,3],[4,3]])#,[1,4],[3,4],[4,4],[5,4]])
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

#%% 11
count+=1
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Kat2_Method(4,4,Fixed=[[1,1]],OneTurns=[[1,4],[2,4],[3,4],[4,4]])#,[1,4],[3,4],[4,4],[5,4]])
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

#%% 12
count+=1
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Kat2_Method(4,4,Fixed=[[1,1]],OneTurns=[[1,3],[2,3],[3,3],[4,3],[1,4],[2,4],[3,4],[4,4]])#,[1,4],[3,4],[4,4],[5,4]])
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

#%% 13
count+=1
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Kat2_Method(4,4,Fixed=[[1,1],[4,4]],OneTurns=[[2,2],[1,2],[2,1]])#,[1,4],[3,4],[4,4],[5,4]])
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

#%% 14
count+=1
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Kat2_Method(4,4,Fixed=[[1,1],[4,4]],OneTurns=[[1,2],[2,2],[2,1],[3,3],[3,4],[4,3]])#,[1,4],[3,4],[4,4],[5,4]])
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

#%% 15
count+=1
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Kat2_Method(4,4,Fixed=[[1,1],[4,4]],OneTurns=[[2,2],[3,3]])#,[1,4],[3,4],[4,4],[5,4]])
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

#%% 16
count+=1
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Kat2_Method(4,4,Fixed=[[1,1],[4,4]],OneTurns=[[2,2],[2,3],[3,2],[3,3]])#,[1,4],[3,4],[4,4],[5,4]])
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

#%% 17
count+=1
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Kat2_Method(4,4,Fixed=[[1,1],[4,4]],OneTurns=[[1,4],[2,3],[3,2],[4,1]])#,[1,4],[3,4],[4,4],[5,4]])
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

#%% 18
count+=1
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Kat2_Method(4,4,Fixed=[[1,1],[4,4]],OneTurns=[[3,1],[3,2],[3,3],[3,4]])#,[1,4],[3,4],[4,4],[5,4]])
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

#%% 19
count+=1
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Kat2_Method(4,4,Fixed=[[1,1],[4,4]],OneTurns=[[1,3],[2,3],[3,1],[3,2],[3,3],[3,4],[4,3]])#,[1,4],[3,4],[4,4],[5,4]])
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


#%% 20
count+=1
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Kat2_Method(4,4,Fixed=[[1,1],[1,4],[4,1],[4,4]],OneTurns=[[1,2],[1,3],[2,1],[2,4],[3,1],[3,4],[4,2],[4,3]])#,[1,4],[3,4],[4,4],[5,4]])
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

#%% 21
count+=1
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Kat2_Method(4,4,Fixed=[[1,1],[1,4],[4,1],[4,4]],OneTurns=[[2,2],[2,3],[3,2],[3,3]])#,[1,4],[3,4],[4,4],[5,4]])
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

#%% 22
count+=1
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Kat2_Method(4,4,Fixed=[[1,1],[1,4],[4,1],[4,4]],OneTurns=[[2,4],[2,2],[3,3],[3,1]])#,[1,4],[3,4],[4,4],[5,4]])
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

#%% 23
count+=1
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Kat2_Method(4,4,Fixed=[[1,1],[1,4],[4,1],[4,4]],OneTurns=[[2,1],[2,2],[2,3],[2,4]])#,[1,4],[3,4],[4,4],[5,4]])
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

#%% 24
