# -*- coding: utf-8 -*-
"""
Created on Wed Jul 29 18:34:40 2015

@author: Mija
"""
import sys

from PyQt4.QtGui import*
from PyQt4.QtCore import *
from graphic_white_cell_item_class import *
from graphic_drag_label_class import *
from graphic_maze_scene_class import *


class FieldWindow(QMainWindow):
    """this class creates a main window to observe the growth of a simulated field"""
    def __init__(self):
        super(FieldWindow,self).__init__()
        self.setWindowTitle("Squared Level Designer")
        
        #create toolbars
        self.cell_tool_bar=QToolBar()
        
        
        #create toolbar labels
        self.white_label =WhiteCellDragLabel()
        self.white_label.setToolTip("Add White Cell")
        
        self.blue_label =BlueCellDragLabel()
        self.blue_label.setToolTip("Add Blue Cell")
        
        self.yellow_label =YellowCellDragLabel()
        self.yellow_label.setToolTip("Add Yellow Cell")
        
        self.red_label =RedCellDragLabel()
        self.red_label.setToolTip("Add Red Cell")
        
        self.green_label =GreenCellDragLabel()
        self.green_label.setToolTip("Add Green Cell")
#        

#        
#        
        
        #add labels to toolbars
        self.cell_tool_bar.addWidget(self.white_label)
        self.cell_tool_bar.addWidget(self.blue_label)
        self.cell_tool_bar.addWidget(self.yellow_label)
        self.cell_tool_bar.addWidget(self.red_label)
        self.cell_tool_bar.addWidget(self.green_label)

        
        
        #add toolbars to window
        self.addToolBar(self.cell_tool_bar)
        
        
        
        
        self.maze_graphics_view =QGraphicsView()
        self.maze_graphics_view.setScene(MazeGraphicsScene()) #1,5 are standing for max Crops and max animals
        
        self.maze_graphics_view.setFixedHeight(400)
        self. maze_graphics_view.setFixedWidth(400)
        self.maze_graphics_view.setSceneRect(0,0,400,400)
        self.maze_graphics_view.setHorizontalScrollBarPolicy(1)
        self.maze_graphics_view.setVerticalScrollBarPolicy(1)
        
        self.maze_report_button=QPushButton("Calculate Shortest Solution")
        self.maze_automatic_grow_button=QPushButton("Save Level")
        self.maze_manual_grow_button=QPushButton("Load Level")
        
        self.layout=QVBoxLayout()
        
        self.layout.addWidget(self.maze_graphics_view)
        self.layout.addWidget(self.maze_report_button)
        self.layout.addWidget(self.maze_automatic_grow_button)
        self.layout.addWidget(self.maze_manual_grow_button)
        
        self.main_widget = QWidget()
        self.main_widget.setLayout(self.layout)
        self.setCentralWidget(self.main_widget)
        
        #connections
#        self.maze_automatic_grow_button.clicked.connect(self.automatically_grow)
#        self.maze_manual_grow_button.clicked.connect(self.manually_grow)        
#        self.maze_report_button.clicked.connect(self.report)     
        

def main():
    field_simulation= QApplication(sys.argv) #create new application
    field_window = FieldWindow() # create new instance of main window
    field_window.show() #make instance visible
    field_window.raise_() #raise instance to top of window stack
    field_simulation.exec_() #monitor application for events#
    
    
if __name__=="__main__":
    main()
        