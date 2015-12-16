# -*- coding: utf-8 -*-
"""
Created on Wed Jul 29 19:19:21 2015

@author: Mija
"""
from Game_Variations import *


class MazeClassManager(object):
    def __init__(self):
        self.Maze=Kat3_Method(6,6)
        
    def saveMaze2File(self,filepath):
        txtfile=open(filepath,'w')
        txtfile.write("[Maze]\n")
        txtfile.write(str(self.Maze._basic_maze.Matrix)+"\n")
        txtfile.write("[Fixed]\n")
        for cell in self.Maze._Fixed:
            txtfile.write(str(cell[0])+' '+str(cell[1])+"\n")
        txtfile.write("[OneTurns]\n")
        for cell in self.Maze._OneTurns:
            txtfile.write(str(cell[0])+' '+str(cell[1])+"\n")
        txtfile.write("[Crossers]\n")
        for cell in self.Maze._crossers:
            txtfile.write(str(cell[0])+' '+str(cell[1])+"\n")
        txtfile.write("[Edgers]\n")
        for cell in self.Maze._edgers:
            txtfile.write(str(cell[0])+' '+str(cell[1])+"\n")
    
    def loadMazeFromFile(self,filepath):
        txtfile=open(filepath,'r')
        pp='start'
        while pp != '[Maze]\n' and pp != '':
            pp=txtfile.readline()
        #read the matrix
        M=[]
        while pp != '[Fixed]\n' and pp != '':
            
            pp=txtfile.readline()
            if pp != '[Fixed]\n':
                LL=pp.replace('[','').replace(']','').replace('.','')
                LL=LL.split()
                line=[]
                for each in LL:
                    line.append(int(each))
                M.append(line)
        T=np.array(M)
        #read the fixed
        Fixed=readCellinidicesTable(txtfile)
        OneTurns=readCellinidicesTable(txtfile)
        Crossers=readCellinidicesTable(txtfile)
        Edgers=readCellinidicesTable(txtfile)
        self.Maze=Kat3_Method(int(T.shape[0]),int(T.shape[1]),Fixed,OneTurns,Crossers,Edgers)
        
def readCellinidicesTable(f):
    array=[]
    k='start'
    while not'[' in k and k != '':
        k=f.readline()
        if '[' in k or k=='':
            return array
        l=k.split()
        p=[]
        for e in l:
            p.append(int(e))
        array.append(p)

if __name__=="__main__":
    kk=MazeClassManager()
    kk.saveMaze2File("tester.txt")
    
    kk.loadMazeFromFile("tester.txt")
    