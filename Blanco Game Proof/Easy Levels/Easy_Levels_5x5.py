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
from Game_VariationsV3 import *
import time
start_time = time.time()

Savepath=r"5x5/"
#%%1
count=1
"""
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Block_Method(5,5)#,Fixed=[[1,1]])#,[1,4],[3,4],[4,4],[5,4]])
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

#%%2


count+=1
"""
#
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Block_Method(5,5,Fixed=[[1,1]])#,[1,4],[3,4],[4,4],[5,4]])
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
#
"""
#%%3

count+=1
"""
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Block_Method(5,5,Fixed=[[1,1],[5,5]])#,[1,4],[3,4],[4,4],[5,4]])
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
#%%4

count+=1
"""
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Block_Method(5,5,Fixed=[[1,1],[5,1],[1,5],[5,5]])#,[1,4],[3,4],[4,4],[5,4]])
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
#%%5

print("--- %s seconds ---" % (time.time() - start_time))
start_time = time.time()
count+=1
"""
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Block_Method(5,5,Fixed=[[1,1],[5,1],[5,5]])#,[1,4],[3,4],[4,4],[5,4]])
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
print("--- %s seconds ---" % (time.time() - start_time))
start_time = time.time()
"""
#%%6

count+=1
"""
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Block_Method(5,5,Fixed=[[1,1],[2,2],[5,5]])#,[1,4],[3,4],[4,4],[5,4]])
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

