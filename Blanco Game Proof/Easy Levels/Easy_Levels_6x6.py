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
Savepath=r"6x6/"
#%%1
count=1
"""
start_time = time.time()
print("Calculating Nr.: "+str(count))
B=Block_Method(6,6)
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

#%%2
count+=1
"""
start_time = time.time()
print("Calculating Nr.: "+str(count))
B=Block_Method(6,6,Fixed=[1,1])
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
#%%3
count+=1
"""
start_time = time.time()
print("Calculating Nr.: "+str(count))
B=Block_Method(6,6,Fixed=[[1,1],[1,2],[1,5],[1,6],[2,1],[2,2],[2,5],[2,6],[5,1],[5,2],[5,5],[5,6],[6,1],[6,2],[6,5],[6,6]])
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
#%%4
count+=1
"""
start_time = time.time()
print("Calculating Nr.: "+str(count))
B=Block_Method(6,6,Fixed=[[1,1],[1,2],[1,5],[1,6],[2,1],[2,2],[2,5],[2,6],[3,5],[5,1],[5,2],[5,5],[5,6],[6,1],[6,2],[6,5],[6,6]])
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
#%%5
count+=1
"""
start_time = time.time()
print("Calculating Nr.: "+str(count))
B=Block_Method(6,6,Fixed=[[1,1],[1,2],[1,5],[1,6],[2,1],[2,2],[2,5],[2,6],[3,5],[5,1],[5,2],[5,4],[5,5],[5,6],[6,1],[6,2],[6,5],[6,6]])
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
#%%6
count+=1
"""
start_time = time.time()
print("Calculating Nr.: "+str(count))
B=Block_Method(6,6,Fixed=[[1,1],[1,2],[1,5],[1,6],[2,1],[2,2],[2,4],[2,5],[2,6],[3,5],[4,2],[5,1],[5,2],[5,3],[5,5],[5,6],[6,1],[6,2],[6,5],[6,6]])
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
#%%7
count+=1
"""
start_time = time.time()
print("Calculating Nr.: "+str(count))
B=Block_Method(6,6,Fixed=[[1,1],[1,2],[1,5],[1,6],[2,1],[2,2],[2,5],[2,6],[3,4],[5,1],[5,2],[5,5],[5,6],[6,1],[6,2],[6,5],[6,6]])
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

#%%8
count+=1
"""
start_time = time.time()
print("Calculating Nr.: "+str(count))
B=Block_Method(6,6,Fixed=[[1,1],[1,2],[1,5],[1,6],[2,1],[2,2],[2,5],[2,6],[3,4],[4,3],[5,1],[5,2],[5,5],[5,6],[6,1],[6,2],[6,5],[6,6]])
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
#%%9
count+=1
"""
start_time = time.time()
print("Calculating Nr.: "+str(count))
B=Block_Method(6,6,Fixed=[[1,1],[1,2],[1,3],[1,6],[2,1],[2,2],[2,3],[2,6],[5,1],[5,2],[5,3],[5,6],[6,1],[6,2],[6,3],[6,6]])
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
count+=1
"""
start_time = time.time()
print("Calculating Nr.: "+str(count))
B=Block_Method(6,6,Fixed=[[1,1],[1,2],[1,5],[1,6],[2,1],[2,6],[5,1],[5,6],[6,1],[6,2],[6,5],[6,6]])
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

#%%11
count+=1
"""
start_time = time.time()
print("Calculating Nr.: "+str(count))
B=Block_Method(6,6,Fixed=[[1,1],[1,2],[1,3],[2,1],[2,2],[2,3],[3,1],[3,2],[4,5],[4,6],[5,4],[5,5],[5,6],[6,4],[6,6],[6,5],[6,6]])
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
