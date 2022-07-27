<template>
    <Menubar class="navbar" :model="items">
        <template #start>
            <div id="startComponent">Soltree Project</div>
        </template>
    </Menubar>
</template>

<script lang="ts">
export default {
    data() {
        return {
            items: []
        }
    }
}
</script>

<style lang="css">
body {
    margin: 0px;
}

.p-menubar {
    margin: 0px 0px 25px 0px !important;
    background-color: #00708C !important;
    border-radius: 0% !important;
    height: 80px !important;
}

#startComponent {
    color: white !important;
}
</style>    