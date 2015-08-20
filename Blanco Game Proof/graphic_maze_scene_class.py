# -*- coding: utf-8 -*-
"""
Created on Mon Oct 13 18:00:17 2014

@author: Mija
"""

from PyQt4.QtGui import*

from Game_Variations import *

from graphic_white_cell_item_class import *
from graphic_blue_cell_item_class import *
from graphic_yellow_cell_item_class import *
from graphic_red_cell_item_class import *
from graphic_green_cell_item_class import *


import resources

class MazeGraphicsScene(QGraphicsScene):
    """ this class provides a scene to manage items in the field"""
    
    #constructor
    def __init__(self,mazeX=6,mazeY=6):
        super(MazeGraphicsScene,self).__init__()
        
        self.mazeX=mazeX
        self.mazeY=mazeY
        self.maze = Kat3_Method(mazeX,mazeY)
        
        self.background_brush=QBrush()
        self.background_picture= QPixmap(":/blue_cell.png")
        self.background_brush.setTexture(self.background_picture)
        self.setBackgroundBrush(self.background_brush)
        
#        view=self.views()[0]
#        self.total_width=view.width()
#        self.total_height=view.height()
#        print("w: "+str(self.total_width))
        
        
    def update_maze(self):
        view=self.views()[0]
        self.total_width=view.width()
        self.total_height=view.height()
        
        cell_space_width=int(self.total_width/self.mazeX)
        cell_space_height=int(self.total_height/self.mazeY)
        
        #remove all items
        items=self.items()
        for i in items:
            self.removeItem(i)
            
        for Xi in range(0,self.mazeX):
            for Yi in range(0,self.mazeY):
                MatrixValue=self.maze._basic_maze.Matrix[Xi][Yi]
                ViewXPos=Xi*cell_space_width-cell_space_width/2
                ViewYPos=Yi*cell_space_height-cell_space_height/2
                self.maze.test.append(WhiteCellGraphicsPixmapItem())
                self._add_graphic_item(True,"white_cell",[ViewXPos,ViewYPos])
                
        
        print("w: "+str(self.total_width))

                   
        
    
    def _drop_position(self, item):
        cursor_position = QCursor.pos() #global cursor position
        current_view =self.views()[0]
        scene_position =current_view.mapFromGlobal(cursor_position) #gets position in scene
        
        width= item.boundingRect().width()
        height= item.boundingRect().height()
        
        width_offset = width/2
        height_offset = height/2
        
        drop_x =scene_position.x()-width_offset
        drop_y= scene_position.y()-height_offset
        
        return drop_x,drop_y
        
    def _visualise_graphic_item(self,graphic_item_type,view_position=None):
        if graphic_item_type == "white_cell":
            if view_position==None:
                x,y = self._drop_position(self.maze.test[-1])
            else:
                x=view_position[0]
                y=view_position[1]
            self.maze.test[-1].setPos(x,y)
            self.addItem(self.maze.test[-1])
            
            #self.update_maze()
#        elif graphic_item_type =="animal":
#            x,y = self._drop_position(self.field._animals[-1])
#            self.field._animals[-1].setPos(x,y)
#            self.addItem(self.field._animals[-1])
     
    def _add_graphic_item(self,result,graphic_item_type,view_position=None):
        if result:
            self._visualise_graphic_item(graphic_item_type,view_position)
        else:
            error_message =QMessageBox()
            error_message.setText("No more {0}s can be added to this field".format(graphic_item_type))
            error_message.exec_()
        
        
        
    #this method orrides the parent mode
    def dragEnterEvent(self,event):
        #what do if an object is dragged into the scene
        event.accept()
        
    def dragMoveEvent(self,event):
        event.accept()
    
    def dropEvent(self,event):
        event.accept()
        
        #what do if an object is dropped on the scene
        if event.mimeData().hasFormat("application/x-white"):
            #crop_added = self.field.plant_crop(WheatGraphicsPixmapItem())
            self.maze.test.append(WhiteCellGraphicsPixmapItem())
            self._add_graphic_item(True,"white_cell")
#        elif event.mimeData().hasFormat("application/x-blue"):
#            crop_added = self.field.plant_crop(PotatoGraphicsPixmapItem())
#            self._add_graphic_item(crop_added,"crop")
#        elif event.mimeData().hasFormat("application/x-sheep"):
#            animal_added = self.field.add_animal(SheepGraphicsPixmapItem())
#            self._add_graphic_item(animal_added,"animal")
#        elif event.mimeData().hasFormat("application/x-cow"):
#            animal_added = self.field.add_animal(CowGraphicsPixmapItem())
#            self._add_graphic_item(animal_added,"animal")
        
        