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
Savepath=r"6x6/"
#%%1
"""
count=1

start_time = time.time()
print("Calculating Nr.: "+str(count))
B=Kat2_Method(6,6,OneTurns=[[2,2],[2,3],[2,4],[2,5],[3,2],[3,3],[3,4],[3,5],[4,2],[4,3],[4,4],[4,5],[5,2],[5,3],[5,4],[5,5]])
#Sol=B.findPath()
Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("6x6, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
Filename=Savepath+str(count)+"cost="+str(Sol[1])+".txt"
B.WriteChronologicalShortestpathtoFile(Filename)
print("--- %s seconds ---" % (time.time() - start_time))

count=1

#%%2
count+=1
start_time = time.time()
print("Calculating Nr.: "+str(count))
B=Kat2_Method(6,6,OneTurns=[[1,1],[1,2],[1,3],[1,4],[1,5],[1,6],[2,1],[2,6],[3,1],[3,6],[4,1],[4,6],[5,1],[5,6],[6,1],[6,2],[6,3],[6,4],[6,5],[6,6]])
#Sol=B.findPath()
Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("6x6, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
Filename=Savepath+str(count)+"cost="+str(Sol[1])+".txt"
B.WriteChronologicalShortestpathtoFile(Filename)
print("--- %s seconds ---" % (time.time() - start_time))

count=2

#%%3
count+=1
start_time = time.time()
print("Calculating Nr.: "+str(count))
B=Kat2_Method(6,6,OneTurns=[[1,1],[2,2],[3,3],[4,4],[5,5],[6,6]])
#Sol=B.findPath()
Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("6x6, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
Filename=Savepath+str(count)+"cost="+str(Sol[1])+".txt"
B.WriteChronologicalShortestpathtoFile(Filename)
print("--- %s seconds ---" % (time.time() - start_time))
"""
count=3

#%%4
count+=1
start_time = time.time()
print("Calculating Nr.: "+str(count))
B=Kat2_Method(6,6,OneTurns=[[2,2],[2,3],[3,2],[3,3],[4,4],[4,5],[5,4],[5,5]])
#Sol=B.findPath()
Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("6x6, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
Filename=Savepath+str(count)+"cost="+str(Sol[1])+".txt"
B.WriteChronologicalShortestpathtoFile(Filename)
print("--- %s seconds ---" % (time.time() - start_time))


#%%5
count+=1
start_time = time.time()
print("Calculating Nr.: "+str(count))
B=Kat2_Method(6,6,OneTurns=[[1,2],[1,3],[1,4],[1,5],[2,2],[2,5],[5,2],[5,5],[6,2],[6,3],[6,4],[6,5]])
#Sol=B.findPath()
Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("6x6, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
Filename=Savepath+str(count)+"cost="+str(Sol[1])+".txt"
B.WriteChronologicalShortestpathtoFile(Filename)
print("--- %s seconds ---" % (time.time() - start_time))


#%%6
count+=1
start_time = time.time()
print("Calculating Nr.: "+str(count))
B=Kat2_Method(6,6,OneTurns=[[2,1],[2,2],[2,3],[2,4],[2,5],[2,6],[5,1],[5,2],[5,3],[5,4],[5,5],[5,6]])
#Sol=B.findPath()
Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("6x6, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
Filename=Savepath+str(count)+"cost="+str(Sol[1])+".txt"
B.WriteChronologicalShortestpathtoFile(Filename)
print("--- %s seconds ---" % (time.time() - start_time))

"""
count=6

#%%7
count+=1
start_time = time.time()
print("Calculating Nr.: "+str(count))
B=Kat2_Method(6,6,Fixed=[[1,1],[1,2],[1,5],[1,6],[2,1],[2,2],[2,5],[2,6],[5,1],[5,2],[5,5],[5,6],[6,1],[6,2],[6,5],[6,6]],OneTurns=[[3,3],[3,4],[4,3],[4,4]])
#Sol=B.findPath()
Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("6x6, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
Filename=Savepath+str(count)+"cost="+str(Sol[1])+".txt"
B.WriteChronologicalShortestpathtoFile(Filename)
print("--- %s seconds ---" % (time.time() - start_time))


#%%8
count+=1
start_time = time.time()
print("Calculating Nr.: "+str(count))
B=Kat2_Method(6,6,Fixed=[[1,1],[1,2],[1,5],[1,6],[2,1],[2,2],[2,5],[2,6],[5,1],[5,2],[5,5],[5,6],[6,1],[6,2],[6,5],[6,6]],OneTurns=[[2,3],[2,4],[3,2],[3,3],[3,4],[3,5],[4,2],[4,3],[4,4],[4,5],[5,3],[5,4]])
#Sol=B.findPath()
Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("6x6, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
Filename=Savepath+str(count)+"cost="+str(Sol[1])+".txt"
B.WriteChronologicalShortestpathtoFile(Filename)
print("--- %s seconds ---" % (time.time() - start_time))


#%%9
count+=1
start_time = time.time()
print("Calculating Nr.: "+str(count))
B=Kat2_Method(6,6,Fixed=[[1,1],[1,2],[1,5],[1,6],[2,1],[2,2],[2,5],[2,6],[5,1],[5,2],[5,5],[5,6],[6,1],[6,2],[6,5],[6,6]],OneTurns=[[1,3],[1,4],[2,3],[2,4],[3,1],[3,2],[3,5],[3,6],[4,1],[4,2],[4,5],[4,6],[5,3],[5,4],[6,3],[6,4]])
#Sol=B.findPath()
Sol=B.findShortestPath()
print("State Costs: "+str(Sol[1]))
plt.figure()
ax=plt.subplot(1,1,1)
plt.title("6x6, Shortest="+str(Sol[1])+" moves")
B.plotBasicMaze(Axes=ax)
plt.savefig(Savepath+str(count)+"cost="+str(Sol[1])+".jpg")
Filename=Savepath+str(count)+"cost="+str(Sol[1])+".txt"
B.WriteChronologicalShortestpathtoFile(Filename)
print("--- %s seconds ---" % (time.time() - start_time))
"""

#%%10
