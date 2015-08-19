# -*- coding: utf-8 -*-
"""
Created on Mon Oct 13 17:06:07 2014

@author: Mija
"""

from graphic_maze_item_class import *

class CellGraphicsPixmapItem(MazeItemGraphicsPixmapItem):
    """this class provides a pixmap item with a present image for the animal"""
    
    def __init__(self,graphics_list):
        super(CellGraphicsPixmapItem,self).__init__(graphics_list)
        
        self.Celltype=None
        
    
    
