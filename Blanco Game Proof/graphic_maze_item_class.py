# -*- coding: utf-8 -*-
"""
Created on Mon Oct 13 16:58:49 2014

@author: Mija
"""

from PyQt4.QtGui import *

class MazeItemGraphicsPixmapItem(QGraphicsPixmapItem):
    """This class provides a pixmap item with a present image for the item"""
    
    #constructor
    def __init__(self,graphics_list):
        super(MazeItemGraphicsPixmapItem,self).__init__()
        self.available_graphics = graphics_list
        self.current_graphic= QPixmap(self.available_graphics[0])
        self.setPixmap(self.current_graphic.scaledToWidth(25,1))
        self.setFlag(QGraphicsItem.ItemIsMovable) #allows us to move the graphics into field
        
        
    def update_status(self):
        pass
        