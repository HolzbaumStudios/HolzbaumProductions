# -*- coding: utf-8 -*-
"""
Created on Wed Oct 15 16:09:51 2014

@author: Mija
"""
from Tkinter import *
from tkFileDialog import askopenfilename,asksaveasfile
from PyQt4.QtGui import *
import matplotlib.pyplot as plt
from Maze_Class_Manager import *

class CalculationDialog(QDialog):
    """This class create a dialog to report field"""
    
    def __init__(self,Maze):
        super(CalculationDialog,self).__init__()
        self.Maze=Maze
        
        self.setWindowTitle("Calculation Window")
        
        #labels for the crop status
        self.calculation_label = QLabel("Calculation Status:   ")
        self.solution_label = QLabel("Solution:")
        self.calculation_info_label = QLabel("No Calculation yet")
        self.solution_info_label = QLabel("No Solution yet")
        
        self.close_button=QPushButton("Close Calculation")
        self.calc_button=QPushButton("Calculate Solution")
        
        #layouts
        self.report_layout=QGridLayout()
        self.layout=QVBoxLayout()
        
        self.texer="No Calculation yet"
        self.report_layout.addWidget(self.calculation_label,0,0)
        self.report_layout.addWidget(self.solution_label,0,1)
        self.report_layout.addWidget(self.calculation_info_label,1,0)
        self.report_layout.addWidget(self.solution_info_label,1,1)
                
                
        self.layout.addLayout(self.report_layout)
        self.layout.addWidget(self.calc_button)
        self.layout.addWidget(self.close_button)
        self.setLayout(self.layout)
        
        #connections
        self.close_button.clicked.connect(self.close)
        self.calc_button.clicked.connect(self.calculateSolution)
        
        
    def calculateSolution(self):
        #save the files
        save_name='default'
        if self.Maze.saveName==None:
            root=Tk()
            fileName=asksaveasfile(mode='w',defaultextension=".txt")
            fileName.close()
            root.destroy()        
            save_name=fileName.name
            
        
        if save_name!='':
            if self.Maze.saveName==None:
                self.Maze.saveName=save_name
                
            self.calculation_info_label.setText("Processing")
            
            self.setLayout(self.layout)
            self.updateGeometry()
            
            Manager=MazeClassManager()
            Manager.Maze=self.Maze
            Manager.saveMaze2File(self.Maze.saveName)            
            
            
            
            Sol=self.Maze.findShortestPath()
            self.solution_info_label.setText("Solution in "+str(Sol[1])+" steps.")
            self.calculation_info_label.setText("Finished")
            
            plt.figure()
            ax=plt.subplot(1,1,1)
            plt.title("Shortest="+str(Sol[1])+" moves")
            self.Maze.plotBasicMaze(Axes=ax)
            plt.savefig(self.Maze.saveName.replace(".txt","_Sol_in_"+str(Sol[1])+"_steps.jpg"))        
            plt.close('all')
            self.Maze.WriteChronologicalShortestpathtoFile(self.Maze.saveName.replace(".txt","_sol.txt"))
        
                
                
                
        