print("--- %s seconds ---" % (time.time() - start_time))
start_time = time.time()
"""
#%%7

count+=1
"""
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Block_Method(5,5,Fixed=[[1,1],[2,2],[4,4],[5,5]])#,[1,4],[3,4],[4,4],[5,4]])
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
print("--- %s seconds ---" % (time.time() - start_time))
start_time = time.time()
"""
#%%8

count+=1
"""
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Block_Method(5,5,Fixed=[[1,1],[2,2],[3,3],[4,4],[5,5]])#,[1,4],[3,4],[4,4],[5,4]])
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
print("--- %s seconds ---" % (time.time() - start_time))
start_time = time.time()
"""
#%%9

count+=1
"""
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Block_Method(5,5,Fixed=[[1,1],[2,2],[3,3],[4,4],[5,5],[1,5]])#,[1,4],[3,4],[4,4],[5,4]])
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
print("--- %s seconds ---" % (time.time() - start_time))
start_time = time.time()
"""
#%%10

count+=1
"""
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Block_Method(5,5,Fixed=[[1,1],[2,2],[3,3],[4,4],[5,5],[1,5],[5,1]])#,[1,4],[3,4],[4,4],[5,4]])
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
print("--- %s seconds ---" % (time.time() - start_time))
start_time = time.time()
"""
#%%11

count+=1
"""
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Block_Method(5,5,Fixed=[[1,1],[2,2],[3,3],[4,4],[5,5],[1,5],[2,4],[5,1]])#,[1,4],[3,4],[4,4],[5,4]])
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
print("--- %s seconds ---" % (time.time() - start_time))
start_time = time.time()
"""
#%%12

count+=1
"""
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Block_Method(5,5,Fixed=[[1,1],[2,2],[3,3],[4,4],[5,5],[1,5],[2,4],[4,2],[5,1]])#,[1,4],[3,4],[4,4],[5,4]])
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
print("--- %s seconds ---" % (time.time() - start_time))
start_time = time.time()
"""
#%%13

count+=1
"""
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Block_Method(5,5,Fixed=[[2,2],[2,3],[2,4],[1,5],[5,1]])#,[1,4],[3,4],[4,4],[5,4]])
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
print("--- %s seconds ---" % (time.time() - start_time))
start_time = time.time()
"""
#%%14

count+=1
"""
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Block_Method(5,5,Fixed=[[2,3],[2,2],[3,3],[4,4],[2,4],[3,2],[3,4],[4,2],[4,3]])#,[1,4],[3,4],[4,4],[5,4]])
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
print("--- %s seconds ---" % (time.time() - start_time))
start_time = time.time()
"""
#%%15

count+=1
"""
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Block_Method(5,5,Fixed=[[1,1],[2,2],[2,3],[2,4],[1,5]])#,[5,1]])#,[1,4],[3,4],[4,4],[5,4]])
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
print("--- %s seconds ---" % (time.time() - start_time))
start_time = time.time()
"""
#%%16

count+=1
"""
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Block_Method(5,5,Fixed=[[1,1],[2,2],[2,3],[2,4],[1,5],[5,1]])#,[1,4],[3,4],[4,4],[5,4]])
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
print("--- %s seconds ---" % (time.time() - start_time))
start_time = time.time()
"""
#%%17

count+=1
"""
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Block_Method(5,5,Fixed=[[1,2],[1,4]])#,[5,1]])#,[1,4],[3,4],[4,4],[5,4]])
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
print("--- %s seconds ---" % (time.time() - start_time))
start_time = time.time()
"""
#%%18

count+=1
"""
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Block_Method(5,5,Fixed=[[1,2],[1,4],[1,3]])#,[5,1]])#,[1,4],[3,4],[4,4],[5,4]])
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
print("--- %s seconds ---" % (time.time() - start_time))
start_time = time.time()
"""
#%%19

count+=1
"""
print("Calculating Nr.: "+str(count)) #Dont know if it has solution
#initialize Object 4x4 Maze
B=Block_Method(5,5,Fixed=[[1,2],[1,4],[1,3],[2,1],[2,5]])#,[5,1]])#,[1,4],[3,4],[4,4],[5,4]])
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
print("--- %s seconds ---" % (time.time() - start_time))
start_time = time.time()
"""
#%%20

count+=1
"""
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Block_Method(5,5,Fixed=[[1,2],[1,4],[1,3],[2,1],[2,5],[2,3]])#,[5,1]])#,[1,4],[3,4],[4,4],[5,4]])
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
print("--- %s seconds ---" % (time.time() - start_time))
start_time = time.time()
"""
#%%21

count+=1
"""
print("Calculating Nr.: "+str(count)) #Dont know if it has solution
#initialize Object 4x4 Maze
B=Block_Method(5,5,Fixed=[[1,2],[1,4],[1,3],[2,1],[2,5],[3,3]])#,[5,1]])#,[1,4],[3,4],[4,4],[5,4]])
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
print("--- %s seconds ---" % (time.time() - start_time))
start_time = time.time()
"""

#%%22

count+=1
"""
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Block_Method(5,5,Fixed=[[1,2],[1,4],[1,3],[2,1],[2,5],[2,3],[3,3]])#,[5,1]])#,[1,4],[3,4],[4,4],[5,4]])
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
print("--- %s seconds ---" % (time.time() - start_time))
start_time = time.time()
"""
#%%23

count+=1
"""
print("Calculating Nr.: "+str(count)) #Dont know if it has solution
#initialize Object 4x4 Maze
B=Block_Method(5,5,Fixed=[[1,2],[1,4],[1,3],[2,1],[2,5],[4,1],[5,2],[5,3],[5,4],[4,5]])#,[5,1]])#,[1,4],[3,4],[4,4],[5,4]])
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
print("--- %s seconds ---" % (time.time() - start_time))
start_time = time.time()
"""
#%%24

count+=1
"""
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Block_Method(5,5,Fixed=[[1,2],[1,4],[1,3],[2,1],[2,5],[4,1],[5,2],[5,3],[5,4],[4,5],[2,3]])#,[5,1]])#,[1,4],[3,4],[4,4],[5,4]])
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
print("--- %s seconds ---" % (time.time() - start_time))
"""

#%%25

count+=1
"""
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Block_Method(5,5,Fixed=[[1,5],[1,3],[2,1],[2,2],[2,4],[2,5],[3,5],[4,4],[4,5],[5,4]])#,[5,1]])#,[1,4],[3,4],[4,4],[5,4]])
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
print("--- %s seconds ---" % (time.time() - start_time))
"""

#%%26

count+=1
"""
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Block_Method(5,5,Fixed=[[1,1],[1,2],[1,3],[1,5],[2,1],[3,1],[3,5],[4,5],[5,1],[5,5]])
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
print("--- %s seconds ---" % (time.time() - start_time))
"""
#%% 27
count+=1
"""
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Block_Method(5,5,Fixed=[[1,1],[1,2],[1,3],[1,5],[2,1],[3,1],[3,5],[4,5],[5,1],[5,3],[5,4],[5,5]])
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
print("--- %s seconds ---" % (time.time() - start_time))
"""
#%% 28
count+=1
"""
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Block_Method(5,5,Fixed=[[1,1],[1,2],[1,4],[1,5],[2,1],[4,1],[2,5],[4,5],[5,1],[5,2],[5,4],[5,5]])
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
print("--- %s seconds ---" % (time.time() - start_time))
"""
#%% 29
count+=1
"""
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Block_Method(5,5,Fixed=[[1,1],[1,2],[1,3],[1,4],[1,5],[2,1],[3,1],[3,5],[4,5],[5,1],[5,3],[5,4],[5,5]])
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
print("--- %s seconds ---" % (time.time() - start_time))
"""
#%% 30
count+=1
"""
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Block_Method(5,5,Fixed=[[1,1],[1,2],[1,3],[1,4],[1,5],[2,1],[4,1],[2,5],[4,5],[5,1],[5,2],[5,4],[5,5]])
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
print("--- %s seconds ---" % (time.time() - start_time))
"""
#%% 31
count+=1
"""
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Block_Method(5,5,Fixed=[[1,1],[1,2],[1,3],[2,1],[3,1],[3,5],[4,5],[5,5]])
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
print("--- %s seconds ---" % (time.time() - start_time))
"""

#%% 32
count+=1
"""
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Block_Method(5,5,Fixed=[[1,1],[1,2],[1,3],[2,1],[3,1],[3,5],[4,5],[5,3],[5,4],[5,5]])
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
print("--- %s seconds ---" % (time.time() - start_time))
"""

#%% 33
count+=1
"""
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Block_Method(5,5,Fixed=[[1,3],[3,1],[3,5],[5,3]])
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
print("--- %s seconds ---" % (time.time() - start_time))
"""
#%% 34
count+=1
"""
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Block_Method(5,5,Fixed=[[1,1],[1,2],[2,1],[2,2],[4,4],[4,5],[5,4],[5,5]])
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
print("--- %s seconds ---" % (time.time() - start_time))
"""
#%% 35
count+=1
"""
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Block_Method(5,5,Fixed=[[1,1],[1,2],[1,3],[3,5],[4,5],[5,5]])
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
print("--- %s seconds ---" % (time.time() - start_time))
"""
#%% 36
count+=1
"""
print("Calculating Nr.: "+str(count))
#initialize Object 4x4 Maze
B=Block_Method(5,5,Fixed=[[1,1],[1,2],[2,1],[4,5],[5,4],[5,5]])
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
print("--- %s seconds ---" % (time.time() - start_time))
"""