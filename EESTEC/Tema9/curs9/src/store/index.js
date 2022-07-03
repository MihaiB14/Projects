import { createStore } from 'vuex'

export default createStore({
  state: {
    toDoItems: [
      {
        id: 1,
        name: "Item1",
        status: "Incomplet"
      },
      {
        id: 2,
        name: "Item2",
        status: "Incomplet"
      },
      {
        id: 3,
        name: "Item3",
        status: "Incomplet"
      },
    ],

  },
  getters: {
    completedItems(state) {
      return state.toDoItems.filter(item => item.status == 'Completed');
    }
  },
  mutations: {
    completeItem(state, completedItemId) {
      let itemIndex = state.toDoItems.findIndex(item => item.id == completedItemId);
      state.toDoItems[itemIndex].status = 'Completed';
    },
    decompleteItem(state, decompletedItemId) {
      let itemIndex = state.toDoItems.findIndex(item => item.id == decompletedItemId);
      state.toDoItems[itemIndex].status = 'Incompleted';
    }
  },
  actions: {
  },
  modules: {
  }
})
