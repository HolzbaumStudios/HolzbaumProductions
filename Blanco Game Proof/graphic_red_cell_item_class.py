# -*- coding: utf-8 -*-
"""
Created on Mon Oct 13 17:28:11 2014

@author: Mija
"""

from graphic_cell_item_class import *
#from cow_class import *

import resources

class RedCellGraphicsPixmapItem(CellGraphicsPixmapItem):
    """ this class provides a graphical representation of a cow"""
    
    #constructor
    def __init__(self):
        self.available_graphics = [":/red_cell.png"]
        super(RedCellGraphicsPixmapItem,self).__init__(self.available_graphics)
        